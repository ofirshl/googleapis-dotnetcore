using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A full product type string. Category of the product according to the merchant's own
	/// classification. Example:
	///
	/// <pre>{@code "Home & Garden > Kitchen & Dining > Kitchen Appliances > Refrigerators"}</pre>
	///
	/// <p>Not supported by campaigns of {@link AdvertisingChannelType#SHOPPING}.
	/// </summary>
	public class ProductTypeFull : ProductDimension, ISoapable
	{
		/// <summary>
		/// <span class="constraint StringLength">This string must not be empty.</span>
		/// </summary>
		public string Value { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					Value = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ProductTypeFull");
			XElement xItem = null;
			if (Value != null)
			{
				xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Value);
				xE.Add(xItem);
			}
		}
	}
}
