using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A custom parameter of date type. Supported date formats are listed as follows:
	/// <ul>
	/// <li> 2011-03-31T12:20:19-05:00
	/// <li> 03/31/2011 12:20:19-05:00
	/// <li> Fri, Mar 31 2011 12:20:19 EST
	/// <li> Fri, Mar 31 12:20:19 EST 2011
	/// </ul>
	/// <p>
	/// If time zone information is not present in the value,
	/// it is assumed to be PST. If time value is not specified,
	/// it defaults to midnight of the day.
	/// </summary>
	public class DateKey : ISoapable
	{
		/// <summary>
		/// <span class="constraint MatchesRegex">A name must begin with US-ascii letters or underscore or UTF8 code that is greater than 127 and consist of US-ascii letters or digits or underscore or UTF8 code that is greater than 127. This is checked by the regular expression '^[a-zA-Z_?-?][a-zA-Z0-9_?-?]*$'.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint StringLength">This string must not be empty, (trimmed).</span>
		/// </summary>
		public string Name { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Name = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "name")
				{
					Name = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
		}
	}
}
