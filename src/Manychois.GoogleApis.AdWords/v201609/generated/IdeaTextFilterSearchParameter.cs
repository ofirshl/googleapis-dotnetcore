using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A {@link SearchParameter} for {@code KEYWORD} {@link IdeaType}s that
	/// specifies a collection of strings by which the results should be
	/// constrained. This guarantees that each idea in the result will match
	/// at least one of the {@code included} values.
	///
	/// For this {@link SearchParameter}, excluded items will always take
	/// priority over included ones.
	///
	/// This can handle a maximum of 200 (included + excluded) elements.
	/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
	/// <p>This element is supported by following {@link RequestType}s: IDEAS, STATS.
	/// </summary>
	public class IdeaTextFilterSearchParameter : SearchParameter, ISoapable
	{
		/// <summary>
		/// A set of strings specifying which ideas should be included in the results.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint ContentsStringLength">Strings in this field must be non-empty (trimmed).</span>
		/// </summary>
		public List<string> Included { get; set; }
		/// <summary>
		/// A set of strings specifying which ideas should be excluded from the results.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint ContentsStringLength">Strings in this field must be non-empty (trimmed).</span>
		/// </summary>
		public List<string> Excluded { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Included = null;
			Excluded = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "included")
				{
					if (Included == null) Included = new List<string>();
					Included.Add(xItem.Value);
				}
				else if (localName == "excluded")
				{
					if (Excluded == null) Excluded = new List<string>();
					Excluded.Add(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "IdeaTextFilterSearchParameter");
			XElement xItem = null;
			if (Included != null)
			{
				foreach (var includedItem in Included)
				{
					xItem = new XElement(XName.Get("included", "https://adwords.google.com/api/adwords/o/v201609"));
					xItem.Add(includedItem);
					xE.Add(xItem);
				}
			}
			if (Excluded != null)
			{
				foreach (var excludedItem in Excluded)
				{
					xItem = new XElement(XName.Get("excluded", "https://adwords.google.com/api/adwords/o/v201609"));
					xItem.Add(excludedItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
