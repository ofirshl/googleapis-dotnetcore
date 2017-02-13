using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class CustomerExtensionSettingService : ICustomerExtensionSettingService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public CustomerExtensionSettingService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<CustomerExtensionSettingService>();
		}
		/// <summary>
		/// Returns a list of CustomerExtensionSettings that meet the selector criteria.
		///
		/// @param selector Determines which CustomerExtensionSettings to return. If empty, all
		/// CustomerExtensionSettings are returned.
		/// @return The list of CustomerExtensionSettings specified by the selector.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<CustomerExtensionSettingPage> GetAsync(Selector selector)
		{
			var binding = new CustomerExtensionSettingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CustomerExtensionSettingService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CustomerExtensionSettingServiceRequestHeader, CustomerExtensionSettingServiceGet>();
			inData.Header = new CustomerExtensionSettingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CustomerExtensionSettingServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Applies the list of mutate operations (add, remove, and set).
		///
		/// <p> Beginning in v201509, add and set operations are treated identically. Performing an add
		/// operation when there is an existing ExtensionSetting will cause the operation to be
		/// treated like a set operation. Performing a set operation when there is no existing
		/// ExtensionSetting will cause the operation to be treated like an add operation.
		///
		/// @param operations The operations to apply. The same {@link CustomerExtensionSetting} cannot be
		/// specified in more than one operation.
		/// @return The changed {@link CustomerExtensionSetting}s.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<CustomerExtensionSettingReturnValue> MutateAsync(IEnumerable<CustomerExtensionSettingOperation> operations)
		{
			var binding = new CustomerExtensionSettingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CustomerExtensionSettingService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CustomerExtensionSettingServiceRequestHeader, CustomerExtensionSettingServiceMutate>();
			inData.Header = new CustomerExtensionSettingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CustomerExtensionSettingServiceMutate();
			inData.Body.Operations = new List<CustomerExtensionSettingOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of CustomerExtensionSettings that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return The list of CustomerExtensionSettings specified by the query.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<CustomerExtensionSettingPage> QueryAsync(string query)
		{
			var binding = new CustomerExtensionSettingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CustomerExtensionSettingService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CustomerExtensionSettingServiceRequestHeader, CustomerExtensionSettingServiceQuery>();
			inData.Header = new CustomerExtensionSettingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CustomerExtensionSettingServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(CustomerExtensionSettingServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
