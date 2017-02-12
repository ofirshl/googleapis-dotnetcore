using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to manage conversion trackers. A conversion tracker provides
	/// a snippet of code which records every time a user visits a page that contains
	/// it. The data this provides can be used to gauge the effectiveness of your ads
	/// and keywords.
	/// </summary>
	public interface IConversionTrackerService
	{
		/// <summary>
		/// Returns a list of the conversion trackers that match the selector. The
		/// actual objects contained in the page's list of entries will be specific
		/// subclasses of the abstract {@link ConversionTracker} class.
		///
		/// @param serviceSelector The selector specifying the
		/// {@link ConversionTracker}s to return.
		/// @return List of conversion trackers specified by the selector.
		/// @throws com.google.ads.api.services.common.error.ApiException if problems
		/// occurred while retrieving results.
		/// </summary>
		Task<ConversionTrackerPage> GetAsync(Selector ServiceSelector);
		/// <summary>
		/// Applies the list of mutate operations such as adding or updating conversion trackers.
		/// <p class="note"><b>Note:</b> {@link ConversionTrackerOperation} does not support the
		/// <code>REMOVE</code> operator. In order to 'disable' a conversion type, send a
		/// <code>SET</code> operation for the conversion tracker with the <code>status</code>
		/// property set to <code>DISABLED</code></p>
		///
		/// <p>You can mutate any ConversionTracker that belongs to your account. You may not
		/// mutate a ConversionTracker that belongs to some other account. You may not directly
		/// mutate a system-defined ConversionTracker, but you can create a mutable copy of it
		/// in your account by sending a mutate request with an ADD operation specifying
		/// an originalConversionTypeId matching a system-defined conversion tracker's ID. That new
		/// ADDed ConversionTracker will inherit the statistics and properties
		/// of the system-defined type, but will be editable as usual.</p>
		///
		/// @param operations A list of mutate operations to perform.
		/// @return The list of the conversion trackers as they appear after mutation,
		/// in the same order as they appeared in the list of operations.
		/// @throws com.google.ads.api.services.common.error.ApiException if problems
		/// occurred while updating the data.
		/// </summary>
		Task<ConversionTrackerReturnValue> MutateAsync(IEnumerable<ConversionTrackerOperation> Operations);
		/// <summary>
		/// Returns a list of conversion trackers that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of conversion trackers.
		/// @throws ApiException if problems occur while parsing the query or fetching conversion trackers.
		/// </summary>
		Task<ConversionTrackerPage> QueryAsync(string Query);
	}
}
