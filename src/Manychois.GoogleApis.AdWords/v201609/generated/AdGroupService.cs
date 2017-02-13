using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AdGroupService : IAdGroupService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public AdGroupService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<AdGroupService>();
		}
		/// <summary>
		/// Returns a list of all the ad groups specified by the selector
		/// from the target customer's account.
		///
		/// @param serviceSelector The selector specifying the {@link AdGroup}s to return.
		/// @return List of adgroups identified by the selector.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<AdGroupPage> GetAsync(Selector serviceSelector)
		{
			var binding = new AdGroupServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupServiceRequestHeader, AdGroupServiceGet>();
			inData.Header = new AdGroupServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupServiceGet();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds, updates, or removes ad groups.
		/// <p class="note"><b>Note:</b> {@link AdGroupOperation} does not support the
		/// {@code REMOVE} operator. To remove an ad group, set its
		/// {@link AdGroup#status status} to {@code REMOVED}.</p>
		///
		/// @param operations List of unique operations. The same ad group cannot be
		/// specified in more than one operation.
		/// @return The updated adgroups.
		/// </summary>
		public async Task<AdGroupReturnValue> MutateAsync(IEnumerable<AdGroupOperation> operations)
		{
			var binding = new AdGroupServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupServiceRequestHeader, AdGroupServiceMutate>();
			inData.Header = new AdGroupServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupServiceMutate();
			inData.Body.Operations = new List<AdGroupOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds labels to the {@linkplain AdGroup ad group} or removes {@linkplain Label label}s from the
		/// {@linkplain AdGroup ad group}.
		/// <p>{@code ADD} -- Apply an existing label to an existing {@linkplain AdGroup ad group}.
		/// The {@code adGroupId} must reference an existing {@linkplain AdGroup ad group}. The
		/// {@code labelId} must reference an existing {@linkplain Label label}.
		/// <p>{@code REMOVE} -- Removes the link between the specified {@linkplain AdGroup ad group}
		/// and a {@linkplain Label label}.</p>
		///
		/// @param operations the operations to apply.
		/// @return a list of {@linkplain AdGroupLabel}s where each entry in the list is the result of
		/// applying the operation in the input list with the same index. For an
		/// add operation, the returned AdGroupLabel contains the AdGroupId and the LabelId.
		/// In the case of a remove operation, the returned AdGroupLabel will only have AdGroupId.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		public async Task<AdGroupLabelReturnValue> MutateLabelAsync(IEnumerable<AdGroupLabelOperation> operations)
		{
			var binding = new AdGroupServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupServiceRequestHeader, AdGroupServiceMutateLabel>();
			inData.Header = new AdGroupServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupServiceMutateLabel();
			inData.Body.Operations = new List<AdGroupLabelOperation>(operations);
			var outData = await binding.MutateLabelAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of ad groups that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @return A list of adgroups
		/// @throws ApiException
		/// </summary>
		public async Task<AdGroupPage> QueryAsync(string query)
		{
			var binding = new AdGroupServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupServiceRequestHeader, AdGroupServiceQuery>();
			inData.Header = new AdGroupServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(AdGroupServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
