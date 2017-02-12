using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Data representing an AdWords campaign.
	/// </summary>
	public class Campaign : ISoapable
	{
		/// <summary>
		/// ID of this campaign.
		/// <span class="constraint Selectable">This field can be selected using the value "Id".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// Name of this campaign.
		/// This field is required and should not be {@code null} for ADD operations.
		///
		/// For SET and REMOVE operations, this can be used to address the campaign
		/// by name when the campaign is ENABLED or PAUSED. Removed campaigns cannot
		/// be addressed by name. If you wish to rename a campaign, you must provide
		/// the ID.
		/// <span class="constraint Selectable">This field can be selected using the value "Name".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint MatchesRegex">Campaign names must not contain any null (code point 0x0), NL line feed (code point 0xA) or carriage return (code point 0xD) characters. This is checked by the regular expression '[^\x00\x0A\x0D]*'.</span>
		/// <span class="constraint StringLength">This string must not be empty.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Status of this campaign. On add, defaults to {@code ENABLED}.
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public CampaignStatus? Status { get; set; }
		/// <summary>
		/// Serving status.
		/// <span class="constraint Selectable">This field can be selected using the value "ServingStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public ServingStatus? ServingStatus { get; set; }
		/// <summary>
		/// Date the campaign begins. On add, defaults to the current day
		/// in the parent account's local timezone. The date's format should be YYYYMMDD.
		/// <span class="constraint Selectable">This field can be selected using the value "StartDate".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string StartDate { get; set; }
		/// <summary>
		/// Date the campaign ends. On add, defaults to <code>20371230</code>, which means the
		/// campaign will run indefinitely. To set an existing campaign to run indefinitely, set this
		/// field to <code>203712<b>30</b></code>. The date's format should be YYYYMMDD.
		/// <span class="constraint Selectable">This field can be selected using the value "EndDate".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string EndDate { get; set; }
		/// <summary>
		/// Current base budget of campaign; default if no custom budgets are enabled.
		/// </summary>
		public Budget Budget { get; set; }
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public ConversionOptimizerEligibility ConversionOptimizerEligibility { get; set; }
		/// <summary>
		/// Ad serving optimization status.
		/// <span class="constraint Selectable">This field can be selected using the value "AdServingOptimizationStatus".</span>
		/// <span class="constraint CampaignType">This field may only be set to CONVERSION_OPTIMIZE for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// </summary>
		public AdServingOptimizationStatus? AdServingOptimizationStatus { get; set; }
		/// <summary>
		/// Frequency cap for this campaign.
		/// <span class="constraint CampaignType">This field may not be set for campaign channel subtypes: UNIVERSAL_APP_CAMPAIGN, SEARCH_MOBILE_APP.</span>
		/// </summary>
		public FrequencyCap FrequencyCap { get; set; }
		/// <summary>
		/// List of settings for the campaign.
		/// <span class="constraint Selectable">This field can be selected using the value "Settings".</span>
		/// </summary>
		public List<Setting> Settings { get; set; }
		/// <summary>
		/// The primary serving target for ads within this campaign. The targeting options can be refined
		/// in NetworkSetting. May only be set for new campaigns.
		/// This field is required and should not be {@code null} when it is contained within
		/// {@link Operator}s : ADD
		/// <span class="constraint Selectable">This field can be selected using the value "AdvertisingChannelType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: SET.</span>
		/// </summary>
		public AdvertisingChannelType? AdvertisingChannelType { get; set; }
		/// <summary>
		/// Optional refinement of advertisingChannelType. Must be a valid sub-type of the parent channel
		/// type. May only be set for new campaigns and cannot be changed once set.
		/// <span class="constraint Selectable">This field can be selected using the value "AdvertisingChannelSubType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: SET.</span>
		/// </summary>
		public AdvertisingChannelSubType? AdvertisingChannelSubType { get; set; }
		/// <summary>
		/// Network settings for the campaign indicating where the campaign will serve.
		/// </summary>
		public NetworkSetting NetworkSetting { get; set; }
		/// <summary>
		/// Labels that are attached to the campaign. To associate an existing {@link Label} to an
		/// existing {@link Campaign}, use {@link CampaignService#mutateLabel} with the ADD
		/// operator. To remove an associated {@link Label} from the {@link Campaign}, use
		/// {@link CampaignService#mutateLabel} with the REMOVE operator. To filter on {@link Label}s,
		/// use one of {@link Predicate.Operator#CONTAINS_ALL}, {@link Predicate.Operator#CONTAINS_ANY},
		/// {@link Predicate.Operator#CONTAINS_NONE} operators with a list of {@link Label} ids.
		/// <span class="constraint Selectable">This field can be selected using the value "Labels".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// </summary>
		public List<Label> Labels { get; set; }
		/// <summary>
		/// Bidding configuration for this campaign. To change an existing campaign's
		/// bidding strategy, set the {@link BiddingStrategyConfiguration#biddingStrategyType}
		/// or {@link BiddingStrategyConfiguration#biddingScheme}.
		/// This field is required and should not be {@code null} when it is contained within
		/// {@link Operator}s : ADD
		/// </summary>
		public BiddingStrategyConfiguration BiddingStrategyConfiguration { get; set; }
		/// <summary>
		/// Indicates if this campaign is a normal campaign, a draft campaign,
		/// or a trial campaign.
		/// <span class="constraint Selectable">This field can be selected using the value "CampaignTrialType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public CampaignTrialType? CampaignTrialType { get; set; }
		/// <summary>
		/// ID of the base campaign of the draft or trial campaign. For base campaigns, this is equal to
		/// the campaign ID.  This field is only returned on get requests.
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
		/// URL template for constructing a tracking URL.
		///
		/// <p>On update, empty string ("") indicates to clear the field.
		/// <span class="constraint Selectable">This field can be selected using the value "TrackingUrlTemplate".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint CampaignType">This field may not be set for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// </summary>
		public string TrackingUrlTemplate { get; set; }
		/// <summary>
		/// A list of mappings to be used for substituting URL custom parameter tags in the
		/// trackingUrlTemplate, finalUrls, and/or finalMobileUrls.
		/// <span class="constraint Selectable">This field can be selected using the value "UrlCustomParameters".</span>
		/// <span class="constraint CampaignType">This field may not be set for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// </summary>
		public CustomParameters UrlCustomParameters { get; set; }
		/// <summary>
		/// Describes how unbranded pharma ads will be displayed.
		/// <span class="constraint CampaignType">This field may not be set for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// </summary>
		public VanityPharma VanityPharma { get; set; }
		/// <summary>
		/// Selective optimization setting for this campaign, which includes a set of conversion
		/// types to optimize this campaign towards.
		/// <span class="constraint Selectable">This field can be selected using the value "SelectiveOptimization".</span>
		/// <span class="constraint CampaignType">This field may only be set for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// <span class="constraint CampaignType">This field may not be set.</span>
		/// </summary>
		public SelectiveOptimization SelectiveOptimization { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			Name = null;
			Status = null;
			ServingStatus = null;
			StartDate = null;
			EndDate = null;
			Budget = null;
			ConversionOptimizerEligibility = null;
			AdServingOptimizationStatus = null;
			FrequencyCap = null;
			Settings = null;
			AdvertisingChannelType = null;
			AdvertisingChannelSubType = null;
			NetworkSetting = null;
			Labels = null;
			BiddingStrategyConfiguration = null;
			CampaignTrialType = null;
			BaseCampaignId = null;
			ForwardCompatibilityMap = null;
			TrackingUrlTemplate = null;
			UrlCustomParameters = null;
			VanityPharma = null;
			SelectiveOptimization = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "status")
				{
					Status = CampaignStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "servingStatus")
				{
					ServingStatus = ServingStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "startDate")
				{
					StartDate = xItem.Value;
				}
				else if (localName == "endDate")
				{
					EndDate = xItem.Value;
				}
				else if (localName == "budget")
				{
					Budget = new Budget();
					Budget.ReadFrom(xItem);
				}
				else if (localName == "conversionOptimizerEligibility")
				{
					ConversionOptimizerEligibility = new ConversionOptimizerEligibility();
					ConversionOptimizerEligibility.ReadFrom(xItem);
				}
				else if (localName == "adServingOptimizationStatus")
				{
					AdServingOptimizationStatus = AdServingOptimizationStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "frequencyCap")
				{
					FrequencyCap = new FrequencyCap();
					FrequencyCap.ReadFrom(xItem);
				}
				else if (localName == "settings")
				{
					if (Settings == null) Settings = new List<Setting>();
					var settingsItem = InstanceCreator.CreateSetting(xItem);
					settingsItem.ReadFrom(xItem);
					Settings.Add(settingsItem);
				}
				else if (localName == "advertisingChannelType")
				{
					AdvertisingChannelType = AdvertisingChannelTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "advertisingChannelSubType")
				{
					AdvertisingChannelSubType = AdvertisingChannelSubTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "networkSetting")
				{
					NetworkSetting = new NetworkSetting();
					NetworkSetting.ReadFrom(xItem);
				}
				else if (localName == "labels")
				{
					if (Labels == null) Labels = new List<Label>();
					var labelsItem = new Label();
					labelsItem.ReadFrom(xItem);
					Labels.Add(labelsItem);
				}
				else if (localName == "biddingStrategyConfiguration")
				{
					BiddingStrategyConfiguration = new BiddingStrategyConfiguration();
					BiddingStrategyConfiguration.ReadFrom(xItem);
				}
				else if (localName == "campaignTrialType")
				{
					CampaignTrialType = CampaignTrialTypeExtensions.Parse(xItem.Value);
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
				else if (localName == "trackingUrlTemplate")
				{
					TrackingUrlTemplate = xItem.Value;
				}
				else if (localName == "urlCustomParameters")
				{
					UrlCustomParameters = new CustomParameters();
					UrlCustomParameters.ReadFrom(xItem);
				}
				else if (localName == "vanityPharma")
				{
					VanityPharma = new VanityPharma();
					VanityPharma.ReadFrom(xItem);
				}
				else if (localName == "selectiveOptimization")
				{
					SelectiveOptimization = new SelectiveOptimization();
					SelectiveOptimization.ReadFrom(xItem);
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
			if (ServingStatus != null)
			{
				xItem = new XElement(XName.Get("servingStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ServingStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (StartDate != null)
			{
				xItem = new XElement(XName.Get("startDate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StartDate);
				xE.Add(xItem);
			}
			if (EndDate != null)
			{
				xItem = new XElement(XName.Get("endDate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EndDate);
				xE.Add(xItem);
			}
			if (Budget != null)
			{
				xItem = new XElement(XName.Get("budget", "https://adwords.google.com/api/adwords/cm/v201609"));
				Budget.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (ConversionOptimizerEligibility != null)
			{
				xItem = new XElement(XName.Get("conversionOptimizerEligibility", "https://adwords.google.com/api/adwords/cm/v201609"));
				ConversionOptimizerEligibility.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (AdServingOptimizationStatus != null)
			{
				xItem = new XElement(XName.Get("adServingOptimizationStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdServingOptimizationStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (FrequencyCap != null)
			{
				xItem = new XElement(XName.Get("frequencyCap", "https://adwords.google.com/api/adwords/cm/v201609"));
				FrequencyCap.WriteTo(xItem);
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
			if (AdvertisingChannelType != null)
			{
				xItem = new XElement(XName.Get("advertisingChannelType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdvertisingChannelType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (AdvertisingChannelSubType != null)
			{
				xItem = new XElement(XName.Get("advertisingChannelSubType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdvertisingChannelSubType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (NetworkSetting != null)
			{
				xItem = new XElement(XName.Get("networkSetting", "https://adwords.google.com/api/adwords/cm/v201609"));
				NetworkSetting.WriteTo(xItem);
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
			if (BiddingStrategyConfiguration != null)
			{
				xItem = new XElement(XName.Get("biddingStrategyConfiguration", "https://adwords.google.com/api/adwords/cm/v201609"));
				BiddingStrategyConfiguration.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (CampaignTrialType != null)
			{
				xItem = new XElement(XName.Get("campaignTrialType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CampaignTrialType.Value.ToXmlValue());
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
			if (VanityPharma != null)
			{
				xItem = new XElement(XName.Get("vanityPharma", "https://adwords.google.com/api/adwords/cm/v201609"));
				VanityPharma.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (SelectiveOptimization != null)
			{
				xItem = new XElement(XName.Get("selectiveOptimization", "https://adwords.google.com/api/adwords/cm/v201609"));
				SelectiveOptimization.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
