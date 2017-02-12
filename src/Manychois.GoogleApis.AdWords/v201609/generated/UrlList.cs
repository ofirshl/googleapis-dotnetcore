using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Wrapper POJO for a list of URLs.  The list can be cleared if a request contains
	/// a UrlList with an empty urls list.
	/// </summary>
	public class UrlList : ISoapable
	{
		/// <summary>
		/// List of URLs.  On SET operation, empty list indicates to clear the list.
		/// <span class="constraint CollectionSize">The maximum size of this collection is 10.</span>
		/// <span class="constraint ContentsStringLength">Strings in this field must be non-empty (trimmed).</span>
		/// </summary>
		public List<string> Urls { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Urls = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "urls")
				{
					if (Urls == null) Urls = new List<string>();
					Urls.Add(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Urls != null)
			{
				foreach (var urlsItem in Urls)
				{
					xItem = new XElement(XName.Get("urls", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(urlsItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
