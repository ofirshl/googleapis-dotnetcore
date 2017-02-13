using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class BudgetOrderService : IBudgetOrderService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public BudgetOrderService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<BudgetOrderService>();
		}
		/// <summary>
		/// Gets a list of {@link BudgetOrder}s using the generic selector.
		/// @param serviceSelector specifies which BudgetOrder to return.
		/// @return A {@link BudgetOrderPage} of BudgetOrders of the client customer.
		/// All BudgetOrder fields are returned. Stats are not yet supported.
		/// @throws ApiException
		/// </summary>
		public async Task<BudgetOrderPage> GetAsync(Selector serviceSelector)
		{
			var binding = new BudgetOrderServiceSoapBinding("https://adwords.google.com/api/adwords/billing/v201609/BudgetOrderService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<BudgetOrderServiceRequestHeader, BudgetOrderServiceGet>();
			inData.Header = new BudgetOrderServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BudgetOrderServiceGet();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns all the open/active BillingAccounts associated with the current
		/// manager.
		/// @return A list of {@link BillingAccount}s.
		/// @throws ApiException
		/// </summary>
		public async Task<IEnumerable<BillingAccount>> GetBillingAccountsAsync()
		{
			var binding = new BudgetOrderServiceSoapBinding("https://adwords.google.com/api/adwords/billing/v201609/BudgetOrderService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<BudgetOrderServiceRequestHeader, BudgetOrderServiceGetBillingAccounts>();
			inData.Header = new BudgetOrderServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BudgetOrderServiceGetBillingAccounts();
			var outData = await binding.GetBillingAccountsAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Mutates BudgetOrders, supported operations are:
		/// <p><code>ADD</code>: Adds a {@link BudgetOrder} to the billing account
		/// specified by the billing account ID.</p>
		/// <p><code>SET</code>: Sets the start/end date and amount of the
		/// {@link BudgetOrder}.</p>
		/// <p><code>REMOVE</code>: Cancels the {@link BudgetOrder} (status change).</p>
		/// <p class="warning"><b>Warning:</b> The <code>BudgetOrderService</code>
		/// is limited to one operation per mutate request. Any attempt to make more
		/// than one operation will result in an <code>ApiException</code>.</p>
		/// @param operations A list of operations, <b>however currently we only
		/// support one operation per mutate call</b>.
		/// @return BudgetOrders affected by the mutate operation.
		/// @throws ApiException
		/// </summary>
		public async Task<BudgetOrderReturnValue> MutateAsync(IEnumerable<BudgetOrderOperation> operations)
		{
			var binding = new BudgetOrderServiceSoapBinding("https://adwords.google.com/api/adwords/billing/v201609/BudgetOrderService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<BudgetOrderServiceRequestHeader, BudgetOrderServiceMutate>();
			inData.Header = new BudgetOrderServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BudgetOrderServiceMutate();
			inData.Body.Operations = new List<BudgetOrderOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(BudgetOrderServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
