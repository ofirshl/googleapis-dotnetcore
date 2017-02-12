using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class AdGroupExtensionSettingServiceSoapBinding : BaseSoapBinding
	{
		public AdGroupExtensionSettingServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<AdGroupExtensionSettingServiceResponseHeader, AdGroupExtensionSettingServiceGetResponse>> GetAsync(SoapData<AdGroupExtensionSettingServiceRequestHeader, AdGroupExtensionSettingServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupExtensionSettingServiceResponseHeader, AdGroupExtensionSettingServiceGetResponse>();
			outData.Header = new AdGroupExtensionSettingServiceResponseHeader();
			outData.Body = new AdGroupExtensionSettingServiceGetResponse();
			var faultData = new AdGroupExtensionSettingServiceApiExceptionFault();
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
		public async Task<SoapData<AdGroupExtensionSettingServiceResponseHeader, AdGroupExtensionSettingServiceMutateResponse>> MutateAsync(SoapData<AdGroupExtensionSettingServiceRequestHeader, AdGroupExtensionSettingServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupExtensionSettingServiceResponseHeader, AdGroupExtensionSettingServiceMutateResponse>();
			outData.Header = new AdGroupExtensionSettingServiceResponseHeader();
			outData.Body = new AdGroupExtensionSettingServiceMutateResponse();
			var faultData = new AdGroupExtensionSettingServiceApiExceptionFault();
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
		public async Task<SoapData<AdGroupExtensionSettingServiceResponseHeader, AdGroupExtensionSettingServiceQueryResponse>> QueryAsync(SoapData<AdGroupExtensionSettingServiceRequestHeader, AdGroupExtensionSettingServiceQuery> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("query", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupExtensionSettingServiceResponseHeader, AdGroupExtensionSettingServiceQueryResponse>();
			outData.Header = new AdGroupExtensionSettingServiceResponseHeader();
			outData.Body = new AdGroupExtensionSettingServiceQueryResponse();
			var faultData = new AdGroupExtensionSettingServiceApiExceptionFault();
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
