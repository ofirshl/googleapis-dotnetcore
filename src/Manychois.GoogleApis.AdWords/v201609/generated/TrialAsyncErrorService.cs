using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class TrialAsyncErrorService : ITrialAsyncErrorService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public TrialAsyncErrorService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<TrialAsyncErrorService>();
		}
		/// <summary>
		/// Returns a TrialAsyncErrorPage that contains a list of TrialAsyncErrors matching the selector.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		public async Task<TrialAsyncErrorPage> GetAsync(Selector selector)
		{
			var binding = new TrialAsyncErrorServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/TrialAsyncErrorService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
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
			var binding = new TrialAsyncErrorServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/TrialAsyncErrorService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
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
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
