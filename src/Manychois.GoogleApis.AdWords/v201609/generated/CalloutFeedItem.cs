using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a callout extension.
	/// </summary>
	public class CalloutFeedItem : ExtensionFeedItem, ISoapable
	{
		/// <summary>
		/// The callout text.
		/// <span class="constraint StringLength">The length of this string should be between 1 and 25, inclusive, (trimmed).</span>
		/// </summary>
		public string CalloutText { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			CalloutText = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "calloutText")
				{
					CalloutText = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CalloutFeedItem");
			XElement xItem = null;
			if (CalloutText != null)
			{
				xItem = new XElement(XName.Get("calloutText", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CalloutText);
				xE.Add(xItem);
			}
		}
	}
}
