using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A custom parameter of type number.
	/// </summary>
	public class NumberKey : ISoapable
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
