using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// <a href="https://support.google.com/adwords/answer/6268632">Target CPA</a> is an automated bid
	/// strategy that sets bids to help get as many conversions as possible at the target cost per
	/// acquisition (CPA) you set.
	///
	/// <p>A {@linkplain #targetCpa target CPA} must be set for the strategy, but can also be optionally
	/// set for individual ad groups in the strategy. Ad group targets, if set, will override strategy
	/// targets.
	///
	/// <p>Note that campaigns must meet
	/// <a href="https://support.google.com/adwords/answer/2471188">specific eligibility requirements</a>
	/// before they can use the Target CPA bid strategy.
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public class TargetCpaBiddingScheme : BiddingScheme, ISoapable
	{
		/// <summary>
		/// Average cost per acquisition (CPA) target. This target should be greater than or equal to
		/// minimum billable unit based on the currency for the account.
		/// <span class="constraint Selectable">This field can be selected using the value "TargetCpa".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Money TargetCpa { get; set; }
		/// <summary>
		/// Maximum cpc bid limit that applies to all keywords managed by the strategy.
		/// <span class="constraint Selectable">This field can be selected using the value "TargetCpaMaxCpcBidCeiling".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public Money MaxCpcBidCeiling { get; set; }
		/// <summary>
		/// Minimum cpc bid limit that applies to all keywords managed by the strategy.
		/// <span class="constraint Selectable">This field can be selected using the value "TargetCpaMaxCpcBidFloor".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public Money MaxCpcBidFloor { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			TargetCpa = null;
			MaxCpcBidCeiling = null;
			MaxCpcBidFloor = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "targetCpa")
				{
					TargetCpa = new Money();
					TargetCpa.ReadFrom(xItem);
				}
				else if (localName == "maxCpcBidCeiling")
				{
					MaxCpcBidCeiling = new Money();
					MaxCpcBidCeiling.ReadFrom(xItem);
				}
				else if (localName == "maxCpcBidFloor")
				{
					MaxCpcBidFloor = new Money();
					MaxCpcBidFloor.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "TargetCpaBiddingScheme");
			XElement xItem = null;
			if (TargetCpa != null)
			{
				xItem = new XElement(XName.Get("targetCpa", "https://adwords.google.com/api/adwords/cm/v201609"));
				TargetCpa.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (MaxCpcBidCeiling != null)
			{
				xItem = new XElement(XName.Get("maxCpcBidCeiling", "https://adwords.google.com/api/adwords/cm/v201609"));
				MaxCpcBidCeiling.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (MaxCpcBidFloor != null)
			{
				xItem = new XElement(XName.Get("maxCpcBidFloor", "https://adwords.google.com/api/adwords/cm/v201609"));
				MaxCpcBidFloor.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
