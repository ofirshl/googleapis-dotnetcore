using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service to access basic details about any customer.
	/// </summary>
	public interface ICustomerService
	{
		/// <summary>
		/// Returns details of all the customers directly accessible by the user authenticating the call.
		/// <p>
		/// Starting with v201607, if {@code clientCustomerId} is specified in the request header,
		/// only details of that customer will be returned. To do this for prior versions, use the
		/// {@code get()} method instead.
		/// </summary>
		Task<IEnumerable<Customer>> GetCustomersAsync();
		/// <summary>
		/// Retrieves the list of service links for the authorized customer.
		/// See {@link ServiceType} for information on the various linking types supported.
		///
		/// @param selector describing which links to retrieve
		/// @throws ApiException
		/// </summary>
		Task<IEnumerable<ServiceLink>> GetServiceLinksAsync(Selector Selector);
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
		Task<Customer> MutateAsync(Customer Customer);
		/// <summary>
		/// Modifies links to other services for the authorized customer.
		/// See {@link ServiceType} for information on the various linking types supported.
		///
		/// @param operations to perform
		/// @throws ApiException
		/// </summary>
		Task<IEnumerable<ServiceLink>> MutateServiceLinksAsync(IEnumerable<ServiceLinkOperation> Operations);
	}
}
