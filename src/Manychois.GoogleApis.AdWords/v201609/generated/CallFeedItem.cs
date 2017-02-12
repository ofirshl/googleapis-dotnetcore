using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a Call extension.
	/// </summary>
	public class CallFeedItem : ExtensionFeedItem, ISoapable
	{
		/// <summary>
		/// The advertiser's phone number to append to the ad.
		/// <span class="constraint StringLength">This string must not be empty, (trimmed).</span>
		/// </summary>
		public string CallPhoneNumber { get; set; }
		/// <summary>
		/// Uppercase two-letter country code of the advertiser's phone number.
		/// <span class="constraint StringLength">This string must not be empty, (trimmed).</span>
		/// </summary>
		public string CallCountryCode { get; set; }
		/// <summary>
		/// Indicates whether call tracking is enabled. By default, call tracking is not enabled.
		/// </summary>
		public bool? CallTracking { get; set; }
		/// <summary>
		/// Call conversion type. To clear this field, set a CallConversionType with a value of null in its
		/// conversionTypeId field. This value should not be set if
		/// {@linkPlain CallFeedItem#disableCallConversionTracking} is true.
		/// </summary>
		public CallConversionType CallConversionType { get; set; }
		/// <summary>
		/// If set, disable call conversion tracking. {@linkPlain CallFeedItem#callConversionType} should
		/// not be set if this value is true.
		/// </summary>
		public bool? DisableCallConversionTracking { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			CallPhoneNumber = null;
			CallCountryCode = null;
			CallTracking = null;
			CallConversionType = null;
			DisableCallConversionTracking = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "callPhoneNumber")
				{
					CallPhoneNumber = xItem.Value;
				}
				else if (localName == "callCountryCode")
				{
					CallCountryCode = xItem.Value;
				}
				else if (localName == "callTracking")
				{
					CallTracking = bool.Parse(xItem.Value);
				}
				else if (localName == "callConversionType")
				{
					CallConversionType = new CallConversionType();
					CallConversionType.ReadFrom(xItem);
				}
				else if (localName == "disableCallConversionTracking")
				{
					DisableCallConversionTracking = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CallFeedItem");
			XElement xItem = null;
			if (CallPhoneNumber != null)
			{
				xItem = new XElement(XName.Get("callPhoneNumber", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CallPhoneNumber);
				xE.Add(xItem);
			}
			if (CallCountryCode != null)
			{
				xItem = new XElement(XName.Get("callCountryCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CallCountryCode);
				xE.Add(xItem);
			}
			if (CallTracking != null)
			{
				xItem = new XElement(XName.Get("callTracking", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CallTracking.Value.ToString());
				xE.Add(xItem);
			}
			if (CallConversionType != null)
			{
				xItem = new XElement(XName.Get("callConversionType", "https://adwords.google.com/api/adwords/cm/v201609"));
				CallConversionType.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (DisableCallConversionTracking != null)
			{
				xItem = new XElement(XName.Get("disableCallConversionTracking", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DisableCallConversionTracking.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
