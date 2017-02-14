using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service used to manage extensions at the campaign level. The extensions are managed by AdWords
	/// using existing feed services, including creating and modifying feeds, feed items, and campaign
	/// feeds for the user.
	/// </summary>
	public interface ICampaignExtensionSettingService
	{
		/// <summary>
		/// Returns a list of CampaignExtensionSettings that meet the selector criteria.
		///
		/// @param selector Determines which CampaignExtensionSettings to return. If empty, all
		/// CampaignExtensionSettings are returned.
		/// @return The list of CampaignExtensionSettings specified by the selector.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<CampaignExtensionSettingPage> GetAsync(Selector selector);
		/// <summary>
		/// Applies the list of mutate operations (add, remove, and set).
		///
		/// <p> Beginning in v201509, add and set operations are treated identically. Performing an add
		/// operation on a campaign with an existing ExtensionSetting will cause the operation to be
		/// treated like a set operation. Performing a set operation on a campaign with no
		/// ExtensionSetting will cause the operation to be treated like an add operation.
		///
		/// @param operations The operations to apply. The same {@link CampaignExtensionSetting} cannot be
		/// specified in more than one operation.
		/// @return The changed {@link CampaignExtensionSetting}s.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<CampaignExtensionSettingReturnValue> MutateAsync(IEnumerable<CampaignExtensionSettingOperation> operations);
		/// <summary>
		/// Returns a list of CampaignExtensionSettings that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return The list of CampaignExtensionSettings specified by the query.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<CampaignExtensionSettingPage> QueryAsync(string query);
	}
}
