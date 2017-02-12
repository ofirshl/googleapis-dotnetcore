using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class FeedMappingService : IFeedMappingService
	{
		public AdWordsApiConfig Config { get; }
		public FeedMappingService(AdWordsApiConfig config)
		{
			Config = config;
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
			var binding = new FeedMappingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedMappingService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
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
			var binding = new FeedMappingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedMappingService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
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
			var binding = new FeedMappingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/FeedMappingService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
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
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
