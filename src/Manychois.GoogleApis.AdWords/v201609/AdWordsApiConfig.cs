using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class AdWordsApiConfig
	{
		public AdWordsApiConfig()
		{
			EnableGzipCompression = true;
		}

		public string AccessToken { get; set; }
		public string ClientCustomerId { get; set; }
		public string DeveloperToken { get; set; }
		public bool? PartialFailure { get; set; }
		public int Timeout { get; set; }
		public string UserAgent { get; set; }
		public bool? ValidateOnly { get; set; }

		public bool EnableGzipCompression { get; set; }
		public bool SkipReportHeader { get; set; }

		public bool SkipColumnHeader { get; set; }

		public bool SkipReportSummary { get; set; }

		public bool UseRawEnumValues { get; set; }

		public bool IncludeZeroImpressions { get; set; }
	}
}
