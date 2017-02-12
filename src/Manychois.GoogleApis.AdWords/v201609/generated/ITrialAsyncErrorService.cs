using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The TrialAsyncErrorService is retrieving asynchronous errors from creating and promoting trials.
	/// </summary>
	public interface ITrialAsyncErrorService
	{
		/// <summary>
		/// Returns a TrialAsyncErrorPage that contains a list of TrialAsyncErrors matching the selector.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		Task<TrialAsyncErrorPage> GetAsync(Selector Selector);
		/// <summary>
		/// Returns a TrialAsyncErrorPage that contains a list of TrialAsyncError matching the query.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		Task<TrialAsyncErrorPage> QueryAsync(string Query);
	}
}
