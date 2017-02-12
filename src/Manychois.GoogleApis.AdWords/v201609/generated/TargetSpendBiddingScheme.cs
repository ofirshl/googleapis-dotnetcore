using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// <a href="https://support.google.com/adwords/answer/6268626">Target Spend</a> is an automated
	/// bid strategy that sets your bids to help get as many clicks as possible within your budget.
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public class TargetSpendBiddingScheme : BiddingScheme, ISoapable
	{
		/// <summary>
		/// The largest max CPC bid that can be set by the TargetSpend bidder.
		/// <span class="constraint Selectable">This field can be selected using the value "TargetSpendBidCeiling".</span>
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public Money BidCeiling { get; set; }
		/// <summary>
		/// A spend target under which to maximize clicks. The TargetSpend bidder will
		/// attempt to spend the smaller of this value or the natural throttling spend
		/// amount. If not specified, the budget is used as the spend target.
		/// <span class="constraint Selectable">This field can be selected using the value "TargetSpendSpendTarget".</span>
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public Money SpendTarget { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			BidCeiling = null;
			SpendTarget = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "bidCeiling")
				{
					BidCeiling = new Money();
					BidCeiling.ReadFrom(xItem);
				}
				else if (localName == "spendTarget")
				{
					SpendTarget = new Money();
					SpendTarget.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "TargetSpendBiddingScheme");
			XElement xItem = null;
			if (BidCeiling != null)
			{
				xItem = new XElement(XName.Get("bidCeiling", "https://adwords.google.com/api/adwords/cm/v201609"));
				BidCeiling.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (SpendTarget != null)
			{
				xItem = new XElement(XName.Get("spendTarget", "https://adwords.google.com/api/adwords/cm/v201609"));
				SpendTarget.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
