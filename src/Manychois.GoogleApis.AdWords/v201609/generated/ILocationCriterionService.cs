using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service that returns {@link LocationCriterion} constants that match a specified name or list of
	/// criterion id(s) as specified in the input selector.<p>
	///
	/// <p>Please note that filtering by date range is not supported.
	/// </summary>
	public interface ILocationCriterionService
	{
		/// <summary>
		/// Returns a list of {@link LocationCriterion}'s that match the specified selector.
		///
		/// @param selector filters the LocationCriterion to be returned.
		/// @return A list of location criterion.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<IEnumerable<LocationCriterion>> GetAsync(Selector Selector);
		/// <summary>
		/// Returns the list of {@link LocationCriterion}s that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns The list of location criteria
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		Task<IEnumerable<LocationCriterion>> QueryAsync(string Query);
	}
}
