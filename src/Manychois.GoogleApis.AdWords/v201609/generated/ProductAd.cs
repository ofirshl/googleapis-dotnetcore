using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a product ad (known as a <a href=
	/// "//support.google.com/adwords/answer/2456103">product
	/// listing ad</a> in the AdWords user interface). A product ad displays
	/// product data (managed using the Google Merchant Center) that is
	/// pulled from the Google base product feed specified in the parent campaign's
	/// {@linkplain ShoppingSetting shopping setting}.
	///
	/// <p class="caution"><b>Caution:</b> Product ads do not use {@link #url url},
	/// {@link #finalUrls finalUrls}, {@link #finalMobileUrls finalMobileUrls},
	/// {@link #finalAppUrls finalAppUrls}, or {@link #displayUrl displayUrl};
	/// setting these fields on a product ad will cause an error.
	/// {@link #urlCustomParameters urlCustomParameters} and
	/// {@link #trackingUrlTemplate trackingUrlTemplate} can be set, but it is not
	/// recommended, as they will not be used; they should be set at the ad group or
	/// campaign level instead.</p>
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class ProductAd : Ad, ISoapable
	{
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ProductAd");
		}
	}
}
