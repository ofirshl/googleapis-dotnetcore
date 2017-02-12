using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AdGroupCriterionService : IAdGroupCriterionService
	{
		public AdWordsApiConfig Config { get; }
		public AdGroupCriterionService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Gets adgroup criteria.
		///
		/// @param serviceSelector filters the adgroup criteria to be returned.
		/// @return a page (subset) view of the criteria selected
		/// @throws ApiException when there is at least one error with the request
		/// </summary>
		public async Task<AdGroupCriterionPage> GetAsync(Selector serviceSelector)
		{
			var binding = new AdGroupCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupCriterionService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdGroupCriterionServiceRequestHeader, AdGroupCriterionServiceGet>();
			inData.Header = new AdGroupCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupCriterionServiceGet();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds, removes or updates adgroup criteria.
		///
		/// @param operations operations to do
		/// during checks on keywords to be added.
		/// @return added and updated adgroup criteria (without optional parts)
		/// @throws ApiException when there is at least one error with the request
		/// </summary>
		public async Task<AdGroupCriterionReturnValue> MutateAsync(IEnumerable<AdGroupCriterionOperation> operations)
		{
			var binding = new AdGroupCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupCriterionService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdGroupCriterionServiceRequestHeader, AdGroupCriterionServiceMutate>();
			inData.Header = new AdGroupCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupCriterionServiceMutate();
			inData.Body.Operations = new List<AdGroupCriterionOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds labels to the AdGroupCriterion or removes labels from the AdGroupCriterion
		/// <p>Add - Apply an existing label to an existing
		/// {@linkplain AdGroupCriterion ad group criterion}. The {@code adGroupId} and
		/// {@code criterionId}
		/// must reference an existing {@linkplain AdGroupCriterion ad group criterion}. The
		/// {@code labelId} must reference an existing {@linkplain Label label}.
		/// <p>Remove - Removes the link between the specified
		/// {@linkplain AdGroupCriterion ad group criterion} and {@linkplain Label label}.</p>
		/// @param operations the operations to apply
		/// @return a list of AdGroupCriterionLabel where each entry in the list is the result of
		/// applying the operation in the input list with the same index. For an
		/// add operation, the returned AdGroupCriterionLabel contains the AdGroupId, CriterionId and the
		/// LabelId. In the case of a remove operation, the returned AdGroupCriterionLabel will only have
		/// AdGroupId and CriterionId.
		/// @throws ApiException when there are one or more errors with the request
		/// </summary>
		public async Task<AdGroupCriterionLabelReturnValue> MutateLabelAsync(IEnumerable<AdGroupCriterionLabelOperation> operations)
		{
			var binding = new AdGroupCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupCriterionService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdGroupCriterionServiceRequestHeader, AdGroupCriterionServiceMutateLabel>();
			inData.Header = new AdGroupCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupCriterionServiceMutateLabel();
			inData.Body.Operations = new List<AdGroupCriterionLabelOperation>(operations);
			var outData = await binding.MutateLabelAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of AdGroupCriterion that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns A list of AdGroupCriterion
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		public async Task<AdGroupCriterionPage> QueryAsync(string query)
		{
			var binding = new AdGroupCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/AdGroupCriterionService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdGroupCriterionServiceRequestHeader, AdGroupCriterionServiceQuery>();
			inData.Header = new AdGroupCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdGroupCriterionServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(AdGroupCriterionServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
