using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents one row in a price extension.
	/// </summary>
	public class PriceTableRow : ISoapable
	{
		/// <summary>
		/// Header text of this row. Required.
		/// <span class="constraint StringLength">The length of this string should be between 1 and 25, inclusive, (trimmed).</span>
		/// </summary>
		public string Header { get; set; }
		/// <summary>
		/// Description text of this row. Required.
		/// <span class="constraint StringLength">The length of this string should be between 1 and 25, inclusive, (trimmed).</span>
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// A list of possible final URLs after all cross domain redirects. Required.
		/// </summary>
		public UrlList FinalUrls { get; set; }
		/// <summary>
		/// Price value of this row. Required.
		/// </summary>
		public MoneyWithCurrency Price { get; set; }
		/// <summary>
		/// Price unit for this row.
		/// </summary>
		public PriceExtensionPriceUnit? PriceUnit { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Header = null;
			Description = null;
			FinalUrls = null;
			Price = null;
			PriceUnit = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "header")
				{
					Header = xItem.Value;
				}
				else if (localName == "description")
				{
					Description = xItem.Value;
				}
				else if (localName == "finalUrls")
				{
					FinalUrls = new UrlList();
					FinalUrls.ReadFrom(xItem);
				}
				else if (localName == "price")
				{
					Price = new MoneyWithCurrency();
					Price.ReadFrom(xItem);
				}
				else if (localName == "priceUnit")
				{
					PriceUnit = PriceExtensionPriceUnitExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Header != null)
			{
				xItem = new XElement(XName.Get("header", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Header);
				xE.Add(xItem);
			}
			if (Description != null)
			{
				xItem = new XElement(XName.Get("description", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description);
				xE.Add(xItem);
			}
			if (FinalUrls != null)
			{
				xItem = new XElement(XName.Get("finalUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
				FinalUrls.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Price != null)
			{
				xItem = new XElement(XName.Get("price", "https://adwords.google.com/api/adwords/cm/v201609"));
				Price.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (PriceUnit != null)
			{
				xItem = new XElement(XName.Get("priceUnit", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PriceUnit.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
