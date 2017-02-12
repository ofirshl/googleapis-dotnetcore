using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The DraftService is used for creating new drafts and controlling the life cycle of drafts.
	/// </summary>
	public interface IDraftService
	{
		/// <summary>
		/// Returns a DraftPage that contains a list of Draft objects matching the selector.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		Task<DraftPage> GetAsync(Selector Selector);
		/// <summary>
		/// The mutate action is used for creating new Drafts and controlling the life cycle of Drafts,
		/// such as abandoning or promoting Drafts.
		///
		/// @return The list of updated Drafts, in the same order as the {@code operations} list.
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while processing the request.
		/// </summary>
		Task<DraftReturnValue> MutateAsync(IEnumerable<DraftOperation> Operations);
		/// <summary>
		/// Returns a DraftPage that contains a list of Draft objects matching the query.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		Task<DraftPage> QueryAsync(string Query);
	}
}
