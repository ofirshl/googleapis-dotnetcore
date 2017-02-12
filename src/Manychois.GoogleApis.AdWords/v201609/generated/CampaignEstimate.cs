using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents the estimate results for a single campaign.
	/// </summary>
	public class CampaignEstimate : Estimate, ISoapable
	{
		/// <summary>
		/// The campaignId of the campaign specified in the request.
		///
		/// This will be <code>null</code> for new campaigns.
		/// </summary>
		public long? CampaignId { get; set; }
		/// <summary>
		/// The estimates for the ad groups belonging to this campaign in the request.
		///
		/// They will be returned in the same order that they were sent in the request.
		/// </summary>
		public List<AdGroupEstimate> AdGroupEstimates { get; set; }
		/// <summary>
		/// Traffic estimates segmented by platform for this campaign.
		/// </summary>
		public List<PlatformCampaignEstimate> PlatformEstimates { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			CampaignId = null;
			AdGroupEstimates = null;
			PlatformEstimates = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "campaignId")
				{
					CampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "adGroupEstimates")
				{
					if (AdGroupEstimates == null) AdGroupEstimates = new List<AdGroupEstimate>();
					var adGroupEstimatesItem = new AdGroupEstimate();
					adGroupEstimatesItem.ReadFrom(xItem);
					AdGroupEstimates.Add(adGroupEstimatesItem);
				}
				else if (localName == "platformEstimates")
				{
					if (PlatformEstimates == null) PlatformEstimates = new List<PlatformCampaignEstimate>();
					var platformEstimatesItem = new PlatformCampaignEstimate();
					platformEstimatesItem.ReadFrom(xItem);
					PlatformEstimates.Add(platformEstimatesItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "CampaignEstimate");
			XElement xItem = null;
			if (CampaignId != null)
			{
				xItem = new XElement(XName.Get("campaignId", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(CampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (AdGroupEstimates != null)
			{
				foreach (var adGroupEstimatesItem in AdGroupEstimates)
				{
					xItem = new XElement(XName.Get("adGroupEstimates", "https://adwords.google.com/api/adwords/o/v201609"));
					adGroupEstimatesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (PlatformEstimates != null)
			{
				foreach (var platformEstimatesItem in PlatformEstimates)
				{
					xItem = new XElement(XName.Get("platformEstimates", "https://adwords.google.com/api/adwords/o/v201609"));
					platformEstimatesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
