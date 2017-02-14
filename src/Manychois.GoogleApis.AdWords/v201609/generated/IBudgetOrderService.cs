using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service for managing {@link BudgetOrder}s.
	/// <p class="note"><b>Note:</b> This service is available only
	/// on a whitelist basis.</p>
	/// <p class="warning"><b>Warning:</b> The <code>BudgetOrderService</code>
	/// is limited to one operation per mutate request. Any attempt to make
	/// more than one operation will result in an <code>ApiException</code>.</p>
	/// </summary>
	public interface IBudgetOrderService
	{
		/// <summary>
		/// Gets a list of {@link BudgetOrder}s using the generic selector.
		/// @param serviceSelector specifies which BudgetOrder to return.
		/// @return A {@link BudgetOrderPage} of BudgetOrders of the client customer.
		/// All BudgetOrder fields are returned. Stats are not yet supported.
		/// @throws ApiException
		/// </summary>
		Task<BudgetOrderPage> GetAsync(Selector serviceSelector);
		/// <summary>
		/// Returns all the open/active BillingAccounts associated with the current
		/// manager.
		/// @return A list of {@link BillingAccount}s.
		/// @throws ApiException
		/// </summary>
		Task<IEnumerable<BillingAccount>> GetBillingAccountsAsync();
		/// <summary>
		/// Mutates BudgetOrders, supported operations are:
		/// <p><code>ADD</code>: Adds a {@link BudgetOrder} to the billing account
		/// specified by the billing account ID.</p>
		/// <p><code>SET</code>: Sets the start/end date and amount of the
		/// {@link BudgetOrder}.</p>
		/// <p><code>REMOVE</code>: Cancels the {@link BudgetOrder} (status change).</p>
		/// <p class="warning"><b>Warning:</b> The <code>BudgetOrderService</code>
		/// is limited to one operation per mutate request. Any attempt to make more
		/// than one operation will result in an <code>ApiException</code>.</p>
		/// @param operations A list of operations, <b>however currently we only
		/// support one operation per mutate call</b>.
		/// @return BudgetOrders affected by the mutate operation.
		/// @throws ApiException
		/// </summary>
		Task<BudgetOrderReturnValue> MutateAsync(IEnumerable<BudgetOrderOperation> operations);
	}
}
