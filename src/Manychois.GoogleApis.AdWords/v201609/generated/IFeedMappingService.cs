using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service for getting and mutating FeedMappings.
	/// </summary>
	public interface IFeedMappingService
	{
		/// <summary>
		/// Returns a list of FeedMappings that meet the selector criteria.
		///
		/// @param selector Determines which FeedMappings to return. If empty all
		/// FeedMappings are returned.
		/// @return The list of FeedMappings.
		/// @throws ApiException indicates a problem with the request.
		/// </summary>
		Task<FeedMappingPage> GetAsync(Selector Selector);
		/// <summary>
		/// Add and remove FeedMappings.
		/// The following {@link Operator}s are supported: ADD, REMOVE.
		///
		/// @param operations The operations to apply.
		/// @return The resulting FeedMappings.
		/// @throws ApiException indicates a problem with the request.
		/// </summary>
		Task<FeedMappingReturnValue> MutateAsync(IEnumerable<FeedMappingOperation> Operations);
		/// <summary>
		/// Returns the list of FeedMappings that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns The list of FeedMappings
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		Task<FeedMappingPage> QueryAsync(string Query);
	}
}
