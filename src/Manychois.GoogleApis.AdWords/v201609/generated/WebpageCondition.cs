using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Logical expression for targeting webpages of an advertiser's website.
	///
	/// <p>A condition is defined as {@code operand OP argument}
	/// where {@code operand} is one of the values enumerated in
	/// {@link WebpageConditionOperand}, and, based on this value,
	/// {@code OP} is either of {@code EQUALS} or {@code CONTAINS}.</p>
	/// </summary>
	public class WebpageCondition : ISoapable
	{
		/// <summary>
		/// Operand of webpage targeting condition.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public WebpageConditionOperand? Operand { get; set; }
		/// <summary>
		/// Argument of the webpage targeting condition.
		/// <span class="constraint MustNotContain">This string must not contain a substring that matches the regular expression '\*|\>\>|\=\=|\&\+'</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 2048, inclusive.</span>
		/// </summary>
		public string Argument { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operand = null;
			Argument = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operand")
				{
					Operand = WebpageConditionOperandExtensions.Parse(xItem.Value);
				}
				else if (localName == "argument")
				{
					Argument = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Operand != null)
			{
				xItem = new XElement(XName.Get("operand", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Operand.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Argument != null)
			{
				xItem = new XElement(XName.Get("argument", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Argument);
				xE.Add(xItem);
			}
		}
	}
}
