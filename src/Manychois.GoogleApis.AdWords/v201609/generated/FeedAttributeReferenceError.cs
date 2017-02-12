using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An error indicating a problem with a reference to a feed attribute in an ad.
	/// </summary>
	public class FeedAttributeReferenceError : ApiError, ISoapable
	{
		public FeedAttributeReferenceErrorReason? Reason { get; set; }
		/// <summary>
		/// The referenced feed name.
		/// </summary>
		public string FeedName { get; set; }
		/// <summary>
		/// The referenced feed attribute name.
		/// </summary>
		public string FeedAttributeName { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Reason = null;
			FeedName = null;
			FeedAttributeName = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reason")
				{
					Reason = FeedAttributeReferenceErrorReasonExtensions.Parse(xItem.Value);
				}
				else if (localName == "feedName")
				{
					FeedName = xItem.Value;
				}
				else if (localName == "feedAttributeName")
				{
					FeedAttributeName = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "FeedAttributeReferenceError");
			XElement xItem = null;
			if (Reason != null)
			{
				xItem = new XElement(XName.Get("reason", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Reason.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (FeedName != null)
			{
				xItem = new XElement(XName.Get("feedName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedName);
				xE.Add(xItem);
			}
			if (FeedAttributeName != null)
			{
				xItem = new XElement(XName.Get("feedAttributeName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedAttributeName);
				xE.Add(xItem);
			}
		}
	}
}
