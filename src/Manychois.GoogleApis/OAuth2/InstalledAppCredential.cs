using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.OAuth2
{
	public class InstalledAppCredential : OAuth2Credential
	{
		public static InstalledAppCredential ReadFromFile(string path)
		{
			var json = File.ReadAllText(path);
			var credential = JsonConvert.DeserializeObject<CredentialJson>(json);
			var installed = new InstalledAppCredential();
			installed.ClientId = credential.installed.client_id;
			installed.ProjectId = credential.installed.project_id;
			installed.AuthUri = credential.installed.auth_uri;
			installed.TokenUri = credential.installed.token_uri;
			installed.AuthProviderX509CertUrl = credential.installed.auth_provider_x509_cert_url;
			installed.ClientSecret = credential.installed.client_secret;
			installed.RedirectUrls = credential.installed.redirect_uris;
			return installed;
		}

		private InstalledAppCredential()
		{
			AppType = OAuth2CredentialType.InstalledApp;
		}

		private class CredentialJson
		{
			public InstalledJson installed { get; set; }
		}
		private class InstalledJson
		{
			public string client_id { get; set; }
			public string project_id { get; set; }
			public string auth_uri { get; set; }
			public string token_uri { get; set; }
			public string auth_provider_x509_cert_url { get; set; }
			public string client_secret { get; set; }
			public string[] redirect_uris { get; set; }
		}
	}

}
