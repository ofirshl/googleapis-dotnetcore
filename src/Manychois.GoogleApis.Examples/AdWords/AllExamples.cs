using Manychois.GoogleApis.AdWords.v201609;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.Examples.AdWords
{
	public class AllExamples
	{
		private readonly ILoggerFactory _loggerFactory;
		private readonly ILogger _logger;
		private readonly AdWordsApiConfig _config;
		private readonly long _targetCampaignId;

		public AllExamples(IConfigurationRoot programConfig, ILoggerFactory loggerFactory)
		{
			_loggerFactory = loggerFactory;
			_logger = loggerFactory.CreateLogger<AllExamples>();

			_config = new AdWordsApiConfig();
			var configSection = programConfig.GetSection("adwords");
			_config.AccessToken = configSection["accessToken"];
			_config.ClientCustomerId = configSection["clientCustomerId"];
			_config.DeveloperToken = configSection["developerToken"];
			_config.UserAgent = "Manychois.GoogleApis.Examples.AdWords";

			_targetCampaignId = long.Parse(configSection["campaignId"]);
		}

		public async Task RunAsync()
		{

			// comment out the examples you want to skip

			var campaignServiceTask = new CampaignServiceTask(_loggerFactory);
			_logger.LogInformation("Renaming campaign (ID: {0})", _targetCampaignId);
			var newCampaignName = await campaignServiceTask.ChangeCampaignNameAsync(_config, _targetCampaignId).ConfigureAwait(false);
			_logger.LogInformation("Campaign name is changed to {0}", newCampaignName);

			/*
			var reportTask = new ReportTask();
			_logger.LogInformation("Getting a gzipped Xml report...");
			var content = await reportTask.GetGzippedXmlContentAsync(_config).ConfigureAwait(false);
			_logger.LogInformation("Result:{0}{1}", Environment.NewLine, content);
			*/
		}
	}
}
