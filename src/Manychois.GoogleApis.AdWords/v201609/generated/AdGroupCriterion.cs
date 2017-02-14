using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a criterion in an ad group, used with AdGroupCriterionService.
	/// </summary>
	public class AdGroupCriterion : ISoapable
	{
		/// <summary>
		/// The ad group this criterion is in.
		/// <span class="constraint Selectable">This field can be selected using the value "AdGroupId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? AdGroupId { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "CriterionUse".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public CriterionUse? CriterionUse { get; set; }
		/// <summary>
		/// The criterion part of the ad group criterion.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Criterion Criterion { get; set; }
		/// <summary>
		/// Labels that are attached to the AdGroupCriterion. To associate an existing {@link Label} to an
		/// existing {@link AdGroupCriterion}, use {@link AdGroupCriterionService#mutateLabel} with ADD
		/// operator. To remove an associated {@link Label} from the {@link AdGroupCriterion}, use
		/// {@link AdGroupCriterionService#mutateLabel} with REMOVE operator. To filter on {@link Label}s,
		/// use one of {@link Predicate.Operator#CONTAINS_ALL}, {@link Predicate.Operator#CONTAINS_ANY},
		/// {@link Predicate.Operator#CONTAINS_NONE} operators with a list of {@link Label} ids.
		/// <span class="constraint Selectable">This field can be selected using the value "Labels".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint CampaignType">This field may not be set for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// </summary>
		public List<Label> Labels { get; set; }
		/// <summary>
		/// This Map provides a place to put new features and settings in older versions
		/// of the AdWords API in the rare instance we need to introduce a new feature in
		/// an older version.
		///
		/// It is presently unused.  Do not set a value.
		/// </summary>
		public List<String_StringMapEntry> ForwardCompatibilityMap { get; set; }
		/// <summary>
		/// ID of the base campaign from which this draft/trial ad group criterion was created.
		/// This field is only returned on get requests.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseCampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? BaseCampaignId { get; set; }
		/// <summary>
		/// ID of the base ad group from which this draft/trial ad group criterion was created. For
		/// base ad groups this is equal to the ad group ID.  If the ad group was created
		/// in the draft or trial and has no corresponding base ad group, this field is null.
		/// This field is only returned on get requests.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseAdGroupId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? BaseAdGroupId { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of AdGroupCriterion.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string AdGroupCriterionType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			AdGroupId = null;
			CriterionUse = null;
			Criterion = null;
			Labels = null;
			ForwardCompatibilityMap = null;
			BaseCampaignId = null;
			BaseAdGroupId = null;
			AdGroupCriterionType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "adGroupId")
				{
					AdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "criterionUse")
				{
					CriterionUse = CriterionUseExtensions.Parse(xItem.Value);
				}
				else if (localName == "criterion")
				{
					Criterion = InstanceCreator.CreateCriterion(xItem);
					Criterion.ReadFrom(xItem);
				}
				else if (localName == "labels")
				{
					if (Labels == null) Labels = new List<Label>();
					var labelsItem = InstanceCreator.CreateLabel(xItem);
					labelsItem.ReadFrom(xItem);
					Labels.Add(labelsItem);
				}
				else if (localName == "forwardCompatibilityMap")
				{
					if (ForwardCompatibilityMap == null) ForwardCompatibilityMap = new List<String_StringMapEntry>();
					var forwardCompatibilityMapItem = new String_StringMapEntry();
					forwardCompatibilityMapItem.ReadFrom(xItem);
					ForwardCompatibilityMap.Add(forwardCompatibilityMapItem);
				}
				else if (localName == "baseCampaignId")
				{
					BaseCampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "baseAdGroupId")
				{
					BaseAdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "AdGroupCriterion.Type")
				{
					AdGroupCriterionType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (AdGroupId != null)
			{
				xItem = new XElement(XName.Get("adGroupId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdGroupId.Value.ToString());
				xE.Add(xItem);
			}
			if (CriterionUse != null)
			{
				xItem = new XElement(XName.Get("criterionUse", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CriterionUse.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Criterion != null)
			{
				xItem = new XElement(XName.Get("criterion", "https://adwords.google.com/api/adwords/cm/v201609"));
				Criterion.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Labels != null)
			{
				foreach (var labelsItem in Labels)
				{
					xItem = new XElement(XName.Get("labels", "https://adwords.google.com/api/adwords/cm/v201609"));
					labelsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
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
			if (BaseCampaignId != null)
			{
				xItem = new XElement(XName.Get("baseCampaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BaseCampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (BaseAdGroupId != null)
			{
				xItem = new XElement(XName.Get("baseAdGroupId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BaseAdGroupId.Value.ToString());
				xE.Add(xItem);
			}
			if (AdGroupCriterionType != null)
			{
				xItem = new XElement(XName.Get("AdGroupCriterion.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdGroupCriterionType);
				xE.Add(xItem);
			}
		}
	}
}
