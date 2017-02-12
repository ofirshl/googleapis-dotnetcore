using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains base extension feed item data for an extension in an extension feed managed by AdWords.
	/// </summary>
	public class ExtensionFeedItem : ISoapable
	{
		/// <summary>
		/// Id of this feed item's feed.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? FeedId { get; set; }
		/// <summary>
		/// Id of the feed item.
		/// </summary>
		public long? FeedItemId { get; set; }
		/// <summary>
		/// Status of the feed item.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public FeedItemStatus? Status { get; set; }
		/// <summary>
		/// The type of the feed containing this extension feed item data. The field will be set by a
		/// subclass with a defined feed type.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public FeedType? FeedType { get; set; }
		/// <summary>
		/// Start time in which this feed item is effective and can begin serving. The time zone
		/// of startTime must either match the time zone of the account or be unspecified where
		/// the time zone defaults to the account time zone.
		/// This field may be null to indicate no start time restriction.
		/// The special value "00000101 000000" may be used to clear an existing start time.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// </summary>
		public string StartTime { get; set; }
		/// <summary>
		/// End time in which this feed item is no longer effective and will stop serving. The time zone
		/// of endTime must either match the time zone of the account or be unspecified where
		/// the time zone defaults to the account time zone.
		/// This field may be null to indicate no end time restriction.
		/// The special value "00000101 000000" may be used to clear an existing end time.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// </summary>
		public string EndTime { get; set; }
		/// <summary>
		/// Device preference for the feed item.
		/// </summary>
		public FeedItemDevicePreference DevicePreference { get; set; }
		/// <summary>
		/// FeedItemScheduling specifying times for when the feed item may serve.
		/// On retrieval or creation of the feed item, if the field is left null,
		/// no feed item scheduling restrictions are placed on the feed item.
		/// On update, if the field is left unspecified, the previous feedItemScheduling state will
		/// not be changed.
		/// On update, if the field is set with a FeedItemScheduling with an empty feedItemSchedules
		/// list, the scheduling will be cleared of all FeedItemSchedules indicating the feed item
		/// has no scheduling restrictions.
		/// </summary>
		public FeedItemScheduling Scheduling { get; set; }
		/// <summary>
		/// Campaign targeting specifying what campaign this extension can serve with.
		/// On update, if the field is left unspecified, the previous campaign targeting state
		/// will not be changed.
		/// On update, if the field is set with an empty FeedItemCampaignTargeting, the
		/// campaign targeting will be cleared.
		/// Note: If adGroupTargeting and campaignTargeting are set (either in the request or pre-existing
		/// from a previous request), the targeted campaign must match the targeted adgroup's campaign.
		/// If only adGroupTargeting is specified and there is no campaignTargeting, then a
		/// campaignTargeting will be set to the targeted adgroup's campaign.
		/// </summary>
		public FeedItemCampaignTargeting CampaignTargeting { get; set; }
		/// <summary>
		/// Adgroup targeting specifying what adgroup this extension can serve with.
		/// On update, if the field is left unspecified, the previous adgroup targeting state
		/// will not be changed.
		/// On update, if the field is set with an empty FeedItemAdGroupTargeting, the
		/// adgroup targeting will be cleared.
		/// Note: If adGroupTargeting and campaignTargeting are set (either in the request or pre-existing
		/// from a previous request), the targeted campaign must match the targeted adgroup's campaign.
		/// If only adGroupTargeting is specified and there is no campaignTargeting, then a
		/// campaignTargeting will be set to the targeted adgroup's campaign.
		/// </summary>
		public FeedItemAdGroupTargeting AdGroupTargeting { get; set; }
		/// <summary>
		/// Keyword targeting specifies what keyword this extension can serve with.
		/// On update, if the field is left unspecified, the previous keyword targeting state
		/// will not be changed.
		/// On update, if the field is set with a Keyword and without Keyword.text set keyword targeting
		/// will be cleared.
		/// </summary>
		public Keyword KeywordTargeting { get; set; }
		/// <summary>
		/// Geo targeting specifies what locations this extension can serve with.
		/// On update, if the field is left unspecified, the previous geo targeting state will not
		/// be changed.
		/// On update, if the field is set with a null value for criterionId, the geo targeting will be
		/// cleared.
		/// </summary>
		public Location GeoTargeting { get; set; }
		/// <summary>
		/// Geo targeting restriction specifies the type of location that can be used for targeting.
		/// On update, if the field is left unspecified, the previous geo targeting restriction state
		/// will not be changed.
		/// On update, if the field is set with a null GeoRestriction enum, the geo targeting restriction
		/// will be cleared.
		/// </summary>
		public FeedItemGeoRestriction GeoTargetingRestriction { get; set; }
		/// <summary>
		/// List of details about a feed item's validation and approval state.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<FeedItemPolicyData> PolicyData { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of ExtensionFeedItem.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string ExtensionFeedItemType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FeedId = null;
			FeedItemId = null;
			Status = null;
			FeedType = null;
			StartTime = null;
			EndTime = null;
			DevicePreference = null;
			Scheduling = null;
			CampaignTargeting = null;
			AdGroupTargeting = null;
			KeywordTargeting = null;
			GeoTargeting = null;
			GeoTargetingRestriction = null;
			PolicyData = null;
			ExtensionFeedItemType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "feedId")
				{
					FeedId = long.Parse(xItem.Value);
				}
				else if (localName == "feedItemId")
				{
					FeedItemId = long.Parse(xItem.Value);
				}
				else if (localName == "status")
				{
					Status = FeedItemStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "feedType")
				{
					FeedType = FeedTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "startTime")
				{
					StartTime = xItem.Value;
				}
				else if (localName == "endTime")
				{
					EndTime = xItem.Value;
				}
				else if (localName == "devicePreference")
				{
					DevicePreference = new FeedItemDevicePreference();
					DevicePreference.ReadFrom(xItem);
				}
				else if (localName == "scheduling")
				{
					Scheduling = new FeedItemScheduling();
					Scheduling.ReadFrom(xItem);
				}
				else if (localName == "campaignTargeting")
				{
					CampaignTargeting = new FeedItemCampaignTargeting();
					CampaignTargeting.ReadFrom(xItem);
				}
				else if (localName == "adGroupTargeting")
				{
					AdGroupTargeting = new FeedItemAdGroupTargeting();
					AdGroupTargeting.ReadFrom(xItem);
				}
				else if (localName == "keywordTargeting")
				{
					KeywordTargeting = new Keyword();
					KeywordTargeting.ReadFrom(xItem);
				}
				else if (localName == "geoTargeting")
				{
					GeoTargeting = new Location();
					GeoTargeting.ReadFrom(xItem);
				}
				else if (localName == "geoTargetingRestriction")
				{
					GeoTargetingRestriction = new FeedItemGeoRestriction();
					GeoTargetingRestriction.ReadFrom(xItem);
				}
				else if (localName == "policyData")
				{
					if (PolicyData == null) PolicyData = new List<FeedItemPolicyData>();
					var policyDataItem = new FeedItemPolicyData();
					policyDataItem.ReadFrom(xItem);
					PolicyData.Add(policyDataItem);
				}
				else if (localName == "ExtensionFeedItem.Type")
				{
					ExtensionFeedItemType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FeedId != null)
			{
				xItem = new XElement(XName.Get("feedId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedId.Value.ToString());
				xE.Add(xItem);
			}
			if (FeedItemId != null)
			{
				xItem = new XElement(XName.Get("feedItemId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedItemId.Value.ToString());
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (FeedType != null)
			{
				xItem = new XElement(XName.Get("feedType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (StartTime != null)
			{
				xItem = new XElement(XName.Get("startTime", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StartTime);
				xE.Add(xItem);
			}
			if (EndTime != null)
			{
				xItem = new XElement(XName.Get("endTime", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EndTime);
				xE.Add(xItem);
			}
			if (DevicePreference != null)
			{
				xItem = new XElement(XName.Get("devicePreference", "https://adwords.google.com/api/adwords/cm/v201609"));
				DevicePreference.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Scheduling != null)
			{
				xItem = new XElement(XName.Get("scheduling", "https://adwords.google.com/api/adwords/cm/v201609"));
				Scheduling.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (CampaignTargeting != null)
			{
				xItem = new XElement(XName.Get("campaignTargeting", "https://adwords.google.com/api/adwords/cm/v201609"));
				CampaignTargeting.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (AdGroupTargeting != null)
			{
				xItem = new XElement(XName.Get("adGroupTargeting", "https://adwords.google.com/api/adwords/cm/v201609"));
				AdGroupTargeting.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (KeywordTargeting != null)
			{
				xItem = new XElement(XName.Get("keywordTargeting", "https://adwords.google.com/api/adwords/cm/v201609"));
				KeywordTargeting.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (GeoTargeting != null)
			{
				xItem = new XElement(XName.Get("geoTargeting", "https://adwords.google.com/api/adwords/cm/v201609"));
				GeoTargeting.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (GeoTargetingRestriction != null)
			{
				xItem = new XElement(XName.Get("geoTargetingRestriction", "https://adwords.google.com/api/adwords/cm/v201609"));
				GeoTargetingRestriction.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (PolicyData != null)
			{
				foreach (var policyDataItem in PolicyData)
				{
					xItem = new XElement(XName.Get("policyData", "https://adwords.google.com/api/adwords/cm/v201609"));
					policyDataItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (ExtensionFeedItemType != null)
			{
				xItem = new XElement(XName.Get("ExtensionFeedItem.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ExtensionFeedItemType);
				xE.Add(xItem);
			}
		}
	}
}
