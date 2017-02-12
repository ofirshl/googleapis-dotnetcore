using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class AdGroupCriterionServiceSoapBinding : BaseSoapBinding
	{
		public AdGroupCriterionServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<AdGroupCriterionServiceResponseHeader, AdGroupCriterionServiceGetResponse>> GetAsync(SoapData<AdGroupCriterionServiceRequestHeader, AdGroupCriterionServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupCriterionServiceResponseHeader, AdGroupCriterionServiceGetResponse>();
			outData.Header = new AdGroupCriterionServiceResponseHeader();
			outData.Body = new AdGroupCriterionServiceGetResponse();
			var faultData = new AdGroupCriterionServiceApiExceptionFault();
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
		public async Task<SoapData<AdGroupCriterionServiceResponseHeader, AdGroupCriterionServiceMutateResponse>> MutateAsync(SoapData<AdGroupCriterionServiceRequestHeader, AdGroupCriterionServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupCriterionServiceResponseHeader, AdGroupCriterionServiceMutateResponse>();
			outData.Header = new AdGroupCriterionServiceResponseHeader();
			outData.Body = new AdGroupCriterionServiceMutateResponse();
			var faultData = new AdGroupCriterionServiceApiExceptionFault();
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
		public async Task<SoapData<AdGroupCriterionServiceResponseHeader, AdGroupCriterionServiceMutateLabelResponse>> MutateLabelAsync(SoapData<AdGroupCriterionServiceRequestHeader, AdGroupCriterionServiceMutateLabel> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutateLabel", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupCriterionServiceResponseHeader, AdGroupCriterionServiceMutateLabelResponse>();
			outData.Header = new AdGroupCriterionServiceResponseHeader();
			outData.Body = new AdGroupCriterionServiceMutateLabelResponse();
			var faultData = new AdGroupCriterionServiceApiExceptionFault();
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
		public async Task<SoapData<AdGroupCriterionServiceResponseHeader, AdGroupCriterionServiceQueryResponse>> QueryAsync(SoapData<AdGroupCriterionServiceRequestHeader, AdGroupCriterionServiceQuery> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("query", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupCriterionServiceResponseHeader, AdGroupCriterionServiceQueryResponse>();
			outData.Header = new AdGroupCriterionServiceResponseHeader();
			outData.Body = new AdGroupCriterionServiceQueryResponse();
			var faultData = new AdGroupCriterionServiceApiExceptionFault();
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
