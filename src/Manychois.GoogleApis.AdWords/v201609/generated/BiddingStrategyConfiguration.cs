using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Encapsulates the information about bids and bidding strategies.
	///
	/// <p>Bidding Strategy can be set on campaigns, ad groups or ad group criteria.
	/// <p>A bidding strategy can be set using one of the following:
	/// <ul>
	/// <li>{@linkplain BiddingStrategyConfiguration#biddingScheme bidding scheme}</li>
	/// <li>{@linkplain BiddingStrategyConfiguration#biddingStrategyType bidding strategy type}</li>
	/// <li>{@linkplain BiddingStrategyConfiguration#biddingStrategyId bidding strategy ID} for
	/// flexible bid strategies.</li>
	/// </ul>
	/// <p>If the bidding strategy type is used, then schemes are created using default values.
	///
	/// <p>Bids can be set only on ad groups and ad group criteria. They cannot be set on campaigns.
	/// Multiple bids can be set at the same time. Only the bids that apply to the effective
	/// bidding strategy will be used. Effective bidding strategy is considered to be the directly
	/// attached strategy or inherited strategy from above level(s) when there is no directly attached
	/// strategy.
	///
	/// <p>For more information on flexible bidding, visit the
	/// <a href="https://support.google.com/adwords/answer/2979071">Help Center</a>.
	/// </summary>
	public class BiddingStrategyConfiguration : ISoapable
	{
		/// <summary>
		/// Id of the bidding strategy to be associated with the campaign, ad group or ad group criteria.
		/// A bidding strategy is created using the BiddingStrategyService ADD operation and is
		/// assigned a BiddingStrategyId. The BiddingStrategyId can be shared across campaigns,
		/// ad groups and ad group criteria.
		/// <span class="constraint Selectable">This field can be selected using the value "BiddingStrategyId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
		/// </summary>
		public long? BiddingStrategyId { get; set; }
		/// <summary>
		/// Name of the bidding strategy. This is applicable only for flexible bidding strategies.
		/// <span class="constraint Selectable">This field can be selected using the value "BiddingStrategyName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string BiddingStrategyName { get; set; }
		/// <summary>
		/// The type of the bidding strategy to be attached.
		///
		/// <p>For details on portfolio vs. standard availability, see the
		/// <a href="https://developers.google.com/adwords/api/docs/guides/bidding">bidding guide</a>.
		/// <span class="constraint Selectable">This field can be selected using the value "BiddingStrategyType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint CampaignType">This field may only be set to the values: MANUAL_CPC, ENHANCED_CPC, TARGET_ROAS, TARGET_SPEND for campaign channel type SHOPPING.</span>
		/// <span class="constraint CampaignType">This field may only be set to the values: BUDGET_OPTIMIZER, CONVERSION_OPTIMIZER, MANUAL_CPC, MANUAL_CPM, TARGET_SPEND, ENHANCED_CPC, TARGET_CPA, TARGET_ROAS for campaign channel type DISPLAY.</span>
		/// <span class="constraint CampaignType">This field may only be set to the values: MANUAL_CPC, CONVERSION_OPTIMIZER, TARGET_CPA for campaign channel type DISPLAY with campaign channel subtype DISPLAY_MOBILE_APP.</span>
		/// <span class="constraint CampaignType">This field may only be set to the values: BUDGET_OPTIMIZER, MANUAL_CPC, NONE, PAGE_ONE_PROMOTED, TARGET_CPA, TARGET_OUTRANK_SHARE, TARGET_ROAS, TARGET_SPEND for campaign channel subtype SEARCH_MOBILE_APP.</span>
		/// <span class="constraint CampaignType">This field may only be set to TARGET_CPA for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// </summary>
		public BiddingStrategyType? BiddingStrategyType { get; set; }
		/// <summary>
		/// Indicates where the bidding strategy is associated i.e. campaign, ad group or
		/// ad group criterion.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public BiddingStrategySource? BiddingStrategySource { get; set; }
		/// <summary>
		/// The bidding strategy metadata. Bidding strategy can be associated using the
		/// {@linkplain BiddingStrategyConfiguration#biddingStrategyType} or the bidding scheme.
		///
		/// <p>For details on portfolio vs. standard availability, see the
		/// <a href="https://developers.google.com/adwords/api/docs/guides/bidding">bidding guide</a>.
		/// </summary>
		public BiddingScheme BiddingScheme { get; set; }
		/// <summary>
		/// Specifies the bids. Bids can be set only on ad groups and ad group criteria.
		/// Bids cannot be set on campaign.
		///
		/// Default CPC and CPM bid values will be set if they are not provided during {@linkplain AdGroup}
		/// creation. Default CPC and CPM values are minimal billable amounts in local currencies.
		/// For example, for US Dollars CPC and CPM default values are $0.01 and $0.01, respectively.
		/// </summary>
		public List<Bids> Bids { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			BiddingStrategyId = null;
			BiddingStrategyName = null;
			BiddingStrategyType = null;
			BiddingStrategySource = null;
			BiddingScheme = null;
			Bids = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "biddingStrategyId")
				{
					BiddingStrategyId = long.Parse(xItem.Value);
				}
				else if (localName == "biddingStrategyName")
				{
					BiddingStrategyName = xItem.Value;
				}
				else if (localName == "biddingStrategyType")
				{
					BiddingStrategyType = BiddingStrategyTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "biddingStrategySource")
				{
					BiddingStrategySource = BiddingStrategySourceExtensions.Parse(xItem.Value);
				}
				else if (localName == "biddingScheme")
				{
					BiddingScheme = InstanceCreator.CreateBiddingScheme(xItem);
					BiddingScheme.ReadFrom(xItem);
				}
				else if (localName == "bids")
				{
					if (Bids == null) Bids = new List<Bids>();
					var bidsItem = InstanceCreator.CreateBids(xItem);
					bidsItem.ReadFrom(xItem);
					Bids.Add(bidsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (BiddingStrategyId != null)
			{
				xItem = new XElement(XName.Get("biddingStrategyId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BiddingStrategyId.Value.ToString());
				xE.Add(xItem);
			}
			if (BiddingStrategyName != null)
			{
				xItem = new XElement(XName.Get("biddingStrategyName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BiddingStrategyName);
				xE.Add(xItem);
			}
			if (BiddingStrategyType != null)
			{
				xItem = new XElement(XName.Get("biddingStrategyType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BiddingStrategyType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (BiddingStrategySource != null)
			{
				xItem = new XElement(XName.Get("biddingStrategySource", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BiddingStrategySource.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (BiddingScheme != null)
			{
				xItem = new XElement(XName.Get("biddingScheme", "https://adwords.google.com/api/adwords/cm/v201609"));
				BiddingScheme.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Bids != null)
			{
				foreach (var bidsItem in Bids)
				{
					xItem = new XElement(XName.Get("bids", "https://adwords.google.com/api/adwords/cm/v201609"));
					bidsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
