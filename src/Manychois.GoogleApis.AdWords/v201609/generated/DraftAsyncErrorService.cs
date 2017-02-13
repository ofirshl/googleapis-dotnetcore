using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class DraftAsyncErrorService : IDraftAsyncErrorService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public DraftAsyncErrorService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<DraftAsyncErrorService>();
		}
		/// <summary>
		/// Returns a DraftAsyncErrorPage that contains a list of DraftAsyncErrors matching the selector.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		public async Task<DraftAsyncErrorPage> GetAsync(Selector selector)
		{
			var binding = new DraftAsyncErrorServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DraftAsyncErrorService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
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
			var binding = new DraftAsyncErrorServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DraftAsyncErrorService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
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
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
