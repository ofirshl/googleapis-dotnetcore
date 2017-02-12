using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a customer for the CustomerService.
	/// </summary>
	public class Customer : ISoapable
	{
		/// <summary>
		/// The 10-digit AdWords Customer ID.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? CustomerId { get; set; }
		/// <summary>
		/// The currency in which this account operates.
		/// We support a subset of the currency codes derived from the ISO 4217 standard.
		/// See <a href="https://developers.google.com/adwords/api/docs/appendix/currencycodes"
		/// >Currency Codes</a> for the currently supported currencies.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// <span class="constraint StringLength">The length of this string should be between 3 and 3, inclusive.</span>
		/// </summary>
		public string CurrencyCode { get; set; }
		/// <summary>
		/// The local timezone ID for this customer.
		/// See <a href="https://developers.google.com/adwords/api/docs/appendix/timezones"
		/// >Time Zone Codes</a> for the currently supported list.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// <span class="constraint StringLength">This string must not be empty.</span>
		/// </summary>
		public string DateTimeZone { get; set; }
		/// <summary>
		/// An optional, non-unique descriptive name for this customer.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string DescriptiveName { get; set; }
		/// <summary>
		/// An optional, non-unique company name for this customer.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string CompanyName { get; set; }
		/// <summary>
		/// Whether this customer can manage other AdWords customers
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? CanManageClients { get; set; }
		/// <summary>
		/// Whether this customer's account is a test account.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? TestAccount { get; set; }
		/// <summary>
		/// Whether auto-tagging is enabled for this customer.
		/// </summary>
		public bool? AutoTaggingEnabled { get; set; }
		/// <summary>
		/// URL template for constructing a tracking URL.
		///
		/// <p>On update, empty string ("") indicates to clear the field.
		/// </summary>
		public string TrackingUrlTemplate { get; set; }
		/// <summary>
		/// Customer-level AdWords Conversion Tracking settings
		/// </summary>
		public ConversionTrackingSettings ConversionTrackingSettings { get; set; }
		/// <summary>
		/// Customer-level AdWords Remarketing settings
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public RemarketingSettings RemarketingSettings { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			CustomerId = null;
			CurrencyCode = null;
			DateTimeZone = null;
			DescriptiveName = null;
			CompanyName = null;
			CanManageClients = null;
			TestAccount = null;
			AutoTaggingEnabled = null;
			TrackingUrlTemplate = null;
			ConversionTrackingSettings = null;
			RemarketingSettings = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "customerId")
				{
					CustomerId = long.Parse(xItem.Value);
				}
				else if (localName == "currencyCode")
				{
					CurrencyCode = xItem.Value;
				}
				else if (localName == "dateTimeZone")
				{
					DateTimeZone = xItem.Value;
				}
				else if (localName == "descriptiveName")
				{
					DescriptiveName = xItem.Value;
				}
				else if (localName == "companyName")
				{
					CompanyName = xItem.Value;
				}
				else if (localName == "canManageClients")
				{
					CanManageClients = bool.Parse(xItem.Value);
				}
				else if (localName == "testAccount")
				{
					TestAccount = bool.Parse(xItem.Value);
				}
				else if (localName == "autoTaggingEnabled")
				{
					AutoTaggingEnabled = bool.Parse(xItem.Value);
				}
				else if (localName == "trackingUrlTemplate")
				{
					TrackingUrlTemplate = xItem.Value;
				}
				else if (localName == "conversionTrackingSettings")
				{
					ConversionTrackingSettings = new ConversionTrackingSettings();
					ConversionTrackingSettings.ReadFrom(xItem);
				}
				else if (localName == "remarketingSettings")
				{
					RemarketingSettings = new RemarketingSettings();
					RemarketingSettings.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (CustomerId != null)
			{
				xItem = new XElement(XName.Get("customerId", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(CustomerId.Value.ToString());
				xE.Add(xItem);
			}
			if (CurrencyCode != null)
			{
				xItem = new XElement(XName.Get("currencyCode", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(CurrencyCode);
				xE.Add(xItem);
			}
			if (DateTimeZone != null)
			{
				xItem = new XElement(XName.Get("dateTimeZone", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(DateTimeZone);
				xE.Add(xItem);
			}
			if (DescriptiveName != null)
			{
				xItem = new XElement(XName.Get("descriptiveName", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(DescriptiveName);
				xE.Add(xItem);
			}
			if (CompanyName != null)
			{
				xItem = new XElement(XName.Get("companyName", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(CompanyName);
				xE.Add(xItem);
			}
			if (CanManageClients != null)
			{
				xItem = new XElement(XName.Get("canManageClients", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(CanManageClients.Value.ToString());
				xE.Add(xItem);
			}
			if (TestAccount != null)
			{
				xItem = new XElement(XName.Get("testAccount", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(TestAccount.Value.ToString());
				xE.Add(xItem);
			}
			if (AutoTaggingEnabled != null)
			{
				xItem = new XElement(XName.Get("autoTaggingEnabled", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(AutoTaggingEnabled.Value.ToString());
				xE.Add(xItem);
			}
			if (TrackingUrlTemplate != null)
			{
				xItem = new XElement(XName.Get("trackingUrlTemplate", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(TrackingUrlTemplate);
				xE.Add(xItem);
			}
			if (ConversionTrackingSettings != null)
			{
				xItem = new XElement(XName.Get("conversionTrackingSettings", "https://adwords.google.com/api/adwords/mcm/v201609"));
				ConversionTrackingSettings.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (RemarketingSettings != null)
			{
				xItem = new XElement(XName.Get("remarketingSettings", "https://adwords.google.com/api/adwords/mcm/v201609"));
				RemarketingSettings.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
