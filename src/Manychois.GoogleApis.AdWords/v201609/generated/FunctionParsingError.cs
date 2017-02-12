using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An error resulting from a failure to parse the textual representation of a function.
	/// </summary>
	public class FunctionParsingError : ApiError, ISoapable
	{
		public FunctionParsingErrorReason? Reason { get; set; }
		public string OffendingText { get; set; }
		public int? OffendingTextIndex { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Reason = null;
			OffendingText = null;
			OffendingTextIndex = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reason")
				{
					Reason = FunctionParsingErrorReasonExtensions.Parse(xItem.Value);
				}
				else if (localName == "offendingText")
				{
					OffendingText = xItem.Value;
				}
				else if (localName == "offendingTextIndex")
				{
					OffendingTextIndex = int.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "FunctionParsingError");
			XElement xItem = null;
			if (Reason != null)
			{
				xItem = new XElement(XName.Get("reason", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Reason.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (OffendingText != null)
			{
				xItem = new XElement(XName.Get("offendingText", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OffendingText);
				xE.Add(xItem);
			}
			if (OffendingTextIndex != null)
			{
				xItem = new XElement(XName.Get("offendingTextIndex", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OffendingTextIndex.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
