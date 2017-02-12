using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents the traffic estimate result for a single keyword.
	/// </summary>
	public class KeywordEstimate : Estimate, ISoapable
	{
		/// <summary>
		/// The existing criterionId for this keyword, if any.
		///
		/// This will not be returned if this is a new keyword.
		/// </summary>
		public long? CriterionId { get; set; }
		/// <summary>
		/// The lower bound on the estimated stats.
		///
		/// <p>This is not a guarantee that actual performance will never be lower than
		/// these stats.
		/// </summary>
		public StatsEstimate Min { get; set; }
		/// <summary>
		/// The upper bound on the estimated stats.
		///
		/// <p>This is not a guarantee that actual performance will never be higher than
		/// these stats.
		/// </summary>
		public StatsEstimate Max { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			CriterionId = null;
			Min = null;
			Max = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "criterionId")
				{
					CriterionId = long.Parse(xItem.Value);
				}
				else if (localName == "min")
				{
					Min = new StatsEstimate();
					Min.ReadFrom(xItem);
				}
				else if (localName == "max")
				{
					Max = new StatsEstimate();
					Max.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "KeywordEstimate");
			XElement xItem = null;
			if (CriterionId != null)
			{
				xItem = new XElement(XName.Get("criterionId", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(CriterionId.Value.ToString());
				xE.Add(xItem);
			}
			if (Min != null)
			{
				xItem = new XElement(XName.Get("min", "https://adwords.google.com/api/adwords/o/v201609"));
				Min.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Max != null)
			{
				xItem = new XElement(XName.Get("max", "https://adwords.google.com/api/adwords/o/v201609"));
				Max.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
