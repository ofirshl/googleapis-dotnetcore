using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AdGroupAdService : IAdGroupAdService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public AdGroupAdService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<AdGroupAdService>();
		}
		/// <summary>
		/// Returns a list of AdGroupAds.
		/// AdGroupAds that had been removed are not returned by default.
		///
		/// @param serviceSelector The selector specifying the {@link AdGroupAd}s to return.
		/// @return The page containing the AdGroupAds that meet the criteria specified by the selector.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<AdGroupAdPage> GetAsync(Selector serviceSelector)
		{
			var binding = new AdGroupAdServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupAdService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupAdServiceRequestHeader, AdGroupAdServiceGet>();
			inData.Header = new AdGroupAdServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupAdServiceGet();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Applies the list of mutate operations (ie. add, set, remove):
		/// <p>Add - Creates a new {@linkplain AdGroupAd ad group ad}. The
		/// {@code adGroupId} must
		/// reference an existing ad group. The child {@code Ad} must be sufficiently
		/// specified by constructing a concrete ad type (such as {@code TextAd})
		/// and setting its fields accordingly.</p>
		/// <p>Set - Updates an ad group ad. Except for {@code status},
		/// ad group ad fields are not mutable. Status updates are
		/// straightforward - the status of the ad group ad is updated as
		/// specified. If any other field has changed, it will be ignored. If
		/// you want to change any of the fields other than status, you must
		/// make a new ad and then remove the old one.</p>
		/// <p>Remove - Removes the link between the specified AdGroup and
		/// Ad.</p>
		/// @param operations The operations to apply.
		/// @return A list of AdGroupAds where each entry in the list is the result of
		/// applying the operation in the input list with the same index. For an
		/// add/set operation, the return AdGroupAd will be what is saved to the db.
		/// In the case of the remove operation, the return AdGroupAd will simply be
		/// an AdGroupAd containing an Ad with the id set to the Ad being removed from
		/// the AdGroup.
		/// </summary>
		public async Task<AdGroupAdReturnValue> MutateAsync(IEnumerable<AdGroupAdOperation> operations)
		{
			var binding = new AdGroupAdServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupAdService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupAdServiceRequestHeader, AdGroupAdServiceMutate>();
			inData.Header = new AdGroupAdServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupAdServiceMutate();
			inData.Body.Operations = new List<AdGroupAdOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds labels to the AdGroupAd or removes labels from the AdGroupAd.
		/// <p>Add - Apply an existing label to an existing {@linkplain AdGroupAd ad group ad}. The
		/// {@code adGroupId} and {@code adId} must reference an existing
		/// {@linkplain AdGroupAd ad group ad}. The {@code labelId} must reference an existing
		/// {@linkplain Label label}.
		/// <p>Remove - Removes the link between the specified {@linkplain AdGroupAd ad group ad} and
		/// {@linkplain Label label}.
		/// @param operations The operations to apply.
		/// @return A list of AdGroupAdLabel where each entry in the list is the result of
		/// applying the operation in the input list with the same index. For an
		/// add operation, the returned AdGroupAdLabel contains the AdGroupId, AdId and the LabelId.
		/// In the case of a remove operation, the returned AdGroupAdLabel will only have AdGroupId and
		/// AdId.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		public async Task<AdGroupAdLabelReturnValue> MutateLabelAsync(IEnumerable<AdGroupAdLabelOperation> operations)
		{
			var binding = new AdGroupAdServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupAdService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupAdServiceRequestHeader, AdGroupAdServiceMutateLabel>();
			inData.Header = new AdGroupAdServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupAdServiceMutateLabel();
			inData.Body.Operations = new List<AdGroupAdLabelOperation>(operations);
			var outData = await binding.MutateLabelAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of AdGroupAds based on the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of AdGroupAds.
		/// @throws ApiException if problems occur while parsing the query or fetching AdGroupAds.
		/// </summary>
		public async Task<AdGroupAdPage> QueryAsync(string query)
		{
			var binding = new AdGroupAdServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupAdService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupAdServiceRequestHeader, AdGroupAdServiceQuery>();
			inData.Header = new AdGroupAdServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupAdServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Upgrades the url for a set of ads.
		/// @param operations The list of upgrades to apply.
		/// @return The list of Ads that were upgraded.
		/// </summary>
		public async Task<IEnumerable<Ad>> UpgradeUrlAsync(IEnumerable<AdUrlUpgrade> operations)
		{
			var binding = new AdGroupAdServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupAdService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
			var inData = new SoapData<AdGroupAdServiceRequestHeader, AdGroupAdServiceUpgradeUrl>();
			inData.Header = new AdGroupAdServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupAdServiceUpgradeUrl();
			inData.Body.Operations = new List<AdUrlUpgrade>(operations);
			var outData = await binding.UpgradeUrlAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(AdGroupAdServiceRequestHeader header)
		{
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
