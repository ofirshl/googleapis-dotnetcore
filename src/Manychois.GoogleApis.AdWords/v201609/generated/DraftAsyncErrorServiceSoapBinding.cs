using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class DraftAsyncErrorServiceSoapBinding : BaseSoapBinding
	{
		public DraftAsyncErrorServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<DraftAsyncErrorServiceResponseHeader, DraftAsyncErrorServiceGetResponse>> GetAsync(SoapData<DraftAsyncErrorServiceRequestHeader, DraftAsyncErrorServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<DraftAsyncErrorServiceResponseHeader, DraftAsyncErrorServiceGetResponse>();
			outData.Header = new DraftAsyncErrorServiceResponseHeader();
			outData.Body = new DraftAsyncErrorServiceGetResponse();
			var faultData = new DraftAsyncErrorServiceApiExceptionFault();
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
		public async Task<SoapData<DraftAsyncErrorServiceResponseHeader, DraftAsyncErrorServiceQueryResponse>> QueryAsync(SoapData<DraftAsyncErrorServiceRequestHeader, DraftAsyncErrorServiceQuery> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("query", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<DraftAsyncErrorServiceResponseHeader, DraftAsyncErrorServiceQueryResponse>();
			outData.Header = new DraftAsyncErrorServiceResponseHeader();
			outData.Body = new DraftAsyncErrorServiceQueryResponse();
			var faultData = new DraftAsyncErrorServiceApiExceptionFault();
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
