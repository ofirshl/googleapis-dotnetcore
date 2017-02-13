using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class OfflineCallConversionFeedService : IOfflineCallConversionFeedService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public OfflineCallConversionFeedService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<OfflineCallConversionFeedService>();
		}
		/// <summary>
		/// Reports a call conversion for each entry in {@code operations}.
		///
		/// <p>This bulk operation does not have any transactional guarantees. Some operations can succeed
		/// while others fail.
		///
		/// @param operations A list of offline call conversion feed operations.
		/// @return The list of offline call conversion feed results (in the same order as the operations).
		/// @throws {@link ApiException} if problems occurred while applying offline call conversions.
		/// </summary>
		public async Task<OfflineCallConversionFeedReturnValue> MutateAsync(IEnumerable<OfflineCallConversionFeedOperation> operations)
		{
			var binding = new OfflineCallConversionFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/OfflineCallConversionFeedService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<OfflineCallConversionFeedServiceRequestHeader, OfflineCallConversionFeedServiceMutate>();
			inData.Header = new OfflineCallConversionFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new OfflineCallConversionFeedServiceMutate();
			inData.Body.Operations = new List<OfflineCallConversionFeedOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(OfflineCallConversionFeedServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
