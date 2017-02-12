using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class AdwordsUserListServiceSoapBinding : BaseSoapBinding
	{
		public AdwordsUserListServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<AdwordsUserListServiceResponseHeader, AdwordsUserListServiceGetResponse>> GetAsync(SoapData<AdwordsUserListServiceRequestHeader, AdwordsUserListServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/rm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/rm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdwordsUserListServiceResponseHeader, AdwordsUserListServiceGetResponse>();
			outData.Header = new AdwordsUserListServiceResponseHeader();
			outData.Body = new AdwordsUserListServiceGetResponse();
			var faultData = new AdwordsUserListServiceApiExceptionFault();
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
		public async Task<SoapData<AdwordsUserListServiceResponseHeader, AdwordsUserListServiceMutateResponse>> MutateAsync(SoapData<AdwordsUserListServiceRequestHeader, AdwordsUserListServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/rm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/rm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdwordsUserListServiceResponseHeader, AdwordsUserListServiceMutateResponse>();
			outData.Header = new AdwordsUserListServiceResponseHeader();
			outData.Body = new AdwordsUserListServiceMutateResponse();
			var faultData = new AdwordsUserListServiceApiExceptionFault();
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
		public async Task<SoapData<AdwordsUserListServiceResponseHeader, AdwordsUserListServiceMutateMembersResponse>> MutateMembersAsync(SoapData<AdwordsUserListServiceRequestHeader, AdwordsUserListServiceMutateMembers> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/rm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutateMembers", "https://adwords.google.com/api/adwords/rm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdwordsUserListServiceResponseHeader, AdwordsUserListServiceMutateMembersResponse>();
			outData.Header = new AdwordsUserListServiceResponseHeader();
			outData.Body = new AdwordsUserListServiceMutateMembersResponse();
			var faultData = new AdwordsUserListServiceApiExceptionFault();
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
		public async Task<SoapData<AdwordsUserListServiceResponseHeader, AdwordsUserListServiceQueryResponse>> QueryAsync(SoapData<AdwordsUserListServiceRequestHeader, AdwordsUserListServiceQuery> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/rm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("query", "https://adwords.google.com/api/adwords/rm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AdwordsUserListServiceResponseHeader, AdwordsUserListServiceQueryResponse>();
			outData.Header = new AdwordsUserListServiceResponseHeader();
			outData.Body = new AdwordsUserListServiceQueryResponse();
			var faultData = new AdwordsUserListServiceApiExceptionFault();
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
