using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class FeedService : IFeedService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public FeedService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<FeedService>();
		}
		/// <summary>
		/// Returns a list of Feeds that meet the selector criteria.
		///
		/// @param selector Determines which Feeds to return. If empty all
		/// Feeds are returned.
		/// @return The list of Feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<FeedPage> GetAsync(Selector selector)
		{
			var binding = new FeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<FeedServiceRequestHeader, FeedServiceGet>();
			inData.Header = new FeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new FeedServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Add, remove, and set Feeds.
		///
		/// @param operations The operations to apply.
		/// @return The resulting Feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<FeedReturnValue> MutateAsync(IEnumerable<FeedOperation> operations)
		{
			var binding = new FeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<FeedServiceRequestHeader, FeedServiceMutate>();
			inData.Header = new FeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new FeedServiceMutate();
			inData.Body.Operations = new List<FeedOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of Feed that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @returns A list of Feed.
		/// @throws ApiException if problems occur while parsing the query or fetching Feed.
		/// </summary>
		public async Task<FeedPage> QueryAsync(string query)
		{
			var binding = new FeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<FeedServiceRequestHeader, FeedServiceQuery>();
			inData.Header = new FeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new FeedServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(FeedServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
