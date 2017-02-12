using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Campaign level settings for tracking information.
	/// </summary>
	public class TrackingSetting : Setting, ISoapable
	{
		/// <summary>
		/// The url used for dynamic tracking.  For more information, see the
		/// article <a href="https://support.google.com/adwords/answer/2549100">
		/// Use dynamic tracking URLs</a>.
		/// Specify "NONE" to clear existing url.
		/// <span class="constraint StringLength">This string must not be empty.</span>
		/// </summary>
		public string TrackingUrl { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			TrackingUrl = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "trackingUrl")
				{
					TrackingUrl = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "TrackingSetting");
			XElement xItem = null;
			if (TrackingUrl != null)
			{
				xItem = new XElement(XName.Get("trackingUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TrackingUrl);
				xE.Add(xItem);
			}
		}
	}
}
