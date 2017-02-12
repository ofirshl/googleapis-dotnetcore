using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An atomic rule fragment composing of date operation.
	/// </summary>
	public class DateRuleItem : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public DateKey Key { get; set; }
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public DateRuleItemDateOperator? Op { get; set; }
		/// <summary>
		/// The right hand side of date rule item. The date's format should be YYYYMMDD.
		/// </summary>
		public string Value { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Key = null;
			Op = null;
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "key")
				{
					Key = new DateKey();
					Key.ReadFrom(xItem);
				}
				else if (localName == "op")
				{
					Op = DateRuleItemDateOperatorExtensions.Parse(xItem.Value);
				}
				else if (localName == "value")
				{
					Value = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Key != null)
			{
				xItem = new XElement(XName.Get("key", "https://adwords.google.com/api/adwords/rm/v201609"));
				Key.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Op != null)
			{
				xItem = new XElement(XName.Get("op", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Op.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Value != null)
			{
				xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Value);
				xE.Add(xItem);
			}
		}
	}
}
