using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Customer Manager Service.
	/// </summary>
	public interface IManagedCustomerService
	{
		/// <summary>
		/// Returns the list of customers that meet the selector criteria.
		///
		/// @param selector The selector specifying the {@link ManagedCustomer}s to return.
		/// @return List of customers identified by the selector.
		/// @throws ApiException When there is at least one error with the request.
		/// </summary>
		Task<ManagedCustomerPage> GetAsync(Selector ServiceSelector);
		/// <summary>
		/// Returns the pending invitations for the customer IDs in the selector.
		/// @param selector the manager customer ids (inviters) or the client customer ids (invitees)
		/// @throws ApiException when there is at least one error with the request
		/// </summary>
		Task<IEnumerable<PendingInvitation>> GetPendingInvitationsAsync(PendingInvitationSelector Selector);
		/// <summary>
		/// Modifies or creates new {@link ManagedCustomer}s.
		///
		/// <p class="note"><b>Note:</b> See {@link ManagedCustomerOperation} for available operators.</p>
		///
		/// @param operations List of unique operations.
		/// @return The list of updated managed customers, returned in the same order as the
		/// <code>operations</code> array.
		/// </summary>
		Task<ManagedCustomerReturnValue> MutateAsync(IEnumerable<ManagedCustomerOperation> Operations);
		/// <summary>
		/// Adds {@linkplain AccountLabel}s to, and removes
		/// {@linkplain AccountLabel}s from, {@linkplain ManagedCustomer}s.
		///
		/// <p>To add an {@linkplain AccountLabel} to a {@linkplain ManagedCustomer},
		/// use {@link Operator#ADD}.
		/// To remove an {@linkplain AccountLabel} from a {@linkplain ManagedCustomer},
		/// use {@link Operator#REMOVE}.</p>
		/// <p>The label must already exist (see {@link AccountLabelService#mutate} for
		/// how to create them) and be owned by the authenticated user.</p>
		/// <p>The {@linkplain ManagedCustomer} must already exist and be managed by
		/// the customer making the request (either directly or indirectly).</p>
		/// <p>An AccountLabel may be applied to at most 1000 customers.</p>
		/// <p>This method does not support partial failures, and will fail if any
		/// operation is invalid.</p>
		/// </summary>
		Task<ManagedCustomerLabelReturnValue> MutateLabelAsync(IEnumerable<ManagedCustomerLabelOperation> Operations);
		/// <summary>
		/// Modifies the ManagedCustomer forest. These actions are possible (categorized by
		/// Operator + Link Status):
		///
		/// <ul>
		/// <li>ADD + PENDING:   manager extends invitations</li>
		/// <li>SET + CANCELLED: manager rescinds invitations</li>
		/// <li>SET + INACTIVE:  manager/client terminates links</li>
		/// <li>SET + ACTIVE:    client accepts invitations</li>
		/// <li>SET + REFUSED:   client declines invitations</li>
		/// </ul>
		///
		/// In addition to these, active links can also be marked hidden / unhidden.
		/// <ul>
		/// <li> An ACTIVE link can be marked hidden with SET + ACTIVE along with setting the
		/// isHidden bit to true. </li>
		/// <li> An ACTIVE link can be marked unhidden with SET + ACTIVE along with setting the
		/// isHidden bit to false. </li>
		/// </ul>
		///
		/// @param operations the list of operations
		/// @return results for the given operations
		/// @throws ApiException with a {@link ManagedCustomerServiceError}
		/// </summary>
		Task<MutateLinkResults> MutateLinkAsync(IEnumerable<LinkOperation> Operations);
		/// <summary>
		/// Moves client customers to new managers (moving links). Only the following action is possible:
		///
		/// <ul>
		/// <li>SET + ACTIVE: manager moves client customers to new managers within the same manager
		/// account hierarchy</li>
		/// </ul>
		///
		/// @param operations List of unique operations.
		/// @return results for the given operations
		/// @throws ApiException with a {@link ManagedCustomerServiceError}
		/// </summary>
		Task<MutateManagerResults> MutateManagerAsync(IEnumerable<MoveOperation> Operations);
	}
}
