using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AdGroupExtensionSettingService : IAdGroupExtensionSettingService
	{
		public AdWordsApiConfig Config { get; }
		public AdGroupExtensionSettingService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns a list of AdGroupExtensionSettings that meet the selector criteria.
		///
		/// @param selector Determines which AdGroupExtensionSettings to return. If empty, all
		/// AdGroupExtensionSettings are returned.
		/// @return The list of AdGroupExtensionSettings specified by the selector.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<AdGroupExtensionSettingPage> GetAsync(Selector selector)
		{
			var binding = new AdGroupExtensionSettingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupExtensionSettingService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdGroupExtensionSettingServiceRequestHeader, AdGroupExtensionSettingServiceGet>();
			inData.Header = new AdGroupExtensionSettingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupExtensionSettingServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Applies the list of mutate operations (add, remove, and set).
		///
		/// <p> Beginning in v201509, add and set operations are treated identically. Performing an add
		/// operation on an ad group with an existing ExtensionSetting will cause the operation to be
		/// treated like a set operation. Performing a set operation on an ad group with no
		/// ExtensionSetting will cause the operation to be treated like an add operation.
		///
		/// @param operations The operations to apply. The same {@link AdGroupExtensionSetting} cannot be
		/// specified in more than one operation.
		/// @return The changed {@link AdGroupExtensionSetting}s.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<AdGroupExtensionSettingReturnValue> MutateAsync(IEnumerable<AdGroupExtensionSettingOperation> operations)
		{
			var binding = new AdGroupExtensionSettingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupExtensionSettingService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdGroupExtensionSettingServiceRequestHeader, AdGroupExtensionSettingServiceMutate>();
			inData.Header = new AdGroupExtensionSettingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupExtensionSettingServiceMutate();
			inData.Body.Operations = new List<AdGroupExtensionSettingOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of AdGroupExtensionSettings that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return The list of AdGroupExtensionSettings specified by the query.
		/// @throws ApiException Indicates a problem with the request.
		/// </summary>
		public async Task<AdGroupExtensionSettingPage> QueryAsync(string query)
		{
			var binding = new AdGroupExtensionSettingServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupExtensionSettingService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdGroupExtensionSettingServiceRequestHeader, AdGroupExtensionSettingServiceQuery>();
			inData.Header = new AdGroupExtensionSettingServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupExtensionSettingServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(AdGroupExtensionSettingServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
