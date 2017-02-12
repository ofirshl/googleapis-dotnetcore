using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a structured snippet extension.
	/// </summary>
	public class StructuredSnippetFeedItem : ExtensionFeedItem, ISoapable
	{
		/// <summary>
		/// The header of the snippet. See the
		/// <a href="https://developers.google.com/adwords/api/docs/appendix/structured-snippet-headers">
		/// structured snippets header translations</a> page for supported localized headers.
		/// <span class="constraint StringLength">This string must not be empty.</span>
		/// </summary>
		public string Header { get; set; }
		/// <summary>
		/// The values in the snippet. A SET operation replaces the values in the list.
		/// <span class="constraint CollectionSize">The maximum size of this collection is 10.</span>
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// </summary>
		public List<string> Values { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Header = null;
			Values = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "header")
				{
					Header = xItem.Value;
				}
				else if (localName == "values")
				{
					if (Values == null) Values = new List<string>();
					Values.Add(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "StructuredSnippetFeedItem");
			XElement xItem = null;
			if (Header != null)
			{
				xItem = new XElement(XName.Get("header", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Header);
				xE.Add(xItem);
			}
			if (Values != null)
			{
				foreach (var valuesItem in Values)
				{
					xItem = new XElement(XName.Get("values", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(valuesItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
