using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AdCustomizerFeedService : IAdCustomizerFeedService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public AdCustomizerFeedService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<AdCustomizerFeedService>();
		}
		/// <summary>
		/// Returns a list of AdCustomizerFeeds that meet the selector criteria.
		///
		/// @param selector Determines which AdCustomizerFeeds to return. If empty, all AdCustomizerFeeds
		/// are returned.
		/// @return The list of AdCustomizerFeeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<AdCustomizerFeedPage> GetAsync(Selector selector)
		{
			var binding = new AdCustomizerFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdCustomizerFeedService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdCustomizerFeedServiceRequestHeader, AdCustomizerFeedServiceGet>();
			inData.Header = new AdCustomizerFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdCustomizerFeedServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds, removes, or modifies AdCustomizerFeeds.
		///
		/// @param operations The operations to apply.
		/// @return The resulting AdCustomizerFeeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<AdCustomizerFeedReturnValue> MutateAsync(IEnumerable<AdCustomizerFeedOperation> operations)
		{
			var binding = new AdCustomizerFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdCustomizerFeedService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdCustomizerFeedServiceRequestHeader, AdCustomizerFeedServiceMutate>();
			inData.Header = new AdCustomizerFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdCustomizerFeedServiceMutate();
			inData.Body.Operations = new List<AdCustomizerFeedOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(AdCustomizerFeedServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
