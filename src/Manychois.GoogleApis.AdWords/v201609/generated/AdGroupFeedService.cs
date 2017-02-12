using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AdGroupFeedService : IAdGroupFeedService
	{
		public AdWordsApiConfig Config { get; }
		public AdGroupFeedService(AdWordsApiConfig config)
		{
			Config = config;
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
			var binding = new AdGroupFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupFeedService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
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
			var binding = new AdGroupFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupFeedService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
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
			var binding = new AdGroupFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupFeedService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
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
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
