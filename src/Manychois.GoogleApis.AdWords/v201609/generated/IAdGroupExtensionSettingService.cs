using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service used to manage extensions at the adgroup level. The extensions are managed by AdWords
	/// using existing feed services, including creating and modifying feeds, feed items, and adgroup
	/// feeds for the user.
	/// </summary>
	public interface IAdGroupExtensionSettingService
	{
		/// <summary>
		/// Returns a list of AdGroupExtensionSettings that meet the selector criteria.
		///
		/// @param selector Determines which AdGroupExtensionSettings to return. If empty, all
		/// AdGroupExtensionSettings are returned.
		/// @return The list of AdGroupExtensionSettings specified by the selector.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<AdGroupExtensionSettingPage> GetAsync(Selector Selector);
		/// <summary>
		/// Applies the list of mutate operations (add, remove, and set).
		///
		/// <p> Beginning in v201509, add and set operations are treated identically. Performing an add
		/// operation on an ad group with an existing ExtensionSetting will cause the operation to be
		/// treated like a set operation. Performing a set operation on an ad group with no
		/// ExtensionSetting will cause the operation to be treated like an add operation.
		///
		/// @param operations The operations to apply. The same {@link AdGroupExtensionSetting} cannot be
		/// specified in more than one operation.
		/// @return The changed {@link AdGroupExtensionSetting}s.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<AdGroupExtensionSettingReturnValue> MutateAsync(IEnumerable<AdGroupExtensionSettingOperation> Operations);
		/// <summary>
		/// Returns a list of AdGroupExtensionSettings that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return The list of AdGroupExtensionSettings specified by the query.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<AdGroupExtensionSettingPage> QueryAsync(string Query);
	}
}
