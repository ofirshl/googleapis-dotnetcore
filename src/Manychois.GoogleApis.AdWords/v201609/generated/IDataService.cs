using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A service to return Ads Campaign Management data matching a {@link Selector}.
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public interface IDataService
	{
		/// <summary>
		/// Returns a list of {@link AdGroupBidLandscape}s for the ad groups specified in the selector.
		/// In the result, the returned {@link LandscapePoint}s are grouped into
		/// {@link AdGroupBidLandscape}s by their ad groups, and numberResults of paging limits the total
		/// number of {@link LandscapePoint}s instead of number of {@link AdGroupBidLandscape}s.
		///
		/// @param serviceSelector Selects the entities to return bid landscapes for.
		/// @return A list of bid landscapes.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<AdGroupBidLandscapePage> GetAdGroupBidLandscapeAsync(Selector ServiceSelector);
		/// <summary>
		/// Returns a list of {@link CriterionBidLandscape}s for the campaign criteria specified in the
		/// selector. In the result, the returned {@link LandscapePoint}s are grouped into
		/// {@link CriterionBidLandscape}s by their campaign id and criterion id, and numberResults
		/// of paging limits the total number of {@link LandscapePoint}s instead of number of
		/// {@link CriterionBidLandscape}s.
		///
		/// @param serviceSelector Selects the entities to return bid landscapes for.
		/// @return A list of bid landscapes.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<CriterionBidLandscapePage> GetCampaignCriterionBidLandscapeAsync(Selector ServiceSelector);
		/// <summary>
		/// Returns a list of {@link CriterionBidLandscape}s for the criteria specified in the selector.
		/// In the result, the returned {@link LandscapePoint}s are grouped into
		/// {@link CriterionBidLandscape}s by their criteria, and numberResults of paging limits the total
		/// number of {@link LandscapePoint}s instead of number of {@link CriterionBidLandscape}s.
		///
		/// @param serviceSelector Selects the entities to return bid landscapes for.
		/// @return A list of bid landscapes.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<CriterionBidLandscapePage> GetCriterionBidLandscapeAsync(Selector ServiceSelector);
		/// <summary>
		/// Returns a list of domain categories that can be used to create {@link WebPage} criterion.
		///
		/// @param serviceSelector Selects the entities to return domain categories for.
		/// @return A list of domain categories.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<DomainCategoryPage> GetDomainCategoryAsync(Selector ServiceSelector);
		/// <summary>
		/// Returns a list of {@link AdGroupBidLandscape}s for the ad groups that match the query. In the
		/// result, the returned {@link LandscapePoint}s are grouped into {@link AdGroupBidLandscape}s
		/// by their ad groups, and numberResults of paging limits the total number of
		/// {@link LandscapePoint}s instead of number of {@link AdGroupBidLandscape}s.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of bid landscapes.
		/// @throws ApiException if problems occur while parsing the query or fetching bid landscapes.
		/// </summary>
		Task<AdGroupBidLandscapePage> QueryAdGroupBidLandscapeAsync(string Query);
		/// <summary>
		/// Returns a list of {@link CriterionBidLandscape}s for the campaign criteria that match the
		/// query. In the result, the returned {@link LandscapePoint}s are grouped into
		/// {@link CriterionBidLandscape}s by their campaign id and criterion id, and numberResults
		/// of paging limits the total number of {@link LandscapePoint}s instead of number of
		/// {@link CriterionBidLandscape}s.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of bid landscapes.
		/// @throws ApiException if problems occur while parsing the query or fetching bid landscapes.
		/// </summary>
		Task<CriterionBidLandscapePage> QueryCampaignCriterionBidLandscapeAsync(string Query);
		/// <summary>
		/// Returns a list of {@link CriterionBidLandscape}s for the criteria that match the query. In the
		/// result, the returned {@link LandscapePoint}s are grouped into {@link CriterionBidLandscape}s
		/// by their criteria, and numberResults of paging limits the total number of
		/// {@link LandscapePoint}s instead of number of {@link CriterionBidLandscape}s.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of bid landscapes.
		/// @throws ApiException if problems occur while parsing the query or fetching bid landscapes.
		/// </summary>
		Task<CriterionBidLandscapePage> QueryCriterionBidLandscapeAsync(string Query);
		/// <summary>
		/// Returns a list of domain categories that can be used to create {@link WebPage} criterion.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of domain categories.
		/// @throws ApiException if problems occur while parsing the query
		/// or fetching domain categories.
		/// </summary>
		Task<DomainCategoryPage> QueryDomainCategoryAsync(string Query);
	}
}
