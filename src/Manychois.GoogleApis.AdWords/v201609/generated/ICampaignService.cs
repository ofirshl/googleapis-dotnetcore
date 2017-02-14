using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to manage campaigns. A {@linkplain Campaign campaign}
	/// organizes one or more ad groups together and has its own budget, bidding
	/// strategy, serving date range, and targeting settings (managed using
	/// {@link CampaignCriterionService}). You can also set campaign-wide ad
	/// extensions using {@link CampaignExtensionSettingService}.
	///
	/// <p><b>Note:</b> CampaignService does not support video campaigns.</p>
	/// </summary>
	public interface ICampaignService
	{
		/// <summary>
		/// Returns the list of campaigns that meet the selector criteria.
		///
		/// @param serviceSelector the selector specifying the {@link Campaign}s to return.
		/// @return A list of campaigns.
		/// @throws ApiException if problems occurred while fetching campaign information.
		/// </summary>
		Task<CampaignPage> GetAsync(Selector serviceSelector);
		/// <summary>
		/// Adds, updates, or removes campaigns.
		/// <p class="note"><b>Note:</b> {@link CampaignOperation} does not support the
		/// <code>REMOVE</code> operator. To remove a campaign, set its
		/// {@link Campaign#status status} to {@code REMOVED}.</p>
		/// @param operations A list of unique operations.
		/// The same campaign cannot be specified in more than one operation.
		/// @return The list of updated campaigns, returned in the same order as the
		/// <code>operations</code> array.
		/// @throws ApiException if problems occurred while updating campaign information.
		/// </summary>
		Task<CampaignReturnValue> MutateAsync(IEnumerable<CampaignOperation> operations);
		/// <summary>
		/// Adds labels to the {@linkplain Campaign campaign} or removes {@linkplain Label label}s from the
		/// {@linkplain Campaign campaign}.
		/// <p>Add - Apply an existing label to an existing {@linkplain Campaign campaign}. The
		/// {@code campaignId} must reference an existing {@linkplain Campaign}. The {@code labelId} must
		/// reference an existing {@linkplain Label label}.
		/// <p>Remove - Removes the link between the specified {@linkplain Campaign campaign} and
		/// {@linkplain Label label}.
		///
		/// @param operations the operations to apply.
		/// @return a list of {@linkplain CampaignLabel}s where each entry in the list is the result of
		/// applying the operation in the input list with the same index. For an
		/// add operation, the returned CampaignLabel contains the CampaignId and the LabelId.
		/// In the case of a remove operation, the returned CampaignLabel will only have CampaignId.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		Task<CampaignLabelReturnValue> MutateLabelAsync(IEnumerable<CampaignLabelOperation> operations);
		/// <summary>
		/// Returns the list of campaigns that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of campaigns.
		/// @throws ApiException if problems occur while parsing the query or fetching campaign
		/// information.
		/// </summary>
		Task<CampaignPage> QueryAsync(string query);
	}
}
