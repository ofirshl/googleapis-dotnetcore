using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AdwordsUserListService : IAdwordsUserListService
	{
		public AdWordsApiConfig Config { get; }
		public AdwordsUserListService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns the list of user lists that meet the selector criteria.
		///
		/// @param serviceSelector the selector specifying the {@link UserList}s to return.
		/// @return a list of UserList entities which meet the selector criteria.
		/// @throws ApiException if problems occurred while fetching UserList information.
		/// </summary>
		public async Task<UserListPage> GetAsync(Selector serviceSelector)
		{
			var binding = new AdwordsUserListServiceSoapBinding("https://adwords.google.com/api/adwords/rm/v201609/AdwordsUserListService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdwordsUserListServiceRequestHeader, AdwordsUserListServiceGet>();
			inData.Header = new AdwordsUserListServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdwordsUserListServiceGet();
			inData.Body.ServiceSelector = serviceSelector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
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
		public async Task<UserListReturnValue> MutateAsync(IEnumerable<UserListOperation> operations)
		{
			var binding = new AdwordsUserListServiceSoapBinding("https://adwords.google.com/api/adwords/rm/v201609/AdwordsUserListService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdwordsUserListServiceRequestHeader, AdwordsUserListServiceMutate>();
			inData.Header = new AdwordsUserListServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdwordsUserListServiceMutate();
			inData.Body.Operations = new List<UserListOperation>(operations);
			var outData = await binding.MutateAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
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
		public async Task<MutateMembersReturnValue> MutateMembersAsync(IEnumerable<MutateMembersOperation> operations)
		{
			var binding = new AdwordsUserListServiceSoapBinding("https://adwords.google.com/api/adwords/rm/v201609/AdwordsUserListService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdwordsUserListServiceRequestHeader, AdwordsUserListServiceMutateMembers>();
			inData.Header = new AdwordsUserListServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdwordsUserListServiceMutateMembers();
			inData.Body.Operations = new List<MutateMembersOperation>(operations);
			var outData = await binding.MutateMembersAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		/// <summary>
		/// Returns the list of user lists that match the query.
		///
		/// @param query The SQL-like AWQL query string
		/// @return A list of UserList
		/// @throws ApiException when the query is invalid or there are errors processing the request.
		/// </summary>
		public async Task<UserListPage> QueryAsync(string query)
		{
			var binding = new AdwordsUserListServiceSoapBinding("https://adwords.google.com/api/adwords/rm/v201609/AdwordsUserListService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<AdwordsUserListServiceRequestHeader, AdwordsUserListServiceQuery>();
			inData.Header = new AdwordsUserListServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new AdwordsUserListServiceQuery();
			inData.Body.Query = query;
			var outData = await binding.QueryAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(AdwordsUserListServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
