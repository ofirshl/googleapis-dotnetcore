using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains a list of campaigns to perform a traffic estimate on.
	/// </summary>
	public class TrafficEstimatorSelector : ISoapable
	{
		/// <summary>
		/// A list of all campaigns to estimate.<p>
		///
		/// To create a Keyword estimates request, use {@code null} campaign id.
		/// <span class="constraint CollectionSize">The maximum size of this collection is 5.</span>
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<CampaignEstimateRequest> CampaignEstimateRequests { get; set; }
		/// <summary>
		/// To request a list of campaign level estimates segmented by platform.
		/// </summary>
		public bool? PlatformEstimateRequested { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			CampaignEstimateRequests = null;
			PlatformEstimateRequested = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "campaignEstimateRequests")
				{
					if (CampaignEstimateRequests == null) CampaignEstimateRequests = new List<CampaignEstimateRequest>();
					var campaignEstimateRequestsItem = new CampaignEstimateRequest();
					campaignEstimateRequestsItem.ReadFrom(xItem);
					CampaignEstimateRequests.Add(campaignEstimateRequestsItem);
				}
				else if (localName == "platformEstimateRequested")
				{
					PlatformEstimateRequested = bool.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (CampaignEstimateRequests != null)
			{
				foreach (var campaignEstimateRequestsItem in CampaignEstimateRequests)
				{
					xItem = new XElement(XName.Get("campaignEstimateRequests", "https://adwords.google.com/api/adwords/o/v201609"));
					campaignEstimateRequestsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (PlatformEstimateRequested != null)
			{
				xItem = new XElement(XName.Get("platformEstimateRequested", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(PlatformEstimateRequested.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
