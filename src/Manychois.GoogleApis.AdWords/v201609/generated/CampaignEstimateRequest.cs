using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a campaign that will be estimated.<p>
	///
	/// Returns traffic estimates for the requested set of campaigns.
	/// The campaigns can be all new or all existing, or a mixture of
	/// new and existing. Only existing campaigns may contain estimates for existing
	/// ad groups.<p>
	///
	/// For existing campaigns, the campaign and optionally the ad group will be
	/// used as context to produce more accurate estimates. Traffic estimates may
	/// only be requested on keywords, so regardless of whether campaign and ad group
	/// IDs are provided or left blank, at least one keyword is required to estimate
	/// traffic.<p>
	///
	/// To make a keyword estimates request in which estimates do not consider
	/// existing account information (e.g. historical ad group performance), set
	/// {@link #campaignId} to {@code null}.
	/// </summary>
	public class CampaignEstimateRequest : EstimateRequest, ISoapable
	{
		/// <summary>
		/// The campaignId of an existing campaign or {@code null}.<p>
		///
		/// Refer to the {@link CampaignEstimateRequest} documentation for
		/// detailed usage.
		/// </summary>
		public long? CampaignId { get; set; }
		/// <summary>
		/// The list of ad groups to estimate. This field is required and should not be {@code null}. At
		/// least one ad group is required.
		///
		/// <p>New campaigns may only contain new ad groups. If an
		/// {@link AdGroupEstimateRequest} has an adGroupId but the campaign is new,
		/// the API will return an error.
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// </summary>
		public List<AdGroupEstimateRequest> AdGroupEstimateRequests { get; set; }
		/// <summary>
		/// A list of {@link Criterion}s to be used for this Campaign. Criteria
		/// provide information about geographical and language targeting.
		///
		/// <p>Values in this field override the current targets in the Campaign
		/// specified by {@link #campaignId} by the following mechanism:
		///
		/// <p>This field accepts two types of {@link Criterion}s: {@link Location}, which should contain
		/// all geographic targeting and {@link Language}, which should contain all language targeting.
		/// If {@link Location}s are passed in, all geographic targeting in the campaign will be
		/// overridden.  If any {@link Language}s are passed in, all language targeting in the campaign
		/// will be overridden.
		///
		/// <p>If multiple {@link Location}s are specified, the traffic estimate will
		/// be the sum of the estimates for each targeted area. This means that if
		/// criteria are chosen which overlap each other (for example, targeting both
		/// a country and a city within that country), the traffic estimate will be
		/// be larger than if no overlap were present - i. e., the overlap region will
		/// be double-counted in the estimate.
		///
		/// <p>If no criteria are specified and this is for a new campaign then it
		/// will default to all languages in all countries and territories, and
		/// Google search.
		///
		/// <p>If no criteria are specified and this is for an existing campaign
		/// then the current targeting on that campaign will be used.
		///
		/// <p>While there's no solid limit on number of criteria,
		/// TrafficEstimatorService may return error with TOO_MANY_TARGETS if the
		/// request contains too many criteria across all
		/// {@link CampaignEstimateRequest}s in a {@link TrafficEstimatorSelector}.
		///
		/// <p>Supported Criteria : {@link Language} and {@link Location}.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// </summary>
		public List<Criterion> Criteria { get; set; }
		/// <summary>
		/// A {@link NetworkSetting} to be used for this Campaign. The value of this
		/// field overrides the current targets in the Campaign specified by
		/// {@link #campaignId}.
		///
		/// <p>For non Google partner accounts, only
		/// {@link NetworkSetting#targetGoogleSearch} and
		/// {@link NetworkSetting#targetSearchNetwork} are supported, they may be
		/// combined to sum the estimates.
		///
		/// <p>For some Google partner accounts, in addition
		/// {@link NetworkSetting#getTargetPartnerSearchNetwork} is supported.
		///
		/// <p>If all request network settings and Campaign's network settings are
		/// empty, the default is {@link NetworkSetting#targetGoogleSearch}.
		/// </summary>
		public NetworkSetting NetworkSetting { get; set; }
		/// <summary>
		/// Daily campaign budget to use in traffic estimation.  If not specified,
		/// the daily budget is unlimited.
		/// </summary>
		public Money DailyBudget { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			CampaignId = null;
			AdGroupEstimateRequests = null;
			Criteria = null;
			NetworkSetting = null;
			DailyBudget = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "campaignId")
				{
					CampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "adGroupEstimateRequests")
				{
					if (AdGroupEstimateRequests == null) AdGroupEstimateRequests = new List<AdGroupEstimateRequest>();
					var adGroupEstimateRequestsItem = new AdGroupEstimateRequest();
					adGroupEstimateRequestsItem.ReadFrom(xItem);
					AdGroupEstimateRequests.Add(adGroupEstimateRequestsItem);
				}
				else if (localName == "criteria")
				{
					if (Criteria == null) Criteria = new List<Criterion>();
					var criteriaItem = new Criterion();
					criteriaItem.ReadFrom(xItem);
					Criteria.Add(criteriaItem);
				}
				else if (localName == "networkSetting")
				{
					NetworkSetting = new NetworkSetting();
					NetworkSetting.ReadFrom(xItem);
				}
				else if (localName == "dailyBudget")
				{
					DailyBudget = new Money();
					DailyBudget.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "CampaignEstimateRequest");
			XElement xItem = null;
			if (CampaignId != null)
			{
				xItem = new XElement(XName.Get("campaignId", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(CampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (AdGroupEstimateRequests != null)
			{
				foreach (var adGroupEstimateRequestsItem in AdGroupEstimateRequests)
				{
					xItem = new XElement(XName.Get("adGroupEstimateRequests", "https://adwords.google.com/api/adwords/o/v201609"));
					adGroupEstimateRequestsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (Criteria != null)
			{
				foreach (var criteriaItem in Criteria)
				{
					xItem = new XElement(XName.Get("criteria", "https://adwords.google.com/api/adwords/o/v201609"));
					criteriaItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (NetworkSetting != null)
			{
				xItem = new XElement(XName.Get("networkSetting", "https://adwords.google.com/api/adwords/o/v201609"));
				NetworkSetting.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (DailyBudget != null)
			{
				xItem = new XElement(XName.Get("dailyBudget", "https://adwords.google.com/api/adwords/o/v201609"));
				DailyBudget.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
