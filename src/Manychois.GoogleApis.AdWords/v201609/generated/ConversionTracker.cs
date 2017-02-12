using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An abstract Conversion base class.
	/// </summary>
	public abstract class ConversionTracker : ISoapable
	{
		/// <summary>
		/// ID of this conversion tracker, {@code null} when creating a new one.
		///
		/// <p>There are some system-defined conversion trackers that are available
		/// for all customers to use.  See {@link ConversionTrackerService#mutate} for
		/// more information about how to modify these types.
		/// <ul>
		/// <li>179 - Calls from Ads</li>
		/// <li>214 - Android Downloads</li>
		/// <li>239 - Store Visits</li>
		/// </ul>
		/// <span class="constraint Selectable">This field can be selected using the value "Id".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// The ID of the original conversion type on which this ConversionType is based.
		/// This is used to facilitate a connection between an existing shared conversion type
		/// (e.g. Calls from ads) and an advertiser-specific conversion type. This may only be specified
		/// for ADD operations, and can never be modified once a ConversionType is created.
		/// <span class="constraint Selectable">This field can be selected using the value "OriginalConversionTypeId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: SET.</span>
		/// </summary>
		public long? OriginalConversionTypeId { get; set; }
		/// <summary>
		/// Name of this conversion tracker.
		/// <span class="constraint Selectable">This field can be selected using the value "Name".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Status of this conversion tracker.
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public ConversionTrackerStatus? Status { get; set; }
		/// <summary>
		/// The category of conversion that is being tracked.
		/// <span class="constraint Selectable">This field can be selected using the value "Category".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public ConversionTrackerCategory? Category { get; set; }
		/// <summary>
		/// The status of the data-driven attribution model for the conversion type.
		/// <span class="constraint Selectable">This field can be selected using the value "DataDrivenModelStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public DataDrivenModelStatus? DataDrivenModelStatus { get; set; }
		/// <summary>
		/// The external customer ID of the conversion type owner, or 0 if this is a system-defined
		/// conversion type. Only the conversion type owner may edit properties of the conversion type.
		/// <span class="constraint Selectable">This field can be selected using the value "ConversionTypeOwnerCustomerId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? ConversionTypeOwnerCustomerId { get; set; }
		/// <summary>
		/// Lookback window for view-through conversions in days. This is the length of
		/// time in which a conversion without a click can be attributed to an
		/// impression.
		/// <span class="constraint Selectable">This field can be selected using the value "ViewthroughLookbackWindow".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint InRange">This field must be between 1 and 30, inclusive.</span>
		/// </summary>
		public int? ViewthroughLookbackWindow { get; set; }
		/// <summary>
		/// The click-through conversion (ctc) lookback window is the maximum number of days between
		/// the time a conversion event happens and the previous corresponding ad click.
		///
		/// <p>Conversion events that occur more than this many days after the click are ignored.
		///
		/// <p>This field is only editable for Adwords Conversions and Upload Conversions, but has a system
		/// defined default for other types of conversions. The allowed range of values for this window
		/// depends on the type of conversion and may expand, but 7-90 days is the currently-allowed
		/// range.
		/// <span class="constraint Selectable">This field can be selected using the value "CtcLookbackWindow".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public int? CtcLookbackWindow { get; set; }
		/// <summary>
		/// How to count events for this conversion tracker.
		/// If countingType is MANY_PER_CLICK, then all conversion events are counted.
		/// If countingType is ONE_PER_CLICK, then only the first conversion event of this type
		/// following a given click will be counted.
		/// More information is available at https://support.google.com/adwords/answer/3438531
		/// <span class="constraint Selectable">This field can be selected using the value "CountingType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public ConversionDeduplicationMode? CountingType { get; set; }
		/// <summary>
		/// The value to use when the tag for this conversion tracker sends conversion events without
		/// values. This value is applied on the server side, and is applicable to all ConversionTracker
		/// subclasses.
		/// <p>
		/// See also the corresponding {@link ConversionTracker#defaultRevenueCurrencyCode}, and see
		/// {@link ConversionTracker#alwaysUseDefaultRevenueValue} for details about when this value is
		/// used.
		/// <span class="constraint Selectable">This field can be selected using the value "DefaultRevenueValue".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint InRange">This field must be between 0 and 1000000000000, inclusive.</span>
		/// </summary>
		public double? DefaultRevenueValue { get; set; }
		/// <summary>
		/// The currency code to use when the tag for this conversion tracker sends conversion events
		/// without currency codes. This code is applied on the server side, and is applicable to all
		/// ConversionTracker subclasses. It must be a valid ISO4217 3-character code, such as USD.
		/// <p>
		/// This code is used if the code in the tag is not supplied or is unsupported, or if
		/// {@link ConversionTracker#alwaysUseDefaultRevenueValue} is set to true. If this default code is
		/// not set the currency code of the account is used as the default code.
		/// <p>
		/// Set the default code to XXX in order to specify that this conversion type does not have units
		/// of a currency (that is, it is unitless). In this case no currency conversion will occur even if
		/// a currency code is set in the tag.
		/// <span class="constraint Selectable">This field can be selected using the value "DefaultRevenueCurrencyCode".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string DefaultRevenueCurrencyCode { get; set; }
		/// <summary>
		/// Controls whether conversion event values and currency codes are taken from the tag snippet or
		/// from {@link ConversionTracker#defaultRevenueValue} and
		/// {@link ConversionTracker#defaultRevenueCurrencyCode}. If alwaysUseDefaultRevenueValue is true,
		/// then conversion events will always use defaultRevenueValue and defaultRevenueCurrencyCode, even
		/// if the tag has supplied a value and/or code when reporting the conversion event.  If
		/// alwaysUseDefaultRevenueValue is false, then defaultRevenueValue and defaultRevenueCurrencyCode
		/// are only used if the tag does not supply a value, or the tag's value is unparseable.
		/// <span class="constraint Selectable">This field can be selected using the value "AlwaysUseDefaultRevenueValue".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public bool? AlwaysUseDefaultRevenueValue { get; set; }
		/// <summary>
		/// Whether this conversion tracker should be excluded from the "Conversions" columns in reports.
		/// <p>
		/// If true, the conversion tracker will not be counted towards Conversions.
		/// If false, it will be counted in Conversions. This is the default.</p>
		///
		/// Either way, conversions will still be counted in the "AllConversions" columns in reports.
		/// <span class="constraint Selectable">This field can be selected using the value "ExcludeFromBidding".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public bool? ExcludeFromBidding { get; set; }
		/// <summary>
		/// Attribution models describing how to distribute credit for a particular conversion across
		/// potentially many prior interactions. See https://support.google.com/adwords/answer/6259715 for
		/// more information about attribution modeling in AdWords.
		/// <span class="constraint Selectable">This field can be selected using the value "AttributionModelType".</span>
		/// </summary>
		public AttributionModelType? AttributionModelType { get; set; }
		/// <summary>
		/// The date of the most recent ad click that led to a conversion of this conversion type.
		///
		/// <p>This date is in the <b>advertiser's defined time zone</b>.</p>
		/// <span class="constraint Selectable">This field can be selected using the value "MostRecentConversionDate".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string MostRecentConversionDate { get; set; }
		/// <summary>
		/// The last time a conversion tag for this conversion type successfully fired and was seen by
		/// AdWords. This firing event may not have been the result of an attributable conversion
		/// (ex: because the tag was fired from a browser that did not previously click an ad from the
		/// appropriate advertiser).
		///
		/// <p>This datetime is in <b>UTC</b>, not the advertiser's time zone.</p>
		/// <span class="constraint Selectable">This field can be selected using the value "LastReceivedRequestTime".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string LastReceivedRequestTime { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of ConversionTracker.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string ConversionTrackerType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			OriginalConversionTypeId = null;
			Name = null;
			Status = null;
			Category = null;
			DataDrivenModelStatus = null;
			ConversionTypeOwnerCustomerId = null;
			ViewthroughLookbackWindow = null;
			CtcLookbackWindow = null;
			CountingType = null;
			DefaultRevenueValue = null;
			DefaultRevenueCurrencyCode = null;
			AlwaysUseDefaultRevenueValue = null;
			ExcludeFromBidding = null;
			AttributionModelType = null;
			MostRecentConversionDate = null;
			LastReceivedRequestTime = null;
			ConversionTrackerType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "originalConversionTypeId")
				{
					OriginalConversionTypeId = long.Parse(xItem.Value);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "status")
				{
					Status = ConversionTrackerStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "category")
				{
					Category = ConversionTrackerCategoryExtensions.Parse(xItem.Value);
				}
				else if (localName == "dataDrivenModelStatus")
				{
					DataDrivenModelStatus = DataDrivenModelStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "conversionTypeOwnerCustomerId")
				{
					ConversionTypeOwnerCustomerId = long.Parse(xItem.Value);
				}
				else if (localName == "viewthroughLookbackWindow")
				{
					ViewthroughLookbackWindow = int.Parse(xItem.Value);
				}
				else if (localName == "ctcLookbackWindow")
				{
					CtcLookbackWindow = int.Parse(xItem.Value);
				}
				else if (localName == "countingType")
				{
					CountingType = ConversionDeduplicationModeExtensions.Parse(xItem.Value);
				}
				else if (localName == "defaultRevenueValue")
				{
					DefaultRevenueValue = double.Parse(xItem.Value);
				}
				else if (localName == "defaultRevenueCurrencyCode")
				{
					DefaultRevenueCurrencyCode = xItem.Value;
				}
				else if (localName == "alwaysUseDefaultRevenueValue")
				{
					AlwaysUseDefaultRevenueValue = bool.Parse(xItem.Value);
				}
				else if (localName == "excludeFromBidding")
				{
					ExcludeFromBidding = bool.Parse(xItem.Value);
				}
				else if (localName == "attributionModelType")
				{
					AttributionModelType = AttributionModelTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "mostRecentConversionDate")
				{
					MostRecentConversionDate = xItem.Value;
				}
				else if (localName == "lastReceivedRequestTime")
				{
					LastReceivedRequestTime = xItem.Value;
				}
				else if (localName == "ConversionTracker.Type")
				{
					ConversionTrackerType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (OriginalConversionTypeId != null)
			{
				xItem = new XElement(XName.Get("originalConversionTypeId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OriginalConversionTypeId.Value.ToString());
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Category != null)
			{
				xItem = new XElement(XName.Get("category", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Category.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (DataDrivenModelStatus != null)
			{
				xItem = new XElement(XName.Get("dataDrivenModelStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DataDrivenModelStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ConversionTypeOwnerCustomerId != null)
			{
				xItem = new XElement(XName.Get("conversionTypeOwnerCustomerId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ConversionTypeOwnerCustomerId.Value.ToString());
				xE.Add(xItem);
			}
			if (ViewthroughLookbackWindow != null)
			{
				xItem = new XElement(XName.Get("viewthroughLookbackWindow", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ViewthroughLookbackWindow.Value.ToString());
				xE.Add(xItem);
			}
			if (CtcLookbackWindow != null)
			{
				xItem = new XElement(XName.Get("ctcLookbackWindow", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CtcLookbackWindow.Value.ToString());
				xE.Add(xItem);
			}
			if (CountingType != null)
			{
				xItem = new XElement(XName.Get("countingType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CountingType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (DefaultRevenueValue != null)
			{
				xItem = new XElement(XName.Get("defaultRevenueValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DefaultRevenueValue.Value.ToString());
				xE.Add(xItem);
			}
			if (DefaultRevenueCurrencyCode != null)
			{
				xItem = new XElement(XName.Get("defaultRevenueCurrencyCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DefaultRevenueCurrencyCode);
				xE.Add(xItem);
			}
			if (AlwaysUseDefaultRevenueValue != null)
			{
				xItem = new XElement(XName.Get("alwaysUseDefaultRevenueValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AlwaysUseDefaultRevenueValue.Value.ToString());
				xE.Add(xItem);
			}
			if (ExcludeFromBidding != null)
			{
				xItem = new XElement(XName.Get("excludeFromBidding", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ExcludeFromBidding.Value.ToString());
				xE.Add(xItem);
			}
			if (AttributionModelType != null)
			{
				xItem = new XElement(XName.Get("attributionModelType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AttributionModelType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (MostRecentConversionDate != null)
			{
				xItem = new XElement(XName.Get("mostRecentConversionDate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(MostRecentConversionDate);
				xE.Add(xItem);
			}
			if (LastReceivedRequestTime != null)
			{
				xItem = new XElement(XName.Get("lastReceivedRequestTime", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LastReceivedRequestTime);
				xE.Add(xItem);
			}
			if (ConversionTrackerType != null)
			{
				xItem = new XElement(XName.Get("ConversionTracker.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ConversionTrackerType);
				xE.Add(xItem);
			}
		}
	}
}
