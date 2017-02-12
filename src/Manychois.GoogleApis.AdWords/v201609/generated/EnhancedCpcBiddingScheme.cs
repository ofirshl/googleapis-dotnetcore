using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Enhanced CPC is a bidding strategy that raises your bids for clicks that seem more likely to
	/// lead to a conversion and lowers them for clicks where they seem less likely.
	///
	/// This bidding scheme does not support criteria level bidding strategy overrides.
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public class EnhancedCpcBiddingScheme : BiddingScheme, ISoapable
	{
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "EnhancedCpcBiddingScheme");
		}
	}
}
