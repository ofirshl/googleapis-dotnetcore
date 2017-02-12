using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// In budget optimizer, Google automatically places bids for the user based on
	/// their daily/monthly budget.
	///
	/// <p><b>Note:</b>
	/// This bidding strategy has been deprecated and replaced with
	/// {@linkplain TargetSpendBiddingScheme TargetSpend}. We no longer allow
	/// advertisers to opt into this strategy--{@code BudgetOptimizerBiddingScheme}
	/// solely exists so that advertisers can access campaigns that had specified
	/// this strategy.</p>
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public class BudgetOptimizerBiddingScheme : BiddingScheme, ISoapable
	{
		/// <summary>
		/// Ceiling on bids placed by the budget optimizer.
		/// <span class="constraint Selectable">This field can be selected using the value "BidCeiling".</span>
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public Money BidCeiling { get; set; }
		/// <summary>
		/// The enhanced CPC bidding option for the campaign, which enables
		/// bids to be enhanced based on conversion optimizer data. For more
		/// information about enhanced CPC, see the
		/// <a href="//support.google.com/adwords/answer/2464964"
		/// >AdWords Help Center</a>.
		/// <span class="constraint Selectable">This field can be selected using the value "EnhancedCpcEnabled".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public bool? EnhancedCpcEnabled { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			BidCeiling = null;
			EnhancedCpcEnabled = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "bidCeiling")
				{
					BidCeiling = new Money();
					BidCeiling.ReadFrom(xItem);
				}
				else if (localName == "enhancedCpcEnabled")
				{
					EnhancedCpcEnabled = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "BudgetOptimizerBiddingScheme");
			XElement xItem = null;
			if (BidCeiling != null)
			{
				xItem = new XElement(XName.Get("bidCeiling", "https://adwords.google.com/api/adwords/cm/v201609"));
				BidCeiling.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (EnhancedCpcEnabled != null)
			{
				xItem = new XElement(XName.Get("enhancedCpcEnabled", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EnhancedCpcEnabled.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
