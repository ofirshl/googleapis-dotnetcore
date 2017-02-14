using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service for creating, editing, and deleting labels that can be applied to managed customers.
	///
	/// <p>Labels created by a manager are not accessible to any customers managed
	/// by this manager.  Only manager customers may create these labels.
	///
	/// <p>Note that label access works a little differently in the API than it does in the
	/// AdWords UI.  In the UI, a manager will never see a submanager's labels, and will always
	/// be using his own labels regardless of which managed account he is viewing.  In this API,
	/// like other API services, if you specify a submanager as the effective account for the API
	/// request, then the request will operate on the submanager's labels.
	///
	/// <p>To apply a label to a managed customer, see {@link ManagedCustomerService#mutateLabel}.
	/// </summary>
	public interface IAccountLabelService
	{
		/// <summary>
		/// Returns a list of labels specified by the selector for the authenticated user.
		///
		/// @param selector filters the list of labels to return
		/// @return response containing lists of labels that meet all the criteria of the selector
		/// @throws ApiException if a problem occurs fetching the information requested
		/// </summary>
		Task<AccountLabelPage> GetAsync(Selector selector);
		/// <summary>
		/// Possible actions:
		/// <ul>
		/// <li> Create a new label - create a new {@link Label} and call mutate with ADD operator
		/// <li> Edit the label name - set the appropriate fields in your {@linkplain Label} and call
		/// mutate with the SET operator. Null fields will be interpreted to mean "no change"
		/// <li> Delete the label - call mutate with REMOVE operator
		/// </ul>
		///
		/// @param operations list of unique operations to be executed in a single transaction, in the
		/// order specified.
		/// @return the mutated labels, in the same order that they were in as the parameter
		/// @throws ApiException if problems occurs while modifying label information
		/// </summary>
		Task<AccountLabelReturnValue> MutateAsync(IEnumerable<AccountLabelOperation> operations);
	}
}
