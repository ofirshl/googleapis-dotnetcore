using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A {@link SearchParameter} that specifies a set of URLs that results should
	/// in some way be related to. For example, keyword results would be
	/// similar to content keywords found on the related URLs.
	/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
	/// <p>This element is supported by following {@link RequestType}s: IDEAS.
	/// </summary>
	public class RelatedToUrlSearchParameter : SearchParameter, ISoapable
	{
		/// <summary>
		/// A set of URL strings to which search results should be related.
		/// For {@code KEYWORD} queries, only one URL may be submitted.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<string> Urls { get; set; }
		/// <summary>
		/// Whether to crawl links off of the {@code urls} for the same domain.
		/// Default is {@code false}.
		/// </summary>
		public bool? IncludeSubUrls { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Urls = null;
			IncludeSubUrls = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "urls")
				{
					if (Urls == null) Urls = new List<string>();
					Urls.Add(xItem.Value);
				}
				else if (localName == "includeSubUrls")
				{
					IncludeSubUrls = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "RelatedToUrlSearchParameter");
			XElement xItem = null;
			if (Urls != null)
			{
				foreach (var urlsItem in Urls)
				{
					xItem = new XElement(XName.Get("urls", "https://adwords.google.com/api/adwords/o/v201609"));
					xItem.Add(urlsItem);
					xE.Add(xItem);
				}
			}
			if (IncludeSubUrls != null)
			{
				xItem = new XElement(XName.Get("includeSubUrls", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(IncludeSubUrls.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
