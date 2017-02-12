using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an upgrade operation to upgrade Ad.url.
	/// </summary>
	public class AdUrlUpgrade : ISoapable
	{
		/// <summary>
		/// ID of ad to upgrade.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? AdId { get; set; }
		/// <summary>
		/// Final url of the ad. This is required for all Ad types, except for DynamicSearchAd and
		/// ProductAd.
		/// </summary>
		public string FinalUrl { get; set; }
		/// <summary>
		/// Mobile final url of the ad. This field is optional.
		/// </summary>
		public string FinalMobileUrl { get; set; }
		/// <summary>
		/// Tracking url template of the Ad.
		/// </summary>
		public string TrackingUrlTemplate { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			AdId = null;
			FinalUrl = null;
			FinalMobileUrl = null;
			TrackingUrlTemplate = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "adId")
				{
					AdId = long.Parse(xItem.Value);
				}
				else if (localName == "finalUrl")
				{
					FinalUrl = xItem.Value;
				}
				else if (localName == "finalMobileUrl")
				{
					FinalMobileUrl = xItem.Value;
				}
				else if (localName == "trackingUrlTemplate")
				{
					TrackingUrlTemplate = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (AdId != null)
			{
				xItem = new XElement(XName.Get("adId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdId.Value.ToString());
				xE.Add(xItem);
			}
			if (FinalUrl != null)
			{
				xItem = new XElement(XName.Get("finalUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FinalUrl);
				xE.Add(xItem);
			}
			if (FinalMobileUrl != null)
			{
				xItem = new XElement(XName.Get("finalMobileUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FinalMobileUrl);
				xE.Add(xItem);
			}
			if (TrackingUrlTemplate != null)
			{
				xItem = new XElement(XName.Get("trackingUrlTemplate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TrackingUrlTemplate);
				xE.Add(xItem);
			}
		}
	}
}
