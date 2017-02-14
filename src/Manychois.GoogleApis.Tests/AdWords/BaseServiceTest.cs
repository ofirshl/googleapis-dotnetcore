using Manychois.GoogleApis.AdWords.v201609;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using Manychois.GoogleApis.OAuth2;
using Newtonsoft.Json;
using Xunit.Abstractions;

namespace Manychois.GoogleApis.Tests.AdWords
{
	public abstract class BaseServiceTest
	{
		private static ILoggerFactory _loggerFactory = null;
		private static object _lock = new object();

		protected readonly ITestOutputHelper _output;

		public BaseServiceTest(ITestOutputHelper output)
		{
			_output = output;
		}

		protected T CreateService<T>(Func<AdWordsApiConfig, INetUtility, ILoggerFactory, T> constructor, bool useManagerId = false)
		{
			var testConfig = TestConfig.GetFromConfigFile();
			if (IsAccessTokenExpired(testConfig))
			{
				ObtainValidAccessToken(testConfig);
			}
			var adWordsApiConfig = GetAdWordsApiConfig(testConfig);
			if (useManagerId)
			{
				adWordsApiConfig.ClientCustomerId = testConfig.AdWords.ManagerCustomerId;
			}
			var service = constructor(adWordsApiConfig, GetNetUtility(), GetLoggerFactory());
			return service;
		}

		private void ObtainValidAccessToken(TestConfig testConfig)
		{
			lock (_lock)
			{
				if (!IsAccessTokenExpired(testConfig)) return;
				var oauth2Util = new OAuth2Utility(GetNetUtility());
				string fullPath = testConfig.GetFilePath(testConfig.Oauth2.CredentialJsonPath);
				OAuth2Credential credential = InstalledAppCredential.ReadFromFile(fullPath);
				if (credential.ProjectId == null) credential = WebAppCredential.ReadFromFile(fullPath);
				var tokenInfo = oauth2Util.GetTokenInfoAsync(credential, testConfig.Oauth2.RefreshToken).Result;

				testConfig.Oauth2.AccessToken = tokenInfo.AccessToken;
				testConfig.Oauth2.ExpiresIn = tokenInfo.ExpiresIn;
				testConfig.Oauth2.IssuedTime = tokenInfo.IssuedTime.ToUniversalTime().ToString("s", System.Globalization.CultureInfo.InvariantCulture) + "Z";
				testConfig.Save();
			}
		}

		protected bool IsAccessTokenExpired(TestConfig testConfig)
		{
			DateTime issuedUtc = DateTime.UtcNow;
			if (!string.IsNullOrEmpty(testConfig.Oauth2.IssuedTime))
			{
				issuedUtc = DateTime.Parse(testConfig.Oauth2.IssuedTime,
					System.Globalization.CultureInfo.InvariantCulture,
					System.Globalization.DateTimeStyles.AdjustToUniversal | System.Globalization.DateTimeStyles.AssumeUniversal);
			}
			DateTime expiryUtc = issuedUtc.AddSeconds(testConfig.Oauth2.ExpiresIn - 60); // make sure access token is valid for at least 60 seconds.
			return string.IsNullOrEmpty(testConfig.Oauth2.AccessToken) || expiryUtc < DateTime.UtcNow;
		}

		protected AdWordsApiConfig GetAdWordsApiConfig(TestConfig testConfig)
		{
			var config = new AdWordsApiConfig();
			config.AccessToken = testConfig.Oauth2.AccessToken;
			config.ClientCustomerId = testConfig.AdWords.ClientCustomerId;
			config.DeveloperToken = testConfig.AdWords.DeveloperToken;
			config.EnableGzipCompression = true;
			config.IncludeZeroImpressions = false;
			config.PartialFailure = false;
			config.SkipColumnHeader = false;
			config.SkipReportHeader = false;
			config.SkipReportSummary = false;
			config.Timeout = 1000 * 60;
			config.UserAgent = "Manychois.GoogleApis.Tests.AdWords";
			config.UseRawEnumValues = false;
			config.ValidateOnly = false;
			return config;
		}

		protected INetUtility GetNetUtility()
		{
			return new NetUtility();
		}

		protected ILoggerFactory GetLoggerFactory()
		{
			if (_loggerFactory == null)
			{
				lock (_lock)
				{
					if (_loggerFactory == null)
					{
						_loggerFactory = new LoggerFactory().AddXunitLog(_output);
					}
				}
			}
			return _loggerFactory;
		}
	}
}
