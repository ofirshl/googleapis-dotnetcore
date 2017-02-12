using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Setting for controlling Dynamic Search Ads (DSA). Contains the domain name and the language
	/// used by the DSA system to automatically generate landing pages and keywords for a campaign.
	/// </summary>
	public class DynamicSearchAdsSetting : Setting, ISoapable
	{
		/// <summary>
		/// The Internet domain name that this setting represents. E.g. "google.com" or "www.google.com".
		/// To disable the setting set the domainName field to "-" (a single dash character).
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string DomainName { get; set; }
		/// <summary>
		/// A language code that indicates what language the contents of the domain is in. E.g. "en"
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string LanguageCode { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			DomainName = null;
			LanguageCode = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "domainName")
				{
					DomainName = xItem.Value;
				}
				else if (localName == "languageCode")
				{
					LanguageCode = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "DynamicSearchAdsSetting");
			XElement xItem = null;
			if (DomainName != null)
			{
				xItem = new XElement(XName.Get("domainName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DomainName);
				xE.Add(xItem);
			}
			if (LanguageCode != null)
			{
				xItem = new XElement(XName.Get("languageCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LanguageCode);
				xE.Add(xItem);
			}
		}
	}
}
