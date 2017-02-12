using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Specifies if criteria of this type group should be used to restrict
	/// targeting, or if ads can serve anywhere and criteria are only used in
	/// determining the bid.
	/// <p>For more information, see
	/// <a href="https://support.google.com/adwords/answer/6056342">Targeting Settings</a>.</p>
	/// </summary>
	public class TargetingSettingDetail : ISoapable
	{
		/// <summary>
		/// The criterion type group that these settings apply to.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public CriterionTypeGroup? CriterionTypeGroup { get; set; }
		/// <summary>
		/// If true, criteria of this type can be used to modify bidding but will not restrict targeting
		/// of ads. This is equivalent to "Bid only" in the AdWords user interface.
		/// If false, restricts your ads to showing only for the criteria you have selected for this
		/// CriterionTypeGroup. This is equivalent to "Target and Bid" in the AdWords user interface.
		/// The default setting for a CriterionTypeGroup is false ("Target and Bid").
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public bool? TargetAll { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			CriterionTypeGroup = null;
			TargetAll = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "criterionTypeGroup")
				{
					CriterionTypeGroup = CriterionTypeGroupExtensions.Parse(xItem.Value);
				}
				else if (localName == "targetAll")
				{
					TargetAll = bool.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (CriterionTypeGroup != null)
			{
				xItem = new XElement(XName.Get("criterionTypeGroup", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CriterionTypeGroup.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (TargetAll != null)
			{
				xItem = new XElement(XName.Get("targetAll", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TargetAll.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
