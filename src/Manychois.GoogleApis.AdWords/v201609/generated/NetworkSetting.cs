using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Network settings for a Campaign.
	/// </summary>
	public class NetworkSetting : ISoapable
	{
		/// <summary>
		/// Ads will be served with Google.com search results.
		/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
		/// <span class="constraint CampaignType">This field may only be set to true for campaign channel type SEARCH.</span>
		/// <span class="constraint CampaignType">This field may only be set to true for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// <span class="constraint CampaignType">This field may only be set to false for campaign channel type DISPLAY.</span>
		/// </summary>
		public bool? TargetGoogleSearch { get; set; }
		/// <summary>
		/// Ads will be served on partner sites in the Google Search Network
		/// (requires {@code GOOGLE_SEARCH}).
		/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
		/// <span class="constraint CampaignType">This field may only be set to true for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// </summary>
		public bool? TargetSearchNetwork { get; set; }
		/// <summary>
		/// Ads will be served on specified placements in the Google Display Network.
		/// Placements are specified using {@code Placement} criteria.
		/// <span class="constraint CampaignType">This field may only be set to true for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// <span class="constraint CampaignType">This field may only be set to false for campaign channel subtype SEARCH_MOBILE_APP.</span>
		/// </summary>
		public bool? TargetContentNetwork { get; set; }
		/// <summary>
		/// Ads will be served on the Google Partner Network. This is available to
		/// only some specific Google partner accounts.
		/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
		/// <span class="constraint CampaignType">This field may only be set to false for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// </summary>
		public bool? TargetPartnerSearchNetwork { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			TargetGoogleSearch = null;
			TargetSearchNetwork = null;
			TargetContentNetwork = null;
			TargetPartnerSearchNetwork = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "targetGoogleSearch")
				{
					TargetGoogleSearch = bool.Parse(xItem.Value);
				}
				else if (localName == "targetSearchNetwork")
				{
					TargetSearchNetwork = bool.Parse(xItem.Value);
				}
				else if (localName == "targetContentNetwork")
				{
					TargetContentNetwork = bool.Parse(xItem.Value);
				}
				else if (localName == "targetPartnerSearchNetwork")
				{
					TargetPartnerSearchNetwork = bool.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (TargetGoogleSearch != null)
			{
				xItem = new XElement(XName.Get("targetGoogleSearch", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TargetGoogleSearch.Value.ToString());
				xE.Add(xItem);
			}
			if (TargetSearchNetwork != null)
			{
				xItem = new XElement(XName.Get("targetSearchNetwork", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TargetSearchNetwork.Value.ToString());
				xE.Add(xItem);
			}
			if (TargetContentNetwork != null)
			{
				xItem = new XElement(XName.Get("targetContentNetwork", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TargetContentNetwork.Value.ToString());
				xE.Add(xItem);
			}
			if (TargetPartnerSearchNetwork != null)
			{
				xItem = new XElement(XName.Get("targetPartnerSearchNetwork", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TargetPartnerSearchNetwork.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
