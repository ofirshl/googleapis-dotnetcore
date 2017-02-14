using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to request traffic estimates for proposed or existing campaigns, ad
	/// groups, and keywords.
	///
	/// <p>
	/// To simply retrieve estimates for a list of proposed keywords, create a
	/// {@linkplain CampaignEstimateRequest campaign estimate request} and a child
	/// {@linkplain AdGroupEstimateRequest ad group estimate request} with {@code null} IDs,
	/// and then set the
	/// {@link AdGroupEstimateRequest#keywordEstimateRequests keywordEstimateRequests}
	/// to contain the keywords.</p>
	///
	/// <p>You can refine the traffic estimates by setting
	/// {@linkplain CampaignEstimateRequest#targets campaign targeting options} in the request.
	/// If an ad group ID is provided, all creatives from that ad group will be loaded and used
	/// to improve estimates.</p>
	///
	/// <p>The maximum number of {@linkplain KeywordEstimateRequest keyword estimate
	/// requests} across all campaign estimate requests and
	/// ad group estimate requests is 2500.</p>
	///
	/// <p>The maximum number of {@linkplain AdGroupEstimateRequest adgroup estimate
	/// requests} across all campaign estimate requests is 50.</p>
	///
	/// <p>Note that the API returns intervals whereas the Traffic Estimator UI displays averages.
	/// Estimates are account specific since they are based on creatives already in the account.
	/// When comparing numbers, use the same account for the API and UI.</p>
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public interface ITrafficEstimatorService
	{
		/// <summary>
		/// Returns traffic estimates for specified criteria.
		///
		/// @param selector Campaigns, ad groups and keywords for which traffic
		/// should be estimated.
		/// @return Traffic estimation results.
		/// @throws ApiException if problems occurred while retrieving estimates
		/// </summary>
		Task<TrafficEstimatorResult> GetAsync(TrafficEstimatorSelector selector);
	}
}
