using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Manages which criteria are associated with shared sets.
	/// </summary>
	public interface ISharedCriterionService
	{
		/// <summary>
		/// Returns a list of SharedCriterion that meets the selector criteria.
		///
		/// @param selector filters the criteria returned
		/// @return The list of SharedCriterion
		/// @throws ApiException
		/// </summary>
		Task<SharedCriterionPage> GetAsync(Selector Selector);
		/// <summary>
		/// Adds, removes criteria in a shared set.
		///
		/// @param operations A list of unique operations
		/// @return The list of updated SharedCriterion, returned in the same order as the
		/// {@code operations} array.
		/// @throws ApiException
		/// </summary>
		Task<SharedCriterionReturnValue> MutateAsync(IEnumerable<SharedCriterionOperation> Operations);
		/// <summary>
		/// Returns the list of SharedCriterion that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of SharedCriterion.
		/// @throws ApiException
		/// </summary>
		Task<SharedCriterionPage> QueryAsync(string Query);
	}
}
