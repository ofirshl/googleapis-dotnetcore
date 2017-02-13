using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class FeedMappingService : IFeedMappingService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public FeedMappingService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<FeedMappingService>();
		}
		/// <summary>
		/// Returns a list of FeedMappings that meet the selector criteria.
		///
		/// @param selector Determines which FeedMappings to return. If empty all
		/// FeedMappings are returned.
		/// @return The list of FeedMappings.
		/// @throws ApiException indicates a problem with the request.
		/// </summary>
		public async Task<FeedMappingPage> GetAsync(Selector selector)
		{
			var binding = new FeedMappingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedMappingService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<FeedMappingServiceRequestHeader, FeedMappingServiceGet>();
			inData.Header = new FeedMappingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new FeedMappingServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Add and remove FeedMappings.
		/// The following {@link Operator}s are supported: ADD, REMOVE.
		///
		/// @param operations The operations to apply.
		/// @return The resulting FeedMappings.
		/// @throws ApiException indicates a problem with the request.
		/// </summary>
		public async Task<FeedMappingReturnValue> MutateAsync(IEnumerable<FeedMappingOperation> operations)
		{
			var binding = new FeedMappingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedMappingService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<FeedMappingServiceRequestHeader, FeedMappingServiceMutate>();
			inData.Header = new FeedMappingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new FeedMappingServiceMutate();
			inData.Body.Operations = new List<FeedMappingOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of FeedMappings that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns The list of FeedMappings
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		public async Task<FeedMappingPage> QueryAsync(string query)
		{
			var binding = new FeedMappingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedMappingService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<FeedMappingServiceRequestHeader, FeedMappingServiceQuery>();
			inData.Header = new FeedMappingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new FeedMappingServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(FeedMappingServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
