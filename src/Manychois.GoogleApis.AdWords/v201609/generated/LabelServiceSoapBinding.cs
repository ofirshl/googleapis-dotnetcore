using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class LabelServiceSoapBinding : BaseSoapBinding
	{
		public LabelServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<LabelServiceResponseHeader, LabelServiceGetResponse>> GetAsync(SoapData<LabelServiceRequestHeader, LabelServiceGet> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("get", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<LabelServiceResponseHeader, LabelServiceGetResponse>();
			outData.Header = new LabelServiceResponseHeader();
			outData.Body = new LabelServiceGetResponse();
			var faultData = new LabelServiceApiExceptionFault();
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
		public async Task<SoapData<LabelServiceResponseHeader, LabelServiceMutateResponse>> MutateAsync(SoapData<LabelServiceRequestHeader, LabelServiceMutate> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("mutate", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<LabelServiceResponseHeader, LabelServiceMutateResponse>();
			outData.Header = new LabelServiceResponseHeader();
			outData.Body = new LabelServiceMutateResponse();
			var faultData = new LabelServiceApiExceptionFault();
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
		public async Task<SoapData<LabelServiceResponseHeader, LabelServiceQueryResponse>> QueryAsync(SoapData<LabelServiceRequestHeader, LabelServiceQuery> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("query", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<LabelServiceResponseHeader, LabelServiceQueryResponse>();
			outData.Header = new LabelServiceResponseHeader();
			outData.Body = new LabelServiceQueryResponse();
			var faultData = new LabelServiceApiExceptionFault();
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
