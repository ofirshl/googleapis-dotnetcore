using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An error caused by an invalid Feed in a FeedService request.
	/// </summary>
	public class FeedError : ApiError, ISoapable
	{
		/// <summary>
		/// The cause of the error.
		/// </summary>
		public FeedErrorReason? Reason { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Reason = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reason")
				{
					Reason = FeedErrorReasonExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "FeedError");
			XElement xItem = null;
			if (Reason != null)
			{
				xItem = new XElement(XName.Get("reason", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Reason.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
