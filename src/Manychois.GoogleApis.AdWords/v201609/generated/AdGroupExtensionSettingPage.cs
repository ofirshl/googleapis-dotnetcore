using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains a subset of AdGroupExtensionSetting objects resulting from a
	/// {@code AdGroupExtensionSettingService#get} call.
	/// </summary>
	public class AdGroupExtensionSettingPage : Page, ISoapable
	{
		/// <summary>
		/// The result entries in this page.
		/// </summary>
		public List<AdGroupExtensionSetting> Entries { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Entries = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "entries")
				{
					if (Entries == null) Entries = new List<AdGroupExtensionSetting>();
					var entriesItem = new AdGroupExtensionSetting();
					entriesItem.ReadFrom(xItem);
					Entries.Add(entriesItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AdGroupExtensionSettingPage");
			XElement xItem = null;
			if (Entries != null)
			{
				foreach (var entriesItem in Entries)
				{
					xItem = new XElement(XName.Get("entries", "https://adwords.google.com/api/adwords/cm/v201609"));
					entriesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
