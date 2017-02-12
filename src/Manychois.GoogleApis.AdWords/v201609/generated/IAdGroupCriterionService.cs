using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to manage criteria (such as {@linkplain Keyword keywords} or
	/// {@linkplain Placement placements}). A criterion describes the conditions that
	/// determine if an ad should display. Two classes of criteria are available:
	/// <ul>
	/// <li>A {@linkplain BiddableAdGroupCriterion biddable criterion} defines
	/// conditions that will cause the parent ad group's ads to display. A biddable
	/// criterion can also specify a bid amount that overrides the parent ad group's
	/// default bid.</li>
	/// <li>A {@linkplain NegativeAdGroupCriterion negative criterion} defines
	/// conditions that will prevent the parent ad group's ads from displaying.</li>
	/// </ul>
	/// </summary>
	public interface IAdGroupCriterionService
	{
		/// <summary>
		/// Gets adgroup criteria.
		///
		/// @param serviceSelector filters the adgroup criteria to be returned.
		/// @return a page (subset) view of the criteria selected
		/// @throws ApiException when there is at least one error with the request
		/// </summary>
		Task<AdGroupCriterionPage> GetAsync(Selector ServiceSelector);
		/// <summary>
		/// Adds, removes or updates adgroup criteria.
		///
		/// @param operations operations to do
		/// during checks on keywords to be added.
		/// @return added and updated adgroup criteria (without optional parts)
		/// @throws ApiException when there is at least one error with the request
		/// </summary>
		Task<AdGroupCriterionReturnValue> MutateAsync(IEnumerable<AdGroupCriterionOperation> Operations);
		/// <summary>
		/// Adds labels to the AdGroupCriterion or removes labels from the AdGroupCriterion
		/// <p>Add - Apply an existing label to an existing
		/// {@linkplain AdGroupCriterion ad group criterion}. The {@code adGroupId} and
		/// {@code criterionId}
		/// must reference an existing {@linkplain AdGroupCriterion ad group criterion}. The
		/// {@code labelId} must reference an existing {@linkplain Label label}.
		/// <p>Remove - Removes the link between the specified
		/// {@linkplain AdGroupCriterion ad group criterion} and {@linkplain Label label}.</p>
		/// @param operations the operations to apply
		/// @return a list of AdGroupCriterionLabel where each entry in the list is the result of
		/// applying the operation in the input list with the same index. For an
		/// add operation, the returned AdGroupCriterionLabel contains the AdGroupId, CriterionId and the
		/// LabelId. In the case of a remove operation, the returned AdGroupCriterionLabel will only have
		/// AdGroupId and CriterionId.
		/// @throws ApiException when there are one or more errors with the request
		/// </summary>
		Task<AdGroupCriterionLabelReturnValue> MutateLabelAsync(IEnumerable<AdGroupCriterionLabelOperation> Operations);
		/// <summary>
		/// Returns the list of AdGroupCriterion that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of AdGroupCriterion
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		Task<AdGroupCriterionPage> QueryAsync(string Query);
	}
}
