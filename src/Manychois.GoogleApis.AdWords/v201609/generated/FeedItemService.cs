using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class FeedItemService : IFeedItemService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public FeedItemService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<FeedItemService>();
		}
		/// <summary>
		/// Returns a list of FeedItems that meet the selector criteria.
		///
		/// @param selector Determines which FeedItems to return. If empty all
		/// FeedItems are returned.
		/// @return The list of FeedItems.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<FeedItemPage> GetAsync(Selector selector)
		{
			var binding = new FeedItemServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedItemService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<FeedItemServiceRequestHeader, FeedItemServiceGet>();
			inData.Header = new FeedItemServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new FeedItemServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Add, remove, and set FeedItems.
		///
		/// @param operations The operations to apply.
		/// @return The resulting FeedItems.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<FeedItemReturnValue> MutateAsync(IEnumerable<FeedItemOperation> operations)
		{
			var binding = new FeedItemServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedItemService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<FeedItemServiceRequestHeader, FeedItemServiceMutate>();
			inData.Header = new FeedItemServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new FeedItemServiceMutate();
			inData.Body.Operations = new List<FeedItemOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of FeedItems that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of FeedItems
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		public async Task<FeedItemPage> QueryAsync(string query)
		{
			var binding = new FeedItemServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedItemService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<FeedItemServiceRequestHeader, FeedItemServiceQuery>();
			inData.Header = new FeedItemServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new FeedItemServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(FeedItemServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
