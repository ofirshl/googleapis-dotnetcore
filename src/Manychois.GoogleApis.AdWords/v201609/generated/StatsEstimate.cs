using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a set of stats for a daily traffic estimate.
	///
	/// <p>{@code averageCpc}, {@code averagePosition} and {@code clickThroughRate} will be
	/// {@code null} when not defined and {@code clicksPerDay} or {@code impressionsPerDay}
	/// is {@code 0}, respectively.</p>
	/// </summary>
	public class StatsEstimate : ISoapable
	{
		/// <summary>
		/// The estimated average CPC.
		/// </summary>
		public Money AverageCpc { get; set; }
		/// <summary>
		/// The estimated average position.
		/// </summary>
		public double? AveragePosition { get; set; }
		/// <summary>
		/// The estimated click through rate.
		/// </summary>
		public double? ClickThroughRate { get; set; }
		/// <summary>
		/// The estimated number of clicks, in floating point representation.
		/// </summary>
		public float? ClicksPerDay { get; set; }
		/// <summary>
		/// The estimated number of impressions, in floating point representation.
		/// </summary>
		public float? ImpressionsPerDay { get; set; }
		/// <summary>
		/// The estimated total cost.
		/// </summary>
		public Money TotalCost { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			AverageCpc = null;
			AveragePosition = null;
			ClickThroughRate = null;
			ClicksPerDay = null;
			ImpressionsPerDay = null;
			TotalCost = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "averageCpc")
				{
					AverageCpc = new Money();
					AverageCpc.ReadFrom(xItem);
				}
				else if (localName == "averagePosition")
				{
					AveragePosition = double.Parse(xItem.Value);
				}
				else if (localName == "clickThroughRate")
				{
					ClickThroughRate = double.Parse(xItem.Value);
				}
				else if (localName == "clicksPerDay")
				{
					ClicksPerDay = float.Parse(xItem.Value);
				}
				else if (localName == "impressionsPerDay")
				{
					ImpressionsPerDay = float.Parse(xItem.Value);
				}
				else if (localName == "totalCost")
				{
					TotalCost = new Money();
					TotalCost.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (AverageCpc != null)
			{
				xItem = new XElement(XName.Get("averageCpc", "https://adwords.google.com/api/adwords/o/v201609"));
				AverageCpc.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (AveragePosition != null)
			{
				xItem = new XElement(XName.Get("averagePosition", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(AveragePosition.Value.ToString());
				xE.Add(xItem);
			}
			if (ClickThroughRate != null)
			{
				xItem = new XElement(XName.Get("clickThroughRate", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(ClickThroughRate.Value.ToString());
				xE.Add(xItem);
			}
			if (ClicksPerDay != null)
			{
				xItem = new XElement(XName.Get("clicksPerDay", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(ClicksPerDay.Value.ToString());
				xE.Add(xItem);
			}
			if (ImpressionsPerDay != null)
			{
				xItem = new XElement(XName.Get("impressionsPerDay", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(ImpressionsPerDay.Value.ToString());
				xE.Add(xItem);
			}
			if (TotalCost != null)
			{
				xItem = new XElement(XName.Get("totalCost", "https://adwords.google.com/api/adwords/o/v201609"));
				TotalCost.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
