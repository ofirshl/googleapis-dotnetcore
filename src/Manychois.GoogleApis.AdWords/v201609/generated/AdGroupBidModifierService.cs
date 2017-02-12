using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AdGroupBidModifierService : IAdGroupBidModifierService
	{
		public AdWordsApiConfig Config { get; }
		public AdGroupBidModifierService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Gets ad group level criterion bid modifiers.
		///
		/// @param selector The selector specifying the {@link AdGroupBidModifier}s to return.
		/// @return A list of ad group bid modifiers.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<AdGroupBidModifierPage> GetAsync(Selector selector)
		{
			var binding = new AdGroupBidModifierServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupBidModifierService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdGroupBidModifierServiceRequestHeader, AdGroupBidModifierServiceGet>();
			inData.Header = new AdGroupBidModifierServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupBidModifierServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds, removes or updates ad group bid modifier overrides.
		///
		/// @param operations The operations to apply.
		/// @return The added ad group bid modifier overrides.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<AdGroupBidModifierReturnValue> MutateAsync(IEnumerable<AdGroupBidModifierOperation> operations)
		{
			var binding = new AdGroupBidModifierServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupBidModifierService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdGroupBidModifierServiceRequestHeader, AdGroupBidModifierServiceMutate>();
			inData.Header = new AdGroupBidModifierServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupBidModifierServiceMutate();
			inData.Body.Operations = new List<AdGroupBidModifierOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of {@link AdGroupBidModifier}s that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		public async Task<AdGroupBidModifierPage> QueryAsync(string query)
		{
			var binding = new AdGroupBidModifierServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupBidModifierService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdGroupBidModifierServiceRequestHeader, AdGroupBidModifierServiceQuery>();
			inData.Header = new AdGroupBidModifierServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupBidModifierServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(AdGroupBidModifierServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
