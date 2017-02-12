using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A set of {@link SearchParameter}s is supplied to the {@link TargetingIdeaSelector} to specify how
	/// the user wants to filter the set of all possible {@link TargetingIdea}s.
	///
	/// <p>There is a {@link SearchParameter} for each type of input.
	/// {@link SearchParameter}s can conceptually be broken down into two types.</p>
	///
	/// <ul>
	/// <li>Input {@link SearchParameter}s provide the seed information from which
	/// ideas or stats are to be generated (e.g., {@link RelatedToQuerySearchParameter},
	/// {@link RelatedToUrlSearchParameter}, etc.). This type of {@link SearchParameters}
	/// is required in requests.
	/// <li>Filter {@link SearchParameter}s (e.g., {@link CompetitionSearchParameter}, etc.)
	/// are used to trim down the results based on {@link Attribute}-related information.
	/// </ul>
	///
	/// <p>A request should only contain one instance of each {@link SearchParameter}.
	/// Requests containing multiple instances of the same search parameter will be
	/// rejected.</p>
	/// <p>One or more of the following {@link SearchParameter}s are required:<br/>
	/// <ul><li>{@link CategoryProductsAndServicesSearchParameter}</li>
	/// <li>{@link LocationSearchParameter}</li>
	/// <li>{@link RelatedToQuerySearchParameter}</li>
	/// <li>{@link RelatedToUrlSearchParameter}</li>
	/// <li>{@link SeedAdGroupIdSearchParameter}</li>
	/// </ul><p>
	/// <p><b>{@link IdeaType} KEYWORD supports following {@link SearchParameter}s:</b><br/>
	/// <ul>
	/// <li>{@link CategoryProductsAndServicesSearchParameter}</li>
	/// <li>{@link CompetitionSearchParameter}</li>
	/// <li>{@link IdeaTextFilterSearchParameter}</li>
	/// <li>{@link IncludeAdultContentSearchParameter}</li>
	/// <li>{@link LanguageSearchParameter}</li>
	/// <li>{@link LocationSearchParameter}</li>
	/// <li>{@link NetworkSearchParameter}</li>
	/// <li>{@link RelatedToQuerySearchParameter}</li>
	/// <li>{@link RelatedToUrlSearchParameter}</li>
	/// <li>{@link SearchVolumeSearchParameter}</li>
	/// <li>{@link SeedAdGroupIdSearchParameter}</li>
	/// </ul><p>
	/// </summary>
	public abstract class SearchParameter : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of SearchParameter.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string SearchParameterType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			SearchParameterType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "SearchParameter.Type")
				{
					SearchParameterType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (SearchParameterType != null)
			{
				xItem = new XElement(XName.Get("SearchParameter.Type", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(SearchParameterType);
				xE.Add(xItem);
			}
		}
	}
}
