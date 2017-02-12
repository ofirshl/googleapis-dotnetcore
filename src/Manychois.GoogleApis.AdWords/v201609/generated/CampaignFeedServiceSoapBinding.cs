using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class CampaignFeedServiceSoapBinding : BaseSoapBinding
	{
		public CampaignFeedServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<CampaignFeedServiceResponseHeader, CampaignFeedServiceGetResponse>> GetAsync(SoapData<CampaignFeedServiceRequestHeader, CampaignFeedServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignFeedServiceResponseHeader, CampaignFeedServiceGetResponse>();
			outData.Header = new CampaignFeedServiceResponseHeader();
			outData.Body = new CampaignFeedServiceGetResponse();
			var faultData = new CampaignFeedServiceApiExceptionFault();
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
		public async Task<SoapData<CampaignFeedServiceResponseHeader, CampaignFeedServiceMutateResponse>> MutateAsync(SoapData<CampaignFeedServiceRequestHeader, CampaignFeedServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignFeedServiceResponseHeader, CampaignFeedServiceMutateResponse>();
			outData.Header = new CampaignFeedServiceResponseHeader();
			outData.Body = new CampaignFeedServiceMutateResponse();
			var faultData = new CampaignFeedServiceApiExceptionFault();
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
		public async Task<SoapData<CampaignFeedServiceResponseHeader, CampaignFeedServiceQueryResponse>> QueryAsync(SoapData<CampaignFeedServiceRequestHeader, CampaignFeedServiceQuery> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("query", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignFeedServiceResponseHeader, CampaignFeedServiceQueryResponse>();
			outData.Header = new CampaignFeedServiceResponseHeader();
			outData.Body = new CampaignFeedServiceQueryResponse();
			var faultData = new CampaignFeedServiceApiExceptionFault();
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
