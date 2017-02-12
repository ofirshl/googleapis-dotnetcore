using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A {@link SearchParameter} for a query of {@code String}s.
	/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
	/// <p>This element is supported by following {@link RequestType}s: IDEAS, STATS.
	/// </summary>
	public class RelatedToQuerySearchParameter : SearchParameter, ISoapable
	{
		/// <summary>
		/// A list of exact keyword match query {@link String}s that the search result
		/// should be related to.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<string> Queries { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Queries = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "queries")
				{
					if (Queries == null) Queries = new List<string>();
					Queries.Add(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "RelatedToQuerySearchParameter");
			XElement xItem = null;
			if (Queries != null)
			{
				foreach (var queriesItem in Queries)
				{
					xItem = new XElement(XName.Get("queries", "https://adwords.google.com/api/adwords/o/v201609"));
					xItem.Add(queriesItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
