using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class LocationCriterionService : ILocationCriterionService
	{
		public AdWordsApiConfig Config { get; }
		public LocationCriterionService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns a list of {@link LocationCriterion}'s that match the specified selector.
		///
		/// @param selector filters the LocationCriterion to be returned.
		/// @return A list of location criterion.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<IEnumerable<LocationCriterion>> GetAsync(Selector selector)
		{
			var binding = new LocationCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/LocationCriterionService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<LocationCriterionServiceRequestHeader, LocationCriterionServiceGet>();
			inData.Header = new LocationCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new LocationCriterionServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of {@link LocationCriterion}s that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns The list of location criteria
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		public async Task<IEnumerable<LocationCriterion>> QueryAsync(string query)
		{
			var binding = new LocationCriterionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/LocationCriterionService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<LocationCriterionServiceRequestHeader, LocationCriterionServiceQuery>();
			inData.Header = new LocationCriterionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new LocationCriterionServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(LocationCriterionServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
