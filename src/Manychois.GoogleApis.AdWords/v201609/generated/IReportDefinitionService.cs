using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// <p><b>Note:</b> As of v201109 this service is read-only. New report
	/// definitions are no longer allowed.</p>
	/// <p>A report definition describes the report type, date range, and
	/// {@linkplain Selector fields to include in the report}. Additionally, you can
	/// specify {@linkplain Predicate predicates} to filter which rows are returned
	/// in a generated report. Please note that sorting and paging are not supported for report
	/// downloads.</p>
	///
	/// <p>To find out which report fields are available based on report
	/// type, see the <a href="/adwords/api/docs/appendix/reports">Report
	/// Types</a> appendix or call {@link #getReportFields}.</p>
	///
	/// <p>For more information about retrieving reports, see
	/// <a href="/adwords/api/docs/guides/reporting">Reporting Basics</a>.
	/// </summary>
	public interface IReportDefinitionService
	{
		/// <summary>
		/// Returns the available report fields for a given report type.
		/// When using this method the {@code clientCustomerId} header field is
		/// optional. Callers are discouraged from setting the clientCustomerId
		/// header field in calls to this method as its presence will trigger an
		/// authorization error if the caller does not have access to the customer
		/// with the included ID.
		///
		/// @param reportType The type of report.
		/// @return The list of available report fields. Each
		/// {@link ReportDefinitionField} encapsulates the field name, the
		/// field data type, and the enum values (if the field's type is
		/// {@code enum}).
		/// @throws ApiException if a problem occurred while fetching the
		/// ReportDefinitionField information.
		/// </summary>
		Task<IEnumerable<ReportDefinitionField>> GetReportFieldsAsync(ReportDefinitionReportType? ReportType);
	}
}
