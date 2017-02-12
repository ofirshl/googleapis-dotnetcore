using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Scope of products. Contains a set of product dimensions, all of which a product has to match to
	/// be included in the campaign. These product dimensions must have a value; the "everything else"
	/// case without a value is not allowed.
	///
	/// <p>If there is no {@code ProductScope}, all products are included in the campaign. If a campaign
	/// has more than one {@code ProductScope}, products are included as long as they match any.
	/// Campaigns of {@link AdvertisingChannelType#SHOPPING} can have at most one {@code ProductScope}.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class ProductScope : Criterion, ISoapable
	{
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "Dimensions".</span>
		/// <span class="constraint NotEmptyForOperators">This field must contain at least one element when it is contained within {@link Operator}s: ADD.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public List<ProductDimension> Dimensions { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Dimensions = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "dimensions")
				{
					if (Dimensions == null) Dimensions = new List<ProductDimension>();
					var dimensionsItem = InstanceCreator.CreateProductDimension(xItem);
					dimensionsItem.ReadFrom(xItem);
					Dimensions.Add(dimensionsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ProductScope");
			XElement xItem = null;
			if (Dimensions != null)
			{
				foreach (var dimensionsItem in Dimensions)
				{
					xItem = new XElement(XName.Get("dimensions", "https://adwords.google.com/api/adwords/cm/v201609"));
					dimensionsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
