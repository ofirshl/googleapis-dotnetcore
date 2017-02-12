using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class ConstantDataService : IConstantDataService
	{
		public AdWordsApiConfig Config { get; }
		public ConstantDataService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns a list of all age range criteria.
		///
		/// @return A list of age ranges.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<IEnumerable<AgeRange>> GetAgeRangeCriterionAsync()
		{
			var binding = new ConstantDataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConstantDataService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetAgeRangeCriterion>();
			inData.Header = new ConstantDataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConstantDataServiceGetAgeRangeCriterion();
			var outData = await binding.GetAgeRangeCriterionAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of all carrier criteria.
		///
		/// @return A list of carriers.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<IEnumerable<Carrier>> GetCarrierCriterionAsync()
		{
			var binding = new ConstantDataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConstantDataService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetCarrierCriterion>();
			inData.Header = new ConstantDataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConstantDataServiceGetCarrierCriterion();
			var outData = await binding.GetCarrierCriterionAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of all gender criteria.
		///
		/// @return A list of genders.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<IEnumerable<Gender>> GetGenderCriterionAsync()
		{
			var binding = new ConstantDataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConstantDataService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetGenderCriterion>();
			inData.Header = new ConstantDataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConstantDataServiceGetGenderCriterion();
			var outData = await binding.GetGenderCriterionAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of all language criteria.
		///
		/// @return A list of languages.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<IEnumerable<Language>> GetLanguageCriterionAsync()
		{
			var binding = new ConstantDataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConstantDataService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetLanguageCriterion>();
			inData.Header = new ConstantDataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConstantDataServiceGetLanguageCriterion();
			var outData = await binding.GetLanguageCriterionAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of all mobile app category criteria.
		///
		/// @return A list of mobile app categories.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<IEnumerable<MobileAppCategory>> GetMobileAppCategoryCriterionAsync()
		{
			var binding = new ConstantDataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConstantDataService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetMobileAppCategoryCriterion>();
			inData.Header = new ConstantDataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConstantDataServiceGetMobileAppCategoryCriterion();
			var outData = await binding.GetMobileAppCategoryCriterionAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of all mobile devices.
		///
		/// @return A list of mobile devices.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<IEnumerable<MobileDevice>> GetMobileDeviceCriterionAsync()
		{
			var binding = new ConstantDataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConstantDataService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetMobileDeviceCriterion>();
			inData.Header = new ConstantDataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConstantDataServiceGetMobileDeviceCriterion();
			var outData = await binding.GetMobileDeviceCriterionAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of all operating system version criteria.
		///
		/// @return A list of operating system versions.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<IEnumerable<OperatingSystemVersion>> GetOperatingSystemVersionCriterionAsync()
		{
			var binding = new ConstantDataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConstantDataService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetOperatingSystemVersionCriterion>();
			inData.Header = new ConstantDataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConstantDataServiceGetOperatingSystemVersionCriterion();
			var outData = await binding.GetOperatingSystemVersionCriterionAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of shopping bidding categories.
		///
		/// A country predicate must be included in the selector, only {@link Predicate.Operator#EQUALS}
		/// and {@link Predicate.Operator#IN} with a single value are supported in the country predicate.
		/// An empty parentDimensionType predicate will filter for root categories.
		///
		/// @return A list of shopping bidding categories.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<IEnumerable<ProductBiddingCategoryData>> GetProductBiddingCategoryDataAsync(Selector selector)
		{
			var binding = new ConstantDataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConstantDataService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetProductBiddingCategoryData>();
			inData.Header = new ConstantDataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConstantDataServiceGetProductBiddingCategoryData();
			inData.Body.Selector = selector;
			var outData = await binding.GetProductBiddingCategoryDataAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of user interests.
		///
		/// @param userInterestTaxonomyType The type of taxonomy to use when requesting user interests.
		/// @return A list of user interests.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<IEnumerable<CriterionUserInterest>> GetUserInterestCriterionAsync(ConstantDataServiceUserInterestTaxonomyType? userInterestTaxonomyType)
		{
			var binding = new ConstantDataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConstantDataService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetUserInterestCriterion>();
			inData.Header = new ConstantDataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConstantDataServiceGetUserInterestCriterion();
			inData.Body.UserInterestTaxonomyType = userInterestTaxonomyType;
			var outData = await binding.GetUserInterestCriterionAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns a list of content verticals.
		///
		/// @return A list of verticals.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		public async Task<IEnumerable<Vertical>> GetVerticalCriterionAsync()
		{
			var binding = new ConstantDataServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ConstantDataService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetVerticalCriterion>();
			inData.Header = new ConstantDataServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ConstantDataServiceGetVerticalCriterion();
			var outData = await binding.GetVerticalCriterionAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(ConstantDataServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
