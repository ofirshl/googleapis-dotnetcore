using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class TrafficEstimatorServiceSoapBinding : BaseSoapBinding
	{
		public TrafficEstimatorServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<TrafficEstimatorServiceResponseHeader, TrafficEstimatorServiceGetResponse>> GetAsync(SoapData<TrafficEstimatorServiceRequestHeader, TrafficEstimatorServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/o/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/o/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<TrafficEstimatorServiceResponseHeader, TrafficEstimatorServiceGetResponse>();
			outData.Header = new TrafficEstimatorServiceResponseHeader();
			outData.Body = new TrafficEstimatorServiceGetResponse();
			var faultData = new TrafficEstimatorServiceApiExceptionFault();
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
