using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class AdGroupAdServiceSoapBinding : BaseSoapBinding
	{
		public AdGroupAdServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<AdGroupAdServiceResponseHeader, AdGroupAdServiceGetResponse>> GetAsync(SoapData<AdGroupAdServiceRequestHeader, AdGroupAdServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupAdServiceResponseHeader, AdGroupAdServiceGetResponse>();
			outData.Header = new AdGroupAdServiceResponseHeader();
			outData.Body = new AdGroupAdServiceGetResponse();
			var faultData = new AdGroupAdServiceApiExceptionFault();
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
		public async Task<SoapData<AdGroupAdServiceResponseHeader, AdGroupAdServiceMutateResponse>> MutateAsync(SoapData<AdGroupAdServiceRequestHeader, AdGroupAdServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupAdServiceResponseHeader, AdGroupAdServiceMutateResponse>();
			outData.Header = new AdGroupAdServiceResponseHeader();
			outData.Body = new AdGroupAdServiceMutateResponse();
			var faultData = new AdGroupAdServiceApiExceptionFault();
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
		public async Task<SoapData<AdGroupAdServiceResponseHeader, AdGroupAdServiceMutateLabelResponse>> MutateLabelAsync(SoapData<AdGroupAdServiceRequestHeader, AdGroupAdServiceMutateLabel> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutateLabel", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupAdServiceResponseHeader, AdGroupAdServiceMutateLabelResponse>();
			outData.Header = new AdGroupAdServiceResponseHeader();
			outData.Body = new AdGroupAdServiceMutateLabelResponse();
			var faultData = new AdGroupAdServiceApiExceptionFault();
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
		public async Task<SoapData<AdGroupAdServiceResponseHeader, AdGroupAdServiceQueryResponse>> QueryAsync(SoapData<AdGroupAdServiceRequestHeader, AdGroupAdServiceQuery> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("query", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupAdServiceResponseHeader, AdGroupAdServiceQueryResponse>();
			outData.Header = new AdGroupAdServiceResponseHeader();
			outData.Body = new AdGroupAdServiceQueryResponse();
			var faultData = new AdGroupAdServiceApiExceptionFault();
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
		public async Task<SoapData<AdGroupAdServiceResponseHeader, AdGroupAdServiceUpgradeUrlResponse>> UpgradeUrlAsync(SoapData<AdGroupAdServiceRequestHeader, AdGroupAdServiceUpgradeUrl> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("upgradeUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdGroupAdServiceResponseHeader, AdGroupAdServiceUpgradeUrlResponse>();
			outData.Header = new AdGroupAdServiceResponseHeader();
			outData.Body = new AdGroupAdServiceUpgradeUrlResponse();
			var faultData = new AdGroupAdServiceApiExceptionFault();
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
