using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A keyword response value representing search volume for a single month. An
	/// instance with a {@code null} count is valid, indicating that the information
	/// is unavailable.
	/// </summary>
	public class MonthlySearchVolume : ISoapable
	{
		/// <summary>
		/// The year this search volume occurred in. (i.e. 2009)
		/// </summary>
		public int? Year { get; set; }
		/// <summary>
		/// The month this search volume occurred in. Month is 1 indexed,
		/// such that 1=January and 12=December.
		/// </summary>
		public int? Month { get; set; }
		/// <summary>
		/// The approximate number of searches in this year/month. A {@code null} count
		/// means that data is unavailable or unknown.
		/// </summary>
		public long? Count { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Year = null;
			Month = null;
			Count = null;
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
				else if (localName == "count")
				{
					Count = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Year != null)
			{
				xItem = new XElement(XName.Get("year", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(Year.Value.ToString());
				xE.Add(xItem);
			}
			if (Month != null)
			{
				xItem = new XElement(XName.Get("month", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(Month.Value.ToString());
				xE.Add(xItem);
			}
			if (Count != null)
			{
				xItem = new XElement(XName.Get("count", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(Count.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
