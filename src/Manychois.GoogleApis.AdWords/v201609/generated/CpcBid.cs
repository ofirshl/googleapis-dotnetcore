using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Manual click based bids.
	/// </summary>
	public class CpcBid : Bids, ISoapable
	{
		/// <summary>
		/// Max CPC (cost per click) bid.
		/// At the ad group level, this represents the default bid applicable for
		/// <ul><li>keyword targeting on search network.</li>
		/// <li>keywords & placements for content targeting.</li></ul>
		/// At the ad group criteria level, this is the max cpc bid.
		/// </summary>
		public Money Bid { get; set; }
		/// <summary>
		/// The level (ad group or criterion) at which the bid was set. This is applicable
		/// only at the criteria level.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public BidSource? CpcBidSource { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Bid = null;
			CpcBidSource = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "bid")
				{
					Bid = new Money();
					Bid.ReadFrom(xItem);
				}
				else if (localName == "cpcBidSource")
				{
					CpcBidSource = BidSourceExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CpcBid");
			XElement xItem = null;
			if (Bid != null)
			{
				xItem = new XElement(XName.Get("bid", "https://adwords.google.com/api/adwords/cm/v201609"));
				Bid.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (CpcBidSource != null)
			{
				xItem = new XElement(XName.Get("cpcBidSource", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CpcBidSource.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
