using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AdGroupFeedService : IAdGroupFeedService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public AdGroupFeedService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<AdGroupFeedService>();
		}
		/// <summary>
		/// Returns a list of AdGroupFeeds that meet the selector criteria.
		///
		/// @param selector Determines which AdGroupFeeds to return. If empty all
		/// adgroup feeds are returned.
		/// @return The list of AdgroupFeeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<AdGroupFeedPage> GetAsync(Selector selector)
		{
			var binding = new AdGroupFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupFeedService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupFeedServiceRequestHeader, AdGroupFeedServiceGet>();
			inData.Header = new AdGroupFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupFeedServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds, updates or removes AdGroupFeeds.
		///
		/// @param operations The operations to apply.
		/// @return The resulting Feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<AdGroupFeedReturnValue> MutateAsync(IEnumerable<AdGroupFeedOperation> operations)
		{
			var binding = new AdGroupFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupFeedService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupFeedServiceRequestHeader, AdGroupFeedServiceMutate>();
			inData.Header = new AdGroupFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupFeedServiceMutate();
			inData.Body.Operations = new List<AdGroupFeedOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of AdGroupFeeds that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @returns A list of AdGroupFeed.
		/// @throws ApiException if problems occur while parsing the query or fetching AdGroupFeed.
		/// </summary>
		public async Task<AdGroupFeedPage> QueryAsync(string query)
		{
			var binding = new AdGroupFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupFeedService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupFeedServiceRequestHeader, AdGroupFeedServiceQuery>();
			inData.Header = new AdGroupFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupFeedServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(AdGroupFeedServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
