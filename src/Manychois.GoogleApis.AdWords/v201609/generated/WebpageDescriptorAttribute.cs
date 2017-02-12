using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// {@link Attribute} type that contains a {@link WebpageDescriptor} value.
	/// </summary>
	public class WebpageDescriptorAttribute : Attribute, ISoapable
	{
		/// <summary>
		/// {@link WebpageDescriptor} value contained by this {@link Attribute}.
		/// </summary>
		public WebpageDescriptor Value { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					Value = new WebpageDescriptor();
					Value.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "WebpageDescriptorAttribute");
			XElement xItem = null;
			if (Value != null)
			{
				xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/o/v201609"));
				Value.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
