using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class CustomerSyncService : ICustomerSyncService
	{
		public AdWordsApiConfig Config { get; }
		public CustomerSyncService(AdWordsApiConfig config)
		{
			Config = config;
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
			var binding = new CustomerSyncServiceSoapBinding("https://adwords.google.com/api/adwords/ch/v201609/CustomerSyncService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
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
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
