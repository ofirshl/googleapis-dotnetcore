using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class CustomerFeedService : ICustomerFeedService
	{
		public AdWordsApiConfig Config { get; }
		public CustomerFeedService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns a list of customer feeds that meet the selector criteria.
		///
		/// @param selector Determines which customer feeds to return. If empty, all
		/// customer feeds are returned.
		/// @return The list of customer feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<CustomerFeedPage> GetAsync(Selector selector)
		{
			var binding = new CustomerFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CustomerFeedService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CustomerFeedServiceRequestHeader, CustomerFeedServiceGet>();
			inData.Header = new CustomerFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CustomerFeedServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds, sets, or removes customer feeds.
		///
		/// @param operations The operations to apply.
		/// @return The resulting feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<CustomerFeedReturnValue> MutateAsync(IEnumerable<CustomerFeedOperation> operations)
		{
			var binding = new CustomerFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CustomerFeedService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CustomerFeedServiceRequestHeader, CustomerFeedServiceMutate>();
			inData.Header = new CustomerFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CustomerFeedServiceMutate();
			inData.Body.Operations = new List<CustomerFeedOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of customer feeds that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of CustomerFeed.
		/// @throws ApiException If problems occur while parsing the query or fetching CustomerFeed.
		/// </summary>
		public async Task<CustomerFeedPage> QueryAsync(string query)
		{
			var binding = new CustomerFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CustomerFeedService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CustomerFeedServiceRequestHeader, CustomerFeedServiceQuery>();
			inData.Header = new CustomerFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CustomerFeedServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(CustomerFeedServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
