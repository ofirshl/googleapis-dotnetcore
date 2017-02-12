using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Base class for all bidding schemes.
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public abstract class BiddingScheme : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of BiddingScheme.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string BiddingSchemeType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			BiddingSchemeType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "BiddingScheme.Type")
				{
					BiddingSchemeType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (BiddingSchemeType != null)
			{
				xItem = new XElement(XName.Get("BiddingScheme.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BiddingSchemeType);
				xE.Add(xItem);
			}
		}
	}
}
