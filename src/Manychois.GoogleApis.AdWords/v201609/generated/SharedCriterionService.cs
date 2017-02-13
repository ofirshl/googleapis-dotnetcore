using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class SharedCriterionService : ISharedCriterionService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public SharedCriterionService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<SharedCriterionService>();
		}
		/// <summary>
		/// Returns a list of SharedCriterion that meets the selector criteria.
		///
		/// @param selector filters the criteria returned
		/// @return The list of SharedCriterion
		/// @throws ApiException
		/// </summary>
		public async Task<SharedCriterionPage> GetAsync(Selector selector)
		{
			var binding = new SharedCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/SharedCriterionService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<SharedCriterionServiceRequestHeader, SharedCriterionServiceGet>();
			inData.Header = new SharedCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new SharedCriterionServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds, removes criteria in a shared set.
		///
		/// @param operations A list of unique operations
		/// @return The list of updated SharedCriterion, returned in the same order as the
		/// {@code operations} array.
		/// @throws ApiException
		/// </summary>
		public async Task<SharedCriterionReturnValue> MutateAsync(IEnumerable<SharedCriterionOperation> operations)
		{
			var binding = new SharedCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/SharedCriterionService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<SharedCriterionServiceRequestHeader, SharedCriterionServiceMutate>();
			inData.Header = new SharedCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new SharedCriterionServiceMutate();
			inData.Body.Operations = new List<SharedCriterionOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of SharedCriterion that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of SharedCriterion.
		/// @throws ApiException
		/// </summary>
		public async Task<SharedCriterionPage> QueryAsync(string query)
		{
			var binding = new SharedCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/SharedCriterionService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<SharedCriterionServiceRequestHeader, SharedCriterionServiceQuery>();
			inData.Header = new SharedCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new SharedCriterionServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(SharedCriterionServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
