using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Visitors of a page. The page visit is defined by one boolean rule expression.
	/// </summary>
	public class ExpressionRuleUserList : RuleBasedUserList, ISoapable
	{
		/// <summary>
		/// Boolean rule that defines this user list. The rule consists of a list of
		/// rule item groups. All the rule item groups are ORed for the evaluation. This
		/// field is selected by default.
		/// <span class="constraint Selectable">This field can be selected using the value "ExpressionListRule".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public Rule Rule { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Rule = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "rule")
				{
					Rule = new Rule();
					Rule.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/rm/v201609", "ExpressionRuleUserList");
			XElement xItem = null;
			if (Rule != null)
			{
				xItem = new XElement(XName.Get("rule", "https://adwords.google.com/api/adwords/rm/v201609"));
				Rule.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
