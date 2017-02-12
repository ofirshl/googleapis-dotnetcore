using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service used to get and mutate Feeds that contain ad customizer data.
	///
	/// <p>This service is a convenience for creating and modifying ad customizer Feeds, but such Feeds
	/// can also be managed using a combination of the Feed, FeedMapping, and CustomerFeed services.
	/// </summary>
	public interface IAdCustomizerFeedService
	{
		/// <summary>
		/// Returns a list of AdCustomizerFeeds that meet the selector criteria.
		///
		/// @param selector Determines which AdCustomizerFeeds to return. If empty, all AdCustomizerFeeds
		/// are returned.
		/// @return The list of AdCustomizerFeeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<AdCustomizerFeedPage> GetAsync(Selector Selector);
		/// <summary>
		/// Adds, removes, or modifies AdCustomizerFeeds.
		///
		/// @param operations The operations to apply.
		/// @return The resulting AdCustomizerFeeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<AdCustomizerFeedReturnValue> MutateAsync(IEnumerable<AdCustomizerFeedOperation> Operations);
	}
}
