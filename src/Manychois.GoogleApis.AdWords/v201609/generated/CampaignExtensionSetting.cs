﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A CampaignExtensionSetting is used to add or modify extensions being served for the specified
	/// campaign.
	/// </summary>
	public class CampaignExtensionSetting : ISoapable
	{
		/// <summary>
		/// The id of the campaign for the feed items being added or modified.
		/// <span class="constraint Selectable">This field can be selected using the value "CampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? CampaignId { get; set; }
		/// <summary>
		/// The extension type the extension setting applies to.
		/// <span class="constraint Selectable">This field can be selected using the value "ExtensionType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public FeedType? ExtensionType { get; set; }
		/// <summary>
		/// The extension setting specifying which extensions to serve for the specified campaign. If
		/// extensionSetting is empty (i.e. has an empty list of feed items and null platformRestrictions),
		/// extensions are disabled for the specified extensionType.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, SET.</span>
		/// </summary>
		public ExtensionSetting ExtensionSetting { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			CampaignId = null;
			ExtensionType = null;
			ExtensionSetting = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "campaignId")
				{
					CampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "extensionType")
				{
					ExtensionType = FeedTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "extensionSetting")
				{
					ExtensionSetting = new ExtensionSetting();
					ExtensionSetting.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (CampaignId != null)
			{
				xItem = new XElement(XName.Get("campaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (ExtensionType != null)
			{
				xItem = new XElement(XName.Get("extensionType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ExtensionType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ExtensionSetting != null)
			{
				xItem = new XElement(XName.Get("extensionSetting", "https://adwords.google.com/api/adwords/cm/v201609"));
				ExtensionSetting.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
