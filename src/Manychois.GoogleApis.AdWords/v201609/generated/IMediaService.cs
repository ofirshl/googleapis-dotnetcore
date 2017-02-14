using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to manage media for your template ads. After uploading images and videos
	/// with this service, use the IDs when creating image or template ads.
	/// </summary>
	public interface IMediaService
	{
		/// <summary>
		/// Returns a list of media that meet the criteria specified by the selector.
		/// <p class="note"><b>Note:</b> {@code MediaService} will not return any
		/// {@link ImageAd} image files.</p>
		///
		/// @param serviceSelector Selects which media objects to return.
		/// @return A list of {@code Media} objects.
		/// </summary>
		Task<MediaPage> GetAsync(Selector serviceSelector);
		/// <summary>
		/// Returns the list of {@link Media} objects that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of {@code Media} objects.
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		Task<MediaPage> QueryAsync(string query);
		/// <summary>
		/// Uploads new media. Currently, you can upload {@link Image} files and {@link MediaBundle}s.
		///
		/// @param media A list of {@code Media} objects, each containing the data to
		/// be uploaded.
		/// @return A list of uploaded media in the same order as the argument list.
		/// </summary>
		Task<IEnumerable<Media>> UploadAsync(IEnumerable<Media> media);
	}
}
