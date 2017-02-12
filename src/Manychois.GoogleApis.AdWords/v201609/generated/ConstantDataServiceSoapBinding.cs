using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class ConstantDataServiceSoapBinding : BaseSoapBinding
	{
		public ConstantDataServiceSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)
			: base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)
		{
		}
		public async Task<SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetAgeRangeCriterionResponse>> GetAgeRangeCriterionAsync(SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetAgeRangeCriterion> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getAgeRangeCriterion", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetAgeRangeCriterionResponse>();
			outData.Header = new ConstantDataServiceResponseHeader();
			outData.Body = new ConstantDataServiceGetAgeRangeCriterionResponse();
			var faultData = new ConstantDataServiceApiExceptionFault();
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
		public async Task<SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetCarrierCriterionResponse>> GetCarrierCriterionAsync(SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetCarrierCriterion> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getCarrierCriterion", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetCarrierCriterionResponse>();
			outData.Header = new ConstantDataServiceResponseHeader();
			outData.Body = new ConstantDataServiceGetCarrierCriterionResponse();
			var faultData = new ConstantDataServiceApiExceptionFault();
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
		public async Task<SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetGenderCriterionResponse>> GetGenderCriterionAsync(SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetGenderCriterion> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getGenderCriterion", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetGenderCriterionResponse>();
			outData.Header = new ConstantDataServiceResponseHeader();
			outData.Body = new ConstantDataServiceGetGenderCriterionResponse();
			var faultData = new ConstantDataServiceApiExceptionFault();
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
		public async Task<SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetLanguageCriterionResponse>> GetLanguageCriterionAsync(SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetLanguageCriterion> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getLanguageCriterion", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetLanguageCriterionResponse>();
			outData.Header = new ConstantDataServiceResponseHeader();
			outData.Body = new ConstantDataServiceGetLanguageCriterionResponse();
			var faultData = new ConstantDataServiceApiExceptionFault();
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
		public async Task<SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetMobileAppCategoryCriterionResponse>> GetMobileAppCategoryCriterionAsync(SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetMobileAppCategoryCriterion> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getMobileAppCategoryCriterion", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetMobileAppCategoryCriterionResponse>();
			outData.Header = new ConstantDataServiceResponseHeader();
			outData.Body = new ConstantDataServiceGetMobileAppCategoryCriterionResponse();
			var faultData = new ConstantDataServiceApiExceptionFault();
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
		public async Task<SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetMobileDeviceCriterionResponse>> GetMobileDeviceCriterionAsync(SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetMobileDeviceCriterion> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getMobileDeviceCriterion", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetMobileDeviceCriterionResponse>();
			outData.Header = new ConstantDataServiceResponseHeader();
			outData.Body = new ConstantDataServiceGetMobileDeviceCriterionResponse();
			var faultData = new ConstantDataServiceApiExceptionFault();
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
		public async Task<SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetOperatingSystemVersionCriterionResponse>> GetOperatingSystemVersionCriterionAsync(SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetOperatingSystemVersionCriterion> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getOperatingSystemVersionCriterion", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetOperatingSystemVersionCriterionResponse>();
			outData.Header = new ConstantDataServiceResponseHeader();
			outData.Body = new ConstantDataServiceGetOperatingSystemVersionCriterionResponse();
			var faultData = new ConstantDataServiceApiExceptionFault();
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
		public async Task<SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetProductBiddingCategoryDataResponse>> GetProductBiddingCategoryDataAsync(SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetProductBiddingCategoryData> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getProductBiddingCategoryData", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetProductBiddingCategoryDataResponse>();
			outData.Header = new ConstantDataServiceResponseHeader();
			outData.Body = new ConstantDataServiceGetProductBiddingCategoryDataResponse();
			var faultData = new ConstantDataServiceApiExceptionFault();
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
		public async Task<SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetUserInterestCriterionResponse>> GetUserInterestCriterionAsync(SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetUserInterestCriterion> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getUserInterestCriterion", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetUserInterestCriterionResponse>();
			outData.Header = new ConstantDataServiceResponseHeader();
			outData.Body = new ConstantDataServiceGetUserInterestCriterionResponse();
			var faultData = new ConstantDataServiceApiExceptionFault();
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
		public async Task<SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetVerticalCriterionResponse>> GetVerticalCriterionAsync(SoapData<ConstantDataServiceRequestHeader, ConstantDataServiceGetVerticalCriterion> inData)
		{
			var xHeaderData = new XElement(XName.Get("RequestHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Header.WriteTo(xHeaderData);
			var xBodyData = new XElement(XName.Get("getVerticalCriterion", "https://adwords.google.com/api/adwords/cm/v201609"));
			inData.Body.WriteTo(xBodyData);
			var outData = new SoapData<ConstantDataServiceResponseHeader, ConstantDataServiceGetVerticalCriterionResponse>();
			outData.Header = new ConstantDataServiceResponseHeader();
			outData.Body = new ConstantDataServiceGetVerticalCriterionResponse();
			var faultData = new ConstantDataServiceApiExceptionFault();
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
