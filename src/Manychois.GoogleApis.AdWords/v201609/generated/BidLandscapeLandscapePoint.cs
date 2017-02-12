using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A set of estimates for a criterion's performance for a specific bid
	/// amount.
	/// </summary>
	public class BidLandscapeLandscapePoint : ISoapable
	{
		/// <summary>
		/// The bid amount used to estimate this landscape point's data.
		/// Only available for ad group bid landscapes and ad group criterion bid landscapes.
		/// <span class="constraint Selectable">This field can be selected using the value "Bid".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Money Bid { get; set; }
		/// <summary>
		/// Estimated number of clicks at this bid. For mobile bid modifier landscapes, this is the
		/// estimated number of clicks for mobile only.
		/// <span class="constraint Selectable">This field can be selected using the value "LocalClicks".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? Clicks { get; set; }
		/// <summary>
		/// Estimated cost at this bid. For mobile bid modifier landscapes, this is the estimated cost
		/// for mobile only.
		/// <span class="constraint Selectable">This field can be selected using the value "LocalCost".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public Money Cost { get; set; }
		/// <summary>
		/// Estimated number of impressions at this bid. For mobile bid modifier landscapes, this is the
		/// estimated number of impressions for mobile only.
		/// <span class="constraint Selectable">This field can be selected using the value "LocalImpressions".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? Impressions { get; set; }
		/// <summary>
		/// Estimated number of promoted impressions.
		/// <span class="constraint Selectable">This field can be selected using the value "PromotedImpressions".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? PromotedImpressions { get; set; }
		/// <summary>
		/// Required daily budget to achieve the predicted stats at this bid.
		/// Only available for campaign criterion bid landscapes (versions >= v201603).
		/// <span class="constraint Selectable">This field can be selected using the value "RequiredBudget".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public Money RequiredBudget { get; set; }
		/// <summary>
		/// The bid modifier value of this point.
		/// Only available for campaign criterion bid landscapes (versions >= v201603).
		/// <span class="constraint Selectable">This field can be selected using the value "BidModifier".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public double? BidModifier { get; set; }
		/// <summary>
		/// Estimated total impressions for all devices in mobile bid modifier landscape.
		/// Only available for campaign criterion bid landscapes (versions >= v201603).
		/// <span class="constraint Selectable">This field can be selected using the value "TotalLocalImpressions".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? TotalLocalImpressions { get; set; }
		/// <summary>
		/// Estimated total clicks for all devices in mobile bid modifier landscape.
		/// Only available for campaign criterion bid landscapes (versions >= v201603).
		/// <span class="constraint Selectable">This field can be selected using the value "TotalLocalClicks".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? TotalLocalClicks { get; set; }
		/// <summary>
		/// Estimated total cost for all devices in mobile bid modifier landscape.
		/// Only available for campaign criterion bid landscapes (versions >= v201603).
		/// <span class="constraint Selectable">This field can be selected using the value "TotalLocalCost".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public Money TotalLocalCost { get; set; }
		/// <summary>
		/// Estimated total promoted impressions for all devices in mobile bid modifier landscape.
		/// Only available for campaign criterion bid landscapes (versions >= v201603).
		/// <span class="constraint Selectable">This field can be selected using the value "TotalLocalPromotedImpressions".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? TotalLocalPromotedImpressions { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Bid = null;
			Clicks = null;
			Cost = null;
			Impressions = null;
			PromotedImpressions = null;
			RequiredBudget = null;
			BidModifier = null;
			TotalLocalImpressions = null;
			TotalLocalClicks = null;
			TotalLocalCost = null;
			TotalLocalPromotedImpressions = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "bid")
				{
					Bid = new Money();
					Bid.ReadFrom(xItem);
				}
				else if (localName == "clicks")
				{
					Clicks = long.Parse(xItem.Value);
				}
				else if (localName == "cost")
				{
					Cost = new Money();
					Cost.ReadFrom(xItem);
				}
				else if (localName == "impressions")
				{
					Impressions = long.Parse(xItem.Value);
				}
				else if (localName == "promotedImpressions")
				{
					PromotedImpressions = long.Parse(xItem.Value);
				}
				else if (localName == "requiredBudget")
				{
					RequiredBudget = new Money();
					RequiredBudget.ReadFrom(xItem);
				}
				else if (localName == "bidModifier")
				{
					BidModifier = double.Parse(xItem.Value);
				}
				else if (localName == "totalLocalImpressions")
				{
					TotalLocalImpressions = long.Parse(xItem.Value);
				}
				else if (localName == "totalLocalClicks")
				{
					TotalLocalClicks = long.Parse(xItem.Value);
				}
				else if (localName == "totalLocalCost")
				{
					TotalLocalCost = new Money();
					TotalLocalCost.ReadFrom(xItem);
				}
				else if (localName == "totalLocalPromotedImpressions")
				{
					TotalLocalPromotedImpressions = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Bid != null)
			{
				xItem = new XElement(XName.Get("bid", "https://adwords.google.com/api/adwords/cm/v201609"));
				Bid.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Clicks != null)
			{
				xItem = new XElement(XName.Get("clicks", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Clicks.Value.ToString());
				xE.Add(xItem);
			}
			if (Cost != null)
			{
				xItem = new XElement(XName.Get("cost", "https://adwords.google.com/api/adwords/cm/v201609"));
				Cost.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Impressions != null)
			{
				xItem = new XElement(XName.Get("impressions", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Impressions.Value.ToString());
				xE.Add(xItem);
			}
			if (PromotedImpressions != null)
			{
				xItem = new XElement(XName.Get("promotedImpressions", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PromotedImpressions.Value.ToString());
				xE.Add(xItem);
			}
			if (RequiredBudget != null)
			{
				xItem = new XElement(XName.Get("requiredBudget", "https://adwords.google.com/api/adwords/cm/v201609"));
				RequiredBudget.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (BidModifier != null)
			{
				xItem = new XElement(XName.Get("bidModifier", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BidModifier.Value.ToString());
				xE.Add(xItem);
			}
			if (TotalLocalImpressions != null)
			{
				xItem = new XElement(XName.Get("totalLocalImpressions", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TotalLocalImpressions.Value.ToString());
				xE.Add(xItem);
			}
			if (TotalLocalClicks != null)
			{
				xItem = new XElement(XName.Get("totalLocalClicks", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TotalLocalClicks.Value.ToString());
				xE.Add(xItem);
			}
			if (TotalLocalCost != null)
			{
				xItem = new XElement(XName.Get("totalLocalCost", "https://adwords.google.com/api/adwords/cm/v201609"));
				TotalLocalCost.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (TotalLocalPromotedImpressions != null)
			{
				xItem = new XElement(XName.Get("totalLocalPromotedImpressions", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TotalLocalPromotedImpressions.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
