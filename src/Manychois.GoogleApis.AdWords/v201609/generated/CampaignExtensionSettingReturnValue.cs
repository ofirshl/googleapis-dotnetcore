﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A container for return values from a {@code CampaignExtensionSettingService#mutate} call.
	/// </summary>
	public class CampaignExtensionSettingReturnValue : ListReturnValue, ISoapable
	{
		/// <summary>
		/// The resulting CampaignExtensionSettings.
		/// </summary>
		public List<CampaignExtensionSetting> Value { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					if (Value == null) Value = new List<CampaignExtensionSetting>();
					var valueItem = new CampaignExtensionSetting();
					valueItem.ReadFrom(xItem);
					Value.Add(valueItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CampaignExtensionSettingReturnValue");
			XElement xItem = null;
			if (Value != null)
			{
				foreach (var valueItem in Value)
				{
					xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/cm/v201609"));
					valueItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
