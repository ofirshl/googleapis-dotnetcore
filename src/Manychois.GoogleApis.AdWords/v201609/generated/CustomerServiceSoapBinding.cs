using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class CustomerServiceSoapBinding : BaseSoapBinding
	{
		public CustomerServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<CustomerServiceResponseHeader, CustomerServiceGetCustomersResponse>> GetCustomersAsync(SoapData<CustomerServiceRequestHeader, CustomerServiceGetCustomers> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getCustomers", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CustomerServiceResponseHeader, CustomerServiceGetCustomersResponse>();
			outData.Header = new CustomerServiceResponseHeader();
			outData.Body = new CustomerServiceGetCustomersResponse();
			var faultData = new CustomerServiceApiExceptionFault();
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
		public async Task<SoapData<CustomerServiceResponseHeader, CustomerServiceGetServiceLinksResponse>> GetServiceLinksAsync(SoapData<CustomerServiceRequestHeader, CustomerServiceGetServiceLinks> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getServiceLinks", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CustomerServiceResponseHeader, CustomerServiceGetServiceLinksResponse>();
			outData.Header = new CustomerServiceResponseHeader();
			outData.Body = new CustomerServiceGetServiceLinksResponse();
			var faultData = new CustomerServiceApiExceptionFault();
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
		public async Task<SoapData<CustomerServiceResponseHeader, CustomerServiceMutateResponse>> MutateAsync(SoapData<CustomerServiceRequestHeader, CustomerServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CustomerServiceResponseHeader, CustomerServiceMutateResponse>();
			outData.Header = new CustomerServiceResponseHeader();
			outData.Body = new CustomerServiceMutateResponse();
			var faultData = new CustomerServiceApiExceptionFault();
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
		public async Task<SoapData<CustomerServiceResponseHeader, CustomerServiceMutateServiceLinksResponse>> MutateServiceLinksAsync(SoapData<CustomerServiceRequestHeader, CustomerServiceMutateServiceLinks> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutateServiceLinks", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<CustomerServiceResponseHeader, CustomerServiceMutateServiceLinksResponse>();
			outData.Header = new CustomerServiceResponseHeader();
			outData.Body = new CustomerServiceMutateServiceLinksResponse();
			var faultData = new CustomerServiceApiExceptionFault();
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
