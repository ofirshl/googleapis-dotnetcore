using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an AdSchedule Criterion.
	/// AdSchedule is specified as day and time of the week criteria to target
	/// the Ads.
	/// <p><b>Note:</b> An AdSchedule may not have more than <b>six</b> intervals
	/// in a day.</p>
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class AdSchedule : Criterion, ISoapable
	{
		/// <summary>
		/// Day of the week the schedule applies to.
		/// <span class="constraint Selectable">This field can be selected using the value "DayOfWeek".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public DayOfWeek? DayOfWeek { get; set; }
		/// <summary>
		/// Starting hour in 24 hour time.
		/// <span class="constraint Selectable">This field can be selected using the value "StartHour".</span>
		/// <span class="constraint InRange">This field must be between 0 and 23, inclusive.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public int? StartHour { get; set; }
		/// <summary>
		/// Interval starts these minutes after the starting hour.
		/// The value can be 0, 15, 30, and 45.
		/// <span class="constraint Selectable">This field can be selected using the value "StartMinute".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public MinuteOfHour? StartMinute { get; set; }
		/// <summary>
		/// Ending hour in 24 hour time; <code>24</code> signifies end of the day.
		/// <span class="constraint Selectable">This field can be selected using the value "EndHour".</span>
		/// <span class="constraint InRange">This field must be between 0 and 24, inclusive.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public int? EndHour { get; set; }
		/// <summary>
		/// Interval ends these minutes after the ending hour.
		/// The value can be 0, 15, 30, and 45.
		/// <span class="constraint Selectable">This field can be selected using the value "EndMinute".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public MinuteOfHour? EndMinute { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
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
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AdSchedule");
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
