using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A collection of customer-wide settings related to AdWords Conversion Tracking. Settings
	/// that apply at the conversion type level can be accessed and modified though
	/// {@code ConversionTrackerService}.
	/// </summary>
	public class ConversionTrackingSettings : ISoapable
	{
		/// <summary>
		/// With Cross-Account Conversion Tracking, a manager can share its conversion tracking ID among
		/// the clients it manages. If a customer is using a manager's conversion tracking ID we store
		/// it as the customer's effective conversion tracking ID.
		///
		/// <p>This is the conversion tracking ID used for this customer. If this is 0, the customer is
		/// not using conversion tracking. If the customer is using cross-account conversion tracking,
		/// this conversion tracking ID has been shared from the manager's account. Otherwise, for a
		/// customer who is not using cross-account conversion tracking, this is the customer's own
		/// conversion tracking ID.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? EffectiveConversionTrackingId { get; set; }
		/// <summary>
		/// True if a customer is using cross-account conversion tracking.
		/// False if the customer is not using conversion tracking, or if the customer is using
		/// his own conversion tracking ID.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? UsesCrossAccountConversionTracking { get; set; }
		/// <summary>
		/// True if customer has selected to include cross-device conversions
		/// in the "Conversions" column, which is used by any conversion-based bid
		/// strategies; false otherwise.
		/// </summary>
		public bool? OptimizeOnEstimatedConversions { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			EffectiveConversionTrackingId = null;
			UsesCrossAccountConversionTracking = null;
			OptimizeOnEstimatedConversions = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "effectiveConversionTrackingId")
				{
					EffectiveConversionTrackingId = long.Parse(xItem.Value);
				}
				else if (localName == "usesCrossAccountConversionTracking")
				{
					UsesCrossAccountConversionTracking = bool.Parse(xItem.Value);
				}
				else if (localName == "optimizeOnEstimatedConversions")
				{
					OptimizeOnEstimatedConversions = bool.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (EffectiveConversionTrackingId != null)
			{
				xItem = new XElement(XName.Get("effectiveConversionTrackingId", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(EffectiveConversionTrackingId.Value.ToString());
				xE.Add(xItem);
			}
			if (UsesCrossAccountConversionTracking != null)
			{
				xItem = new XElement(XName.Get("usesCrossAccountConversionTracking", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(UsesCrossAccountConversionTracking.Value.ToString());
				xE.Add(xItem);
			}
			if (OptimizeOnEstimatedConversions != null)
			{
				xItem = new XElement(XName.Get("optimizeOnEstimatedConversions", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(OptimizeOnEstimatedConversions.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
