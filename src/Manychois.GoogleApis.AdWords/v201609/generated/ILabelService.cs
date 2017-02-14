using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to manage labels. The light weight label, once created, can be attached
	/// to campaign management entities such as campaigns, ad groups, creatives, criterion and etc.
	/// </summary>
	public interface ILabelService
	{
		/// <summary>
		/// Returns a list of {@link Label}s.
		///
		/// @param serviceSelector The selector specifying the {@link Label}s to return.
		/// @return The page containing the {@link Label}s which meet the criteria specified by the
		/// selector.
		/// @throws ApiException when there is at least one error with the request
		/// </summary>
		Task<LabelPage> GetAsync(Selector serviceSelector);
		/// <summary>
		/// Applies the list of mutate operations.
		///
		/// @param operations The operations to apply. The same {@link Label} cannot be specified in
		/// more than one operation.
		/// @return The applied {@link Label}s.
		/// @throws ApiException when there is at least one error with the request
		/// </summary>
		Task<LabelReturnValue> MutateAsync(IEnumerable<LabelOperation> operations);
		/// <summary>
		/// Returns the list of {@link Label}s that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @returns  The page containing the {@link Label}s which match the query.
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		Task<LabelPage> QueryAsync(string query);
	}
}
