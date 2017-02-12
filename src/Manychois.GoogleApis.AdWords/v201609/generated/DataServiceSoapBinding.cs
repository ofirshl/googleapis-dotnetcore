using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class DataServiceSoapBinding : BaseSoapBinding
	{
		public DataServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<DataServiceResponseHeader, DataServiceGetAdGroupBidLandscapeResponse>> GetAdGroupBidLandscapeAsync(SoapData<DataServiceRequestHeader, DataServiceGetAdGroupBidLandscape> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getAdGroupBidLandscape", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<DataServiceResponseHeader, DataServiceGetAdGroupBidLandscapeResponse>();
			outData.Header = new DataServiceResponseHeader();
			outData.Body = new DataServiceGetAdGroupBidLandscapeResponse();
			var faultData = new DataServiceApiExceptionFault();
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
		public async Task<SoapData<DataServiceResponseHeader, DataServiceGetCampaignCriterionBidLandscapeResponse>> GetCampaignCriterionBidLandscapeAsync(SoapData<DataServiceRequestHeader, DataServiceGetCampaignCriterionBidLandscape> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getCampaignCriterionBidLandscape", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<DataServiceResponseHeader, DataServiceGetCampaignCriterionBidLandscapeResponse>();
			outData.Header = new DataServiceResponseHeader();
			outData.Body = new DataServiceGetCampaignCriterionBidLandscapeResponse();
			var faultData = new DataServiceApiExceptionFault();
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
		public async Task<SoapData<DataServiceResponseHeader, DataServiceGetCriterionBidLandscapeResponse>> GetCriterionBidLandscapeAsync(SoapData<DataServiceRequestHeader, DataServiceGetCriterionBidLandscape> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getCriterionBidLandscape", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<DataServiceResponseHeader, DataServiceGetCriterionBidLandscapeResponse>();
			outData.Header = new DataServiceResponseHeader();
			outData.Body = new DataServiceGetCriterionBidLandscapeResponse();
			var faultData = new DataServiceApiExceptionFault();
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
		public async Task<SoapData<DataServiceResponseHeader, DataServiceGetDomainCategoryResponse>> GetDomainCategoryAsync(SoapData<DataServiceRequestHeader, DataServiceGetDomainCategory> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getDomainCategory", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<DataServiceResponseHeader, DataServiceGetDomainCategoryResponse>();
			outData.Header = new DataServiceResponseHeader();
			outData.Body = new DataServiceGetDomainCategoryResponse();
			var faultData = new DataServiceApiExceptionFault();
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
		public async Task<SoapData<DataServiceResponseHeader, DataServiceQueryAdGroupBidLandscapeResponse>> QueryAdGroupBidLandscapeAsync(SoapData<DataServiceRequestHeader, DataServiceQueryAdGroupBidLandscape> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("queryAdGroupBidLandscape", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<DataServiceResponseHeader, DataServiceQueryAdGroupBidLandscapeResponse>();
			outData.Header = new DataServiceResponseHeader();
			outData.Body = new DataServiceQueryAdGroupBidLandscapeResponse();
			var faultData = new DataServiceApiExceptionFault();
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
		public async Task<SoapData<DataServiceResponseHeader, DataServiceQueryCampaignCriterionBidLandscapeResponse>> QueryCampaignCriterionBidLandscapeAsync(SoapData<DataServiceRequestHeader, DataServiceQueryCampaignCriterionBidLandscape> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("queryCampaignCriterionBidLandscape", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<DataServiceResponseHeader, DataServiceQueryCampaignCriterionBidLandscapeResponse>();
			outData.Header = new DataServiceResponseHeader();
			outData.Body = new DataServiceQueryCampaignCriterionBidLandscapeResponse();
			var faultData = new DataServiceApiExceptionFault();
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
		public async Task<SoapData<DataServiceResponseHeader, DataServiceQueryCriterionBidLandscapeResponse>> QueryCriterionBidLandscapeAsync(SoapData<DataServiceRequestHeader, DataServiceQueryCriterionBidLandscape> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("queryCriterionBidLandscape", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<DataServiceResponseHeader, DataServiceQueryCriterionBidLandscapeResponse>();
			outData.Header = new DataServiceResponseHeader();
			outData.Body = new DataServiceQueryCriterionBidLandscapeResponse();
			var faultData = new DataServiceApiExceptionFault();
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
		public async Task<SoapData<DataServiceResponseHeader, DataServiceQueryDomainCategoryResponse>> QueryDomainCategoryAsync(SoapData<DataServiceRequestHeader, DataServiceQueryDomainCategory> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("queryDomainCategory", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<DataServiceResponseHeader, DataServiceQueryDomainCategoryResponse>();
			outData.Header = new DataServiceResponseHeader();
			outData.Body = new DataServiceQueryDomainCategoryResponse();
			var faultData = new DataServiceApiExceptionFault();
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
