using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Setting for targeting related features.
	/// This is applicable at Campaign and AdGroup level.
	/// </summary>
	public class TargetingSetting : Setting, ISoapable
	{
		/// <summary>
		/// The list of per-criterion-type-group targeting settings.
		/// </summary>
		public List<TargetingSettingDetail> Details { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Details = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "details")
				{
					if (Details == null) Details = new List<TargetingSettingDetail>();
					var detailsItem = new TargetingSettingDetail();
					detailsItem.ReadFrom(xItem);
					Details.Add(detailsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "TargetingSetting");
			XElement xItem = null;
			if (Details != null)
			{
				foreach (var detailsItem in Details)
				{
					xItem = new XElement(XName.Get("details", "https://adwords.google.com/api/adwords/cm/v201609"));
					detailsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
