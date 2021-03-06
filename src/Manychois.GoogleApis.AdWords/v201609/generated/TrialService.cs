﻿using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class TrialService : ITrialService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public TrialService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<TrialService>();
		}
		/// <summary>
		/// Loads a TrialPage containing a list of {@link Trial} objects matching the selector.
		///
		/// @param selector defines which subset of all available trials to return, the sort order, and
		/// which fields to include
		///
		/// @return Returns a page of matching trial objects.
		/// @throws com.google.ads.api.services.common.error.ApiException if errors occurred while
		/// retrieving the results.
		/// </summary>
		public async Task<TrialPage> GetAsync(Selector selector)
		{
			var binding = new TrialServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/TrialService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<TrialServiceRequestHeader, TrialServiceGet>();
			inData.Header = new TrialServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new TrialServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Creates new trials, updates properties and controls the life cycle of existing trials.
		/// See {@link TrialService} for details on the trial life cycle.
		///
		/// @return Returns the list of updated Trials, in the same order as the {@code operations} list.
		/// @throws com.google.ads.api.services.common.error.ApiException if errors occurred while
		/// processing the request.
		/// </summary>
		public async Task<TrialReturnValue> MutateAsync(IEnumerable<TrialOperation> operations)
		{
			var binding = new TrialServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/TrialService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<TrialServiceRequestHeader, TrialServiceMutate>();
			inData.Header = new TrialServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new TrialServiceMutate();
			inData.Body.Operations = new List<TrialOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Loads a TrialPage containing a list of {@link Trial} objects matching the query.
		///
		/// @param query defines which subset of all available trials to return, the sort order, and
		/// which fields to include
		///
		/// @return Returns a page of matching trial objects.
		/// @throws com.google.ads.api.services.common.error.ApiException if errors occurred while
		/// retrieving the results.
		/// </summary>
		public async Task<TrialPage> QueryAsync(string query)
		{
			var binding = new TrialServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/TrialService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<TrialServiceRequestHeader, TrialServiceQuery>();
			inData.Header = new TrialServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new TrialServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(TrialServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
