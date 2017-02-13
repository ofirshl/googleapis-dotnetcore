using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class CampaignExtensionSettingService : ICampaignExtensionSettingService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public CampaignExtensionSettingService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<CampaignExtensionSettingService>();
		}
		/// <summary>
		/// Returns a list of CampaignExtensionSettings that meet the selector criteria.
		///
		/// @param selector Determines which CampaignExtensionSettings to return. If empty, all
		/// CampaignExtensionSettings are returned.
		/// @return The list of CampaignExtensionSettings specified by the selector.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<CampaignExtensionSettingPage> GetAsync(Selector selector)
		{
			var binding = new CampaignExtensionSettingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignExtensionSettingService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CampaignExtensionSettingServiceRequestHeader, CampaignExtensionSettingServiceGet>();
			inData.Header = new CampaignExtensionSettingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignExtensionSettingServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Applies the list of mutate operations (add, remove, and set).
		///
		/// <p> Beginning in v201509, add and set operations are treated identically. Performing an add
		/// operation on a campaign with an existing ExtensionSetting will cause the operation to be
		/// treated like a set operation. Performing a set operation on a campaign with no
		/// ExtensionSetting will cause the operation to be treated like an add operation.
		///
		/// @param operations The operations to apply. The same {@link CampaignExtensionSetting} cannot be
		/// specified in more than one operation.
		/// @return The changed {@link CampaignExtensionSetting}s.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<CampaignExtensionSettingReturnValue> MutateAsync(IEnumerable<CampaignExtensionSettingOperation> operations)
		{
			var binding = new CampaignExtensionSettingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignExtensionSettingService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CampaignExtensionSettingServiceRequestHeader, CampaignExtensionSettingServiceMutate>();
			inData.Header = new CampaignExtensionSettingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignExtensionSettingServiceMutate();
			inData.Body.Operations = new List<CampaignExtensionSettingOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of CampaignExtensionSettings that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return The list of CampaignExtensionSettings specified by the query.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<CampaignExtensionSettingPage> QueryAsync(string query)
		{
			var binding = new CampaignExtensionSettingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignExtensionSettingService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CampaignExtensionSettingServiceRequestHeader, CampaignExtensionSettingServiceQuery>();
			inData.Header = new CampaignExtensionSettingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignExtensionSettingServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(CampaignExtensionSettingServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
