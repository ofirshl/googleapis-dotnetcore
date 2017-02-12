using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to generate new keyword ideas based on the
	/// parameters specified in the selector. See the {@link TargetingIdeaSelector}
	/// documentation for more details.
	///
	/// <p>You can also use this service to retrieve statistics for existing keyword
	/// ideas by setting the selector's {@code requestType} to {@link RequestType#STATS}
	/// and passing in the appropriate search parameters.</p>
	/// </summary>
	public interface ITargetingIdeaService
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
		Task<TargetingIdeaPage> GetAsync(TargetingIdeaSelector Selector);
	}
}
