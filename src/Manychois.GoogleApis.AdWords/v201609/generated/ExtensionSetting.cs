using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A setting specifying when and which extensions should serve at a given level (customer, campaign,
	/// or ad group).
	/// </summary>
	public class ExtensionSetting : ISoapable
	{
		/// <summary>
		/// The list of feed items to add or modify.
		/// <span class="constraint Selectable">This field can be selected using the value "Extensions".</span>
		/// </summary>
		public List<ExtensionFeedItem> Extensions { get; set; }
		/// <summary>
		/// Any platform (desktop, mobile) restrictions for feed items being served. If set to DESKTOP or
		/// MOBILE, only those feed items with the appropriate device preference or no device preference
		/// will serve.
		/// <span class="constraint Selectable">This field can be selected using the value "PlatformRestrictions".</span>
		/// </summary>
		public ExtensionSettingPlatform? PlatformRestrictions { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Extensions = null;
			PlatformRestrictions = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "extensions")
				{
					if (Extensions == null) Extensions = new List<ExtensionFeedItem>();
					var extensionsItem = new ExtensionFeedItem();
					extensionsItem.ReadFrom(xItem);
					Extensions.Add(extensionsItem);
				}
				else if (localName == "platformRestrictions")
				{
					PlatformRestrictions = ExtensionSettingPlatformExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Extensions != null)
			{
				foreach (var extensionsItem in Extensions)
				{
					xItem = new XElement(XName.Get("extensions", "https://adwords.google.com/api/adwords/cm/v201609"));
					extensionsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (PlatformRestrictions != null)
			{
				xItem = new XElement(XName.Get("platformRestrictions", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PlatformRestrictions.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
