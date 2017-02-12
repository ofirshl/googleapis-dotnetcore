using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// BiddingStrategy Service to get/mutate bidding strategies.
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public interface IBiddingStrategyService
	{
		/// <summary>
		/// Returns a list of bidding strategies that match the selector.
		///
		/// @return list of bidding strategies specified by the selector.
		/// @throws com.google.ads.api.services.common.error.ApiException if problems
		/// occurred while retrieving results.
		/// </summary>
		Task<BiddingStrategyPage> GetAsync(Selector Selector);
		/// <summary>
		/// Applies the list of mutate operations.
		///
		/// @param operations the operations to apply
		/// @return the modified list of BiddingStrategy
		/// @throws ApiException
		/// </summary>
		Task<BiddingStrategyReturnValue> MutateAsync(IEnumerable<BiddingStrategyOperation> Operations);
		/// <summary>
		/// Returns a list of bidding strategies that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		Task<BiddingStrategyPage> QueryAsync(string Query);
	}
}
