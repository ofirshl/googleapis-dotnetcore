using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The product channel exclusivity dimension, which limits the availability of an offer between only
	/// local, only online, or both. Only supported by campaigns of
	/// {@link AdvertisingChannelType#SHOPPING}.
	/// </summary>
	public class ProductChannelExclusivity : ProductDimension, ISoapable
	{
		public ShoppingProductChannelExclusivity? ChannelExclusivity { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			ChannelExclusivity = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "channelExclusivity")
				{
					ChannelExclusivity = ShoppingProductChannelExclusivityExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ProductChannelExclusivity");
			XElement xItem = null;
			if (ChannelExclusivity != null)
			{
				xItem = new XElement(XName.Get("channelExclusivity", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ChannelExclusivity.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
