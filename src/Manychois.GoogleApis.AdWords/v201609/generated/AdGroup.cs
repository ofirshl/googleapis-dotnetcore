using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an ad group.
	/// </summary>
	public class AdGroup : ISoapable
	{
		/// <summary>
		/// ID of this ad group.
		/// <span class="constraint Selectable">This field can be selected using the value "Id".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// ID of the campaign with which this ad group is associated.
		/// <span class="constraint Selectable">This field can be selected using the value "CampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public long? CampaignId { get; set; }
		/// <summary>
		/// Name of the campaign with which this ad group is associated.
		/// <span class="constraint Selectable">This field can be selected using the value "CampaignName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string CampaignName { get; set; }
		/// <summary>
		/// Name of this ad group (at most 255 UTF-8 full-width characters).
		/// This field is required and should not be {@code null} for ADD operations from v201309 version.
		/// <span class="constraint Selectable">This field can be selected using the value "Name".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint MatchesRegex">AdGroup names must not contain any null (code point 0x0), NL line feed (code point 0xA) or carriage return (code point 0xD) characters. This is checked by the regular expression '[^\x00\x0A\x0D]*'.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Status of this ad group.
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public AdGroupStatus? Status { get; set; }
		/// <summary>
		/// List of settings for the AdGroup.
		/// <span class="constraint Selectable">This field can be selected using the value "Settings".</span>
		/// </summary>
		public List<Setting> Settings { get; set; }
		/// <summary>
		/// Labels that are attached to the {@link AdGroup}. To associate an existing {@link Label} to an
		/// existing {@link AdGroup}, use {@link AdGroupService#mutateLabel} with ADD
		/// operator. To remove an associated {@link Label} from the {@link AdGroup}, use
		/// {@link AdGroupService#mutateLabel} with REMOVE operator. To filter on {@link Label}s,
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
		/// Bidding configuration for this ad group. To set the bids on the ad groups use
		/// {@link BiddingStrategyConfiguration#bids}. Multiple bids can be set on ad group at the same
		/// time. Only the bids that apply to the effective bidding strategy will be used. Effective
		/// bidding strategy is considered to be the directly attached strategy or inherited campaign level
		/// strategy when there?s no directly attached strategy.
		/// </summary>
		public BiddingStrategyConfiguration BiddingStrategyConfiguration { get; set; }
		/// <summary>
		/// Allows advertisers to specify a criteria dimension on which to place absolute bids.
		/// This is only applicable for campaigns that target only the content network and not search.
		/// <span class="constraint Selectable">This field can be selected using the value "ContentBidCriterionTypeGroup".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public CriterionTypeGroup? ContentBidCriterionTypeGroup { get; set; }
		/// <summary>
		/// ID of the base campaign from which this draft/trial adgroup was created. This
		/// field is only returned on get requests.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseCampaignId".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? BaseCampaignId { get; set; }
		/// <summary>
		/// ID of the base adgroup from which this draft/trial adgroup was created. For
		/// base adgroups this is equal to the adgroup ID.  If the adgroup was created
		/// in the draft or trial and has no corresponding base adgroup, this field is null.
		/// This field is readonly and only returned on get requests.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseAdGroupId".</span>
		/// </summary>
		public long? BaseAdGroupId { get; set; }
		/// <summary>
		/// URL template for constructing a tracking URL.
		///
		/// <p>On update, empty string ("") indicates to clear the field.
		/// <span class="constraint Selectable">This field can be selected using the value "TrackingUrlTemplate".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string TrackingUrlTemplate { get; set; }
		/// <summary>
		/// A list of mappings to be used for substituting URL custom parameter tags in the
		/// trackingUrlTemplate, finalUrls, and/or finalMobileUrls.
		/// <span class="constraint Selectable">This field can be selected using the value "UrlCustomParameters".</span>
		/// </summary>
		public CustomParameters UrlCustomParameters { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			CampaignId = null;
			CampaignName = null;
			Name = null;
			Status = null;
			Settings = null;
			Labels = null;
			ForwardCompatibilityMap = null;
			BiddingStrategyConfiguration = null;
			ContentBidCriterionTypeGroup = null;
			BaseCampaignId = null;
			BaseAdGroupId = null;
			TrackingUrlTemplate = null;
			UrlCustomParameters = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "campaignId")
				{
					CampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "campaignName")
				{
					CampaignName = xItem.Value;
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "status")
				{
					Status = AdGroupStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "settings")
				{
					if (Settings == null) Settings = new List<Setting>();
					var settingsItem = InstanceCreator.CreateSetting(xItem);
					settingsItem.ReadFrom(xItem);
					Settings.Add(settingsItem);
				}
				else if (localName == "labels")
				{
					if (Labels == null) Labels = new List<Label>();
					var labelsItem = new Label();
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
				else if (localName == "biddingStrategyConfiguration")
				{
					BiddingStrategyConfiguration = new BiddingStrategyConfiguration();
					BiddingStrategyConfiguration.ReadFrom(xItem);
				}
				else if (localName == "contentBidCriterionTypeGroup")
				{
					ContentBidCriterionTypeGroup = CriterionTypeGroupExtensions.Parse(xItem.Value);
				}
				else if (localName == "baseCampaignId")
				{
					BaseCampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "baseAdGroupId")
				{
					BaseAdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "trackingUrlTemplate")
				{
					TrackingUrlTemplate = xItem.Value;
				}
				else if (localName == "urlCustomParameters")
				{
					UrlCustomParameters = new CustomParameters();
					UrlCustomParameters.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (CampaignId != null)
			{
				xItem = new XElement(XName.Get("campaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (CampaignName != null)
			{
				xItem = new XElement(XName.Get("campaignName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CampaignName);
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Settings != null)
			{
				foreach (var settingsItem in Settings)
				{
					xItem = new XElement(XName.Get("settings", "https://adwords.google.com/api/adwords/cm/v201609"));
					settingsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
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
			if (BiddingStrategyConfiguration != null)
			{
				xItem = new XElement(XName.Get("biddingStrategyConfiguration", "https://adwords.google.com/api/adwords/cm/v201609"));
				BiddingStrategyConfiguration.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (ContentBidCriterionTypeGroup != null)
			{
				xItem = new XElement(XName.Get("contentBidCriterionTypeGroup", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ContentBidCriterionTypeGroup.Value.ToXmlValue());
				xE.Add(xItem);
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
			if (TrackingUrlTemplate != null)
			{
				xItem = new XElement(XName.Get("trackingUrlTemplate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TrackingUrlTemplate);
				xE.Add(xItem);
			}
			if (UrlCustomParameters != null)
			{
				xItem = new XElement(XName.Get("urlCustomParameters", "https://adwords.google.com/api/adwords/cm/v201609"));
				UrlCustomParameters.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
