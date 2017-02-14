using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service used to manage campaign criterion bid overrides at the ad group level.
	/// Currently supports platform (mobile) bid multiplier overrides only.
	/// </summary>
	public interface IAdGroupBidModifierService
	{
		/// <summary>
		/// Gets ad group level criterion bid modifiers.
		///
		/// @param selector The selector specifying the {@link AdGroupBidModifier}s to return.
		/// @return A list of ad group bid modifiers.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<AdGroupBidModifierPage> GetAsync(Selector selector);
		/// <summary>
		/// Adds, removes or updates ad group bid modifier overrides.
		///
		/// @param operations The operations to apply.
		/// @return The added ad group bid modifier overrides.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<AdGroupBidModifierReturnValue> MutateAsync(IEnumerable<AdGroupBidModifierOperation> operations);
		/// <summary>
		/// Returns a list of {@link AdGroupBidModifier}s that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		Task<AdGroupBidModifierPage> QueryAsync(string query);
	}
}
