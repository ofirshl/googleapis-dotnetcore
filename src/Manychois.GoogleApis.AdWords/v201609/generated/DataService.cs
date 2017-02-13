using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class DataService : IDataService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public DataService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<DataService>();
		}
		/// <summary>
		/// Returns a list of {@link AdGroupBidLandscape}s for the ad groups specified in the selector.
		/// In the result, the returned {@link LandscapePoint}s are grouped into
		/// {@link AdGroupBidLandscape}s by their ad groups, and numberResults of paging limits the total
		/// number of {@link LandscapePoint}s instead of number of {@link AdGroupBidLandscape}s.
		///
		/// @param serviceSelector Selects the entities to return bid landscapes for.
		/// @return A list of bid landscapes.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<AdGroupBidLandscapePage> GetAdGroupBidLandscapeAsync(Selector serviceSelector)
		{
			var binding = new DataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DataService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<DataServiceRequestHeader, DataServiceGetAdGroupBidLandscape>();
			inData.Header = new DataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DataServiceGetAdGroupBidLandscape();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAdGroupBidLandscapeAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of {@link CriterionBidLandscape}s for the campaign criteria specified in the
		/// selector. In the result, the returned {@link LandscapePoint}s are grouped into
		/// {@link CriterionBidLandscape}s by their campaign id and criterion id, and numberResults
		/// of paging limits the total number of {@link LandscapePoint}s instead of number of
		/// {@link CriterionBidLandscape}s.
		///
		/// @param serviceSelector Selects the entities to return bid landscapes for.
		/// @return A list of bid landscapes.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<CriterionBidLandscapePage> GetCampaignCriterionBidLandscapeAsync(Selector serviceSelector)
		{
			var binding = new DataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DataService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<DataServiceRequestHeader, DataServiceGetCampaignCriterionBidLandscape>();
			inData.Header = new DataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DataServiceGetCampaignCriterionBidLandscape();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetCampaignCriterionBidLandscapeAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of {@link CriterionBidLandscape}s for the criteria specified in the selector.
		/// In the result, the returned {@link LandscapePoint}s are grouped into
		/// {@link CriterionBidLandscape}s by their criteria, and numberResults of paging limits the total
		/// number of {@link LandscapePoint}s instead of number of {@link CriterionBidLandscape}s.
		///
		/// @param serviceSelector Selects the entities to return bid landscapes for.
		/// @return A list of bid landscapes.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<CriterionBidLandscapePage> GetCriterionBidLandscapeAsync(Selector serviceSelector)
		{
			var binding = new DataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DataService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<DataServiceRequestHeader, DataServiceGetCriterionBidLandscape>();
			inData.Header = new DataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DataServiceGetCriterionBidLandscape();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetCriterionBidLandscapeAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of domain categories that can be used to create {@link WebPage} criterion.
		///
		/// @param serviceSelector Selects the entities to return domain categories for.
		/// @return A list of domain categories.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<DomainCategoryPage> GetDomainCategoryAsync(Selector serviceSelector)
		{
			var binding = new DataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DataService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<DataServiceRequestHeader, DataServiceGetDomainCategory>();
			inData.Header = new DataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DataServiceGetDomainCategory();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetDomainCategoryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of {@link AdGroupBidLandscape}s for the ad groups that match the query. In the
		/// result, the returned {@link LandscapePoint}s are grouped into {@link AdGroupBidLandscape}s
		/// by their ad groups, and numberResults of paging limits the total number of
		/// {@link LandscapePoint}s instead of number of {@link AdGroupBidLandscape}s.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of bid landscapes.
		/// @throws ApiException if problems occur while parsing the query or fetching bid landscapes.
		/// </summary>
		public async Task<AdGroupBidLandscapePage> QueryAdGroupBidLandscapeAsync(string query)
		{
			var binding = new DataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DataService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<DataServiceRequestHeader, DataServiceQueryAdGroupBidLandscape>();
			inData.Header = new DataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DataServiceQueryAdGroupBidLandscape();
			inData.Body.Query = query;
			var outData = await binding.QueryAdGroupBidLandscapeAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of {@link CriterionBidLandscape}s for the campaign criteria that match the
		/// query. In the result, the returned {@link LandscapePoint}s are grouped into
		/// {@link CriterionBidLandscape}s by their campaign id and criterion id, and numberResults
		/// of paging limits the total number of {@link LandscapePoint}s instead of number of
		/// {@link CriterionBidLandscape}s.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of bid landscapes.
		/// @throws ApiException if problems occur while parsing the query or fetching bid landscapes.
		/// </summary>
		public async Task<CriterionBidLandscapePage> QueryCampaignCriterionBidLandscapeAsync(string query)
		{
			var binding = new DataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DataService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<DataServiceRequestHeader, DataServiceQueryCampaignCriterionBidLandscape>();
			inData.Header = new DataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DataServiceQueryCampaignCriterionBidLandscape();
			inData.Body.Query = query;
			var outData = await binding.QueryCampaignCriterionBidLandscapeAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of {@link CriterionBidLandscape}s for the criteria that match the query. In the
		/// result, the returned {@link LandscapePoint}s are grouped into {@link CriterionBidLandscape}s
		/// by their criteria, and numberResults of paging limits the total number of
		/// {@link LandscapePoint}s instead of number of {@link CriterionBidLandscape}s.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of bid landscapes.
		/// @throws ApiException if problems occur while parsing the query or fetching bid landscapes.
		/// </summary>
		public async Task<CriterionBidLandscapePage> QueryCriterionBidLandscapeAsync(string query)
		{
			var binding = new DataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DataService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<DataServiceRequestHeader, DataServiceQueryCriterionBidLandscape>();
			inData.Header = new DataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DataServiceQueryCriterionBidLandscape();
			inData.Body.Query = query;
			var outData = await binding.QueryCriterionBidLandscapeAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of domain categories that can be used to create {@link WebPage} criterion.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of domain categories.
		/// @throws ApiException if problems occur while parsing the query
		/// or fetching domain categories.
		/// </summary>
		public async Task<DomainCategoryPage> QueryDomainCategoryAsync(string query)
		{
			var binding = new DataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/DataService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<DataServiceRequestHeader, DataServiceQueryDomainCategory>();
			inData.Header = new DataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new DataServiceQueryDomainCategory();
			inData.Body.Query = query;
			var outData = await binding.QueryDomainCategoryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(DataServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
