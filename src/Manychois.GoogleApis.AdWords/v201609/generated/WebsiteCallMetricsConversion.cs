using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A conversion that happens when a user performs the following sequence of actions:
	/// <ul>
	/// <li>Clicks on an advertiser's ad</li>
	/// <li>
	/// Proceeds to the advertiser's website, where special javascript installed on the page
	/// produces a dynamically-generated phone number,
	/// </li>
	/// <li>Calls that number from their home (or other) phone</li>
	/// </ul>
	/// </summary>
	public class WebsiteCallMetricsConversion : ConversionTracker, ISoapable
	{
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "WebsitePhoneCallDuration".</span>
		/// <span class="constraint InRange">This field must be between 0 and 10000, inclusive.</span>
		/// </summary>
		public long? PhoneCallDuration { get; set; }
		public string Snippet { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			PhoneCallDuration = null;
			Snippet = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "phoneCallDuration")
				{
					PhoneCallDuration = long.Parse(xItem.Value);
				}
				else if (localName == "snippet")
				{
					Snippet = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "WebsiteCallMetricsConversion");
			XElement xItem = null;
			if (PhoneCallDuration != null)
			{
				xItem = new XElement(XName.Get("phoneCallDuration", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PhoneCallDuration.Value.ToString());
				xE.Add(xItem);
			}
			if (Snippet != null)
			{
				xItem = new XElement(XName.Get("snippet", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Snippet);
				xE.Add(xItem);
			}
		}
	}
}
