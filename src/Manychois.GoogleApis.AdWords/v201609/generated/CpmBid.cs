using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Manual impression based bids.
	/// </summary>
	public class CpmBid : Bids, ISoapable
	{
		/// <summary>
		/// Max CPM (cost per thousand impressions) bid.
		/// </summary>
		public Money Bid { get; set; }
		/// <summary>
		/// The level (ad group or criterion) at which the bid was set. This is applicable
		/// only at the criteria level.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public BidSource? CpmBidSource { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Bid = null;
			CpmBidSource = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "bid")
				{
					Bid = new Money();
					Bid.ReadFrom(xItem);
				}
				else if (localName == "cpmBidSource")
				{
					CpmBidSource = BidSourceExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CpmBid");
			XElement xItem = null;
			if (Bid != null)
			{
				xItem = new XElement(XName.Get("bid", "https://adwords.google.com/api/adwords/cm/v201609"));
				Bid.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (CpmBidSource != null)
			{
				xItem = new XElement(XName.Get("cpmBidSource", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CpmBidSource.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
