using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to manage ad groups. An {@linkplain AdGroup ad group}
	/// organizes a set of ads and criteria together, and also provides the
	/// {@linkplain AdGroup#bids default bid} for its criteria. One or more ad groups
	/// belong to a campaign.
	/// </summary>
	public interface IAdGroupService
	{
		/// <summary>
		/// Returns a list of all the ad groups specified by the selector
		/// from the target customer's account.
		///
		/// @param serviceSelector The selector specifying the {@link AdGroup}s to return.
		/// @return List of adgroups identified by the selector.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<AdGroupPage> GetAsync(Selector serviceSelector);
		/// <summary>
		/// Adds, updates, or removes ad groups.
		/// <p class="note"><b>Note:</b> {@link AdGroupOperation} does not support the
		/// {@code REMOVE} operator. To remove an ad group, set its
		/// {@link AdGroup#status status} to {@code REMOVED}.</p>
		///
		/// @param operations List of unique operations. The same ad group cannot be
		/// specified in more than one operation.
		/// @return The updated adgroups.
		/// </summary>
		Task<AdGroupReturnValue> MutateAsync(IEnumerable<AdGroupOperation> operations);
		/// <summary>
		/// Adds labels to the {@linkplain AdGroup ad group} or removes {@linkplain Label label}s from the
		/// {@linkplain AdGroup ad group}.
		/// <p>{@code ADD} -- Apply an existing label to an existing {@linkplain AdGroup ad group}.
		/// The {@code adGroupId} must reference an existing {@linkplain AdGroup ad group}. The
		/// {@code labelId} must reference an existing {@linkplain Label label}.
		/// <p>{@code REMOVE} -- Removes the link between the specified {@linkplain AdGroup ad group}
		/// and a {@linkplain Label label}.</p>
		///
		/// @param operations the operations to apply.
		/// @return a list of {@linkplain AdGroupLabel}s where each entry in the list is the result of
		/// applying the operation in the input list with the same index. For an
		/// add operation, the returned AdGroupLabel contains the AdGroupId and the LabelId.
		/// In the case of a remove operation, the returned AdGroupLabel will only have AdGroupId.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		Task<AdGroupLabelReturnValue> MutateLabelAsync(IEnumerable<AdGroupLabelOperation> operations);
		/// <summary>
		/// Returns the list of ad groups that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @return A list of adgroups
		/// @throws ApiException
		/// </summary>
		Task<AdGroupPage> QueryAsync(string query);
	}
}
