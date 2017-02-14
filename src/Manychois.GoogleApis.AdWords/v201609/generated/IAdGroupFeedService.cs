using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service used to manage adgroup feed links, and matching functions.
	/// </summary>
	public interface IAdGroupFeedService
	{
		/// <summary>
		/// Returns a list of AdGroupFeeds that meet the selector criteria.
		///
		/// @param selector Determines which AdGroupFeeds to return. If empty all
		/// adgroup feeds are returned.
		/// @return The list of AdgroupFeeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<AdGroupFeedPage> GetAsync(Selector selector);
		/// <summary>
		/// Adds, updates or removes AdGroupFeeds.
		///
		/// @param operations The operations to apply.
		/// @return The resulting Feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<AdGroupFeedReturnValue> MutateAsync(IEnumerable<AdGroupFeedOperation> operations);
		/// <summary>
		/// Returns the list of AdGroupFeeds that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @returns A list of AdGroupFeed.
		/// @throws ApiException if problems occur while parsing the query or fetching AdGroupFeed.
		/// </summary>
		Task<AdGroupFeedPage> QueryAsync(string query);
	}
}
