using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An atomic rule fragment composing of number operation.
	/// </summary>
	public class NumberRuleItem : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public NumberKey Key { get; set; }
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public NumberRuleItemNumberOperator? Op { get; set; }
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public double? Value { get; set; }
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
					Key = new NumberKey();
					Key.ReadFrom(xItem);
				}
				else if (localName == "op")
				{
					Op = NumberRuleItemNumberOperatorExtensions.Parse(xItem.Value);
				}
				else if (localName == "value")
				{
					Value = double.Parse(xItem.Value);
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
				xItem.Add(Value.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
