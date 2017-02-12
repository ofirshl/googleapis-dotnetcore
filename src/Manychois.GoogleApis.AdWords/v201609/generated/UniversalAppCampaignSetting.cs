using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Setting for storing the mobile app to advertise and creative assets for Universal app campaigns.
	/// This setting is required for Campaigns with advertising channel subtype UNIVERSAL_APP_CAMPAIGN
	/// and can only be attached to such Campaigns.
	/// </summary>
	public class UniversalAppCampaignSetting : Setting, ISoapable
	{
		/// <summary>
		/// A string that uniquely identifies a mobile application. The appId should be the same as the
		/// vendor native id for the app. For example the Android Application "Color Drips"
		/// (https://play.google.com/store/apps/details?id=com.labpixies.colordrips) would have the appId -
		/// "com.labpixies.colordrips".
		/// <span class="constraint Filterable">This field can be filtered on using the value "UniversalAppCampaignSettingAppId".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string AppId { get; set; }
		/// <summary>
		/// A description line of your mobile application promotion ad(s).
		/// <span class="constraint MatchesRegex">Description must not contain any '{' or '}' characters. This is checked by the regular expression '[^\{\}]*'.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 25, inclusive, (trimmed).</span>
		/// </summary>
		public string Description1 { get; set; }
		/// <summary>
		/// A description line of your mobile application promotion ad(s).
		/// <span class="constraint MatchesRegex">Description must not contain any '{' or '}' characters. This is checked by the regular expression '[^\{\}]*'.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 25, inclusive, (trimmed).</span>
		/// </summary>
		public string Description2 { get; set; }
		/// <summary>
		/// A description line of your mobile application promotion ad(s).
		/// <span class="constraint MatchesRegex">Description must not contain any '{' or '}' characters. This is checked by the regular expression '[^\{\}]*'.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 25, inclusive, (trimmed).</span>
		/// </summary>
		public string Description3 { get; set; }
		/// <summary>
		/// A description line of your mobile application promotion ad(s).
		/// <span class="constraint MatchesRegex">Description must not contain any '{' or '}' characters. This is checked by the regular expression '[^\{\}]*'.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 25, inclusive, (trimmed).</span>
		/// </summary>
		public string Description4 { get; set; }
		/// <summary>
		/// MediaIds for YouTube videos to be shown to users when advertising on video networks.
		/// </summary>
		public List<long> YoutubeVideoMediaIds { get; set; }
		/// <summary>
		/// MediaIds for landscape images to be used in creatives to be shown to users when advertising on
		/// display networks.
		/// </summary>
		public List<long> ImageMediaIds { get; set; }
		/// <summary>
		/// Represents the goal towards which the bidding strategy, of this universal app campaign, should
		/// optimize for.
		/// </summary>
		public UniversalAppBiddingStrategyGoalType? UniversalAppBiddingStrategyGoalType { get; set; }
		/// <summary>
		/// Operations for YouTube Video MediaIds.
		/// </summary>
		public ListOperations YoutubeVideoMediaIdsOps { get; set; }
		/// <summary>
		/// Operations for Image MediaIds.
		/// </summary>
		public ListOperations ImageMediaIdsOps { get; set; }
		/// <summary>
		/// Ads policy decisions associated with asset(s).
		/// </summary>
		public List<UniversalAppCampaignAdsPolicyDecisions> AdsPolicyDecisions { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			AppId = null;
			Description1 = null;
			Description2 = null;
			Description3 = null;
			Description4 = null;
			YoutubeVideoMediaIds = null;
			ImageMediaIds = null;
			UniversalAppBiddingStrategyGoalType = null;
			YoutubeVideoMediaIdsOps = null;
			ImageMediaIdsOps = null;
			AdsPolicyDecisions = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "appId")
				{
					AppId = xItem.Value;
				}
				else if (localName == "description1")
				{
					Description1 = xItem.Value;
				}
				else if (localName == "description2")
				{
					Description2 = xItem.Value;
				}
				else if (localName == "description3")
				{
					Description3 = xItem.Value;
				}
				else if (localName == "description4")
				{
					Description4 = xItem.Value;
				}
				else if (localName == "youtubeVideoMediaIds")
				{
					if (YoutubeVideoMediaIds == null) YoutubeVideoMediaIds = new List<long>();
					YoutubeVideoMediaIds.Add(long.Parse(xItem.Value));
				}
				else if (localName == "imageMediaIds")
				{
					if (ImageMediaIds == null) ImageMediaIds = new List<long>();
					ImageMediaIds.Add(long.Parse(xItem.Value));
				}
				else if (localName == "universalAppBiddingStrategyGoalType")
				{
					UniversalAppBiddingStrategyGoalType = UniversalAppBiddingStrategyGoalTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "youtubeVideoMediaIdsOps")
				{
					YoutubeVideoMediaIdsOps = new ListOperations();
					YoutubeVideoMediaIdsOps.ReadFrom(xItem);
				}
				else if (localName == "imageMediaIdsOps")
				{
					ImageMediaIdsOps = new ListOperations();
					ImageMediaIdsOps.ReadFrom(xItem);
				}
				else if (localName == "adsPolicyDecisions")
				{
					if (AdsPolicyDecisions == null) AdsPolicyDecisions = new List<UniversalAppCampaignAdsPolicyDecisions>();
					var adsPolicyDecisionsItem = new UniversalAppCampaignAdsPolicyDecisions();
					adsPolicyDecisionsItem.ReadFrom(xItem);
					AdsPolicyDecisions.Add(adsPolicyDecisionsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "UniversalAppCampaignSetting");
			XElement xItem = null;
			if (AppId != null)
			{
				xItem = new XElement(XName.Get("appId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AppId);
				xE.Add(xItem);
			}
			if (Description1 != null)
			{
				xItem = new XElement(XName.Get("description1", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description1);
				xE.Add(xItem);
			}
			if (Description2 != null)
			{
				xItem = new XElement(XName.Get("description2", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description2);
				xE.Add(xItem);
			}
			if (Description3 != null)
			{
				xItem = new XElement(XName.Get("description3", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description3);
				xE.Add(xItem);
			}
			if (Description4 != null)
			{
				xItem = new XElement(XName.Get("description4", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description4);
				xE.Add(xItem);
			}
			if (YoutubeVideoMediaIds != null)
			{
				foreach (var youtubeVideoMediaIdsItem in YoutubeVideoMediaIds)
				{
					xItem = new XElement(XName.Get("youtubeVideoMediaIds", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(youtubeVideoMediaIdsItem.ToString());
					xE.Add(xItem);
				}
			}
			if (ImageMediaIds != null)
			{
				foreach (var imageMediaIdsItem in ImageMediaIds)
				{
					xItem = new XElement(XName.Get("imageMediaIds", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(imageMediaIdsItem.ToString());
					xE.Add(xItem);
				}
			}
			if (UniversalAppBiddingStrategyGoalType != null)
			{
				xItem = new XElement(XName.Get("universalAppBiddingStrategyGoalType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UniversalAppBiddingStrategyGoalType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (YoutubeVideoMediaIdsOps != null)
			{
				xItem = new XElement(XName.Get("youtubeVideoMediaIdsOps", "https://adwords.google.com/api/adwords/cm/v201609"));
				YoutubeVideoMediaIdsOps.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (ImageMediaIdsOps != null)
			{
				xItem = new XElement(XName.Get("imageMediaIdsOps", "https://adwords.google.com/api/adwords/cm/v201609"));
				ImageMediaIdsOps.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (AdsPolicyDecisions != null)
			{
				foreach (var adsPolicyDecisionsItem in AdsPolicyDecisions)
				{
					xItem = new XElement(XName.Get("adsPolicyDecisions", "https://adwords.google.com/api/adwords/cm/v201609"));
					adsPolicyDecisionsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
