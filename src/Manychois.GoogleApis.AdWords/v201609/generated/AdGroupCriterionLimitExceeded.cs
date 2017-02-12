using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Signals that too many criteria were added to some ad group.
	/// </summary>
	public class AdGroupCriterionLimitExceeded : EntityCountLimitExceeded, ISoapable
	{
		public AdGroupCriterionLimitExceededCriteriaLimitType? LimitType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			LimitType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "limitType")
				{
					LimitType = AdGroupCriterionLimitExceededCriteriaLimitTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AdGroupCriterionLimitExceeded");
			XElement xItem = null;
			if (LimitType != null)
			{
				xItem = new XElement(XName.Get("limitType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LimitType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
