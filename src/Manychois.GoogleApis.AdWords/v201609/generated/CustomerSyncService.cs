using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class CustomerSyncService : ICustomerSyncService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public CustomerSyncService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<CustomerSyncService>();
		}
		/// <summary>
		/// Returns information about changed entities inside a customer's account.
		///
		/// @param selector Specifies the filter for selecting changehistory events for a customer.
		/// @return A Customer->Campaign->AdGroup hierarchy containing information about the objects
		/// changed at each level. All Campaigns that are requested in the selector will be returned,
		/// regardless of whether or not they have changed, but unchanged AdGroups will be ignored.
		/// </summary>
		public async Task<CustomerChangeData> GetAsync(CustomerSyncSelector selector)
		{
			var binding = new CustomerSyncServiceSoapBinding("https://adwords.google.com/api/adwords/ch/v201609/CustomerSyncService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<CustomerSyncServiceRequestHeader, CustomerSyncServiceGet>();
			inData.Header = new CustomerSyncServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CustomerSyncServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(CustomerSyncServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
