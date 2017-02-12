using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class ReportDefinitionServiceSoapBinding : BaseSoapBinding
	{
		public ReportDefinitionServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<ReportDefinitionServiceResponseHeader, ReportDefinitionServiceGetReportFieldsResponse>> GetReportFieldsAsync(SoapData<ReportDefinitionServiceRequestHeader, ReportDefinitionServiceGetReportFields> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getReportFields", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ReportDefinitionServiceResponseHeader, ReportDefinitionServiceGetReportFieldsResponse>();
			outData.Header = new ReportDefinitionServiceResponseHeader();
			outData.Body = new ReportDefinitionServiceGetReportFieldsResponse();
			var faultData = new ReportDefinitionServiceApiExceptionFault();
			var isSuccessful = await GetSoapResultAsync("", xHeaderData, xBodyData, outData, faultData).ConfigureAwait(false);
			if (!isSuccessful)
			{
				if (faultData.Errors.Count == 1)
				{
					throw faultData.Errors[0];
				}
				else
				{
					throw new AggregateException(faultData.Errors);
				}
			}
			return outData;
		}
	}
}
