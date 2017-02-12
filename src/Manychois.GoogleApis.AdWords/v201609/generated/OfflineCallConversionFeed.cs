using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an entire record in the offline call conversions feed that the advertiser uploads.
	/// </summary>
	public class OfflineCallConversionFeed : ISoapable
	{
		/// <summary>
		/// The caller id from which this call was placed.
		///
		/// <p>Caller ids in E.164 format with preceding '+' sign. (e.g., "+16502531234", +443308182000),
		/// National numbers which are treated as US numbers in formats like "6502531234",
		/// and International Numbers with accompanying country code and preceding '+' like +64 3-331 6005
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 30, inclusive, (trimmed).</span>
		/// </summary>
		public string CallerId { get; set; }
		/// <summary>
		/// The time at which this call started.
		/// <p> A time in the future is not allowed. A timezone is always required.
		///
		/// <p> When a conversion for the same caller id, conversion name
		/// and conversion time is uploaded multiple times, the first one
		/// results in a conversion being recorded. The duplicates are
		/// ignored and reported as successes, to indicate that a conversion
		/// for this combination has been recorded.
		///
		/// <p>String Format: yyyyMMdd HHmmss <Timezone ID> (for example, 20100609 150223
		/// America/New_York). See the <a
		/// href="https://developers.google.com/adwords/api/docs/appendix/timezones">Timezones</a> page for
		/// the complete list of Timezone IDs.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string CallStartTime { get; set; }
		/// <summary>
		/// The type associated with this conversion.
		/// <p>It is valid to report multiple conversions for the same call
		/// since visitors may trigger multiple conversions for a
		/// call. These conversions names are generated in the front end by
		/// advertisers.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 100, inclusive, (trimmed).</span>
		/// </summary>
		public string ConversionName { get; set; }
		/// <summary>
		/// The time that this conversion occurred at.
		/// <p>This has to be after the call time. A time in the future is not allowed.
		/// A timezone is always required.
		///
		/// <p>When a conversion for the same caller id, conversion name
		/// and conversion time is uploaded multiple times, the first one
		/// results in a conversion being recorded. The duplicates are
		/// ignored and reported as successes, to indicate that a conversion
		/// for this combination has been recorded.
		///
		/// <p>String Format: yyyyMMdd HHmmss <Timezone ID> (for example, 20100609 150223
		/// America/New_York). See the <a
		/// href="https://developers.google.com/adwords/api/docs/appendix/timezones">Timezones</a> page for
		/// the complete list of Timezone IDs.
		/// </summary>
		public string ConversionTime { get; set; }
		/// <summary>
		/// This conversions value for the advertiser.
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public double? ConversionValue { get; set; }
		/// <summary>
		/// The currency that the advertiser associates with the conversion value. This is the ISO 4217
		/// 3-character currency code. For example: USD, EUR.
		/// <span class="constraint StringLength">The length of this string should be between 3 and 3, inclusive, (trimmed).</span>
		/// </summary>
		public string ConversionCurrencyCode { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			CallerId = null;
			CallStartTime = null;
			ConversionName = null;
			ConversionTime = null;
			ConversionValue = null;
			ConversionCurrencyCode = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "callerId")
				{
					CallerId = xItem.Value;
				}
				else if (localName == "callStartTime")
				{
					CallStartTime = xItem.Value;
				}
				else if (localName == "conversionName")
				{
					ConversionName = xItem.Value;
				}
				else if (localName == "conversionTime")
				{
					ConversionTime = xItem.Value;
				}
				else if (localName == "conversionValue")
				{
					ConversionValue = double.Parse(xItem.Value);
				}
				else if (localName == "conversionCurrencyCode")
				{
					ConversionCurrencyCode = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (CallerId != null)
			{
				xItem = new XElement(XName.Get("callerId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CallerId);
				xE.Add(xItem);
			}
			if (CallStartTime != null)
			{
				xItem = new XElement(XName.Get("callStartTime", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CallStartTime);
				xE.Add(xItem);
			}
			if (ConversionName != null)
			{
				xItem = new XElement(XName.Get("conversionName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ConversionName);
				xE.Add(xItem);
			}
			if (ConversionTime != null)
			{
				xItem = new XElement(XName.Get("conversionTime", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ConversionTime);
				xE.Add(xItem);
			}
			if (ConversionValue != null)
			{
				xItem = new XElement(XName.Get("conversionValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ConversionValue.Value.ToString());
				xE.Add(xItem);
			}
			if (ConversionCurrencyCode != null)
			{
				xItem = new XElement(XName.Get("conversionCurrencyCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ConversionCurrencyCode);
				xE.Add(xItem);
			}
		}
	}
}
