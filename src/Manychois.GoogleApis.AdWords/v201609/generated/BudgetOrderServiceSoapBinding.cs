using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class BudgetOrderServiceSoapBinding : BaseSoapBinding
	{
		public BudgetOrderServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<BudgetOrderServiceResponseHeader, BudgetOrderServiceGetResponse>> GetAsync(SoapData<BudgetOrderServiceRequestHeader, BudgetOrderServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/billing/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/billing/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<BudgetOrderServiceResponseHeader, BudgetOrderServiceGetResponse>();
			outData.Header = new BudgetOrderServiceResponseHeader();
			outData.Body = new BudgetOrderServiceGetResponse();
			var faultData = new BudgetOrderServiceApiExceptionFault();
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
		public async Task<SoapData<BudgetOrderServiceResponseHeader, BudgetOrderServiceGetBillingAccountsResponse>> GetBillingAccountsAsync(SoapData<BudgetOrderServiceRequestHeader, BudgetOrderServiceGetBillingAccounts> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/billing/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getBillingAccounts", "https://adwords.google.com/api/adwords/billing/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<BudgetOrderServiceResponseHeader, BudgetOrderServiceGetBillingAccountsResponse>();
			outData.Header = new BudgetOrderServiceResponseHeader();
			outData.Body = new BudgetOrderServiceGetBillingAccountsResponse();
			var faultData = new BudgetOrderServiceApiExceptionFault();
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
		public async Task<SoapData<BudgetOrderServiceResponseHeader, BudgetOrderServiceMutateResponse>> MutateAsync(SoapData<BudgetOrderServiceRequestHeader, BudgetOrderServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/billing/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/billing/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<BudgetOrderServiceResponseHeader, BudgetOrderServiceMutateResponse>();
			outData.Header = new BudgetOrderServiceResponseHeader();
			outData.Body = new BudgetOrderServiceMutateResponse();
			var faultData = new BudgetOrderServiceApiExceptionFault();
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
