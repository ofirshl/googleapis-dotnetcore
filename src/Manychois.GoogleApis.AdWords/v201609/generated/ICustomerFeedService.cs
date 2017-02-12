using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service used to manage customer feed links, and matching functions.
	/// </summary>
	public interface ICustomerFeedService
	{
		/// <summary>
		/// Returns a list of customer feeds that meet the selector criteria.
		///
		/// @param selector Determines which customer feeds to return. If empty, all
		/// customer feeds are returned.
		/// @return The list of customer feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<CustomerFeedPage> GetAsync(Selector Selector);
		/// <summary>
		/// Adds, sets, or removes customer feeds.
		///
		/// @param operations The operations to apply.
		/// @return The resulting feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<CustomerFeedReturnValue> MutateAsync(IEnumerable<CustomerFeedOperation> Operations);
		/// <summary>
		/// Returns the list of customer feeds that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of CustomerFeed.
		/// @throws ApiException If problems occur while parsing the query or fetching CustomerFeed.
		/// </summary>
		Task<CustomerFeedPage> QueryAsync(string Query);
	}
}
