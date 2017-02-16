using Manychois.GoogleApis.AdWords.v201609;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Manychois.GoogleApis.Tests.AdWords
{
	public class ReportUtilityTest : BaseServiceTest
	{
		public ReportUtilityTest(ITestOutputHelper output) : base(output)
		{
		}

		protected IReportUtility CreateReportUtility()
		{
			return CreateService<IReportUtility>((x, y, z) => new ReportUtility(x, y, z));
		}

		[Fact]
		public async Task TestGetContentStringAsyncByReportDefinition_PlainCsv_Passed()
		{
			var reportUtil = CreateReportUtility();
			var rptDef = new ReportDefinition();
			rptDef.DateRangeType = ReportDefinitionDateRangeType.AllTime;
			rptDef.DownloadFormat = DownloadFormat.Csv;
			rptDef.ReportName = "TestGetContentStringAsyncByReportDefinition";
			rptDef.ReportType = ReportDefinitionReportType.CampaignPerformanceReport;
			rptDef.Selector = new Selector();
			rptDef.Selector.Fields = new List<string>();
			rptDef.Selector.Fields.AddRange(new string[] { "CampaignId", "CampaignName", "Impressions" });

			var reportContent = await reportUtil.GetContentStringAsync(rptDef);
			var lines = reportContent.Split('\n');

			int i = 0;
			Assert.Equal("TestGetContentStringAsyncByReportDefinition (All Time)", lines[i++]);
			Assert.Equal("Campaign ID,Campaign,Impressions", lines[i++]);
			Assert.Equal('0', lines[i++].Last());
			Assert.Equal("Total, --,0", lines[i++]);
			Assert.Equal("", lines[i++]); // there is always an empty line at last
		}

		[Fact]
		public async Task TestGetContentStringAsyncByAwql_GzippedXml_Passed()
		{
			var reportUtil = CreateReportUtility();
			string awql = @"SELECT CampaignId, AdGroupId, Impressions
FROM ADGROUP_PERFORMANCE_REPORT
WHERE AdGroupStatus IN[ENABLED, PAUSED]";
			var reportContent = await reportUtil.GetContentStringAsync(awql, DownloadFormat.GzippedXml);
			var xDoc = XDocument.Parse(reportContent);
			var xRoot = xDoc.Root;
			Assert.Equal("report", xRoot.Name.LocalName);
			Assert.Equal("ADGROUP_PERFORMANCE_REPORT", xRoot.Element("report-name").Attribute("name").Value);
			Assert.Equal("All Time", xRoot.Element("date-range").Attribute("date").Value);
			var xTable = xRoot.Element("table");
			var xColumns = xTable.Element("columns").Elements("column").ToList();
			Assert.Equal("campaignID", xColumns[0].Attribute("name").Value);
			Assert.Equal("adGroupID", xColumns[1].Attribute("name").Value);
			Assert.Equal("impressions", xColumns[2].Attribute("name").Value);
			var xRow = xTable.Element("row");
			Assert.False(string.IsNullOrEmpty(xRow.Attribute("campaignID").Value));
			Assert.False(string.IsNullOrEmpty(xRow.Attribute("adGroupID").Value));
			Assert.Equal("0", xRow.Attribute("impressions").Value);
		}
	}
}
