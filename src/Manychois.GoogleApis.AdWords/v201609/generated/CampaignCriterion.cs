using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a campaign level criterion.
	/// </summary>
	public class CampaignCriterion : ISoapable
	{
		/// <summary>
		/// The campaign that the criterion is in.
		/// <span class="constraint Selectable">This field can be selected using the value "CampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? CampaignId { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "IsNegative".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? IsNegative { get; set; }
		/// <summary>
		/// The criterion part of the campaign criterion.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Criterion Criterion { get; set; }
		/// <summary>
		/// The modifier for bids when the criterion matches.
		///
		/// <p> Valid modifier values range from {@code 0.1} to {@code 10.0}, with {@code 0.0} reserved
		/// for opting out of platform criterion.
		/// <p>Specify {@code -1.0} to clear existing bid modifier.
		/// <span class="constraint Selectable">This field can be selected using the value "BidModifier".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public double? BidModifier { get; set; }
		/// <summary>
		/// The status for criteria.
		/// <span class="constraint Selectable">This field can be selected using the value "CampaignCriterionStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public CampaignCriterionCampaignCriterionStatus? CampaignCriterionStatus { get; set; }
		/// <summary>
		/// ID of the base campaign from which this draft/trial campaign criterion was created.
		/// This field is only returned on get requests.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseCampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? BaseCampaignId { get; set; }
		/// <summary>
		/// This Map provides a place to put new features and settings in older versions
		/// of the AdWords API in the rare instance we need to introduce a new feature in
		/// an older version.
		///
		/// It is presently unused.  Do not set a value.
		/// </summary>
		public List<String_StringMapEntry> ForwardCompatibilityMap { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of CampaignCriterion.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string CampaignCriterionType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			CampaignId = null;
			IsNegative = null;
			Criterion = null;
			BidModifier = null;
			CampaignCriterionStatus = null;
			BaseCampaignId = null;
			ForwardCompatibilityMap = null;
			CampaignCriterionType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "campaignId")
				{
					CampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "isNegative")
				{
					IsNegative = bool.Parse(xItem.Value);
				}
				else if (localName == "criterion")
				{
					Criterion = InstanceCreator.CreateCriterion(xItem);
					Criterion.ReadFrom(xItem);
				}
				else if (localName == "bidModifier")
				{
					BidModifier = double.Parse(xItem.Value);
				}
				else if (localName == "campaignCriterionStatus")
				{
					CampaignCriterionStatus = CampaignCriterionCampaignCriterionStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "baseCampaignId")
				{
					BaseCampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "forwardCompatibilityMap")
				{
					if (ForwardCompatibilityMap == null) ForwardCompatibilityMap = new List<String_StringMapEntry>();
					var forwardCompatibilityMapItem = new String_StringMapEntry();
					forwardCompatibilityMapItem.ReadFrom(xItem);
					ForwardCompatibilityMap.Add(forwardCompatibilityMapItem);
				}
				else if (localName == "CampaignCriterion.Type")
				{
					CampaignCriterionType = xItem.Value;
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
			if (IsNegative != null)
			{
				xItem = new XElement(XName.Get("isNegative", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsNegative.Value.ToString());
				xE.Add(xItem);
			}
			if (Criterion != null)
			{
				xItem = new XElement(XName.Get("criterion", "https://adwords.google.com/api/adwords/cm/v201609"));
				Criterion.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (BidModifier != null)
			{
				xItem = new XElement(XName.Get("bidModifier", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BidModifier.Value.ToString());
				xE.Add(xItem);
			}
			if (CampaignCriterionStatus != null)
			{
				xItem = new XElement(XName.Get("campaignCriterionStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CampaignCriterionStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (BaseCampaignId != null)
			{
				xItem = new XElement(XName.Get("baseCampaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BaseCampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (ForwardCompatibilityMap != null)
			{
				foreach (var forwardCompatibilityMapItem in ForwardCompatibilityMap)
				{
					xItem = new XElement(XName.Get("forwardCompatibilityMap", "https://adwords.google.com/api/adwords/cm/v201609"));
					forwardCompatibilityMapItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (CampaignCriterionType != null)
			{
				xItem = new XElement(XName.Get("CampaignCriterion.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CampaignCriterionType);
				xE.Add(xItem);
			}
		}
	}
}
