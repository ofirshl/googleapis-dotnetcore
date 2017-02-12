using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class TargetingIdeaService : ITargetingIdeaService
	{
		public AdWordsApiConfig Config { get; }
		public TargetingIdeaService(AdWordsApiConfig config)
		{
			Config = config;
		}
		/// <summary>
		/// Returns a page of ideas that match the query described by the specified
		/// {@link TargetingIdeaSelector}.
		///
		/// <p>The selector must specify a {@code paging} value, with {@code numberResults} set to 800 or
		/// less.  Large result sets must be composed through multiple calls to this method, advancing the
		/// paging {@code startIndex} value by {@code numberResults} with each call.</p>
		///
		/// @param selector Query describing the types of results to return when
		/// finding matches (similar keyword ideas).
		/// @return A {@link TargetingIdeaPage} of results, that is a subset of the
		/// list of possible ideas meeting the criteria of the
		/// {@link TargetingIdeaSelector}.
		/// @throws ApiException If problems occurred while querying for ideas.
		/// </summary>
		public async Task<TargetingIdeaPage> GetAsync(TargetingIdeaSelector selector)
		{
			var binding = new TargetingIdeaServiceSoapBinding("https://adwords.google.com/api/adwords/o/v201609/TargetingIdeaService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<TargetingIdeaServiceRequestHeader, TargetingIdeaServiceGet>();
			inData.Header = new TargetingIdeaServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new TargetingIdeaServiceGet();
			inData.Body.Selector = selector;
			var outData = await binding.GetAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(TargetingIdeaServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
