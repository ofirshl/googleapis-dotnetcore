using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to manage ads. Available ad types are subclasses of the base {@link Ad} type and
	/// are shown in the {@link AdGroupAd#ad AdGroupAd.ad} documentation. Here are some of the commonly
	/// used ad types:
	///
	/// <dl>
	/// <dt>{@linkplain ExpandedTextAd Expanded Text Ad}
	/// <dd>The primary ad type used on the search network. An expanded text ad contains two headlines,
	/// a single description line, a final url, and optional path fields.
	/// <dt>{@linkplain ImageAd Image Ad}
	/// <dd>A standard image ad.
	/// <dt>{@linkplain TemplateAd Template Ad} (<span class="deem">AdWords Display Ad Builder</span>)
	/// <dd>A flexible ad type that supports various <a
	/// href="/adwords/api/docs/appendix/templateads">Template Ad formats</a>.
	/// </dl>
	/// </summary>
	public interface IAdGroupAdService
	{
		/// <summary>
		/// Returns a list of AdGroupAds.
		/// AdGroupAds that had been removed are not returned by default.
		///
		/// @param serviceSelector The selector specifying the {@link AdGroupAd}s to return.
		/// @return The page containing the AdGroupAds that meet the criteria specified by the selector.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<AdGroupAdPage> GetAsync(Selector ServiceSelector);
		/// <summary>
		/// Applies the list of mutate operations (ie. add, set, remove):
		/// <p>Add - Creates a new {@linkplain AdGroupAd ad group ad}. The
		/// {@code adGroupId} must
		/// reference an existing ad group. The child {@code Ad} must be sufficiently
		/// specified by constructing a concrete ad type (such as {@code TextAd})
		/// and setting its fields accordingly.</p>
		/// <p>Set - Updates an ad group ad. Except for {@code status},
		/// ad group ad fields are not mutable. Status updates are
		/// straightforward - the status of the ad group ad is updated as
		/// specified. If any other field has changed, it will be ignored. If
		/// you want to change any of the fields other than status, you must
		/// make a new ad and then remove the old one.</p>
		/// <p>Remove - Removes the link between the specified AdGroup and
		/// Ad.</p>
		/// @param operations The operations to apply.
		/// @return A list of AdGroupAds where each entry in the list is the result of
		/// applying the operation in the input list with the same index. For an
		/// add/set operation, the return AdGroupAd will be what is saved to the db.
		/// In the case of the remove operation, the return AdGroupAd will simply be
		/// an AdGroupAd containing an Ad with the id set to the Ad being removed from
		/// the AdGroup.
		/// </summary>
		Task<AdGroupAdReturnValue> MutateAsync(IEnumerable<AdGroupAdOperation> Operations);
		/// <summary>
		/// Adds labels to the AdGroupAd or removes labels from the AdGroupAd.
		/// <p>Add - Apply an existing label to an existing {@linkplain AdGroupAd ad group ad}. The
		/// {@code adGroupId} and {@code adId} must reference an existing
		/// {@linkplain AdGroupAd ad group ad}. The {@code labelId} must reference an existing
		/// {@linkplain Label label}.
		/// <p>Remove - Removes the link between the specified {@linkplain AdGroupAd ad group ad} and
		/// {@linkplain Label label}.
		/// @param operations The operations to apply.
		/// @return A list of AdGroupAdLabel where each entry in the list is the result of
		/// applying the operation in the input list with the same index. For an
		/// add operation, the returned AdGroupAdLabel contains the AdGroupId, AdId and the LabelId.
		/// In the case of a remove operation, the returned AdGroupAdLabel will only have AdGroupId and
		/// AdId.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		Task<AdGroupAdLabelReturnValue> MutateLabelAsync(IEnumerable<AdGroupAdLabelOperation> Operations);
		/// <summary>
		/// Returns a list of AdGroupAds based on the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of AdGroupAds.
		/// @throws ApiException if problems occur while parsing the query or fetching AdGroupAds.
		/// </summary>
		Task<AdGroupAdPage> QueryAsync(string Query);
		/// <summary>
		/// Upgrades the url for a set of ads.
		/// @param operations The list of upgrades to apply.
		/// @return The list of Ads that were upgraded.
		/// </summary>
		Task<IEnumerable<Ad>> UpgradeUrlAsync(IEnumerable<AdUrlUpgrade> Operations);
	}
}
