using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class CampaignSharedSetServiceSoapBinding : BaseSoapBinding
	{
		public CampaignSharedSetServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<CampaignSharedSetServiceResponseHeader, CampaignSharedSetServiceGetResponse>> GetAsync(SoapData<CampaignSharedSetServiceRequestHeader, CampaignSharedSetServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignSharedSetServiceResponseHeader, CampaignSharedSetServiceGetResponse>();
			outData.Header = new CampaignSharedSetServiceResponseHeader();
			outData.Body = new CampaignSharedSetServiceGetResponse();
			var faultData = new CampaignSharedSetServiceApiExceptionFault();
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
		public async Task<SoapData<CampaignSharedSetServiceResponseHeader, CampaignSharedSetServiceMutateResponse>> MutateAsync(SoapData<CampaignSharedSetServiceRequestHeader, CampaignSharedSetServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignSharedSetServiceResponseHeader, CampaignSharedSetServiceMutateResponse>();
			outData.Header = new CampaignSharedSetServiceResponseHeader();
			outData.Body = new CampaignSharedSetServiceMutateResponse();
			var faultData = new CampaignSharedSetServiceApiExceptionFault();
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
		public async Task<SoapData<CampaignSharedSetServiceResponseHeader, CampaignSharedSetServiceQueryResponse>> QueryAsync(SoapData<CampaignSharedSetServiceRequestHeader, CampaignSharedSetServiceQuery> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("query", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignSharedSetServiceResponseHeader, CampaignSharedSetServiceQueryResponse>();
			outData.Header = new CampaignSharedSetServiceResponseHeader();
			outData.Body = new CampaignSharedSetServiceQueryResponse();
			var faultData = new CampaignSharedSetServiceApiExceptionFault();
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
