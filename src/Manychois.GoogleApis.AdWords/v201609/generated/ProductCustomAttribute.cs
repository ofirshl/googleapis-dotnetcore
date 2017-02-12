using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A custom attribute value. As a product can have multiple custom attributes, the user must specify
	/// a dimension type that indicates the index of the attribute by which to subdivide. All cases of
	/// the same subdivision must have the same dimension type (attribute index).
	/// </summary>
	public class ProductCustomAttribute : ProductDimension, ISoapable
	{
		/// <summary>
		/// Dimension type of the custom attribute. Indicates the index of the custom attribute.
		/// <span class="constraint OneOf">The value must be one of {CUSTOM_ATTRIBUTE_0, CUSTOM_ATTRIBUTE_1, CUSTOM_ATTRIBUTE_2, CUSTOM_ATTRIBUTE_3, CUSTOM_ATTRIBUTE_4}.</span>
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
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ProductCustomAttribute");
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
