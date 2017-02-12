using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class CampaignService : ICampaignService
	{
		public AdWordsApiConfig Config { get; }
		public CampaignService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns the list of campaigns that meet the selector criteria.
		///
		/// @param serviceSelector the selector specifying the {@link Campaign}s to return.
		/// @return A list of campaigns.
		/// @throws ApiException if problems occurred while fetching campaign information.
		/// </summary>
		public async Task<CampaignPage> GetAsync(Selector serviceSelector)
		{
			var binding = new CampaignServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CampaignServiceRequestHeader, CampaignServiceGet>();
			inData.Header = new CampaignServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignServiceGet();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds, updates, or removes campaigns.
		/// <p class="note"><b>Note:</b> {@link CampaignOperation} does not support the
		/// <code>REMOVE</code> operator. To remove a campaign, set its
		/// {@link Campaign#status status} to {@code REMOVED}.</p>
		/// @param operations A list of unique operations.
		/// The same campaign cannot be specified in more than one operation.
		/// @return The list of updated campaigns, returned in the same order as the
		/// <code>operations</code> array.
		/// @throws ApiException if problems occurred while updating campaign information.
		/// </summary>
		public async Task<CampaignReturnValue> MutateAsync(IEnumerable<CampaignOperation> operations)
		{
			var binding = new CampaignServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CampaignServiceRequestHeader, CampaignServiceMutate>();
			inData.Header = new CampaignServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignServiceMutate();
			inData.Body.Operations = new List<CampaignOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Adds labels to the {@linkplain Campaign campaign} or removes {@linkplain Label label}s from the
		/// {@linkplain Campaign campaign}.
		/// <p>Add - Apply an existing label to an existing {@linkplain Campaign campaign}. The
		/// {@code campaignId} must reference an existing {@linkplain Campaign}. The {@code labelId} must
		/// reference an existing {@linkplain Label label}.
		/// <p>Remove - Removes the link between the specified {@linkplain Campaign campaign} and
		/// {@linkplain Label label}.
		///
		/// @param operations the operations to apply.
		/// @return a list of {@linkplain CampaignLabel}s where each entry in the list is the result of
		/// applying the operation in the input list with the same index. For an
		/// add operation, the returned CampaignLabel contains the CampaignId and the LabelId.
		/// In the case of a remove operation, the returned CampaignLabel will only have CampaignId.
		/// @throws ApiException when there are one or more errors with the request.
		/// </summary>
		public async Task<CampaignLabelReturnValue> MutateLabelAsync(IEnumerable<CampaignLabelOperation> operations)
		{
			var binding = new CampaignServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CampaignServiceRequestHeader, CampaignServiceMutateLabel>();
			inData.Header = new CampaignServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignServiceMutateLabel();
			inData.Body.Operations = new List<CampaignLabelOperation>(operations);
			var outData = await binding.MutateLabelAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of campaigns that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return A list of campaigns.
		/// @throws ApiException if problems occur while parsing the query or fetching campaign
		/// information.
		/// </summary>
		public async Task<CampaignPage> QueryAsync(string query)
		{
			var binding = new CampaignServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/CampaignService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<CampaignServiceRequestHeader, CampaignServiceQuery>();
			inData.Header = new CampaignServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new CampaignServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(CampaignServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
