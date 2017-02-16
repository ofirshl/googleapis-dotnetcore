using Manychois.GoogleApis.AdWords.v201609;
using Manychois.GoogleApis.OAuth2;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.Examples
{
	public class Program
	{
		public static void Main(string[] args)
		{
			NLog.LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(
				Path.Combine(Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.ApplicationBasePath, "NLog.config"), false);
			var loggerFactory = new LoggerFactory();
			loggerFactory.AddNLog();

			var program = new Program(loggerFactory);
			program.RunAsync(new NetUtility(), loggerFactory).Wait();
		}

		private readonly ILogger _logger;

		public Program(ILoggerFactory loggerFactory)
		{
			_logger = loggerFactory.CreateLogger<Program>();
		}

		async Task RunAsync(INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			try
			{
				var credential = InstalledAppCredential.ReadFromFile("Path of your json file downloaded from your Google API Console");
				var oauth2Util = new OAuth2Utility(netUtil);
				var tokenInfo = await oauth2Util.GetTokenInfoAsync(credential, "refreshToken"); // assume you have already obtained your refresh token

				var adWordsApiConfig = new AdWordsApiConfig();
				adWordsApiConfig.AccessToken = tokenInfo.AccessToken;
				adWordsApiConfig.ClientCustomerId = "Your client customer ID";
				adWordsApiConfig.DeveloperToken = "Developer token";
				adWordsApiConfig.UserAgent = "Testing example"; // this and the rest of the properties are optional

				// An example of using some AdWords service
				ICampaignService campaignService = new CampaignService(adWordsApiConfig, netUtil, loggerFactory); // loggerFactory can be null
				var selector = new Selector<CampaignServiceField>()
					.AddFields(CampaignServiceField.Id, CampaignServiceField.Name)
					.AddPredicate(CampaignServiceField.Status, PredicateOperator.Equals, CampaignStatus.Enabled.ToXmlValue());
				var campaignPage = await campaignService.GetAsync(selector);

				// An example of getting AdWords report
				IReportUtility reportUtil = new ReportUtility(adWordsApiConfig, netUtil, loggerFactory); // loggerFactory can be null
				var rptDef = new ReportDefinition();
				rptDef.DateRangeType = ReportDefinitionDateRangeType.AllTime;
				rptDef.DownloadFormat = DownloadFormat.GzippedCsv;
				rptDef.ReportName = "Testing Report";
				rptDef.ReportType = ReportDefinitionReportType.CampaignPerformanceReport;
				rptDef.Selector = new Selector
				{
					Fields = new List<string>()
				};
				rptDef.Selector.Fields.AddRange(new string[] { "CampaignId", "CampaignName", "Impressions" });
				var reportCsv = await reportUtil.GetContentStringAsync(rptDef);				
			}
			catch (Exception ex)
			{
				_logger.LogError("{0}: {1}{2}{3}", ex.GetType().Name, ex.Message, Environment.NewLine, ex.StackTrace);
			}
		}
	}
}
