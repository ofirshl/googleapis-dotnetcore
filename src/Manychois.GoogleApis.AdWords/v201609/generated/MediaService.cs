using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class MediaService : IMediaService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public MediaService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<MediaService>();
		}
		/// <summary>
		/// Returns a list of media that meet the criteria specified by the selector.
		/// <p class="note"><b>Note:</b> {@code MediaService} will not return any
		/// {@link ImageAd} image files.</p>
		///
		/// @param serviceSelector Selects which media objects to return.
		/// @return A list of {@code Media} objects.
		/// </summary>
		public async Task<MediaPage> GetAsync(Selector serviceSelector)
		{
			var binding = new MediaServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/MediaService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<MediaServiceRequestHeader, MediaServiceGet>();
			inData.Header = new MediaServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new MediaServiceGet();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of {@link Media} objects that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of {@code Media} objects.
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		public async Task<MediaPage> QueryAsync(string query)
		{
			var binding = new MediaServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/MediaService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<MediaServiceRequestHeader, MediaServiceQuery>();
			inData.Header = new MediaServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new MediaServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Uploads new media. Currently, you can upload {@link Image} files and {@link MediaBundle}s.
		///
		/// @param media A list of {@code Media} objects, each containing the data to
		/// be uploaded.
		/// @return A list of uploaded media in the same order as the argument list.
		/// </summary>
		public async Task<IEnumerable<Media>> UploadAsync(IEnumerable<Media> media)
		{
			var binding = new MediaServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/MediaService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<MediaServiceRequestHeader, MediaServiceUpload>();
			inData.Header = new MediaServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new MediaServiceUpload();
			inData.Body.Media = new List<Media>(media);
			var outData = await binding.UploadAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(MediaServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
