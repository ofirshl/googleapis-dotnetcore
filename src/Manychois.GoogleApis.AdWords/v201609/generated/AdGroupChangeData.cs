using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Holds information about a changed adgroup
	/// </summary>
	public class AdGroupChangeData : ISoapable
	{
		/// <summary>
		/// The ad group ID.
		/// </summary>
		public long? AdGroupId { get; set; }
		/// <summary>
		/// Whether or not the fields of this adgroup have changed, for example the AdGroup name. Changes
		/// to the Ads and Criteria are enumerated in their respective lists and will not be reflected in
		/// this status.
		/// </summary>
		public ChangeStatus? AdGroupChangeStatus { get; set; }
		/// <summary>
		/// The IDs of any changed ads of this ad group. This includes ads that have been deleted.
		/// </summary>
		public List<long> ChangedAds { get; set; }
		/// <summary>
		/// The IDs of any changed criterion of this ad group.
		/// </summary>
		public List<long> ChangedCriteria { get; set; }
		/// <summary>
		/// The IDs of any deleted criterion of this ad group.
		/// </summary>
		public List<long> RemovedCriteria { get; set; }
		/// <summary>
		/// A list of feed IDs for AdGroupFeeds that have been changed in this ad group. If an AdGroupFeed
		/// is deleted after a modification, it will not be included in this list.
		/// </summary>
		public List<long> ChangedFeeds { get; set; }
		/// <summary>
		/// A list of feed IDs for AdGroupFeeds that have been removed from the ad group.
		/// </summary>
		public List<long> RemovedFeeds { get; set; }
		/// <summary>
		/// Set of campaign criterion that have a bid modifier override at ad group level. If the
		/// associated bid modifier override is deleted after a modification, it will not be included in
		/// this list.
		/// </summary>
		public List<long> ChangedAdGroupBidModifierCriteria { get; set; }
		/// <summary>
		/// Set of campaign criterion whose bid modifier override at ad group level has been removed.
		/// </summary>
		public List<long> RemovedAdGroupBidModifierCriteria { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			AdGroupId = null;
			AdGroupChangeStatus = null;
			ChangedAds = null;
			ChangedCriteria = null;
			RemovedCriteria = null;
			ChangedFeeds = null;
			RemovedFeeds = null;
			ChangedAdGroupBidModifierCriteria = null;
			RemovedAdGroupBidModifierCriteria = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "adGroupId")
				{
					AdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "adGroupChangeStatus")
				{
					AdGroupChangeStatus = ChangeStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "changedAds")
				{
					if (ChangedAds == null) ChangedAds = new List<long>();
					ChangedAds.Add(long.Parse(xItem.Value));
				}
				else if (localName == "changedCriteria")
				{
					if (ChangedCriteria == null) ChangedCriteria = new List<long>();
					ChangedCriteria.Add(long.Parse(xItem.Value));
				}
				else if (localName == "removedCriteria")
				{
					if (RemovedCriteria == null) RemovedCriteria = new List<long>();
					RemovedCriteria.Add(long.Parse(xItem.Value));
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
				else if (localName == "changedAdGroupBidModifierCriteria")
				{
					if (ChangedAdGroupBidModifierCriteria == null) ChangedAdGroupBidModifierCriteria = new List<long>();
					ChangedAdGroupBidModifierCriteria.Add(long.Parse(xItem.Value));
				}
				else if (localName == "removedAdGroupBidModifierCriteria")
				{
					if (RemovedAdGroupBidModifierCriteria == null) RemovedAdGroupBidModifierCriteria = new List<long>();
					RemovedAdGroupBidModifierCriteria.Add(long.Parse(xItem.Value));
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (AdGroupId != null)
			{
				xItem = new XElement(XName.Get("adGroupId", "https://adwords.google.com/api/adwords/ch/v201609"));
				xItem.Add(AdGroupId.Value.ToString());
				xE.Add(xItem);
			}
			if (AdGroupChangeStatus != null)
			{
				xItem = new XElement(XName.Get("adGroupChangeStatus", "https://adwords.google.com/api/adwords/ch/v201609"));
				xItem.Add(AdGroupChangeStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ChangedAds != null)
			{
				foreach (var changedAdsItem in ChangedAds)
				{
					xItem = new XElement(XName.Get("changedAds", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(changedAdsItem.ToString());
					xE.Add(xItem);
				}
			}
			if (ChangedCriteria != null)
			{
				foreach (var changedCriteriaItem in ChangedCriteria)
				{
					xItem = new XElement(XName.Get("changedCriteria", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(changedCriteriaItem.ToString());
					xE.Add(xItem);
				}
			}
			if (RemovedCriteria != null)
			{
				foreach (var removedCriteriaItem in RemovedCriteria)
				{
					xItem = new XElement(XName.Get("removedCriteria", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(removedCriteriaItem.ToString());
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
			if (ChangedAdGroupBidModifierCriteria != null)
			{
				foreach (var changedAdGroupBidModifierCriteriaItem in ChangedAdGroupBidModifierCriteria)
				{
					xItem = new XElement(XName.Get("changedAdGroupBidModifierCriteria", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(changedAdGroupBidModifierCriteriaItem.ToString());
					xE.Add(xItem);
				}
			}
			if (RemovedAdGroupBidModifierCriteria != null)
			{
				foreach (var removedAdGroupBidModifierCriteriaItem in RemovedAdGroupBidModifierCriteria)
				{
					xItem = new XElement(XName.Get("removedAdGroupBidModifierCriteria", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(removedAdGroupBidModifierCriteriaItem.ToString());
					xE.Add(xItem);
				}
			}
		}
	}
}
