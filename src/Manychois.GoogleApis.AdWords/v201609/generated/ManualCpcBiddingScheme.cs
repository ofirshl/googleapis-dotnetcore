using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Manual click based bidding where user pays per click.
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public class ManualCpcBiddingScheme : BiddingScheme, ISoapable
	{
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
			EnhancedCpcEnabled = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "enhancedCpcEnabled")
				{
					EnhancedCpcEnabled = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ManualCpcBiddingScheme");
			XElement xItem = null;
			if (EnhancedCpcEnabled != null)
			{
				xItem = new XElement(XName.Get("enhancedCpcEnabled", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EnhancedCpcEnabled.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
