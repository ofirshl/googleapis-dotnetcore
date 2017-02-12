using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class CampaignFeedService : ICampaignFeedService
	{
		public AdWordsApiConfig Config { get; }
		public CampaignFeedService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns a list of CampaignFeeds that meet the selector criteria.
		///
		/// @param selector Determines which CampaignFeeds to return. If empty all
		/// Campaign feeds are returned.
		/// @return The list of CampaignFeeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<CampaignFeedPage> GetAsync(Selector selector)
		{
			var binding = new CampaignFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignFeedService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CampaignFeedServiceRequestHeader, CampaignFeedServiceGet>();
			inData.Header = new CampaignFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignFeedServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds, sets or removes CampaignFeeds.
		///
		/// @param operations The operations to apply.
		/// @return The resulting Feeds.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<CampaignFeedReturnValue> MutateAsync(IEnumerable<CampaignFeedOperation> operations)
		{
			var binding = new CampaignFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignFeedService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CampaignFeedServiceRequestHeader, CampaignFeedServiceMutate>();
			inData.Header = new CampaignFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignFeedServiceMutate();
			inData.Body.Operations = new List<CampaignFeedOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of {@link CampaignFeed}s inside a {@link CampaignFeedPage} that matches
		/// the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		public async Task<CampaignFeedPage> QueryAsync(string query)
		{
			var binding = new CampaignFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignFeedService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CampaignFeedServiceRequestHeader, CampaignFeedServiceQuery>();
			inData.Header = new CampaignFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignFeedServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(CampaignFeedServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
