using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// CPA Bids.
	/// </summary>
	public class CpaBid : Bids, ISoapable
	{
		/// <summary>
		/// Target cost per acquisition (CPA). This is applicable only at the ad group level.
		///
		/// <p>If an ad group-level target is not set and the strategy type is TARGET_CPA,
		/// the strategy level target will be used. To set the strategy-level target,
		/// set the {@linkplain TargetCpaBiddingScheme#targetCpa} on the strategy's
		/// {@linkplain BiddingStrategyConfiguration#biddingScheme}.
		/// </summary>
		public Money Bid { get; set; }
		/// <summary>
		/// The level (ad group, ad group strategy, or campaign strategy) at which the bid was set.
		/// This is applicable only at the ad group level.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public BidSource? BidSource { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Bid = null;
			BidSource = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "bid")
				{
					Bid = new Money();
					Bid.ReadFrom(xItem);
				}
				else if (localName == "bidSource")
				{
					BidSource = BidSourceExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CpaBid");
			XElement xItem = null;
			if (Bid != null)
			{
				xItem = new XElement(XName.Get("bid", "https://adwords.google.com/api/adwords/cm/v201609"));
				Bid.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (BidSource != null)
			{
				xItem = new XElement(XName.Get("bidSource", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BidSource.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
