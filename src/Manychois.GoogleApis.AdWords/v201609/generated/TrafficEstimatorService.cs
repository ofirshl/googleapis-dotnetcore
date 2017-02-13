using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class TrafficEstimatorService : ITrafficEstimatorService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public TrafficEstimatorService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<TrafficEstimatorService>();
		}
		/// <summary>
		/// Returns traffic estimates for specified criteria.
		///
		/// @param selector Campaigns, ad groups and keywords for which traffic
		/// should be estimated.
		/// @return Traffic estimation results.
		/// @throws ApiException if problems occurred while retrieving estimates
		/// </summary>
		public async Task<TrafficEstimatorResult> GetAsync(TrafficEstimatorSelector selector)
		{
			var binding = new TrafficEstimatorServiceSoapBinding("https://adwords.google.com/api/adwords/o/v201609/TrafficEstimatorService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<TrafficEstimatorServiceRequestHeader, TrafficEstimatorServiceGet>();
			inData.Header = new TrafficEstimatorServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new TrafficEstimatorServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(TrafficEstimatorServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
