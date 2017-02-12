using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A {@link SearchParameter} used to indicate multiple language being targeted.
	/// This can be used, for example, to search for {@code KEYWORD}
	/// {@link IdeaType}s that are best for Japanese language.
	///
	/// <p>The service allows at most one language to be targeted for
	/// {@code KEYWORD} requests.
	/// <p>In the {@code KEYWORD} {@link IdeaType} {@code STATS} {@link RequestType}
	/// requests, those keywords that are from different language than specified in
	/// {@code LanguageSearchParameter} or have unknown language will be filtered
	/// out in the response. To avoid filtering, do not include
	/// {@code LanguageSearchParameter} in the request.
	/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
	/// <p>This element is supported by following {@link RequestType}s: IDEAS, STATS.
	/// </summary>
	public class LanguageSearchParameter : SearchParameter, ISoapable
	{
		/// <summary>
		/// A list of {@link Language}s indicating the desired languages being targeted in the results.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<Language> Languages { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Languages = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "languages")
				{
					if (Languages == null) Languages = new List<Language>();
					var languagesItem = new Language();
					languagesItem.ReadFrom(xItem);
					Languages.Add(languagesItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "LanguageSearchParameter");
			XElement xItem = null;
			if (Languages != null)
			{
				foreach (var languagesItem in Languages)
				{
					xItem = new XElement(XName.Get("languages", "https://adwords.google.com/api/adwords/o/v201609"));
					languagesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
