using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class BudgetService : IBudgetService
	{
		public AdWordsApiConfig Config { get; }
		public BudgetService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns a list of budgets that match the selector.
		///
		/// @return List of budgets specified by the selector.
		/// @throws com.google.ads.api.services.common.error.ApiException if problems
		/// occurred while retrieving results.
		/// </summary>
		public async Task<BudgetPage> GetAsync(Selector selector)
		{
			var binding = new BudgetServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/BudgetService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<BudgetServiceRequestHeader, BudgetServiceGet>();
			inData.Header = new BudgetServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BudgetServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Applies the list of mutate operations.
		///
		/// @param operations The operations to apply.
		/// @return The modified list of Budgets, returned in the same order as <code>operations</code>.
		/// @throws ApiException
		/// </summary>
		public async Task<BudgetReturnValue> MutateAsync(IEnumerable<BudgetOperation> operations)
		{
			var binding = new BudgetServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/BudgetService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<BudgetServiceRequestHeader, BudgetServiceMutate>();
			inData.Header = new BudgetServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BudgetServiceMutate();
			inData.Body.Operations = new List<BudgetOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of budgets that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of Budget
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		public async Task<BudgetPage> QueryAsync(string query)
		{
			var binding = new BudgetServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/BudgetService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<BudgetServiceRequestHeader, BudgetServiceQuery>();
			inData.Header = new BudgetServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new BudgetServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(BudgetServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
