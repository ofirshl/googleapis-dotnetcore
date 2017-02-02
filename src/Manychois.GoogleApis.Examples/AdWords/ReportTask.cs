using Manychois.GoogleApis.AdWords.v201609;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.Examples.AdWords
{
	public class ReportTask
	{
		public async Task<string> GetGzippedXmlContentAsync(AdWordsApiConfig config)
		{
			var definition = new ReportDefinition();
			definition.DateRangeType = ReportDefinitionDateRangeType.AllTime;
			definition.DownloadFormat = DownloadFormat.GzippedXml; // note that value of config.EnableGzipCompression is ignored
			definition.ReportName = "Test Report";
			definition.ReportType = ReportDefinitionReportType.CampaignPerformanceReport;
			definition.Selector = new Selector();
			definition.Selector.Fields = new List<string>();
			definition.Selector.Fields.AddRange(new string[]
			{
				"CampaignId",
				"CampaignName",
				"Impressions",
				"Clicks",
				"HourOfDay"
			});
			definition.Selector.Predicates = new List<Predicate>();
			definition.Selector.Predicates.Add(new Predicate
			{
				Field = "CampaignStatus",
				Operator = PredicateOperator.NotEquals,
				Values = new List<string>(new string[] { CampaignStatus.Removed.ToString().ToUpperInvariant() })
			});

			ReportUtility reportUtil = new ReportUtility(config);
			var content = await reportUtil.GetContentAsync(definition).ConfigureAwait(false);

			return content;
		}
	}
}
