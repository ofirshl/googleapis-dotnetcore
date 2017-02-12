using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A user list logical rule. A rule has a logical operator (and/or/not) and a
	/// list of operands that can be user lists or user interests.
	/// </summary>
	public class UserListLogicalRule : ISoapable
	{
		/// <summary>
		/// The logical operator of the rule.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public UserListLogicalRuleOperator? Operator { get; set; }
		/// <summary>
		/// The list of operands of the rule.
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<LogicalUserListOperand> RuleOperands { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operator = null;
			RuleOperands = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operator")
				{
					Operator = UserListLogicalRuleOperatorExtensions.Parse(xItem.Value);
				}
				else if (localName == "ruleOperands")
				{
					if (RuleOperands == null) RuleOperands = new List<LogicalUserListOperand>();
					var ruleOperandsItem = new LogicalUserListOperand();
					ruleOperandsItem.ReadFrom(xItem);
					RuleOperands.Add(ruleOperandsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Operator != null)
			{
				xItem = new XElement(XName.Get("operator", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Operator.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (RuleOperands != null)
			{
				foreach (var ruleOperandsItem in RuleOperands)
				{
					xItem = new XElement(XName.Get("ruleOperands", "https://adwords.google.com/api/adwords/rm/v201609"));
					ruleOperandsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
