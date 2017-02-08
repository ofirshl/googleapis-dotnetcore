using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Manychois.GoogleApis.OAuth2;
using Xunit;
using System.Text;

namespace Manychois.GoogleApis.Tests.OAuth2
{
	public class OAuth2UtilityTest
	{
		[Fact]
		public void TestGetAuthorizationCodeRequestUrl_StandardSettings_Passed()
		{
			var credential = new TestCredential();
			var trSettings = new OAuth2TokenRequestSettings();
			trSettings.RedirectUri = credential.RedirectUrls[0];
			trSettings.Scopes.Add("test-scope1");
			trSettings.Scopes.Add("test-scope2");
			trSettings.State = "state999";

			var oauth2 = new OAuth2Utility(new DummyNetUtility());
			string url = oauth2.GetAuthorizationCodeRequestUrl(credential, trSettings);
			string expected = "https://accounts.google.com/o/oauth2/v2/auth?response_type=code&client_id=test-client-id&redirect_uri=http%3A%2F%2Flocalhost%3A1234&scope=test-scope1%20test-scope2&state=state999";
			Assert.Equal(expected, url);
		}

		[Fact]
		public void TestGetAuthorizationCodeRequestUrl_AllSettingsUsed_Passed()
		{
			var credential = new TestCredential();
			var trSettings = new OAuth2TokenRequestSettings();
			trSettings.IncludeGrantedScopes = true;
			trSettings.IsOnlineAccess = false;
			trSettings.LoginHint = "someone@gmail.com";
			trSettings.Prompts.Add(OAuth2TokenRequestPrompt.Consent);
			trSettings.Prompts.Add(OAuth2TokenRequestPrompt.SelectAccount);
			trSettings.RedirectUri = credential.RedirectUrls[0];
			trSettings.Scopes.Add("test-scope");
			trSettings.State = "state999";
			trSettings.IsOnlineAccess = false;
			trSettings.IncludeGrantedScopes = true;

			var oauth2 = new OAuth2Utility(new DummyNetUtility());
			string url = oauth2.GetAuthorizationCodeRequestUrl(credential, trSettings);
			string expected = "https://accounts.google.com/o/oauth2/v2/auth?response_type=code&client_id=test-client-id&redirect_uri=http%3A%2F%2Flocalhost%3A1234&scope=test-scope&state=state999&access_type=offline&prompt=consent%20select_account&login_hint=someone@gmail.com&include_granted_scopes=true";
			Assert.Equal(expected, url);
		}

		[Fact]
		public async Task TestGetTokenInfoAsync_ByRefreshToken_Passed()
		{
			var credential = new TestCredential();
			string refreshToken = "refreshToken";

			var net = new DummyNetUtility();
			var response = new DummyHttpWebResponse(HttpStatusCode.OK, @"{
""access_token"": ""accessToken"",
""expires_in"": 123
}");
			net.AddResponse(response);
			var utility = new OAuth2Utility(net);
			DateTime timeBefore = DateTime.UtcNow;
			var tokenInfo = await utility.GetTokenInfoAsync(credential, refreshToken);
			DateTime timeAfter = DateTime.UtcNow;

			Assert.Equal("accessToken",tokenInfo.AccessToken);
			Assert.Equal(123, tokenInfo.ExpiresIn);
			Assert.True(timeBefore <= tokenInfo.IssuedTime && tokenInfo.IssuedTime <= timeAfter, $"Expect {timeBefore} <= Issued Time {tokenInfo.IssuedTime} <= {timeAfter}");
		}

		private class TestCredential : OAuth2Credential
		{
			public TestCredential()
			{
				AppType = OAuth2CredentialType.InstalledApp;
				ClientId = "test-client-id";
				ProjectId = "test-project-id";
				ClientSecret = "client-secret";
				RedirectUrls = new string[] { "http://localhost:1234" };
			}
		}

		private class DummyNetUtility : NetUtility
		{
			private List<DummyHttpWebRequest> _requests = new List<DummyHttpWebRequest>();
			private List<DummyHttpWebResponse> _responses = new List<DummyHttpWebResponse>();
			public override IHttpWebRequest CreateHttp(string url)
			{
				var request = new DummyHttpWebRequest(this, url);
				_requests.Add(request);
				return request;
			}

			public void AddResponse(DummyHttpWebResponse response)
			{
				_responses.Add(response);
			}

			public DummyHttpWebRequest GetRequestAt(int index)
			{
				return _requests[index];
			}

			public DummyHttpWebResponse GetResponse(DummyHttpWebRequest request)
			{
				var index = _requests.IndexOf(request);
				return _responses[index];
			}
		}

		private class DummyHttpWebRequest : IHttpWebRequest
		{
			private MemoryStream _stream;
			private DummyNetUtility _net;
			public DummyHttpWebRequest(DummyNetUtility net, string url)
			{
				_stream = new MemoryStream();
				_net = net;
				Headers = new WebHeaderCollection();
				RequestUri = new Uri(url);
			}

			public string Accept { get; set; }

			public string ContentType { get; set; }

			public WebHeaderCollection Headers { get; private set; }

			public string Method { get; set; }

			public Task<Stream> GetRequestStreamAsync()
			{
				return Task.FromResult<Stream>(_stream);
			}

			public Task<IHttpWebResponse> GetResponseAsync()
			{
				return Task.FromResult<IHttpWebResponse>(_net.GetResponse(this));
			}

			public Uri RequestUri { get; private set; }
		}

		private class DummyHttpWebResponse : IHttpWebResponse
		{
			private WebHeaderCollection _headers = new WebHeaderCollection();
			private byte[] _content;

			public DummyHttpWebResponse(HttpStatusCode statusCode, string content)
			{
				StatusCode = statusCode;
				_content = Encoding.UTF8.GetBytes(content);
			}


			public WebHeaderCollection Headers { get { return _headers; } }

			public HttpStatusCode StatusCode { get; private set; }

			public void Dispose() { }

			public Stream GetResponseStream()
			{
				return new MemoryStream(_content);
			}
		}
	}
}
