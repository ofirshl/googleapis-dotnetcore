using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public interface IReportUtility
	{
		Task<string> GetContentStringAsync(ReportDefinition definition);
	}
}
