using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Holds information about changes to a customer
	/// </summary>
	public class CustomerChangeData : ISoapable
	{
		/// <summary>
		/// A list of campaign changes for the customer, as specified by the selector. If a campaign is
		/// included in the selector it will be included in this list, even if the campaign did not change.
		/// </summary>
		public List<CampaignChangeData> ChangedCampaigns { get; set; }
		/// <summary>
		/// A list of feed changes for the customer as specified in the selector. If a feed is included in
		/// the selector then it will be included in this list, even if the feed did not change.
		/// </summary>
		public List<FeedChangeData> ChangedFeeds { get; set; }
		/// <summary>
		/// The timestamp for the last changed processed for this customer. It is important that this
		/// timestamp be used for subsequent requests to avoid missing any changes.
		/// </summary>
		public string LastChangeTimestamp { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ChangedCampaigns = null;
			ChangedFeeds = null;
			LastChangeTimestamp = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "changedCampaigns")
				{
					if (ChangedCampaigns == null) ChangedCampaigns = new List<CampaignChangeData>();
					var changedCampaignsItem = new CampaignChangeData();
					changedCampaignsItem.ReadFrom(xItem);
					ChangedCampaigns.Add(changedCampaignsItem);
				}
				else if (localName == "changedFeeds")
				{
					if (ChangedFeeds == null) ChangedFeeds = new List<FeedChangeData>();
					var changedFeedsItem = new FeedChangeData();
					changedFeedsItem.ReadFrom(xItem);
					ChangedFeeds.Add(changedFeedsItem);
				}
				else if (localName == "lastChangeTimestamp")
				{
					LastChangeTimestamp = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ChangedCampaigns != null)
			{
				foreach (var changedCampaignsItem in ChangedCampaigns)
				{
					xItem = new XElement(XName.Get("changedCampaigns", "https://adwords.google.com/api/adwords/ch/v201609"));
					changedCampaignsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (ChangedFeeds != null)
			{
				foreach (var changedFeedsItem in ChangedFeeds)
				{
					xItem = new XElement(XName.Get("changedFeeds", "https://adwords.google.com/api/adwords/ch/v201609"));
					changedFeedsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (LastChangeTimestamp != null)
			{
				xItem = new XElement(XName.Get("lastChangeTimestamp", "https://adwords.google.com/api/adwords/ch/v201609"));
				xItem.Add(LastChangeTimestamp);
				xE.Add(xItem);
			}
		}
	}
}
