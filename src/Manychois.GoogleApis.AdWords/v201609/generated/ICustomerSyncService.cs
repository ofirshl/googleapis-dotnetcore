using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to retrieve the changed entities for a customer account or campaign based on the
	/// given date range.
	///
	/// <p class="note"><b>Note:</b> There will be some delay in changes becoming visible to this
	/// service; thus, use {@code lastChangeTimestamp} from the response to determine the validity period
	/// for the data.
	///
	/// <p class="note"><b>Note:</b> CustomerSyncService only supports queries for dates within the last
	/// 90 days.
	/// </summary>
	public interface ICustomerSyncService
	{
		/// <summary>
		/// Returns information about changed entities inside a customer's account.
		///
		/// @param selector Specifies the filter for selecting changehistory events for a customer.
		/// @return A Customer->Campaign->AdGroup hierarchy containing information about the objects
		/// changed at each level. All Campaigns that are requested in the selector will be returned,
		/// regardless of whether or not they have changed, but unchanged AdGroups will be ignored.
		/// </summary>
		Task<CustomerChangeData> GetAsync(CustomerSyncSelector selector);
	}
}
