using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service used to get and mutate Feeds.
	/// </summary>
	public interface IFeedService
	{
		/// <summary>
		/// Returns a list of Feeds that meet the selector criteria.
		///
		/// @param selector Determines which Feeds to return. If empty all
		/// Feeds are returned.
		/// @return The list of Feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<FeedPage> GetAsync(Selector selector);
		/// <summary>
		/// Add, remove, and set Feeds.
		///
		/// @param operations The operations to apply.
		/// @return The resulting Feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<FeedReturnValue> MutateAsync(IEnumerable<FeedOperation> operations);
		/// <summary>
		/// Returns the list of Feed that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @returns A list of Feed.
		/// @throws ApiException if problems occur while parsing the query or fetching Feed.
		/// </summary>
		Task<FeedPage> QueryAsync(string query);
	}
}
