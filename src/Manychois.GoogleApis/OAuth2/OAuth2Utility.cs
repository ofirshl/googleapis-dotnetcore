using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.OAuth2
{
	public static class OAuth2Utility
	{
		public static readonly string AuthorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";
		public static readonly string TokenEndpoint = "https://www.googleapis.com/oauth2/v4/token";
		public static string GetAuthorizationCodeRequestUrl(OAuth2Credential credential, OAuth2TokenRequestSettings requestSettings)
		{
			if (credential == null) throw new ArgumentNullException(nameof(credential));
			if (requestSettings == null) throw new ArgumentNullException(nameof(requestSettings));
			if (!credential.RedirectUrls.Contains(requestSettings.RedirectUri)) throw new ArgumentException("RedirectUri must match one of the values in credential.RedirectUrls", nameof(requestSettings));

			var queryParams = new Dictionary<string, string>();
			queryParams.Add("response_type", "code");
			queryParams.Add("client_id", credential.ClientId);
			queryParams.Add("redirect_uri", requestSettings.RedirectUri);
			queryParams.Add("scope", string.Join(" ", requestSettings.Scopes));
			queryParams.Add("state", requestSettings.State);
			queryParams.Add("access_type", requestSettings.IsOnlineAccess ? "online" : "offline");
			if (requestSettings.Prompts.Count > 0)
			{
				if (requestSettings.Prompts.Contains(OAuth2TokenRequestPrompt.None))
				{
					queryParams.Add("prompt", "none");
				}
				else
				{
					var prompts = new List<string>();
					foreach (var prompt in requestSettings.Prompts)
					{
						switch (prompt)
						{
							case OAuth2TokenRequestPrompt.Consent: prompts.Add("consent"); break;
							case OAuth2TokenRequestPrompt.SelectAccount: prompts.Add("select_account"); break;
						}
					}
					queryParams.Add("prompt", string.Join(" ", prompts));
				}
			}
			if (!string.IsNullOrEmpty(requestSettings.LoginHint))
				queryParams.Add("login_hint", requestSettings.LoginHint);
			if (requestSettings.IncludeGrantedScopes)
				queryParams.Add("include_granted_scopes", "true");

			string queryString = NetUtility.GetQueryString(queryParams);
			return $"{AuthorizationEndpoint}?{queryString}";
		}

		public static async Task<OAuth2TokenInfo> GetTokenInfoAsync(OAuth2Credential credential, string redirectUri, string authorizationCode)
		{
			var queryParams = new Dictionary<string, string>();
			queryParams.Add("code", authorizationCode);
			queryParams.Add("client_id", credential.ClientId);
			queryParams.Add("client_secret", credential.ClientSecret);
			queryParams.Add("redirect_uri", redirectUri);
			queryParams.Add("grant_type", "authorization_code");
			var queryString = NetUtility.GetQueryString(queryParams);

			var request = WebRequest.CreateHttp(TokenEndpoint);
			request.Method = "POST";
			request.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
			request.Headers[HttpRequestHeader.ContentLength] = Encoding.UTF8.GetByteCount(queryString).ToString();
			using (var stream = await request.GetRequestStreamAsync().ConfigureAwait(false))
			using (var writer = new StreamWriter(stream))
			{
				await writer.WriteAsync(queryString).ConfigureAwait(false);
			}

			DateTime issuedTime = DateTime.UtcNow;
			var response = await NetUtility.GetSafeResponseAsync(request).ConfigureAwait(false);
			var jsonContent = await NetUtility.GetResponseTextAsync(response).ConfigureAwait(false);
			if (response.StatusCode == HttpStatusCode.OK)
			{
				var tokenInfo = OAuth2TokenInfo.CreateFromJson(jsonContent);
				tokenInfo.IssuedTime = issuedTime;
				return tokenInfo;
			}
			else
			{
				throw new WebException(jsonContent, WebExceptionStatus.ReceiveFailure);
			}
		}

		public static async Task<OAuth2TokenInfo> GetTokenInfoAsync(OAuth2Credential credential, string refreshToken)
		{
			var queryParams = new Dictionary<string, string>();
			queryParams.Add("refresh_token", refreshToken);
			queryParams.Add("client_id", credential.ClientId);
			queryParams.Add("client_secret", credential.ClientSecret);
			queryParams.Add("grant_type", "refresh_token");
			var queryString = NetUtility.GetQueryString(queryParams);

			var request = WebRequest.CreateHttp(TokenEndpoint);
			request.Method = "POST";
			request.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
			request.Headers[HttpRequestHeader.ContentLength] = Encoding.UTF8.GetByteCount(queryString).ToString();
			using (var stream = await request.GetRequestStreamAsync().ConfigureAwait(false))
			using (var writer = new StreamWriter(stream))
			{
				await writer.WriteAsync(queryString).ConfigureAwait(false);
			}

			DateTime issuedTime = DateTime.UtcNow;
			var response = await NetUtility.GetSafeResponseAsync(request).ConfigureAwait(false);
			var jsonContent = await NetUtility.GetResponseTextAsync(response).ConfigureAwait(false);
			if (response.StatusCode == HttpStatusCode.OK)
			{
				var tokenInfo = OAuth2TokenInfo.CreateFromJson(jsonContent);
				tokenInfo.IssuedTime = issuedTime;
				return tokenInfo;
			}
			else
			{
				throw new WebException(jsonContent, WebExceptionStatus.ReceiveFailure);
			}
		}
	}
}
