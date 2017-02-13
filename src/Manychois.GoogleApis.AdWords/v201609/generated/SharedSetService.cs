using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class SharedSetService : ISharedSetService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public SharedSetService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<SharedSetService>();
		}
		/// <summary>
		/// Returns a list of SharedSets based on the given selector.
		/// @param selector the selector specifying the query
		/// @return a list of SharedSet entities that meet the criterion specified
		/// by the selector
		/// @throws ApiException
		/// </summary>
		public async Task<SharedSetPage> GetAsync(Selector selector)
		{
			var binding = new SharedSetServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/SharedSetService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<SharedSetServiceRequestHeader, SharedSetServiceGet>();
			inData.Header = new SharedSetServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new SharedSetServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Applies the list of mutate operations.
		/// @param operations the operations to apply
		/// @return the modified CriterionList entities
		/// @throws ApiException
		/// </summary>
		public async Task<SharedSetReturnValue> MutateAsync(IEnumerable<SharedSetOperation> operations)
		{
			var binding = new SharedSetServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/SharedSetService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<SharedSetServiceRequestHeader, SharedSetServiceMutate>();
			inData.Header = new SharedSetServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new SharedSetServiceMutate();
			inData.Body.Operations = new List<SharedSetOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of SharedSet entities that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of SharedSet entities
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		public async Task<SharedSetPage> QueryAsync(string query)
		{
			var binding = new SharedSetServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/SharedSetService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<SharedSetServiceRequestHeader, SharedSetServiceQuery>();
			inData.Header = new SharedSetServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new SharedSetServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(SharedSetServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
