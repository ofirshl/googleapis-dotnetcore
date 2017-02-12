using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class TrialAsyncErrorService : ITrialAsyncErrorService
	{
		public AdWordsApiConfig Config { get; }
		public TrialAsyncErrorService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns a TrialAsyncErrorPage that contains a list of TrialAsyncErrors matching the selector.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		public async Task<TrialAsyncErrorPage> GetAsync(Selector selector)
		{
			var binding = new TrialAsyncErrorServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/TrialAsyncErrorService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<TrialAsyncErrorServiceRequestHeader, TrialAsyncErrorServiceGet>();
			inData.Header = new TrialAsyncErrorServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new TrialAsyncErrorServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a TrialAsyncErrorPage that contains a list of TrialAsyncError matching the query.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		public async Task<TrialAsyncErrorPage> QueryAsync(string query)
		{
			var binding = new TrialAsyncErrorServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/TrialAsyncErrorService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<TrialAsyncErrorServiceRequestHeader, TrialAsyncErrorServiceQuery>();
			inData.Header = new TrialAsyncErrorServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new TrialAsyncErrorServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(TrialAsyncErrorServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
