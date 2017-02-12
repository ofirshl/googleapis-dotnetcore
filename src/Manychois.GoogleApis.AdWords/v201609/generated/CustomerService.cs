using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class CustomerService : ICustomerService
	{
		public AdWordsApiConfig Config { get; }
		public CustomerService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns details of all the customers directly accessible by the user authenticating the call.
		/// <p>
		/// Starting with v201607, if {@code clientCustomerId} is specified in the request header,
		/// only details of that customer will be returned. To do this for prior versions, use the
		/// {@code get()} method instead.
		/// </summary>
		public async Task<IEnumerable<Customer>> GetCustomersAsync()
		{
			var binding = new CustomerServiceSoapBinding("https://adwords.google.com/api/adwords/mcm/v201609/CustomerService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CustomerServiceRequestHeader, CustomerServiceGetCustomers>();
			inData.Header = new CustomerServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CustomerServiceGetCustomers();
			var outData = await binding.GetCustomersAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Retrieves the list of service links for the authorized customer.
		/// See {@link ServiceType} for information on the various linking types supported.
		///
		/// @param selector describing which links to retrieve
		/// @throws ApiException
		/// </summary>
		public async Task<IEnumerable<ServiceLink>> GetServiceLinksAsync(Selector selector)
		{
			var binding = new CustomerServiceSoapBinding("https://adwords.google.com/api/adwords/mcm/v201609/CustomerService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CustomerServiceRequestHeader, CustomerServiceGetServiceLinks>();
			inData.Header = new CustomerServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CustomerServiceGetServiceLinks();
			inData.Body.Selector = selector;
			var outData = await binding.GetServiceLinksAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Update the authorized customer.
		///
		/// <p>While there are a limited set of properties available to update, please read this
		/// <a href="https://support.google.com/analytics/answer/1033981">help center article
		/// on auto-tagging</a> before updating {@code customer.autoTaggingEnabled}.
		///
		/// @param customer the requested updated value for the customer.
		/// @throws ApiException
		/// </summary>
		public async Task<Customer> MutateAsync(Customer customer)
		{
			var binding = new CustomerServiceSoapBinding("https://adwords.google.com/api/adwords/mcm/v201609/CustomerService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CustomerServiceRequestHeader, CustomerServiceMutate>();
			inData.Header = new CustomerServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CustomerServiceMutate();
			inData.Body.Customer = customer;
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Modifies links to other services for the authorized customer.
		/// See {@link ServiceType} for information on the various linking types supported.
		///
		/// @param operations to perform
		/// @throws ApiException
		/// </summary>
		public async Task<IEnumerable<ServiceLink>> MutateServiceLinksAsync(IEnumerable<ServiceLinkOperation> operations)
		{
			var binding = new CustomerServiceSoapBinding("https://adwords.google.com/api/adwords/mcm/v201609/CustomerService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CustomerServiceRequestHeader, CustomerServiceMutateServiceLinks>();
			inData.Header = new CustomerServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CustomerServiceMutateServiceLinks();
			inData.Body.Operations = new List<ServiceLinkOperation>(operations);
			var outData = await binding.MutateServiceLinksAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(CustomerServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
