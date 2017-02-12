using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The product channel dimension, which specifies the locality of an offer. Only supported by
	/// campaigns of {@link AdvertisingChannelType#SHOPPING}.
	/// </summary>
	public class ProductChannel : ProductDimension, ISoapable
	{
		public ShoppingProductChannel? Channel { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Channel = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "channel")
				{
					Channel = ShoppingProductChannelExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ProductChannel");
			XElement xItem = null;
			if (Channel != null)
			{
				xItem = new XElement(XName.Get("channel", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Channel.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
