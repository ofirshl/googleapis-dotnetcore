using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class BatchJobService : IBatchJobService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public BatchJobService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<BatchJobService>();
		}
		/// <summary>
		/// Query the status of existing {@code BatchJob}s.
		///
		/// @param selector The selector specifying the {@code BatchJob}s to return.
		/// @return The list of selected jobs.
		/// @throws ApiException
		/// </summary>
		public async Task<BatchJobPage> GetAsync(Selector selector)
		{
			var binding = new BatchJobServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/BatchJobService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<BatchJobServiceRequestHeader, BatchJobServiceGet>();
			inData.Header = new BatchJobServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BatchJobServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Creates or updates a {@code BatchJob}.
		///
		/// <p class="note"><b>Note:</b> {@link BatchJobOperation} does not support the
		/// {@code REMOVE} operator. It is not necessary to remove BatchJobs.
		///
		/// @param operations A list of operations.
		/// @return The list of created or updated jobs.
		/// @throws ApiException
		/// </summary>
		public async Task<BatchJobReturnValue> MutateAsync(IEnumerable<BatchJobOperation> operations)
		{
			var binding = new BatchJobServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/BatchJobService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<BatchJobServiceRequestHeader, BatchJobServiceMutate>();
			inData.Header = new BatchJobServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BatchJobServiceMutate();
			inData.Body.Operations = new List<BatchJobOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of {@code BatchJob}s that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return The list of selected jobs.
		/// @throws ApiException if problems occur while parsing the query or fetching
		/// batchjob information.
		/// </summary>
		public async Task<BatchJobPage> QueryAsync(string query)
		{
			var binding = new BatchJobServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/BatchJobService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<BatchJobServiceRequestHeader, BatchJobServiceQuery>();
			inData.Header = new BatchJobServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BatchJobServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(BatchJobServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
