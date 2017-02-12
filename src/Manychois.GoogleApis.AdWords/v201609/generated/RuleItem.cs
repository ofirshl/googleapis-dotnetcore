using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An atomic rule fragment.
	/// </summary>
	public class RuleItem : ISoapable
	{
		public DateRuleItem DateRuleItem { get; set; }
		public NumberRuleItem NumberRuleItem { get; set; }
		public StringRuleItem StringRuleItem { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "DateRuleItem")
				{
					DateRuleItem = new DateRuleItem();
					DateRuleItem.ReadFrom(xItem);
				}
				else if (localName == "NumberRuleItem")
				{
					NumberRuleItem = new NumberRuleItem();
					NumberRuleItem.ReadFrom(xItem);
				}
				else if (localName == "StringRuleItem")
				{
					StringRuleItem = new StringRuleItem();
					StringRuleItem.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			xItem = new XElement(XName.Get("DateRuleItem", "https://adwords.google.com/api/adwords/rm/v201609"));
			DateRuleItem.WriteTo(xItem);
			xE.Add(xItem);
			xItem = new XElement(XName.Get("NumberRuleItem", "https://adwords.google.com/api/adwords/rm/v201609"));
			NumberRuleItem.WriteTo(xItem);
			xE.Add(xItem);
			xItem = new XElement(XName.Get("StringRuleItem", "https://adwords.google.com/api/adwords/rm/v201609"));
			StringRuleItem.WriteTo(xItem);
			xE.Add(xItem);
		}
	}
}
