using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Holds information about a changed campaign and any ad groups under that have changed.
	/// </summary>
	public class CampaignChangeData : ISoapable
	{
		/// <summary>
		/// The campaign ID.
		/// </summary>
		public long? CampaignId { get; set; }
		/// <summary>
		/// Whether or not the fields of this campaign have changed. Changes to campaign level criteria and
		/// ad extensions are enumerated in their respective lists and will not be reflected in this
		/// status.
		/// </summary>
		public ChangeStatus? CampaignChangeStatus { get; set; }
		/// <summary>
		/// A list of change information for all changed adgroups belonging to the campaign.
		/// </summary>
		public List<AdGroupChangeData> ChangedAdGroups { get; set; }
		/// <summary>
		/// A list of criteria IDs that have been added as campaign criteria. This list includes any
		/// criteria that can be downloaded using CampaignCriterionService.
		/// </summary>
		public List<long> AddedCampaignCriteria { get; set; }
		/// <summary>
		/// A list of criteria IDs that have been deleted as campaign criteria. This list includes any
		/// criteria that can be downloaded using CampaignCriterionService.
		/// </summary>
		public List<long> RemovedCampaignCriteria { get; set; }
		/// <summary>
		/// A list of feed IDs for CampaignFeeds that have been changed in this campaign. If a CampaignFeed
		/// is deleted after a modification, it will not be included in this list.
		/// </summary>
		public List<long> ChangedFeeds { get; set; }
		/// <summary>
		/// A list of feed IDs for CampaignFeeds that have been removed from the campaign.
		/// </summary>
		public List<long> RemovedFeeds { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			CampaignId = null;
			CampaignChangeStatus = null;
			ChangedAdGroups = null;
			AddedCampaignCriteria = null;
			RemovedCampaignCriteria = null;
			ChangedFeeds = null;
			RemovedFeeds = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "campaignId")
				{
					CampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "campaignChangeStatus")
				{
					CampaignChangeStatus = ChangeStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "changedAdGroups")
				{
					if (ChangedAdGroups == null) ChangedAdGroups = new List<AdGroupChangeData>();
					var changedAdGroupsItem = new AdGroupChangeData();
					changedAdGroupsItem.ReadFrom(xItem);
					ChangedAdGroups.Add(changedAdGroupsItem);
				}
				else if (localName == "addedCampaignCriteria")
				{
					if (AddedCampaignCriteria == null) AddedCampaignCriteria = new List<long>();
					AddedCampaignCriteria.Add(long.Parse(xItem.Value));
				}
				else if (localName == "removedCampaignCriteria")
				{
					if (RemovedCampaignCriteria == null) RemovedCampaignCriteria = new List<long>();
					RemovedCampaignCriteria.Add(long.Parse(xItem.Value));
				}
				else if (localName == "changedFeeds")
				{
					if (ChangedFeeds == null) ChangedFeeds = new List<long>();
					ChangedFeeds.Add(long.Parse(xItem.Value));
				}
				else if (localName == "removedFeeds")
				{
					if (RemovedFeeds == null) RemovedFeeds = new List<long>();
					RemovedFeeds.Add(long.Parse(xItem.Value));
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (CampaignId != null)
			{
				xItem = new XElement(XName.Get("campaignId", "https://adwords.google.com/api/adwords/ch/v201609"));
				xItem.Add(CampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (CampaignChangeStatus != null)
			{
				xItem = new XElement(XName.Get("campaignChangeStatus", "https://adwords.google.com/api/adwords/ch/v201609"));
				xItem.Add(CampaignChangeStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ChangedAdGroups != null)
			{
				foreach (var changedAdGroupsItem in ChangedAdGroups)
				{
					xItem = new XElement(XName.Get("changedAdGroups", "https://adwords.google.com/api/adwords/ch/v201609"));
					changedAdGroupsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (AddedCampaignCriteria != null)
			{
				foreach (var addedCampaignCriteriaItem in AddedCampaignCriteria)
				{
					xItem = new XElement(XName.Get("addedCampaignCriteria", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(addedCampaignCriteriaItem.ToString());
					xE.Add(xItem);
				}
			}
			if (RemovedCampaignCriteria != null)
			{
				foreach (var removedCampaignCriteriaItem in RemovedCampaignCriteria)
				{
					xItem = new XElement(XName.Get("removedCampaignCriteria", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(removedCampaignCriteriaItem.ToString());
					xE.Add(xItem);
				}
			}
			if (ChangedFeeds != null)
			{
				foreach (var changedFeedsItem in ChangedFeeds)
				{
					xItem = new XElement(XName.Get("changedFeeds", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(changedFeedsItem.ToString());
					xE.Add(xItem);
				}
			}
			if (RemovedFeeds != null)
			{
				foreach (var removedFeedsItem in RemovedFeeds)
				{
					xItem = new XElement(XName.Get("removedFeeds", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(removedFeedsItem.ToString());
					xE.Add(xItem);
				}
			}
		}
	}
}
