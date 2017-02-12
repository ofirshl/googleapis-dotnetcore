using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// One element of a bidding category at a certain level. Top-level categories are at level 1,
	/// their children at level 2, and so on. We currently support up to 5 levels. The user must specify
	/// a dimension type that indicates the level of the category. All cases of the same subdivision
	/// must have the same dimension type (category level).
	/// </summary>
	public class ProductBiddingCategory : ProductDimension, ISoapable
	{
		/// <summary>
		/// Dimension type of the category. Indicates the level of the category in the taxonomy.
		/// <span class="constraint Filterable">This field can be filtered on using the value "ParentDimensionType".</span>
		/// <span class="constraint OneOf">The value must be one of {BIDDING_CATEGORY_L1, BIDDING_CATEGORY_L2, BIDDING_CATEGORY_L3, BIDDING_CATEGORY_L4, BIDDING_CATEGORY_L5}.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public ProductDimensionType? Type { get; set; }
		/// <summary>
		/// ID of the product category.
		/// <span class="constraint Filterable">This field can be filtered on using the value "ParentDimensionId".</span>
		/// </summary>
		public long? Value { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Type = null;
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "type")
				{
					Type = ProductDimensionTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "value")
				{
					Value = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ProductBiddingCategory");
			XElement xItem = null;
			if (Type != null)
			{
				xItem = new XElement(XName.Get("type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Type.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Value != null)
			{
				xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Value.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
