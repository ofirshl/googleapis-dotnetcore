using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service that handles the reporting of externally provided call conversions.
	/// </summary>
	public interface IOfflineCallConversionFeedService
	{
		/// <summary>
		/// Reports a call conversion for each entry in {@code operations}.
		///
		/// <p>This bulk operation does not have any transactional guarantees. Some operations can succeed
		/// while others fail.
		///
		/// @param operations A list of offline call conversion feed operations.
		/// @return The list of offline call conversion feed results (in the same order as the operations).
		/// @throws {@link ApiException} if problems occurred while applying offline call conversions.
		/// </summary>
		Task<OfflineCallConversionFeedReturnValue> MutateAsync(IEnumerable<OfflineCallConversionFeedOperation> Operations);
	}
}
