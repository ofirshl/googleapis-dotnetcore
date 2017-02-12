using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The DraftAsyncErrorService is retrieving asynchronous errors from promoting drafts.
	/// </summary>
	public interface IDraftAsyncErrorService
	{
		/// <summary>
		/// Returns a DraftAsyncErrorPage that contains a list of DraftAsyncErrors matching the selector.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		Task<DraftAsyncErrorPage> GetAsync(Selector Selector);
		/// <summary>
		/// Returns a DraftAsyncErrorPage that contains a list of DraftAsyncErrors matching the query.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		Task<DraftAsyncErrorPage> QueryAsync(string Query);
	}
}
