using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class OfflineCallConversionFeedService : IOfflineCallConversionFeedService
	{
		public AdWordsApiConfig Config { get; }
		public OfflineCallConversionFeedService(AdWordsApiConfig config)
		{
			Config = config;
		}
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
		public async Task<OfflineCallConversionFeedReturnValue> MutateAsync(IEnumerable<OfflineCallConversionFeedOperation> operations)
		{
			var binding = new OfflineCallConversionFeedServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/OfflineCallConversionFeedService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<OfflineCallConversionFeedServiceRequestHeader, OfflineCallConversionFeedServiceMutate>();
			inData.Header = new OfflineCallConversionFeedServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new OfflineCallConversionFeedServiceMutate();
			inData.Body.Operations = new List<OfflineCallConversionFeedOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(OfflineCallConversionFeedServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
