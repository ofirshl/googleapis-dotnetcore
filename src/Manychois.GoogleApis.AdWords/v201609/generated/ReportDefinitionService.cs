using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class ReportDefinitionService : IReportDefinitionService
	{
		public AdWordsApiConfig Config { get; }
		public ReportDefinitionService(AdWordsApiConfig config)
		{
			Config = config;
		}
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
		public async Task<IEnumerable<ReportDefinitionField>> GetReportFieldsAsync(ReportDefinitionReportType? reportType)
		{
			var binding = new ReportDefinitionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ReportDefinitionService", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);
			var inData = new SoapData<ReportDefinitionServiceRequestHeader, ReportDefinitionServiceGetReportFields>();
			inData.Header = new ReportDefinitionServiceRequestHeader();
			AssignHeaderValues(inData.Header);
			inData.Body = new ReportDefinitionServiceGetReportFields();
			inData.Body.ReportType = reportType;
			var outData = await binding.GetReportFieldsAsync(inData).ConfigureAwait(false);
			return outData.Body.Rval;
		}
		private void AssignHeaderValues(ReportDefinitionServiceRequestHeader header)
		{
			header.ClientCustomerId = Config.ClientCustomerId;
			header.DeveloperToken = Config.DeveloperToken;
			header.PartialFailure = Config.PartialFailure;
			header.UserAgent = Config.UserAgent;
			header.ValidateOnly = Config.ValidateOnly;
		}
	}
}
