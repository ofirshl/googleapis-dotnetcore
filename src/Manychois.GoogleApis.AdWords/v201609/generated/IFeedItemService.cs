using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service to operate on feed items.
	/// </summary>
	public interface IFeedItemService
	{
		/// <summary>
		/// Returns a list of FeedItems that meet the selector criteria.
		///
		/// @param selector Determines which FeedItems to return. If empty all
		/// FeedItems are returned.
		/// @return The list of FeedItems.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<FeedItemPage> GetAsync(Selector selector);
		/// <summary>
		/// Add, remove, and set FeedItems.
		///
		/// @param operations The operations to apply.
		/// @return The resulting FeedItems.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<FeedItemReturnValue> MutateAsync(IEnumerable<FeedItemOperation> operations);
		/// <summary>
		/// Returns the list of FeedItems that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of FeedItems
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		Task<FeedItemPage> QueryAsync(string query);
	}
}
