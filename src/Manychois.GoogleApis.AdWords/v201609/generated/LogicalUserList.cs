using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a user list that is a custom combination of user lists and user
	/// interests.
	/// </summary>
	public class LogicalUserList : UserList, ISoapable
	{
		/// <summary>
		/// Logical list rules that define this user list.  The rules are defined as
		/// logical operator (ALL/ANY/NONE) and a list of user lists. All the rules are
		/// anded for the evaluation.
		/// <span class="constraint Selectable">This field can be selected using the value "Rules".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public List<UserListLogicalRule> Rules { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Rules = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "rules")
				{
					if (Rules == null) Rules = new List<UserListLogicalRule>();
					var rulesItem = new UserListLogicalRule();
					rulesItem.ReadFrom(xItem);
					Rules.Add(rulesItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/rm/v201609", "LogicalUserList");
			XElement xItem = null;
			if (Rules != null)
			{
				foreach (var rulesItem in Rules)
				{
					xItem = new XElement(XName.Get("rules", "https://adwords.google.com/api/adwords/rm/v201609"));
					rulesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
