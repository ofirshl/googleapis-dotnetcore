using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.OAuth2
{
	public class WebAppCredential : OAuth2Credential
	{
		public static WebAppCredential ReadFromFile(string path)
		{
			var json = File.ReadAllText(path);
			var credential = JsonConvert.DeserializeObject<CredentialJson>(json);
			var web = new WebAppCredential();
			web.ClientId = credential.web.client_id;
			web.ProjectId = credential.web.project_id;
			web.AuthUri = credential.web.auth_uri;
			web.TokenUri = credential.web.token_uri;
			web.AuthProviderX509CertUrl = credential.web.auth_provider_x509_cert_url;
			web.ClientSecret = credential.web.client_secret;
			web.RedirectUrls = credential.web.redirect_uris;
			web.JavaScriptOrigins = credential.web.javascript_origins;
			return web;
		}
		private WebAppCredential()
		{
			AppType = OAuth2CredentialType.WebApp;
		}

		public string[] JavaScriptOrigins { get; protected set; }

		private class CredentialJson
		{
			public WebJson web { get; set; }
		}
		private class WebJson
		{
			public string client_id { get; set; }
			public string project_id { get; set; }
			public string auth_uri { get; set; }
			public string token_uri { get; set; }
			public string auth_provider_x509_cert_url { get; set; }
			public string client_secret { get; set; }
			public string[] redirect_uris { get; set; }
			public string[] javascript_origins { get; set; }
		}
	}
}
