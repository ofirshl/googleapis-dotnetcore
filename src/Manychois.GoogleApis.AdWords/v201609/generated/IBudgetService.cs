using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Budget Service to get/mutate budgets.
	/// </summary>
	public interface IBudgetService
	{
		/// <summary>
		/// Returns a list of budgets that match the selector.
		///
		/// @return List of budgets specified by the selector.
		/// @throws com.google.ads.api.services.common.error.ApiException if problems
		/// occurred while retrieving results.
		/// </summary>
		Task<BudgetPage> GetAsync(Selector selector);
		/// <summary>
		/// Applies the list of mutate operations.
		///
		/// @param operations The operations to apply.
		/// @return The modified list of Budgets, returned in the same order as <code>operations</code>.
		/// @throws ApiException
		/// </summary>
		Task<BudgetReturnValue> MutateAsync(IEnumerable<BudgetOperation> operations);
		/// <summary>
		/// Returns the list of budgets that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of Budget
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		Task<BudgetPage> QueryAsync(string query);
	}
}
