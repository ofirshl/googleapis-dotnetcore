using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Errors associated with the length of the given string being
	/// out of bounds.
	/// </summary>
	public class StringLengthError : ApiError, ISoapable
	{
		/// <summary>
		/// The error reason represented by an enum.
		/// </summary>
		public StringLengthErrorReason? Reason { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Reason = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reason")
				{
					Reason = StringLengthErrorReasonExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "StringLengthError");
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
