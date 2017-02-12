using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service used to manage extensions at the customer level. The extensions are managed by AdWords
	/// using existing feed services, including creating and modifying feeds, feed items, and customer
	/// feeds for the user.
	/// </summary>
	public interface ICustomerExtensionSettingService
	{
		/// <summary>
		/// Returns a list of CustomerExtensionSettings that meet the selector criteria.
		///
		/// @param selector Determines which CustomerExtensionSettings to return. If empty, all
		/// CustomerExtensionSettings are returned.
		/// @return The list of CustomerExtensionSettings specified by the selector.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<CustomerExtensionSettingPage> GetAsync(Selector Selector);
		/// <summary>
		/// Applies the list of mutate operations (add, remove, and set).
		///
		/// <p> Beginning in v201509, add and set operations are treated identically. Performing an add
		/// operation when there is an existing ExtensionSetting will cause the operation to be
		/// treated like a set operation. Performing a set operation when there is no existing
		/// ExtensionSetting will cause the operation to be treated like an add operation.
		///
		/// @param operations The operations to apply. The same {@link CustomerExtensionSetting} cannot be
		/// specified in more than one operation.
		/// @return The changed {@link CustomerExtensionSetting}s.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<CustomerExtensionSettingReturnValue> MutateAsync(IEnumerable<CustomerExtensionSettingOperation> Operations);
		/// <summary>
		/// Returns a list of CustomerExtensionSettings that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return The list of CustomerExtensionSettings specified by the query.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		Task<CustomerExtensionSettingPage> QueryAsync(string Query);
	}
}
