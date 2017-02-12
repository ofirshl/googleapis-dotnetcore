using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains results of traffic estimation request.
	/// </summary>
	public class TrafficEstimatorResult : ISoapable
	{
		/// <summary>
		/// The estimates for the campaigns specified in the request.
		///
		/// They are listed in the same order as the campaigns that were sent in the
		/// request.
		/// </summary>
		public List<CampaignEstimate> CampaignEstimates { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			CampaignEstimates = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "campaignEstimates")
				{
					if (CampaignEstimates == null) CampaignEstimates = new List<CampaignEstimate>();
					var campaignEstimatesItem = new CampaignEstimate();
					campaignEstimatesItem.ReadFrom(xItem);
					CampaignEstimates.Add(campaignEstimatesItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (CampaignEstimates != null)
			{
				foreach (var campaignEstimatesItem in CampaignEstimates)
				{
					xItem = new XElement(XName.Get("campaignEstimates", "https://adwords.google.com/api/adwords/o/v201609"));
					campaignEstimatesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
