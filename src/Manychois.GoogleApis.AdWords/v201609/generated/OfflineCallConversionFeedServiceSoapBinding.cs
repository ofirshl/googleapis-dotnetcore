using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class OfflineCallConversionFeedServiceSoapBinding : BaseSoapBinding
	{
		public OfflineCallConversionFeedServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<OfflineCallConversionFeedServiceResponseHeader, OfflineCallConversionFeedServiceMutateResponse>> MutateAsync(SoapData<OfflineCallConversionFeedServiceRequestHeader, OfflineCallConversionFeedServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<OfflineCallConversionFeedServiceResponseHeader, OfflineCallConversionFeedServiceMutateResponse>();
			outData.Header = new OfflineCallConversionFeedServiceResponseHeader();
			outData.Body = new OfflineCallConversionFeedServiceMutateResponse();
			var faultData = new OfflineCallConversionFeedServiceApiExceptionFault();
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
