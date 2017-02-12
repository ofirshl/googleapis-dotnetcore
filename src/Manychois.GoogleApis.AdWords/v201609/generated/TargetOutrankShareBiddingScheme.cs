using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Target Outrank Share bidding strategy is an automated bidding strategy which automatically sets
	/// bids so that the customer's ads appear above a specified competitors' ads for a specified target
	/// fraction of the advertiser's eligible impressions on Google.com.
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public class TargetOutrankShareBiddingScheme : BiddingScheme, ISoapable
	{
		/// <summary>
		/// Specifies the target fraction (in micros) of auctions where the advertiser should outrank the
		/// competitor. The advertiser outranks the competitor in an auction if either the advertiser
		/// appears above the competitor in the search results, or appears in the search results when the
		/// competitor does not.
		/// <span class="constraint InRange">This field must be between 1 and 1000000, inclusive.</span>
		/// </summary>
		public int? TargetOutrankShare { get; set; }
		/// <summary>
		/// Competitor's visible domain URL.
		/// </summary>
		public string CompetitorDomain { get; set; }
		/// <summary>
		/// Ceiling on max CPC bids.
		/// </summary>
		public Money MaxCpcBidCeiling { get; set; }
		/// <summary>
		/// Controls whether the strategy always follows bid estimate changes, or only increases. If false,
		/// always sets a keyword's new bid to the estimate that will meet the target. If true, only
		/// updates a keyword's bid if the current bid estimate is greater than the current bid.
		/// </summary>
		public bool? BidChangesForRaisesOnly { get; set; }
		/// <summary>
		/// Controls whether the strategy is allowed to raise bids on keywords with lower-range quality
		/// scores.
		/// </summary>
		public bool? RaiseBidWhenLowQualityScore { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			TargetOutrankShare = null;
			CompetitorDomain = null;
			MaxCpcBidCeiling = null;
			BidChangesForRaisesOnly = null;
			RaiseBidWhenLowQualityScore = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "targetOutrankShare")
				{
					TargetOutrankShare = int.Parse(xItem.Value);
				}
				else if (localName == "competitorDomain")
				{
					CompetitorDomain = xItem.Value;
				}
				else if (localName == "maxCpcBidCeiling")
				{
					MaxCpcBidCeiling = new Money();
					MaxCpcBidCeiling.ReadFrom(xItem);
				}
				else if (localName == "bidChangesForRaisesOnly")
				{
					BidChangesForRaisesOnly = bool.Parse(xItem.Value);
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
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "TargetOutrankShareBiddingScheme");
			XElement xItem = null;
			if (TargetOutrankShare != null)
			{
				xItem = new XElement(XName.Get("targetOutrankShare", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TargetOutrankShare.Value.ToString());
				xE.Add(xItem);
			}
			if (CompetitorDomain != null)
			{
				xItem = new XElement(XName.Get("competitorDomain", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CompetitorDomain);
				xE.Add(xItem);
			}
			if (MaxCpcBidCeiling != null)
			{
				xItem = new XElement(XName.Get("maxCpcBidCeiling", "https://adwords.google.com/api/adwords/cm/v201609"));
				MaxCpcBidCeiling.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (BidChangesForRaisesOnly != null)
			{
				xItem = new XElement(XName.Get("bidChangesForRaisesOnly", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BidChangesForRaisesOnly.Value.ToString());
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
