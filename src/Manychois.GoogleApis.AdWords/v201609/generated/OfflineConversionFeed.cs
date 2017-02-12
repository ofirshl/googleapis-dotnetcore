using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an entire record in the offline conversions feed that the advertiser uploads.
	/// </summary>
	public class OfflineConversionFeed : ISoapable
	{
		/// <summary>
		/// The google click ID associated with this conversion, as captured from the landing page.
		/// <p>
		/// If your account has auto-tagging turned on, the google click ID can be obtained from a query
		/// parameter called 'gclid'.
		/// <span class="constraint Selectable">This field can be selected using the value "GoogleClickId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 512, inclusive, (trimmed).</span>
		/// </summary>
		public string GoogleClickId { get; set; }
		/// <summary>
		/// The type associated with this conversion.
		/// <p>
		/// It is valid to report multiple conversions for the same google
		/// click ID, since visitors may trigger multiple conversions for a
		/// click. These conversions names are generated in the front end by
		/// advertisers.
		/// <span class="constraint Selectable">This field can be selected using the value "ConversionName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 100, inclusive, (trimmed).</span>
		/// </summary>
		public string ConversionName { get; set; }
		/// <summary>
		/// The time that this conversion occurred at.
		/// <p>
		/// This has to be after the click time. A time in the future is not allowed.
		/// A timezone is always required.
		/// <p>
		/// When a conversion for the same google click ID, conversion name
		/// and conversion time is uploaded multiple times, the first one
		/// results in a conversion being recorded. The duplicates are
		/// ignored and reported as successes, to indicate that a conversion
		/// for this combination has been recorded.
		/// <span class="constraint Selectable">This field can be selected using the value "ConversionTime".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string ConversionTime { get; set; }
		/// <summary>
		/// This conversions value for the advertiser.
		/// <span class="constraint Selectable">This field can be selected using the value "ConversionValue".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public double? ConversionValue { get; set; }
		/// <summary>
		/// The currency that the advertiser associates with the conversion value. This is the ISO 4217
		/// 3-character currency code. For example: USD, EUR.
		/// <span class="constraint Selectable">This field can be selected using the value "ConversionCurrencyCode".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint StringLength">The length of this string should be between 3 and 3, inclusive, (trimmed).</span>
		/// </summary>
		public string ConversionCurrencyCode { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			GoogleClickId = null;
			ConversionName = null;
			ConversionTime = null;
			ConversionValue = null;
			ConversionCurrencyCode = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "googleClickId")
				{
					GoogleClickId = xItem.Value;
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
			if (GoogleClickId != null)
			{
				xItem = new XElement(XName.Get("googleClickId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(GoogleClickId);
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
