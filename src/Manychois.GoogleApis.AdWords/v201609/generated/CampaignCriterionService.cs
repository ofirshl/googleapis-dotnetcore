using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class CampaignCriterionService : ICampaignCriterionService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public CampaignCriterionService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<CampaignCriterionService>();
		}
		/// <summary>
		/// Gets campaign criteria.
		///
		/// @param serviceSelector The selector specifying the {@link CampaignCriterion}s to return.
		/// @return A list of campaign criteria.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<CampaignCriterionPage> GetAsync(Selector serviceSelector)
		{
			var binding = new CampaignCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignCriterionService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CampaignCriterionServiceRequestHeader, CampaignCriterionServiceGet>();
			inData.Header = new CampaignCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignCriterionServiceGet();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds, removes or updates campaign criteria.
		///
		/// @param operations The operations to apply.
		/// @return The added campaign criteria (without any optional parts).
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<CampaignCriterionReturnValue> MutateAsync(IEnumerable<CampaignCriterionOperation> operations)
		{
			var binding = new CampaignCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignCriterionService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CampaignCriterionServiceRequestHeader, CampaignCriterionServiceMutate>();
			inData.Header = new CampaignCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignCriterionServiceMutate();
			inData.Body.Operations = new List<CampaignCriterionOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of campaign criteria that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of campaign criteria.
		/// @throws ApiException if problems occur while parsing the query or fetching campaign criteria.
		/// </summary>
		public async Task<CampaignCriterionPage> QueryAsync(string query)
		{
			var binding = new CampaignCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignCriterionService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CampaignCriterionServiceRequestHeader, CampaignCriterionServiceQuery>();
			inData.Header = new CampaignCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignCriterionServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(CampaignCriterionServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
