using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service used to manage campaign feed links, and matching functions.
	/// </summary>
	public interface ICampaignFeedService
	{
		/// <summary>
		/// Returns a list of CampaignFeeds that meet the selector criteria.
		///
		/// @param selector Determines which CampaignFeeds to return. If empty all
		/// Campaign feeds are returned.
		/// @return The list of CampaignFeeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<CampaignFeedPage> GetAsync(Selector selector);
		/// <summary>
		/// Adds, sets or removes CampaignFeeds.
		///
		/// @param operations The operations to apply.
		/// @return The resulting Feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<CampaignFeedReturnValue> MutateAsync(IEnumerable<CampaignFeedOperation> operations);
		/// <summary>
		/// Returns a list of {@link CampaignFeed}s inside a {@link CampaignFeedPage} that matches
		/// the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		Task<CampaignFeedPage> QueryAsync(string query);
	}
}
