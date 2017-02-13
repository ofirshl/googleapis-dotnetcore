using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class ReportDefinitionService : IReportDefinitionService
	{
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _netUtil;
		private readonly ILogger _logger;
		public ReportDefinitionService(AdWordsApiConfig config, INetUtility netUtil, ILoggerFactory loggerFactory)
		{
			_config = config;
			_netUtil = netUtil;
			_logger = loggerFactory?.CreateLogger<ReportDefinitionService>();
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
			var binding = new ReportDefinitionServiceSoapBinding("https://adwords.google.com/api/adwords/cm/v201609/ReportDefinitionService", _config.AccessToken, _config.Timeout, _config.EnableGzipCompression, _netUtil, _logger);
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
			header.ClientCustomerId = _config.ClientCustomerId;
			header.DeveloperToken = _config.DeveloperToken;
			header.PartialFailure = _config.PartialFailure;
			header.UserAgent = _config.UserAgent;
			header.ValidateOnly = _config.ValidateOnly;
		}
	}
}
