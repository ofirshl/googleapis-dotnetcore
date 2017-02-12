using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns a page of ideas that match the query described by the specified
	/// {@link TargetingIdeaSelector}.
	///
	/// <p>The selector must specify a {@code paging} value, with {@code numberResults} set to 800 or
	/// less.  Large result sets must be composed through multiple calls to this method, advancing the
	/// paging {@code startIndex} value by {@code numberResults} with each call.</p>
	///
	/// @param selector Query describing the types of results to return when
	/// finding matches (similar keyword ideas).
	/// @return A {@link TargetingIdeaPage} of results, that is a subset of the
	/// list of possible ideas meeting the criteria of the
	/// {@link TargetingIdeaSelector}.
	/// @throws ApiException If problems occurred while querying for ideas.
	/// </summary>
	internal class TargetingIdeaServiceGet : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public TargetingIdeaSelector Selector { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Selector = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "selector")
				{
					Selector = new TargetingIdeaSelector();
					Selector.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Selector != null)
			{
				xItem = new XElement(XName.Get("selector", "https://adwords.google.com/api/adwords/o/v201609"));
				Selector.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
