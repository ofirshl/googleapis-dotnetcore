using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class AccountLabelServiceSoapBinding : BaseSoapBinding
	{
		public AccountLabelServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<AccountLabelServiceResponseHeader, AccountLabelServiceGetResponse>> GetAsync(SoapData<AccountLabelServiceRequestHeader, AccountLabelServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AccountLabelServiceResponseHeader, AccountLabelServiceGetResponse>();
			outData.Header = new AccountLabelServiceResponseHeader();
			outData.Body = new AccountLabelServiceGetResponse();
			var faultData = new AccountLabelServiceApiExceptionFault();
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
		public async Task<SoapData<AccountLabelServiceResponseHeader, AccountLabelServiceMutateResponse>> MutateAsync(SoapData<AccountLabelServiceRequestHeader, AccountLabelServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/mcm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<AccountLabelServiceResponseHeader, AccountLabelServiceMutateResponse>();
			outData.Header = new AccountLabelServiceResponseHeader();
			outData.Body = new AccountLabelServiceMutateResponse();
			var faultData = new AccountLabelServiceApiExceptionFault();
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
