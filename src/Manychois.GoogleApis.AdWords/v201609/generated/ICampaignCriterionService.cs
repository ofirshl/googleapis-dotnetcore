using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to manage campaign-level criteria.
	///
	/// <p>A campaign-level negative criterion prevents the campaign's ads from
	/// showing on specific placements, specific keywords, demographics, and so on.</p>
	///
	/// <p>Additionally, the service can be used to target criteria such as
	/// {@linkplain Criterion.Type#LOCATION location}, {@linkplain Criterion.Type#LANGUAGE language},
	/// {@linkplain Criterion.Type#CARRIER carrier}, {@linkplain Criterion.Type#PLATFORM platform}, and
	/// so on. The targeting criteria can be added using the Criterion Id listed in the
	/// <a href="/adwords/api/docs/appendix/platforms">documentation</a>.</p>
	/// </summary>
	public interface ICampaignCriterionService
	{
		/// <summary>
		/// Gets campaign criteria.
		///
		/// @param serviceSelector The selector specifying the {@link CampaignCriterion}s to return.
		/// @return A list of campaign criteria.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<CampaignCriterionPage> GetAsync(Selector serviceSelector);
		/// <summary>
		/// Adds, removes or updates campaign criteria.
		///
		/// @param operations The operations to apply.
		/// @return The added campaign criteria (without any optional parts).
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<CampaignCriterionReturnValue> MutateAsync(IEnumerable<CampaignCriterionOperation> operations);
		/// <summary>
		/// Returns the list of campaign criteria that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of campaign criteria.
		/// @throws ApiException if problems occur while parsing the query or fetching campaign criteria.
		/// </summary>
		Task<CampaignCriterionPage> QueryAsync(string query);
	}
}
