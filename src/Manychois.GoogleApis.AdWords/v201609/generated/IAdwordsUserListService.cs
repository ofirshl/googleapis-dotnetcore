using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Service which is used to manage user lists.
	/// </summary>
	public interface IAdwordsUserListService
	{
		/// <summary>
		/// Returns the list of user lists that meet the selector criteria.
		///
		/// @param serviceSelector the selector specifying the {@link UserList}s to return.
		/// @return a list of UserList entities which meet the selector criteria.
		/// @throws ApiException if problems occurred while fetching UserList information.
		/// </summary>
		Task<UserListPage> GetAsync(Selector serviceSelector);
		/// <summary>
		/// Applies a list of mutate operations (i.e. add, set):
		///
		/// Add - creates a set of user lists
		/// Set - updates a set of user lists
		/// Remove - not supported
		///
		/// @param operations the operations to apply
		/// @return a list of UserList objects
		/// </summary>
		Task<UserListReturnValue> MutateAsync(IEnumerable<UserListOperation> operations);
		/// <summary>
		/// Mutate members of user lists by either adding or removing their lists of members.
		/// The following {@link Operator}s are supported: ADD and REMOVE.
		///
		/// <p>Note that operations cannot have same user list id but different operators.
		///
		/// @param operations the mutate members operations to apply
		/// @return a list of UserList objects
		/// @throws ApiException when there are one or more errors with the request
		/// </summary>
		Task<MutateMembersReturnValue> MutateMembersAsync(IEnumerable<MutateMembersOperation> operations);
		/// <summary>
		/// Returns the list of user lists that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @return A list of UserList
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		Task<UserListPage> QueryAsync(string query);
	}
}
