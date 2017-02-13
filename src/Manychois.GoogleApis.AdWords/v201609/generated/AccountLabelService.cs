using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AccountLabelService : IAccountLabelService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public AccountLabelService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<AccountLabelService>();
		}
		/// <summary>
		/// Returns a list of labels specified by the selector for the authenticated user.
		///
		/// @param selector filters the list of labels to return
		/// @return response containing lists of labels that meet all the criteria of the selector
		/// @throws ApiException if a problem occurs fetching the information requested
		/// </summary>
		public async Task<AccountLabelPage> GetAsync(Selector selector)
		{
			var binding = new AccountLabelServiceSoapBinding("https://adwords.google.com/api/adwords/mcm/v201609/AccountLabelService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AccountLabelServiceRequestHeader, AccountLabelServiceGet>();
			inData.Header = new AccountLabelServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AccountLabelServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Possible actions:
		/// <ul>
		/// <li> Create a new label - create a new {@link Label} and call mutate with ADD operator
		/// <li> Edit the label name - set the appropriate fields in your {@linkplain Label} and call
		/// mutate with the SET operator. Null fields will be interpreted to mean "no change"
		/// <li> Delete the label - call mutate with REMOVE operator
		/// </ul>
		///
		/// @param operations list of unique operations to be executed in a single transaction, in the
		/// order specified.
		/// @return the mutated labels, in the same order that they were in as the parameter
		/// @throws ApiException if problems occurs while modifying label information
		/// </summary>
		public async Task<AccountLabelReturnValue> MutateAsync(IEnumerable<AccountLabelOperation> operations)
		{
			var binding = new AccountLabelServiceSoapBinding("https://adwords.google.com/api/adwords/mcm/v201609/AccountLabelService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AccountLabelServiceRequestHeader, AccountLabelServiceMutate>();
			inData.Header = new AccountLabelServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AccountLabelServiceMutate();
			inData.Body.Operations = new List<AccountLabelOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(AccountLabelServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
