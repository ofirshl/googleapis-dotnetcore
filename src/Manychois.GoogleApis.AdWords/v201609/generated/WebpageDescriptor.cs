using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Basic information about a webpage.
	/// </summary>
	public class WebpageDescriptor : ISoapable
	{
		/// <summary>
		/// The URL of the webpage.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// The title of the webpage.
		/// </summary>
		public string Title { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Url = null;
			Title = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "url")
				{
					Url = xItem.Value;
				}
				else if (localName == "title")
				{
					Title = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Url != null)
			{
				xItem = new XElement(XName.Get("url", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(Url);
				xE.Add(xItem);
			}
			if (Title != null)
			{
				xItem = new XElement(XName.Get("title", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(Title);
				xE.Add(xItem);
			}
		}
	}
}
