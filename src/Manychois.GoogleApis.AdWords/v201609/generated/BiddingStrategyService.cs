using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class BiddingStrategyService : IBiddingStrategyService
	{
		public AdWordsApiConfig Config { get; }
		public BiddingStrategyService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns a list of bidding strategies that match the selector.
		///
		/// @return list of bidding strategies specified by the selector.
		/// @throws com.google.ads.api.services.common.error.ApiException if problems
		/// occurred while retrieving results.
		/// </summary>
		public async Task<BiddingStrategyPage> GetAsync(Selector selector)
		{
			var binding = new BiddingStrategyServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/BiddingStrategyService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<BiddingStrategyServiceRequestHeader, BiddingStrategyServiceGet>();
			inData.Header = new BiddingStrategyServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BiddingStrategyServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Applies the list of mutate operations.
		///
		/// @param operations the operations to apply
		/// @return the modified list of BiddingStrategy
		/// @throws ApiException
		/// </summary>
		public async Task<BiddingStrategyReturnValue> MutateAsync(IEnumerable<BiddingStrategyOperation> operations)
		{
			var binding = new BiddingStrategyServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/BiddingStrategyService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<BiddingStrategyServiceRequestHeader, BiddingStrategyServiceMutate>();
			inData.Header = new BiddingStrategyServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BiddingStrategyServiceMutate();
			inData.Body.Operations = new List<BiddingStrategyOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of bidding strategies that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		public async Task<BiddingStrategyPage> QueryAsync(string query)
		{
			var binding = new BiddingStrategyServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/BiddingStrategyService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<BiddingStrategyServiceRequestHeader, BiddingStrategyServiceQuery>();
			inData.Header = new BiddingStrategyServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BiddingStrategyServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(BiddingStrategyServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
