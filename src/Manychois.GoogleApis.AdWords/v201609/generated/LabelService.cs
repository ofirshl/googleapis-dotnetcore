using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class LabelService : ILabelService
	{
		public AdWordsApiConfig Config { get; }
		public LabelService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns a list of {@link Label}s.
		///
		/// @param serviceSelector The selector specifying the {@link Label}s to return.
		/// @return The page containing the {@link Label}s which meet the criteria specified by the
		/// selector.
		/// @throws ApiException when there is at least one error with the request
		/// </summary>
		public async Task<LabelPage> GetAsync(Selector serviceSelector)
		{
			var binding = new LabelServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/LabelService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<LabelServiceRequestHeader, LabelServiceGet>();
			inData.Header = new LabelServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new LabelServiceGet();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Applies the list of mutate operations.
		///
		/// @param operations The operations to apply. The same {@link Label} cannot be specified in
		/// more than one operation.
		/// @return The applied {@link Label}s.
		/// @throws ApiException when there is at least one error with the request
		/// </summary>
		public async Task<LabelReturnValue> MutateAsync(IEnumerable<LabelOperation> operations)
		{
			var binding = new LabelServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/LabelService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<LabelServiceRequestHeader, LabelServiceMutate>();
			inData.Header = new LabelServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new LabelServiceMutate();
			inData.Body.Operations = new List<LabelOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of {@link Label}s that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns  The page containing the {@link Label}s which match the query.
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		public async Task<LabelPage> QueryAsync(string query)
		{
			var binding = new LabelServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/LabelService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<LabelServiceRequestHeader, LabelServiceQuery>();
			inData.Header = new LabelServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new LabelServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(LabelServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
