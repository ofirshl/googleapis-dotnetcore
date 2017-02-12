using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A client defined rule based on custom parameters sent by web sites.
	/// It consists of rule item groups that are connected by OR.
	/// </summary>
	public class Rule : ISoapable
	{
		/// <summary>
		/// Lists of rule item groups that defines this rule. The rule item groups
		/// are ORed together for evaluation.
		/// <span class="constraint CollectionSize">The minimum size of this collection is 1.</span>
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<RuleItemGroup> Groups { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Groups = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "groups")
				{
					if (Groups == null) Groups = new List<RuleItemGroup>();
					var groupsItem = new RuleItemGroup();
					groupsItem.ReadFrom(xItem);
					Groups.Add(groupsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Groups != null)
			{
				foreach (var groupsItem in Groups)
				{
					xItem = new XElement(XName.Get("groups", "https://adwords.google.com/api/adwords/rm/v201609"));
					groupsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
