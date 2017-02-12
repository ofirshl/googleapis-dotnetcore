using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class OfflineConversionFeedServiceSoapBinding : BaseSoapBinding
	{
		public OfflineConversionFeedServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<OfflineConversionFeedServiceResponseHeader, OfflineConversionFeedServiceMutateResponse>> MutateAsync(SoapData<OfflineConversionFeedServiceRequestHeader, OfflineConversionFeedServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<OfflineConversionFeedServiceResponseHeader, OfflineConversionFeedServiceMutateResponse>();
			outData.Header = new OfflineConversionFeedServiceResponseHeader();
			outData.Body = new OfflineConversionFeedServiceMutateResponse();
			var faultData = new OfflineConversionFeedServiceApiExceptionFault();
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
