using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a date.
	/// </summary>
	public class Date : ISoapable
	{
		/// <summary>
		/// Year (e.g., 2009)
		/// </summary>
		public int? Year { get; set; }
		/// <summary>
		/// Month (1..12)
		/// </summary>
		public int? Month { get; set; }
		/// <summary>
		/// Day (1..31)
		/// </summary>
		public int? Day { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Year = null;
			Month = null;
			Day = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "year")
				{
					Year = int.Parse(xItem.Value);
				}
				else if (localName == "month")
				{
					Month = int.Parse(xItem.Value);
				}
				else if (localName == "day")
				{
					Day = int.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Year != null)
			{
				xItem = new XElement(XName.Get("year", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Year.Value.ToString());
				xE.Add(xItem);
			}
			if (Month != null)
			{
				xItem = new XElement(XName.Get("month", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Month.Value.ToString());
				xE.Add(xItem);
			}
			if (Day != null)
			{
				xItem = new XElement(XName.Get("day", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Day.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
