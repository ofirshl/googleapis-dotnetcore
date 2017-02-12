using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class CampaignCriterionServiceSoapBinding : BaseSoapBinding
	{
		public CampaignCriterionServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<CampaignCriterionServiceResponseHeader, CampaignCriterionServiceGetResponse>> GetAsync(SoapData<CampaignCriterionServiceRequestHeader, CampaignCriterionServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignCriterionServiceResponseHeader, CampaignCriterionServiceGetResponse>();
			outData.Header = new CampaignCriterionServiceResponseHeader();
			outData.Body = new CampaignCriterionServiceGetResponse();
			var faultData = new CampaignCriterionServiceApiExceptionFault();
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
		public async Task<SoapData<CampaignCriterionServiceResponseHeader, CampaignCriterionServiceMutateResponse>> MutateAsync(SoapData<CampaignCriterionServiceRequestHeader, CampaignCriterionServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignCriterionServiceResponseHeader, CampaignCriterionServiceMutateResponse>();
			outData.Header = new CampaignCriterionServiceResponseHeader();
			outData.Body = new CampaignCriterionServiceMutateResponse();
			var faultData = new CampaignCriterionServiceApiExceptionFault();
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
		public async Task<SoapData<CampaignCriterionServiceResponseHeader, CampaignCriterionServiceQueryResponse>> QueryAsync(SoapData<CampaignCriterionServiceRequestHeader, CampaignCriterionServiceQuery> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("query", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CampaignCriterionServiceResponseHeader, CampaignCriterionServiceQueryResponse>();
			outData.Header = new CampaignCriterionServiceResponseHeader();
			outData.Body = new CampaignCriterionServiceQueryResponse();
			var faultData = new CampaignCriterionServiceApiExceptionFault();
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
