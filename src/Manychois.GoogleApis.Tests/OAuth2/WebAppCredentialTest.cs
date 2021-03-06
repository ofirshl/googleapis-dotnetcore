﻿using Manychois.GoogleApis.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Manychois.GoogleApis.Tests.OAuth2
{
	public class WebAppCredentialTest
	{
		[Fact]
		public void TestReadFromFile()
		{
			var credential = WebAppCredential.ReadFromFile(@"OAuth2\sample-web-app.json");
			Assert.Equal(OAuth2CredentialType.WebApp, credential.AppType);
			Assert.Equal("246-qwert.apps.googleusercontent.com", credential.ClientId);
			Assert.Equal("manychois-googleapis", credential.ProjectId);
			Assert.Equal("https://accounts.google.com/o/oauth2/auth", credential.AuthUri);
			Assert.Equal("https://accounts.google.com/o/oauth2/token", credential.TokenUri);
			Assert.Equal("https://www.googleapis.com/oauth2/v1/certs", credential.AuthProviderX509CertUrl);
			Assert.Equal("abcde12345", credential.ClientSecret);
			Assert.Equal(new string[] { "http://localhost/oauth2callback" }, credential.RedirectUrls);
			Assert.Equal(new string[] { "http://localhost" }, credential.JavaScriptOrigins);
		}
	}
}
