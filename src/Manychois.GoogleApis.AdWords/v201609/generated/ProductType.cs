using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// One element of a product type string at a certain level. Top-level product types are at level 1,
	/// their children at level 2, and so on. We currently support up to 5 levels. The user must specify
	/// a dimension type that indicates the level of the product type. All cases of the same
	/// subdivision must have the same dimension type (product type level).
	/// </summary>
	public class ProductType : ProductDimension, ISoapable
	{
		/// <summary>
		/// Dimension type of the product type. Indicates the level of the product type.
		/// <span class="constraint OneOf">The value must be one of {PRODUCT_TYPE_L1, PRODUCT_TYPE_L2, PRODUCT_TYPE_L3, PRODUCT_TYPE_L4, PRODUCT_TYPE_L5}.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public ProductDimensionType? Type { get; set; }
		/// <summary>
		/// <span class="constraint StringLength">This string must not be empty, (trimmed).</span>
		/// </summary>
		public string Value { get; set; }
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
					Value = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ProductType");
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
				xItem.Add(Value);
				xE.Add(xItem);
			}
		}
	}
}
