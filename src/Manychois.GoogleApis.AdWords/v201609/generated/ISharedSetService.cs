using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// This service is used for managing {@link SharedSet} entities themselves
	/// and the association between sets and campaigns.
	/// </summary>
	public interface ISharedSetService
	{
		/// <summary>
		/// Returns a list of SharedSets based on the given selector.
		/// @param selector the selector specifying the query
		/// @return a list of SharedSet entities that meet the criterion specified
		/// by the selector
		/// @throws ApiException
		/// </summary>
		Task<SharedSetPage> GetAsync(Selector Selector);
		/// <summary>
		/// Applies the list of mutate operations.
		/// @param operations the operations to apply
		/// @return the modified CriterionList entities
		/// @throws ApiException
		/// </summary>
		Task<SharedSetReturnValue> MutateAsync(IEnumerable<SharedSetOperation> Operations);
		/// <summary>
		/// Returns the list of SharedSet entities that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of SharedSet entities
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		Task<SharedSetPage> QueryAsync(string Query);
	}
}
