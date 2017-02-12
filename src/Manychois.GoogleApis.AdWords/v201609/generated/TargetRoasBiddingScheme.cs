using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Target Roas bidding strategy helps you maximize revenue while averaging a specific target
	/// Return On Average Spend (ROAS).
	///
	/// <p>For example: If TargetRoas is 1.5, the strategy will create as much revenue as possible while
	/// ensuring that every $1.00 of clicks provides $1.50 in conversion value.
	///
	/// <p>Note that campaigns must meet <a
	/// href="//support.google.com/adwords/answer/2471188">specific
	/// eligibility requirements</a> before they can use the <code>TargetRoasBiddingScheme</code>
	/// bidding strategy.
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public class TargetRoasBiddingScheme : BiddingScheme, ISoapable
	{
		/// <summary>
		/// The desired revenue (based on conversion data) per unit of spend.
		/// <span class="constraint Selectable">This field can be selected using the value "TargetRoas".</span>
		/// <span class="constraint InRange">This field must be between 0.01 and 1000.0, inclusive.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public double? TargetRoas { get; set; }
		/// <summary>
		/// Maximum bid limit that applies to all keywords managed by the strategy.
		/// <span class="constraint Selectable">This field can be selected using the value "TargetRoasBidCeiling".</span>
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public Money BidCeiling { get; set; }
		/// <summary>
		/// Minimum bid limit that applies to all keywords managed by the strategy.
		/// <span class="constraint Selectable">This field can be selected using the value "TargetRoasBidFloor".</span>
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public Money BidFloor { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			TargetRoas = null;
			BidCeiling = null;
			BidFloor = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "targetRoas")
				{
					TargetRoas = double.Parse(xItem.Value);
				}
				else if (localName == "bidCeiling")
				{
					BidCeiling = new Money();
					BidCeiling.ReadFrom(xItem);
				}
				else if (localName == "bidFloor")
				{
					BidFloor = new Money();
					BidFloor.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "TargetRoasBiddingScheme");
			XElement xItem = null;
			if (TargetRoas != null)
			{
				xItem = new XElement(XName.Get("targetRoas", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TargetRoas.Value.ToString());
				xE.Add(xItem);
			}
			if (BidCeiling != null)
			{
				xItem = new XElement(XName.Get("bidCeiling", "https://adwords.google.com/api/adwords/cm/v201609"));
				BidCeiling.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (BidFloor != null)
			{
				xItem = new XElement(XName.Get("bidFloor", "https://adwords.google.com/api/adwords/cm/v201609"));
				BidFloor.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
