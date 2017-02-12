using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AdParamService : IAdParamService
	{
		public AdWordsApiConfig Config { get; }
		public AdParamService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns the ad parameters that match the criteria specified in the
		/// selector.
		///
		/// @param serviceSelector Specifies which ad parameters to return.
		/// @return A list of ad parameters.
		/// </summary>
		public async Task<AdParamPage> GetAsync(Selector serviceSelector)
		{
			var binding = new AdParamServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdParamService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdParamServiceRequestHeader, AdParamServiceGet>();
			inData.Header = new AdParamServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdParamServiceGet();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Sets and removes ad parameters.
		/// <p class="note"><b>Note:</b> {@code ADD} is not supported. Use {@code SET}
		/// for new ad parameters.</p>
		///
		/// <ul class="nolist">
		/// <li>{@code SET}: Creates or updates an ad parameter, setting the new
		/// parameterized value for the given ad group / keyword pair.
		/// <li>{@code REMOVE}: Removes an ad parameter. The <code><var>default-value</var>
		/// </code> specified in the ad text will be used.</li>
		/// </ul>
		///
		/// @param operations The operations to perform.
		/// @return A list of ad parameters, where each entry in the list is the
		/// result of applying the operation in the input list with the same index.
		/// For a {@code SET} operation, the returned ad parameter will contain the
		/// updated values. For a {@code REMOVE} operation, the returned ad parameter
		/// will simply be the ad parameter that was removed.
		/// </summary>
		public async Task<IEnumerable<AdParam>> MutateAsync(IEnumerable<AdParamOperation> operations)
		{
			var binding = new AdParamServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdParamService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdParamServiceRequestHeader, AdParamServiceMutate>();
			inData.Header = new AdParamServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdParamServiceMutate();
			inData.Body.Operations = new List<AdParamOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(AdParamServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
