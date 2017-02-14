using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A service to return constant data.
	/// </summary>
	public interface IConstantDataService
	{
		/// <summary>
		/// Returns a list of all age range criteria.
		///
		/// @return A list of age ranges.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<IEnumerable<AgeRange>> GetAgeRangeCriterionAsync();
		/// <summary>
		/// Returns a list of all carrier criteria.
		///
		/// @return A list of carriers.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<IEnumerable<Carrier>> GetCarrierCriterionAsync();
		/// <summary>
		/// Returns a list of all gender criteria.
		///
		/// @return A list of genders.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<IEnumerable<Gender>> GetGenderCriterionAsync();
		/// <summary>
		/// Returns a list of all language criteria.
		///
		/// @return A list of languages.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<IEnumerable<Language>> GetLanguageCriterionAsync();
		/// <summary>
		/// Returns a list of all mobile app category criteria.
		///
		/// @return A list of mobile app categories.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<IEnumerable<MobileAppCategory>> GetMobileAppCategoryCriterionAsync();
		/// <summary>
		/// Returns a list of all mobile devices.
		///
		/// @return A list of mobile devices.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<IEnumerable<MobileDevice>> GetMobileDeviceCriterionAsync();
		/// <summary>
		/// Returns a list of all operating system version criteria.
		///
		/// @return A list of operating system versions.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<IEnumerable<OperatingSystemVersion>> GetOperatingSystemVersionCriterionAsync();
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
		Task<IEnumerable<ProductBiddingCategoryData>> GetProductBiddingCategoryDataAsync(Selector selector);
		/// <summary>
		/// Returns a list of user interests.
		///
		/// @param userInterestTaxonomyType The type of taxonomy to use when requesting user interests.
		/// @return A list of user interests.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<IEnumerable<CriterionUserInterest>> GetUserInterestCriterionAsync(ConstantDataServiceUserInterestTaxonomyType? userInterestTaxonomyType);
		/// <summary>
		/// Returns a list of content verticals.
		///
		/// @return A list of verticals.
		/// @throws ApiException when there is at least one error with the request.
		/// </summary>
		Task<IEnumerable<Vertical>> GetVerticalCriterionAsync();
	}
}
