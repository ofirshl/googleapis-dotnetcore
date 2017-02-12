using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a keyword.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class Keyword : Criterion, ISoapable
	{
		/// <summary>
		/// Text of this keyword (at most 80 characters and ten words).
		/// <span class="constraint Selectable">This field can be selected using the value "KeywordText".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint MatchesRegex">Keyword text must not contain NUL (code point 0x0) characters. This is checked by the regular expression '[^\x00]*'.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Match type of this keyword.
		/// <span class="constraint Selectable">This field can be selected using the value "KeywordMatchType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public KeywordMatchType? MatchType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Text = null;
			MatchType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "text")
				{
					Text = xItem.Value;
				}
				else if (localName == "matchType")
				{
					MatchType = KeywordMatchTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Keyword");
			XElement xItem = null;
			if (Text != null)
			{
				xItem = new XElement(XName.Get("text", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Text);
				xE.Add(xItem);
			}
			if (MatchType != null)
			{
				xItem = new XElement(XName.Get("matchType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(MatchType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
