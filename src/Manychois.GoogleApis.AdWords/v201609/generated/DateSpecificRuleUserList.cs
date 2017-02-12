using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Visitors of a page during specific dates. The visiting periods are defined as follows:
	/// <ul>
	/// <li> between {@code startDate} (inclusive) and {@code endDate} (inclusive);
	/// <li> before {@code endDate} (exclusive) with {@code startDate} = 2000-01-01;
	/// <li> after {@code startDate} (exclusive) with {@code endDate} = 2037-12-30.
	/// </ul>
	/// </summary>
	public class DateSpecificRuleUserList : RuleBasedUserList, ISoapable
	{
		/// <summary>
		/// Boolean rule that defines visitor of a page. This field is selected by default.
		/// <span class="constraint Selectable">This field can be selected using the value "DateSpecificListRule".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public Rule Rule { get; set; }
		/// <summary>
		/// Start date of users visit. If set to <code>20000101</code>, then includes
		/// all users before <code>endDate</code>. The date's format should be YYYYMMDD.
		/// This field is selected by default.
		/// <span class="constraint Selectable">This field can be selected using the value "DateSpecificListStartDate".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string StartDate { get; set; }
		/// <summary>
		/// End date of users visit. If set to <code>20371230</code>, then includes
		/// all users after <code>startDate</code>. The date's format should be YYYYMMDD.
		/// This field is selected by default.
		/// <span class="constraint Selectable">This field can be selected using the value "DateSpecificListEndDate".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string EndDate { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Rule = null;
			StartDate = null;
			EndDate = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "rule")
				{
					Rule = new Rule();
					Rule.ReadFrom(xItem);
				}
				else if (localName == "startDate")
				{
					StartDate = xItem.Value;
				}
				else if (localName == "endDate")
				{
					EndDate = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/rm/v201609", "DateSpecificRuleUserList");
			XElement xItem = null;
			if (Rule != null)
			{
				xItem = new XElement(XName.Get("rule", "https://adwords.google.com/api/adwords/rm/v201609"));
				Rule.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (StartDate != null)
			{
				xItem = new XElement(XName.Get("startDate", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(StartDate);
				xE.Add(xItem);
			}
			if (EndDate != null)
			{
				xItem = new XElement(XName.Get("endDate", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(EndDate);
				xE.Add(xItem);
			}
		}
	}
}
