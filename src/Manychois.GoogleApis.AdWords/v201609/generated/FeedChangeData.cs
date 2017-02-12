using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Holds information about a changed feed and any feeds items within the feed.
	/// </summary>
	public class FeedChangeData : ISoapable
	{
		/// <summary>
		/// The feed ID.
		/// </summary>
		public long? FeedId { get; set; }
		/// <summary>
		/// Whether or not the fields of this feed have changed.
		/// </summary>
		public ChangeStatus? FeedChangeStatus { get; set; }
		/// <summary>
		/// A list of feed item IDs that have been added or modified within the the feed. If a feed item is
		/// deleted after a modification, it will not be included in this list.
		/// </summary>
		public List<long> ChangedFeedItems { get; set; }
		/// <summary>
		/// A list feed item IDs that have been removed from the feed.
		/// </summary>
		public List<long> RemovedFeedItems { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FeedId = null;
			FeedChangeStatus = null;
			ChangedFeedItems = null;
			RemovedFeedItems = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "feedId")
				{
					FeedId = long.Parse(xItem.Value);
				}
				else if (localName == "feedChangeStatus")
				{
					FeedChangeStatus = ChangeStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "changedFeedItems")
				{
					if (ChangedFeedItems == null) ChangedFeedItems = new List<long>();
					ChangedFeedItems.Add(long.Parse(xItem.Value));
				}
				else if (localName == "removedFeedItems")
				{
					if (RemovedFeedItems == null) RemovedFeedItems = new List<long>();
					RemovedFeedItems.Add(long.Parse(xItem.Value));
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FeedId != null)
			{
				xItem = new XElement(XName.Get("feedId", "https://adwords.google.com/api/adwords/ch/v201609"));
				xItem.Add(FeedId.Value.ToString());
				xE.Add(xItem);
			}
			if (FeedChangeStatus != null)
			{
				xItem = new XElement(XName.Get("feedChangeStatus", "https://adwords.google.com/api/adwords/ch/v201609"));
				xItem.Add(FeedChangeStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ChangedFeedItems != null)
			{
				foreach (var changedFeedItemsItem in ChangedFeedItems)
				{
					xItem = new XElement(XName.Get("changedFeedItems", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(changedFeedItemsItem.ToString());
					xE.Add(xItem);
				}
			}
			if (RemovedFeedItems != null)
			{
				foreach (var removedFeedItemsItem in RemovedFeedItems)
				{
					xItem = new XElement(XName.Get("removedFeedItems", "https://adwords.google.com/api/adwords/ch/v201609"));
					xItem.Add(removedFeedItemsItem.ToString());
					xE.Add(xItem);
				}
			}
		}
	}
}
