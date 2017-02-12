using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service that handles the reporting of offline conversion data from external third parties.
	///
	/// <p>For more information, see our
	/// <a href="https://developers.google.com/adwords/api/docs/guides/conversion-tracking">conversion
	/// tracking guide</a>.</p>
	/// </summary>
	public interface IOfflineConversionFeedService
	{
		/// <summary>
		/// Reports an offline conversion for each entry in {@code operations}.
		/// <p>
		/// This bulk operation does not have any transactional guarantees. Some operations can succeed
		/// while others fail.
		///
		/// @param operations A list of offline conversion feed operations.
		/// @return The list of offline conversion feed results (in the same order as the operations).
		/// @throws {@link ApiException} if problems occurred while applying offline conversions.
		/// </summary>
		Task<OfflineConversionFeedReturnValue> MutateAsync(IEnumerable<OfflineConversionFeedOperation> Operations);
	}
}
