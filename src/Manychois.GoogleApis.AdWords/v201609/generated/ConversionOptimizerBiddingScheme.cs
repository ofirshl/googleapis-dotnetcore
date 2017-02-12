using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// This bidding strategy has been deprecated and replaced with
	/// {@linkplain TargetCpaBiddingScheme TargetCpa}. After V201601, we no longer allow
	/// advertisers to opt into this strategy--{@code ConversionOptimizerBiddingScheme}
	/// solely exists so that advertisers can access campaigns that had specified
	/// this strategy.</p>
	///
	/// <p>Conversion optimizer bidding strategy helps you maximize your return on investment
	/// (ROI) by automatically getting you the most possible conversions for your budget.
	///
	/// <p class="warning">{@code pricingMode} currently defaults to {@code CLICKS} and
	/// cannot be changed.</p>
	///
	/// <p>Note that campaigns must meet <a
	/// href="https://support.google.com/adwords/answer/2471188#CORequirements">
	/// specific eligibility requirements</a> before they can use the
	/// <code>ConversionOptimizer</code> bidding strategy.</p>
	///
	/// <p>For more information on conversion optimizer, visit the
	/// <a href="https://support.google.com/adwords/answer/2390684"
	/// >Conversion Optimizer help center</a>.</p>
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public class ConversionOptimizerBiddingScheme : BiddingScheme, ISoapable
	{
		/// <summary>
		/// <b>Note:</b> The value for this field currently cannot be changed.
		///
		/// Pricing model indicates whether it is a pay per clicks or pay per
		/// conversions campaign. If the pricing model is not specified it
		/// defaults to Clicks.
		/// <span class="constraint Selectable">This field can be selected using the value "PricingMode".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public ConversionOptimizerBiddingSchemePricingMode? PricingMode { get; set; }
		/// <summary>
		/// Bid type indicates if it is a Target CPA campaign. If the Bid type is
		/// not specified it defaults to Target CPA.
		/// <span class="constraint Selectable">This field can be selected using the value "BidType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public ConversionOptimizerBiddingSchemeBidType? BidType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			PricingMode = null;
			BidType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "pricingMode")
				{
					PricingMode = ConversionOptimizerBiddingSchemePricingModeExtensions.Parse(xItem.Value);
				}
				else if (localName == "bidType")
				{
					BidType = ConversionOptimizerBiddingSchemeBidTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ConversionOptimizerBiddingScheme");
			XElement xItem = null;
			if (PricingMode != null)
			{
				xItem = new XElement(XName.Get("pricingMode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PricingMode.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (BidType != null)
			{
				xItem = new XElement(XName.Get("bidType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BidType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
