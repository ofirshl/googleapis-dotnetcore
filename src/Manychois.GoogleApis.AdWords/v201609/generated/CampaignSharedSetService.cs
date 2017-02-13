using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class CampaignSharedSetService : ICampaignSharedSetService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public CampaignSharedSetService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<CampaignSharedSetService>();
		}
		/// <summary>
		/// Returns a list of CampaignSharedSets based on the given selector.
		/// @param selector the selector specifying the query
		/// @return a list of CampaignSharedSet entities that meet the criterion specified
		/// by the selector
		/// @throws ApiException
		/// </summary>
		public async Task<CampaignSharedSetPage> GetAsync(Selector selector)
		{
			var binding = new CampaignSharedSetServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignSharedSetService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CampaignSharedSetServiceRequestHeader, CampaignSharedSetServiceGet>();
			inData.Header = new CampaignSharedSetServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignSharedSetServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Applies the list of mutate operations.
		/// @param operations the operations to apply
		/// @return the modified list of CampaignSharedSet associations
		/// @throws ApiException
		/// </summary>
		public async Task<CampaignSharedSetReturnValue> MutateAsync(IEnumerable<CampaignSharedSetOperation> operations)
		{
			var binding = new CampaignSharedSetServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignSharedSetService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CampaignSharedSetServiceRequestHeader, CampaignSharedSetServiceMutate>();
			inData.Header = new CampaignSharedSetServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignSharedSetServiceMutate();
			inData.Body.Operations = new List<CampaignSharedSetOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of CampaignSharedSets that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of CampaignSharedSets
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		public async Task<CampaignSharedSetPage> QueryAsync(string query)
		{
			var binding = new CampaignSharedSetServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignSharedSetService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CampaignSharedSetServiceRequestHeader, CampaignSharedSetServiceQuery>();
			inData.Header = new CampaignSharedSetServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignSharedSetServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(CampaignSharedSetServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
