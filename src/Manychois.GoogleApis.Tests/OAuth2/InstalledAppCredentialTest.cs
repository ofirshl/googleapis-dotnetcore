using Manychois.GoogleApis.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Manychois.GoogleApis.Tests.OAuth2
{
	public class InstalledAppCredentialTest
	{
		[Fact]
		public void TestReadFromFile()
		{
			var credential = InstalledAppCredential.ReadFromFile(@"OAuth2\sample-installed-app.json");
			Assert.Equal(OAuth2CredentialType.InstalledApp, credential.AppType);
			Assert.Equal("123-abcde.apps.googleusercontent.com", credential.ClientId);
			Assert.Equal("manychois-googleapis", credential.ProjectId);
			Assert.Equal("https://accounts.google.com/o/oauth2/auth", credential.AuthUri);
			Assert.Equal("https://accounts.google.com/o/oauth2/token", credential.TokenUri);
			Assert.Equal("https://www.googleapis.com/oauth2/v1/certs", credential.AuthProviderX509CertUrl);
			Assert.Equal("12345abcde", credential.ClientSecret);
			Assert.Equal(new string[] { "urn:ietf:wg:oauth:2.0:oob" , "http://localhost"}, credential.RedirectUrls);
		}
	}
}
