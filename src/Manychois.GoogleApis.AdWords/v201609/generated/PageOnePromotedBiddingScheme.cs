using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Page-One Promoted bidding scheme, which sets max cpc bids to
	/// target impressions on page one or page one promoted slots on google.com.
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public class PageOnePromotedBiddingScheme : BiddingScheme, ISoapable
	{
		/// <summary>
		/// Specifies the strategy goal: where impressions are desired to be shown on
		/// search result pages.
		/// </summary>
		public PageOnePromotedBiddingSchemeStrategyGoal? StrategyGoal { get; set; }
		/// <summary>
		/// Strategy maximum bid limit in advertiser local currency micro units.
		/// This upper limit applies to all keywords managed by the strategy.
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public Money BidCeiling { get; set; }
		/// <summary>
		/// Bid Multiplier to be applied to the relevant bid estimate (depending on the strategyGoal)
		/// in determining a keyword's new max cpc bid.
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public double? BidModifier { get; set; }
		/// <summary>
		/// Controls whether the strategy always follows bid estimate changes, or only
		/// increases. If false, always set a keyword's new bid to the current bid estimate.
		/// If true, only updates a keyword's bid if the current bid estimate is
		/// greater than the current bid.
		/// </summary>
		public bool? BidChangesForRaisesOnly { get; set; }
		/// <summary>
		/// Controls whether the strategy is allowed to raise bids when the throttling rate
		/// of the budget it is serving out of rises above a threshold.
		/// </summary>
		public bool? RaiseBidWhenBudgetConstrained { get; set; }
		/// <summary>
		/// Controls whether the strategy is allowed to raise bids on keywords with lower-range
		/// quality scores.
		/// </summary>
		public bool? RaiseBidWhenLowQualityScore { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			StrategyGoal = null;
			BidCeiling = null;
			BidModifier = null;
			BidChangesForRaisesOnly = null;
			RaiseBidWhenBudgetConstrained = null;
			RaiseBidWhenLowQualityScore = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "strategyGoal")
				{
					StrategyGoal = PageOnePromotedBiddingSchemeStrategyGoalExtensions.Parse(xItem.Value);
				}
				else if (localName == "bidCeiling")
				{
					BidCeiling = new Money();
					BidCeiling.ReadFrom(xItem);
				}
				else if (localName == "bidModifier")
				{
					BidModifier = double.Parse(xItem.Value);
				}
				else if (localName == "bidChangesForRaisesOnly")
				{
					BidChangesForRaisesOnly = bool.Parse(xItem.Value);
				}
				else if (localName == "raiseBidWhenBudgetConstrained")
				{
					RaiseBidWhenBudgetConstrained = bool.Parse(xItem.Value);
				}
				else if (localName == "raiseBidWhenLowQualityScore")
				{
					RaiseBidWhenLowQualityScore = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "PageOnePromotedBiddingScheme");
			XElement xItem = null;
			if (StrategyGoal != null)
			{
				xItem = new XElement(XName.Get("strategyGoal", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StrategyGoal.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (BidCeiling != null)
			{
				xItem = new XElement(XName.Get("bidCeiling", "https://adwords.google.com/api/adwords/cm/v201609"));
				BidCeiling.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (BidModifier != null)
			{
				xItem = new XElement(XName.Get("bidModifier", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BidModifier.Value.ToString());
				xE.Add(xItem);
			}
			if (BidChangesForRaisesOnly != null)
			{
				xItem = new XElement(XName.Get("bidChangesForRaisesOnly", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BidChangesForRaisesOnly.Value.ToString());
				xE.Add(xItem);
			}
			if (RaiseBidWhenBudgetConstrained != null)
			{
				xItem = new XElement(XName.Get("raiseBidWhenBudgetConstrained", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(RaiseBidWhenBudgetConstrained.Value.ToString());
				xE.Add(xItem);
			}
			if (RaiseBidWhenLowQualityScore != null)
			{
				xItem = new XElement(XName.Get("raiseBidWhenLowQualityScore", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(RaiseBidWhenLowQualityScore.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
