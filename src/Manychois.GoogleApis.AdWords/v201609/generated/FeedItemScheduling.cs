using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a collection of FeedItem schedules specifying all time intervals for which
	/// the feed item may serve. Any time range not covered by the specified FeedItemSchedules will
	/// prevent the feed item from serving during those times.
	/// </summary>
	public class FeedItemScheduling : ISoapable
	{
		/// <summary>
		/// List of non-overlapping feed item schedules indicating when the feed item may serve.
		/// There can be a maximum of 6 FeedItemSchedules per day.
		/// If empty, the scheduling will be cleared of all FeedItemSchedules indicating the feed item
		/// has no scheduling restrictions.
		/// </summary>
		public List<FeedItemSchedule> FeedItemSchedules { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FeedItemSchedules = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "feedItemSchedules")
				{
					if (FeedItemSchedules == null) FeedItemSchedules = new List<FeedItemSchedule>();
					var feedItemSchedulesItem = new FeedItemSchedule();
					feedItemSchedulesItem.ReadFrom(xItem);
					FeedItemSchedules.Add(feedItemSchedulesItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FeedItemSchedules != null)
			{
				foreach (var feedItemSchedulesItem in FeedItemSchedules)
				{
					xItem = new XElement(XName.Get("feedItemSchedules", "https://adwords.google.com/api/adwords/cm/v201609"));
					feedItemSchedulesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
