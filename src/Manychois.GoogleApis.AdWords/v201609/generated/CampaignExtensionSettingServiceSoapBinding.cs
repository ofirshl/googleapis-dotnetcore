using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class CampaignExtensionSettingServiceSoapBinding : BaseSoapBinding
	{
		public CampaignExtensionSettingServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<CampaignExtensionSettingServiceResponseHeader, CampaignExtensionSettingServiceGetResponse>> GetAsync(SoapData<CampaignExtensionSettingServiceRequestHeader, CampaignExtensionSettingServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignExtensionSettingServiceResponseHeader, CampaignExtensionSettingServiceGetResponse>();
			outData.Header = new CampaignExtensionSettingServiceResponseHeader();
			outData.Body = new CampaignExtensionSettingServiceGetResponse();
			var faultData = new CampaignExtensionSettingServiceApiExceptionFault();
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
		public async Task<SoapData<CampaignExtensionSettingServiceResponseHeader, CampaignExtensionSettingServiceMutateResponse>> MutateAsync(SoapData<CampaignExtensionSettingServiceRequestHeader, CampaignExtensionSettingServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignExtensionSettingServiceResponseHeader, CampaignExtensionSettingServiceMutateResponse>();
			outData.Header = new CampaignExtensionSettingServiceResponseHeader();
			outData.Body = new CampaignExtensionSettingServiceMutateResponse();
			var faultData = new CampaignExtensionSettingServiceApiExceptionFault();
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
		public async Task<SoapData<CampaignExtensionSettingServiceResponseHeader, CampaignExtensionSettingServiceQueryResponse>> QueryAsync(SoapData<CampaignExtensionSettingServiceRequestHeader, CampaignExtensionSettingServiceQuery> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("query", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignExtensionSettingServiceResponseHeader, CampaignExtensionSettingServiceQueryResponse>();
			outData.Header = new CampaignExtensionSettingServiceResponseHeader();
			outData.Body = new CampaignExtensionSettingServiceQueryResponse();
			var faultData = new CampaignExtensionSettingServiceApiExceptionFault();
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
