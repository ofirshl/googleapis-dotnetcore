using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a CallOnlyAd.
	///
	/// <p class="caution"><b>Caution:</b> Call only ads do not use {@link #url url},
	/// {@link #finalUrls finalUrls}, {@link #finalMobileUrls finalMobileUrls},
	/// {@link #finalAppUrls finalAppUrls}, {@link #urlCustomParameters urlCustomParameters},
	/// or {@link #trackingUrlTemplate trackingUrlTemplate};
	/// setting these fields on a call only ad will cause an error.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class CallOnlyAd : Ad, ISoapable
	{
		/// <summary>
		/// Two letter country code for the ad. Examples: 'US', 'GB'.
		/// <span class="constraint Selectable">This field can be selected using the value "CallOnlyAdCountryCode".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string CountryCode { get; set; }
		/// <summary>
		/// Phone number string for the ad.
		/// Examples: '(800) 356-9377', "16502531234", "+442001234567"
		/// <span class="constraint Selectable">This field can be selected using the value "CallOnlyAdPhoneNumber".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string PhoneNumber { get; set; }
		/// <summary>
		/// Business name of the ad.
		/// <span class="constraint Selectable">This field can be selected using the value "CallOnlyAdBusinessName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string BusinessName { get; set; }
		/// <summary>
		/// First line of ad text.
		/// <span class="constraint Selectable">This field can be selected using the value "CallOnlyAdDescription1".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Description1 { get; set; }
		/// <summary>
		/// Second line of ad text.
		/// <span class="constraint Selectable">This field can be selected using the value "CallOnlyAdDescription2".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Description2 { get; set; }
		/// <summary>
		/// If set to true, enable call tracking for the creative. Enabling call
		/// tracking also enables call conversions.
		/// <span class="constraint Selectable">This field can be selected using the value "CallOnlyAdCallTracked".</span>
		/// </summary>
		public bool? CallTracked { get; set; }
		/// <summary>
		/// By default, call conversions are enabled when callTracked is on.
		/// To disable call conversions, set this field to true.
		/// Only in effect if callTracked is also set to true. If callTracked is set
		/// to false, this field is ignored.
		/// <span class="constraint Selectable">This field can be selected using the value "CallOnlyAdDisableCallConversion".</span>
		/// </summary>
		public bool? DisableCallConversion { get; set; }
		/// <summary>
		/// Conversion type to attribute a call conversion to. If not set, then a
		/// default conversion type id is used. Only in effect if callTracked is also
		/// set to true otherwise this field is ignored.
		/// <span class="constraint Selectable">This field can be selected using the value "CallOnlyAdConversionTypeId".</span>
		/// </summary>
		public long? ConversionTypeId { get; set; }
		/// <summary>
		/// Url to be used for phone number verification.
		/// <span class="constraint Selectable">This field can be selected using the value "CallOnlyAdPhoneNumberVerificationUrl".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string PhoneNumberVerificationUrl { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			CountryCode = null;
			PhoneNumber = null;
			BusinessName = null;
			Description1 = null;
			Description2 = null;
			CallTracked = null;
			DisableCallConversion = null;
			ConversionTypeId = null;
			PhoneNumberVerificationUrl = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "countryCode")
				{
					CountryCode = xItem.Value;
				}
				else if (localName == "phoneNumber")
				{
					PhoneNumber = xItem.Value;
				}
				else if (localName == "businessName")
				{
					BusinessName = xItem.Value;
				}
				else if (localName == "description1")
				{
					Description1 = xItem.Value;
				}
				else if (localName == "description2")
				{
					Description2 = xItem.Value;
				}
				else if (localName == "callTracked")
				{
					CallTracked = bool.Parse(xItem.Value);
				}
				else if (localName == "disableCallConversion")
				{
					DisableCallConversion = bool.Parse(xItem.Value);
				}
				else if (localName == "conversionTypeId")
				{
					ConversionTypeId = long.Parse(xItem.Value);
				}
				else if (localName == "phoneNumberVerificationUrl")
				{
					PhoneNumberVerificationUrl = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CallOnlyAd");
			XElement xItem = null;
			if (CountryCode != null)
			{
				xItem = new XElement(XName.Get("countryCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CountryCode);
				xE.Add(xItem);
			}
			if (PhoneNumber != null)
			{
				xItem = new XElement(XName.Get("phoneNumber", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PhoneNumber);
				xE.Add(xItem);
			}
			if (BusinessName != null)
			{
				xItem = new XElement(XName.Get("businessName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BusinessName);
				xE.Add(xItem);
			}
			if (Description1 != null)
			{
				xItem = new XElement(XName.Get("description1", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description1);
				xE.Add(xItem);
			}
			if (Description2 != null)
			{
				xItem = new XElement(XName.Get("description2", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description2);
				xE.Add(xItem);
			}
			if (CallTracked != null)
			{
				xItem = new XElement(XName.Get("callTracked", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CallTracked.Value.ToString());
				xE.Add(xItem);
			}
			if (DisableCallConversion != null)
			{
				xItem = new XElement(XName.Get("disableCallConversion", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DisableCallConversion.Value.ToString());
				xE.Add(xItem);
			}
			if (ConversionTypeId != null)
			{
				xItem = new XElement(XName.Get("conversionTypeId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ConversionTypeId.Value.ToString());
				xE.Add(xItem);
			}
			if (PhoneNumberVerificationUrl != null)
			{
				xItem = new XElement(XName.Get("phoneNumberVerificationUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PhoneNumberVerificationUrl);
				xE.Add(xItem);
			}
		}
	}
}
