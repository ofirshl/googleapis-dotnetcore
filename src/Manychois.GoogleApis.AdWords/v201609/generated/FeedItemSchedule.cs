using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a FeedItem schedule, which specifies a time interval on a given day
	/// when the feed item may serve. The FeedItemSchedule times are in the account's time zone.
	/// </summary>
	public class FeedItemSchedule : ISoapable
	{
		/// <summary>
		/// Day of the week the schedule applies to.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public DayOfWeek? DayOfWeek { get; set; }
		/// <summary>
		/// Starting hour in 24 hour time.
		/// <span class="constraint InRange">This field must be between 0 and 23, inclusive.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public int? StartHour { get; set; }
		/// <summary>
		/// Interval starts these minutes after the starting hour.
		/// The value can be 0, 15, 30, and 45.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public MinuteOfHour? StartMinute { get; set; }
		/// <summary>
		/// Ending hour in 24 hour time; <code>24</code> signifies
		/// end of the day and subsequently endMinute must be 0.
		/// <span class="constraint InRange">This field must be between 0 and 24, inclusive.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public int? EndHour { get; set; }
		/// <summary>
		/// Interval ends these minutes after the ending hour.
		/// The value can be 0, 15, 30, and 45.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public MinuteOfHour? EndMinute { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			DayOfWeek = null;
			StartHour = null;
			StartMinute = null;
			EndHour = null;
			EndMinute = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "dayOfWeek")
				{
					DayOfWeek = DayOfWeekExtensions.Parse(xItem.Value);
				}
				else if (localName == "startHour")
				{
					StartHour = int.Parse(xItem.Value);
				}
				else if (localName == "startMinute")
				{
					StartMinute = MinuteOfHourExtensions.Parse(xItem.Value);
				}
				else if (localName == "endHour")
				{
					EndHour = int.Parse(xItem.Value);
				}
				else if (localName == "endMinute")
				{
					EndMinute = MinuteOfHourExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (DayOfWeek != null)
			{
				xItem = new XElement(XName.Get("dayOfWeek", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DayOfWeek.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (StartHour != null)
			{
				xItem = new XElement(XName.Get("startHour", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StartHour.Value.ToString());
				xE.Add(xItem);
			}
			if (StartMinute != null)
			{
				xItem = new XElement(XName.Get("startMinute", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StartMinute.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (EndHour != null)
			{
				xItem = new XElement(XName.Get("endHour", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EndHour.Value.ToString());
				xE.Add(xItem);
			}
			if (EndMinute != null)
			{
				xItem = new XElement(XName.Get("endMinute", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EndMinute.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
