using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a price extension.
	/// </summary>
	public class PriceFeedItem : ExtensionFeedItem, ISoapable
	{
		/// <summary>
		/// Price extension type of this extension. Required.
		/// </summary>
		public PriceExtensionType? PriceExtensionType { get; set; }
		/// <summary>
		/// Price qualifier for all rows of this price extension.
		/// </summary>
		public PriceExtensionPriceQualifier? PriceQualifier { get; set; }
		/// <summary>
		/// Tracking URL template for all rows of this price extension. To clear this field, set its value
		/// to the empty string/
		/// </summary>
		public string TrackingUrlTemplate { get; set; }
		/// <summary>
		/// The language the advertiser is using for this price extension. Required.
		/// Supported language codes:
		/// <ul>
		/// <li>en</li>
		/// </ul>
		/// </summary>
		public string Language { get; set; }
		/// <summary>
		/// The rows in this price extension. Minimum number of items allowed is 3 and the maximum number
		/// is 8.
		/// </summary>
		public List<PriceTableRow> TableRows { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			PriceExtensionType = null;
			PriceQualifier = null;
			TrackingUrlTemplate = null;
			Language = null;
			TableRows = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "priceExtensionType")
				{
					PriceExtensionType = PriceExtensionTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "priceQualifier")
				{
					PriceQualifier = PriceExtensionPriceQualifierExtensions.Parse(xItem.Value);
				}
				else if (localName == "trackingUrlTemplate")
				{
					TrackingUrlTemplate = xItem.Value;
				}
				else if (localName == "language")
				{
					Language = xItem.Value;
				}
				else if (localName == "tableRows")
				{
					if (TableRows == null) TableRows = new List<PriceTableRow>();
					var tableRowsItem = new PriceTableRow();
					tableRowsItem.ReadFrom(xItem);
					TableRows.Add(tableRowsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "PriceFeedItem");
			XElement xItem = null;
			if (PriceExtensionType != null)
			{
				xItem = new XElement(XName.Get("priceExtensionType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PriceExtensionType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (PriceQualifier != null)
			{
				xItem = new XElement(XName.Get("priceQualifier", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PriceQualifier.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (TrackingUrlTemplate != null)
			{
				xItem = new XElement(XName.Get("trackingUrlTemplate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TrackingUrlTemplate);
				xE.Add(xItem);
			}
			if (Language != null)
			{
				xItem = new XElement(XName.Get("language", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Language);
				xE.Add(xItem);
			}
			if (TableRows != null)
			{
				foreach (var tableRowsItem in TableRows)
				{
					xItem = new XElement(XName.Get("tableRows", "https://adwords.google.com/api/adwords/cm/v201609"));
					tableRowsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
