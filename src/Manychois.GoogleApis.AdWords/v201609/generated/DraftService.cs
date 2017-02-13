using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class DraftService : IDraftService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public DraftService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<DraftService>();
		}
		/// <summary>
		/// Returns a DraftPage that contains a list of Draft objects matching the selector.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		public async Task<DraftPage> GetAsync(Selector selector)
		{
			var binding = new DraftServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DraftService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<DraftServiceRequestHeader, DraftServiceGet>();
			inData.Header = new DraftServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DraftServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// The mutate action is used for creating new Drafts and controlling the life cycle of Drafts,
		/// such as abandoning or promoting Drafts.
		///
		/// @return The list of updated Drafts, in the same order as the {@code operations} list.
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while processing the request.
		/// </summary>
		public async Task<DraftReturnValue> MutateAsync(IEnumerable<DraftOperation> operations)
		{
			var binding = new DraftServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DraftService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<DraftServiceRequestHeader, DraftServiceMutate>();
			inData.Header = new DraftServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DraftServiceMutate();
			inData.Body.Operations = new List<DraftOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a DraftPage that contains a list of Draft objects matching the query.
		///
		/// @throws {#link com.google.ads.api.services.common.error.ApiException} if problems occurred
		/// while retrieving the results.
		/// </summary>
		public async Task<DraftPage> QueryAsync(string query)
		{
			var binding = new DraftServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DraftService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<DraftServiceRequestHeader, DraftServiceQuery>();
			inData.Header = new DraftServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DraftServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(DraftServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
