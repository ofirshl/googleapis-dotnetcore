using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Manual impression based bidding where user pays per thousand impressions.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class ManualCpmBiddingScheme : BiddingScheme, ISoapable
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
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ManualCpmBiddingScheme");
		}
	}
}
