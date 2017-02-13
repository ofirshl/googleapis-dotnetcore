using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class OfflineConversionFeedService : IOfflineConversionFeedService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public OfflineConversionFeedService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<OfflineConversionFeedService>();
		}
		/// <summary>
		/// Reports an offline conversion for each entry in {@code operations}.
		/// <p>
		/// This bulk operation does not have any transactional guarantees. Some operations can succeed
		/// while others fail.
		///
		/// @param operations A list of offline conversion feed operations.
		/// @return The list of offline conversion feed results (in the same order as the operations).
		/// @throws {@link ApiException} if problems occurred while applying offline conversions.
		/// </summary>
		public async Task<OfflineConversionFeedReturnValue> MutateAsync(IEnumerable<OfflineConversionFeedOperation> operations)
		{
			var binding = new OfflineConversionFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/OfflineConversionFeedService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<OfflineConversionFeedServiceRequestHeader, OfflineConversionFeedServiceMutate>();
			inData.Header = new OfflineConversionFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new OfflineConversionFeedServiceMutate();
			inData.Body.Operations = new List<OfflineConversionFeedOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(OfflineConversionFeedServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
