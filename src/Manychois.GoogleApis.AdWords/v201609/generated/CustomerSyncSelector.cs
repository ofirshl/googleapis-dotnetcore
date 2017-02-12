using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A filter for selecting change history data for a customer.
	/// </summary>
	public class CustomerSyncSelector : ISoapable
	{
		/// <summary>
		/// Only return entities that have changed during the specified time range. String Format: yyyyMMdd
		/// HHmmss <Timezone ID> (for example, 20100609 150223 America/New_York). See the <a
		/// href="https://developers.google.com/adwords/api/docs/appendix/timezones">Timezones</a> page for
		/// the complete list of Timezone IDs.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public DateTimeRange DateTimeRange { get; set; }
		/// <summary>
		/// Return entities belonging to these campaigns.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// </summary>
		public List<long> CampaignIds { get; set; }
		/// <summary>
		/// Return entities belonging to these feeds.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// </summary>
		public List<long> FeedIds { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			DateTimeRange = null;
			CampaignIds = null;
			FeedIds = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "dateTimeRange")
				{
					DateTimeRange = new DateTimeRange();
					DateTimeRange.ReadFrom(xItem);
				}
				else if (localName == "campaignIds")
				{
					if (CampaignIds == null) CampaignIds = new List<long>();
					CampaignIds.Add(long.Parse(xItem.Value));
				}
				else if (localName == "feedIds")
				{
					if (FeedIds == null) FeedIds = new List<long>();
					FeedIds.Add(long.Parse(xItem.Value));
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (DateTimeRange != null)
			{
				xItem = new XElement(XName.Get("dateTimeRange", "https://adwords.google.com/api/adwords/ch/v201609"));
				DateTimeRange.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (CampaignIds != null)
			{
				foreach (var campaignIdsItem in CampaignIds)
				{
					xItem = new XElement(XName.Get("campaignIds", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(campaignIdsItem.ToString());
					xE.Add(xItem);
				}
			}
			if (FeedIds != null)
			{
				foreach (var feedIdsItem in FeedIds)
				{
					xItem = new XElement(XName.Get("feedIds", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(feedIdsItem.ToString());
					xE.Add(xItem);
				}
			}
		}
	}
}
