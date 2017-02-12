using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class TrafficEstimatorService : ITrafficEstimatorService
	{
		public AdWordsApiConfig Config { get; }
		public TrafficEstimatorService(AdWordsApiConfig config)
		{
			Config = config;
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
			var binding = new TrafficEstimatorServiceSoapBinding("https://adwords.google.com/api/adwords/o/v201609/TrafficEstimatorService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
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
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
