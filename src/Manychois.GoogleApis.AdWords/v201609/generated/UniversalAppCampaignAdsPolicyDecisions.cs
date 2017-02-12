using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains Universal App Campaign Ads Policy decisions with asset identifier information, where
	/// available.
	/// </summary>
	public class UniversalAppCampaignAdsPolicyDecisions : ISoapable
	{
		/// <summary>
		/// Used to identify assets that are associated with the Ads Policy decisions.
		/// </summary>
		public UniversalAppCampaignAsset? UniversalAppCampaignAsset { get; set; }
		/// <summary>
		/// Unique identifier, which when combined with the UniversalAppCampaignAsset, can be used to
		/// uniquely identify the exact asset.
		///
		/// <p>For example, in the case of {@link UniversalAppCampaignAsset}.VIDEO - the id could be used
		/// to identify the individual video.
		/// </summary>
		public string AssetId { get; set; }
		/// <summary>
		/// List of policy decisions associated with the asset(s).
		/// </summary>
		public List<PolicyTopicEntry> PolicyTopicEntries { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			UniversalAppCampaignAsset = null;
			AssetId = null;
			PolicyTopicEntries = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "universalAppCampaignAsset")
				{
					UniversalAppCampaignAsset = UniversalAppCampaignAssetExtensions.Parse(xItem.Value);
				}
				else if (localName == "assetId")
				{
					AssetId = xItem.Value;
				}
				else if (localName == "policyTopicEntries")
				{
					if (PolicyTopicEntries == null) PolicyTopicEntries = new List<PolicyTopicEntry>();
					var policyTopicEntriesItem = new PolicyTopicEntry();
					policyTopicEntriesItem.ReadFrom(xItem);
					PolicyTopicEntries.Add(policyTopicEntriesItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (UniversalAppCampaignAsset != null)
			{
				xItem = new XElement(XName.Get("universalAppCampaignAsset", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UniversalAppCampaignAsset.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (AssetId != null)
			{
				xItem = new XElement(XName.Get("assetId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AssetId);
				xE.Add(xItem);
			}
			if (PolicyTopicEntries != null)
			{
				foreach (var policyTopicEntriesItem in PolicyTopicEntries)
				{
					xItem = new XElement(XName.Get("policyTopicEntries", "https://adwords.google.com/api/adwords/cm/v201609"));
					policyTopicEntriesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
