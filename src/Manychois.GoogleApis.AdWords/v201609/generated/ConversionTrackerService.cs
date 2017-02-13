using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class ConversionTrackerService : IConversionTrackerService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public ConversionTrackerService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<ConversionTrackerService>();
		}
		/// <summary>
		/// Returns a list of the conversion trackers that match the selector. The
		/// actual objects contained in the page's list of entries will be specific
		/// subclasses of the abstract {@link ConversionTracker} class.
		///
		/// @param serviceSelector The selector specifying the
		/// {@link ConversionTracker}s to return.
		/// @return List of conversion trackers specified by the selector.
		/// @throws com.google.ads.api.services.common.error.ApiException if problems
		/// occurred while retrieving results.
		/// </summary>
		public async Task<ConversionTrackerPage> GetAsync(Selector serviceSelector)
		{
			var binding = new ConversionTrackerServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConversionTrackerService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<ConversionTrackerServiceRequestHeader, ConversionTrackerServiceGet>();
			inData.Header = new ConversionTrackerServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConversionTrackerServiceGet();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Applies the list of mutate operations such as adding or updating conversion trackers.
		/// <p class="note"><b>Note:</b> {@link ConversionTrackerOperation} does not support the
		/// <code>REMOVE</code> operator. In order to 'disable' a conversion type, send a
		/// <code>SET</code> operation for the conversion tracker with the <code>status</code>
		/// property set to <code>DISABLED</code></p>
		///
		/// <p>You can mutate any ConversionTracker that belongs to your account. You may not
		/// mutate a ConversionTracker that belongs to some other account. You may not directly
		/// mutate a system-defined ConversionTracker, but you can create a mutable copy of it
		/// in your account by sending a mutate request with an ADD operation specifying
		/// an originalConversionTypeId matching a system-defined conversion tracker's ID. That new
		/// ADDed ConversionTracker will inherit the statistics and properties
		/// of the system-defined type, but will be editable as usual.</p>
		///
		/// @param operations A list of mutate operations to perform.
		/// @return The list of the conversion trackers as they appear after mutation,
		/// in the same order as they appeared in the list of operations.
		/// @throws com.google.ads.api.services.common.error.ApiException if problems
		/// occurred while updating the data.
		/// </summary>
		public async Task<ConversionTrackerReturnValue> MutateAsync(IEnumerable<ConversionTrackerOperation> operations)
		{
			var binding = new ConversionTrackerServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConversionTrackerService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<ConversionTrackerServiceRequestHeader, ConversionTrackerServiceMutate>();
			inData.Header = new ConversionTrackerServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConversionTrackerServiceMutate();
			inData.Body.Operations = new List<ConversionTrackerOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of conversion trackers that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of conversion trackers.
		/// @throws ApiException if problems occur while parsing the query or fetching conversion trackers.
		/// </summary>
		public async Task<ConversionTrackerPage> QueryAsync(string query)
		{
			var binding = new ConversionTrackerServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConversionTrackerService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<ConversionTrackerServiceRequestHeader, ConversionTrackerServiceQuery>();
			inData.Header = new ConversionTrackerServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConversionTrackerServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(ConversionTrackerServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
