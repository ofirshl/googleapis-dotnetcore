using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Settings for Real-Time Bidding, a feature only available for campaigns
	/// targeting the Ad Exchange network.
	/// </summary>
	public class RealTimeBiddingSetting : Setting, ISoapable
	{
		/// <summary>
		/// Whether the campaign is opted in to real-time bidding.
		/// </summary>
		public bool? OptIn { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			OptIn = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "optIn")
				{
					OptIn = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "RealTimeBiddingSetting");
			XElement xItem = null;
			if (OptIn != null)
			{
				xItem = new XElement(XName.Get("optIn", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OptIn.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
