using Manychois.GoogleApis.AdWords.v201609;
using Manychois.GoogleApis.OAuth2;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.Examples.OAuth2
{
	public class AllExamples
	{
		private readonly IConfigurationRoot _programConfig;
		private readonly ILoggerFactory _loggerFactory;
		private readonly ILogger _logger;

		public AllExamples(IConfigurationRoot programConfig, ILoggerFactory loggerFactory)
		{
			_programConfig = programConfig;
			_loggerFactory = loggerFactory;
			_logger = loggerFactory.CreateLogger("OAuth2");
		}

		public async Task RunAsync()
		{
			var apiConfig = new AdWordsApiConfig(_loggerFactory);
			var configSection = _programConfig.GetSection("oauth2");
			string credentialJsonPath = configSection["credentialJsonPath"];
			string refreshToken = configSection["refreshToken"];

			// comment out the examples you want to skip
			await GetNewAccessTokenAsync(credentialJsonPath, refreshToken).ConfigureAwait(false);
		}

		public async Task GetNewAccessTokenAsync(string credentialJsonPath, string refreshToken)
		{
			_logger.LogInformation("Getting new access token...");

			OAuth2Credential credential = InstalledAppCredential.ReadFromFile(credentialJsonPath);
			if (credential.ClientId == null) credential = WebAppCredential.ReadFromFile(credentialJsonPath);

			var tokenInfo = await OAuth2Utility.GetTokenInfoAsync(credential, refreshToken).ConfigureAwait(false);

			_logger.LogInformation("New access token: {0}", tokenInfo.AccessToken);
		}
	}
}
