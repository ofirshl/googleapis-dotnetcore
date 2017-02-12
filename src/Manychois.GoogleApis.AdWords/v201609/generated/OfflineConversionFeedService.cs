using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class OfflineConversionFeedService : IOfflineConversionFeedService
	{
		public AdWordsApiConfig Config { get; }
		public OfflineConversionFeedService(AdWordsApiConfig config)
		{
			Config = config;
		}
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
		public async Task<OfflineConversionFeedReturnValue> MutateAsync(IEnumerable<OfflineConversionFeedOperation> operations)
		{
			var binding = new OfflineConversionFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/OfflineConversionFeedService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<OfflineConversionFeedServiceRequestHeader, OfflineConversionFeedServiceMutate>();
			inData.Header = new OfflineConversionFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new OfflineConversionFeedServiceMutate();
			inData.Body.Operations = new List<OfflineConversionFeedOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(OfflineConversionFeedServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
