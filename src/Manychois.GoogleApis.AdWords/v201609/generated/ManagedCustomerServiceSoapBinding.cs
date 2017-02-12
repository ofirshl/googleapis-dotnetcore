using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class ManagedCustomerServiceSoapBinding : BaseSoapBinding
	{
		public ManagedCustomerServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceGetResponse>> GetAsync(SoapData<ManagedCustomerServiceRequestHeader, ManagedCustomerServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceGetResponse>();
			outData.Header = new ManagedCustomerServiceResponseHeader();
			outData.Body = new ManagedCustomerServiceGetResponse();
			var faultData = new ManagedCustomerServiceApiExceptionFault();
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
		public async Task<SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceGetPendingInvitationsResponse>> GetPendingInvitationsAsync(SoapData<ManagedCustomerServiceRequestHeader, ManagedCustomerServiceGetPendingInvitations> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getPendingInvitations", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceGetPendingInvitationsResponse>();
			outData.Header = new ManagedCustomerServiceResponseHeader();
			outData.Body = new ManagedCustomerServiceGetPendingInvitationsResponse();
			var faultData = new ManagedCustomerServiceApiExceptionFault();
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
		public async Task<SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceMutateResponse>> MutateAsync(SoapData<ManagedCustomerServiceRequestHeader, ManagedCustomerServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceMutateResponse>();
			outData.Header = new ManagedCustomerServiceResponseHeader();
			outData.Body = new ManagedCustomerServiceMutateResponse();
			var faultData = new ManagedCustomerServiceApiExceptionFault();
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
		public async Task<SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceMutateLabelResponse>> MutateLabelAsync(SoapData<ManagedCustomerServiceRequestHeader, ManagedCustomerServiceMutateLabel> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutateLabel", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceMutateLabelResponse>();
			outData.Header = new ManagedCustomerServiceResponseHeader();
			outData.Body = new ManagedCustomerServiceMutateLabelResponse();
			var faultData = new ManagedCustomerServiceApiExceptionFault();
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
		public async Task<SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceMutateLinkResponse>> MutateLinkAsync(SoapData<ManagedCustomerServiceRequestHeader, ManagedCustomerServiceMutateLink> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutateLink", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceMutateLinkResponse>();
			outData.Header = new ManagedCustomerServiceResponseHeader();
			outData.Body = new ManagedCustomerServiceMutateLinkResponse();
			var faultData = new ManagedCustomerServiceApiExceptionFault();
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
		public async Task<SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceMutateManagerResponse>> MutateManagerAsync(SoapData<ManagedCustomerServiceRequestHeader, ManagedCustomerServiceMutateManager> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutateManager", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ManagedCustomerServiceResponseHeader, ManagedCustomerServiceMutateManagerResponse>();
			outData.Header = new ManagedCustomerServiceResponseHeader();
			outData.Body = new ManagedCustomerServiceMutateManagerResponse();
			var faultData = new ManagedCustomerServiceApiExceptionFault();
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
