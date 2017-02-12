using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// This service is used for managing associations between {@code SharedSet} entities
	/// and {@code Campaign} entities.
	/// </summary>
	public interface ICampaignSharedSetService
	{
		/// <summary>
		/// Returns a list of CampaignSharedSets based on the given selector.
		/// @param selector the selector specifying the query
		/// @return a list of CampaignSharedSet entities that meet the criterion specified
		/// by the selector
		/// @throws ApiException
		/// </summary>
		Task<CampaignSharedSetPage> GetAsync(Selector Selector);
		/// <summary>
		/// Applies the list of mutate operations.
		/// @param operations the operations to apply
		/// @return the modified list of CampaignSharedSet associations
		/// @throws ApiException
		/// </summary>
		Task<CampaignSharedSetReturnValue> MutateAsync(IEnumerable<CampaignSharedSetOperation> Operations);
		/// <summary>
		/// Returns the list of CampaignSharedSets that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of CampaignSharedSets
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		Task<CampaignSharedSetPage> QueryAsync(string Query);
	}
}
