using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class DraftAsyncErrorService : IDraftAsyncErrorService
	{
		public AdWordsApiConfig Config { get; }
		public DraftAsyncErrorService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns a DraftAsyncErrorPage that contains a list of DraftAsyncErrors matching the selector.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		public async Task<DraftAsyncErrorPage> GetAsync(Selector selector)
		{
			var binding = new DraftAsyncErrorServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DraftAsyncErrorService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<DraftAsyncErrorServiceRequestHeader, DraftAsyncErrorServiceGet>();
			inData.Header = new DraftAsyncErrorServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DraftAsyncErrorServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a DraftAsyncErrorPage that contains a list of DraftAsyncErrors matching the query.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		public async Task<DraftAsyncErrorPage> QueryAsync(string query)
		{
			var binding = new DraftAsyncErrorServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DraftAsyncErrorService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<DraftAsyncErrorServiceRequestHeader, DraftAsyncErrorServiceQuery>();
			inData.Header = new DraftAsyncErrorServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DraftAsyncErrorServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(DraftAsyncErrorServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
