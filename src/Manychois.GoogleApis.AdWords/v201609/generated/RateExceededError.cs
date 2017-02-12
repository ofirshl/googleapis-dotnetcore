using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Signals that a call failed because a measured rate exceeded.
	/// </summary>
	public class RateExceededError : ApiError, ISoapable
	{
		/// <summary>
		/// The error reason represented by an enum.
		/// </summary>
		public RateExceededErrorReason? Reason { get; set; }
		/// <summary>
		/// Cause of the rate exceeded error.
		/// </summary>
		public string RateName { get; set; }
		/// <summary>
		/// The scope of the rate (ACCOUNT/DEVELOPER).
		/// </summary>
		public string RateScope { get; set; }
		/// <summary>
		/// The amount of time (in seconds) the client should wait before retrying the request.
		/// </summary>
		public int? RetryAfterSeconds { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Reason = null;
			RateName = null;
			RateScope = null;
			RetryAfterSeconds = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reason")
				{
					Reason = RateExceededErrorReasonExtensions.Parse(xItem.Value);
				}
				else if (localName == "rateName")
				{
					RateName = xItem.Value;
				}
				else if (localName == "rateScope")
				{
					RateScope = xItem.Value;
				}
				else if (localName == "retryAfterSeconds")
				{
					RetryAfterSeconds = int.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "RateExceededError");
			XElement xItem = null;
			if (Reason != null)
			{
				xItem = new XElement(XName.Get("reason", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Reason.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (RateName != null)
			{
				xItem = new XElement(XName.Get("rateName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(RateName);
				xE.Add(xItem);
			}
			if (RateScope != null)
			{
				xItem = new XElement(XName.Get("rateScope", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(RateScope);
				xE.Add(xItem);
			}
			if (RetryAfterSeconds != null)
			{
				xItem = new XElement(XName.Get("retryAfterSeconds", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(RetryAfterSeconds.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
