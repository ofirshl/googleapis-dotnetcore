using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A conversion that happens when a user performs one the following sequences of actions:
	/// <ul>
	/// <li>User clicks on an advertiser's ad which takes the user to the advertiser's website, where
	/// special javascript installed on the page produces a dynamically-generated phone number.
	/// Then, user calls that number from their home (or other) phone</li>
	/// </li>User makes a phone call from conversion-tracked call extensions </li>
	/// </ul>
	///
	/// After successfully creating a new UploadCallConversion, send the name of this conversion type
	/// along with your conversion details to the OfflineCallConversionFeedService
	/// to attribute those conversions to this conversion type.
	/// </summary>
	public class UploadCallConversion : ConversionTracker, ISoapable
	{
		public string Snippet { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Snippet = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "snippet")
				{
					Snippet = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "UploadCallConversion");
			XElement xItem = null;
			if (Snippet != null)
			{
				xItem = new XElement(XName.Get("snippet", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Snippet);
				xE.Add(xItem);
			}
		}
	}
}
