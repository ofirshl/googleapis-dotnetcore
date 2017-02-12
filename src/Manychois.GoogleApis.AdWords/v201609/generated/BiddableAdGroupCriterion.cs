using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A biddable (positive) criterion in an adgroup.
	/// </summary>
	public class BiddableAdGroupCriterion : AdGroupCriterion, ISoapable
	{
		/// <summary>
		/// Current user-set state of criterion.
		/// UserStatus may not be set to {@code REMOVED} and is not supported for ProductPartition
		/// criterion. On add, defaults to {@code ENABLED} if unspecified.
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public UserStatus? UserStatus { get; set; }
		/// <summary>
		/// Serving status.
		/// <span class="constraint Selectable">This field can be selected using the value "SystemServingStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public SystemServingStatus? SystemServingStatus { get; set; }
		/// <summary>
		/// Approval status.
		/// <span class="constraint Selectable">This field can be selected using the value "ApprovalStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public ApprovalStatus? ApprovalStatus { get; set; }
		/// <summary>
		/// List of disapproval reasons.
		/// <span class="constraint Selectable">This field can be selected using the value "DisapprovalReasons".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<string> DisapprovalReasons { get; set; }
		/// <summary>
		/// Destination URL override when Ad is triggered by this criterion.
		///
		/// <p>Some sample valid URLs are: "http://www.website.com",
		/// "http://www.domain.com/somepath".
		/// <p>Set to the empty string ("") to clear the destination URL.
		/// <span class="constraint Selectable">This field can be selected using the value "DestinationUrl".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string DestinationUrl { get; set; }
		/// <summary>
		/// First page Cpc for this criterion.
		/// <span class="constraint Selectable">This field can be selected using the value "FirstPageCpc".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public Bid FirstPageCpc { get; set; }
		/// <summary>
		/// An estimate of the cpc bid needed for your ad to appear above the
		/// first page of Google search results when a query matches the keywords exactly.
		/// Note that meeting this estimate is not a guarantee of ad position,
		/// which may depend on other factors.
		/// <span class="constraint Selectable">This field can be selected using the value "TopOfPageCpc".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public Bid TopOfPageCpc { get; set; }
		/// <summary>
		/// An estimate of the cpc bid needed for your ad to regularly appear in the top position above
		/// the search results on google.com when a query matches the keywords exactly.  Note that meeting
		/// this estimate is not a guarantee of ad position, which may depend on other factors.
		/// <span class="constraint Selectable">This field can be selected using the value "FirstPositionCpc".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public Bid FirstPositionCpc { get; set; }
		/// <summary>
		/// Contains quality information about the criterion.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public QualityInfo QualityInfo { get; set; }
		/// <summary>
		/// Bidding configuration for this ad group criterion. To set the bids on the ad groups
		/// use {@link BiddingStrategyConfiguration#bids}. Multiple bids can be set on
		/// ad group criterion at the same time. Only the bids that apply to the campaign's bidding
		/// strategy {@linkplain Campaign#biddingStrategyConfiguration bidding strategy}
		/// will be used.
		/// </summary>
		public BiddingStrategyConfiguration BiddingStrategyConfiguration { get; set; }
		/// <summary>
		/// Bid modifier of the criterion which is used when the criterion is not in an absolute bidding
		/// dimension.
		/// <span class="constraint Selectable">This field can be selected using the value "BidModifier".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public double? BidModifier { get; set; }
		/// <summary>
		/// A list of possible final URLs after all cross domain redirects.
		/// <span class="constraint Selectable">This field can be selected using the value "FinalUrls".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public UrlList FinalUrls { get; set; }
		/// <summary>
		/// A list of possible final mobile URLs after all cross domain redirects.
		/// <span class="constraint Selectable">This field can be selected using the value "FinalMobileUrls".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public UrlList FinalMobileUrls { get; set; }
		/// <summary>
		/// A list of final app URLs that will be used on mobile if the user has the specific app
		/// installed.
		/// <span class="constraint Selectable">This field can be selected using the value "FinalAppUrls".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public AppUrlList FinalAppUrls { get; set; }
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
		/// <span class="constraint Selectable">This field can be selected using the value "UrlCustomParameters".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public CustomParameters UrlCustomParameters { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			UserStatus = null;
			SystemServingStatus = null;
			ApprovalStatus = null;
			DisapprovalReasons = null;
			DestinationUrl = null;
			FirstPageCpc = null;
			TopOfPageCpc = null;
			FirstPositionCpc = null;
			QualityInfo = null;
			BiddingStrategyConfiguration = null;
			BidModifier = null;
			FinalUrls = null;
			FinalMobileUrls = null;
			FinalAppUrls = null;
			TrackingUrlTemplate = null;
			UrlCustomParameters = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "userStatus")
				{
					UserStatus = UserStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "systemServingStatus")
				{
					SystemServingStatus = SystemServingStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "approvalStatus")
				{
					ApprovalStatus = ApprovalStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "disapprovalReasons")
				{
					if (DisapprovalReasons == null) DisapprovalReasons = new List<string>();
					DisapprovalReasons.Add(xItem.Value);
				}
				else if (localName == "destinationUrl")
				{
					DestinationUrl = xItem.Value;
				}
				else if (localName == "firstPageCpc")
				{
					FirstPageCpc = new Bid();
					FirstPageCpc.ReadFrom(xItem);
				}
				else if (localName == "topOfPageCpc")
				{
					TopOfPageCpc = new Bid();
					TopOfPageCpc.ReadFrom(xItem);
				}
				else if (localName == "firstPositionCpc")
				{
					FirstPositionCpc = new Bid();
					FirstPositionCpc.ReadFrom(xItem);
				}
				else if (localName == "qualityInfo")
				{
					QualityInfo = new QualityInfo();
					QualityInfo.ReadFrom(xItem);
				}
				else if (localName == "biddingStrategyConfiguration")
				{
					BiddingStrategyConfiguration = new BiddingStrategyConfiguration();
					BiddingStrategyConfiguration.ReadFrom(xItem);
				}
				else if (localName == "bidModifier")
				{
					BidModifier = double.Parse(xItem.Value);
				}
				else if (localName == "finalUrls")
				{
					FinalUrls = new UrlList();
					FinalUrls.ReadFrom(xItem);
				}
				else if (localName == "finalMobileUrls")
				{
					FinalMobileUrls = new UrlList();
					FinalMobileUrls.ReadFrom(xItem);
				}
				else if (localName == "finalAppUrls")
				{
					FinalAppUrls = new AppUrlList();
					FinalAppUrls.ReadFrom(xItem);
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
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "BiddableAdGroupCriterion");
			XElement xItem = null;
			if (UserStatus != null)
			{
				xItem = new XElement(XName.Get("userStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UserStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (SystemServingStatus != null)
			{
				xItem = new XElement(XName.Get("systemServingStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SystemServingStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ApprovalStatus != null)
			{
				xItem = new XElement(XName.Get("approvalStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ApprovalStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (DisapprovalReasons != null)
			{
				foreach (var disapprovalReasonsItem in DisapprovalReasons)
				{
					xItem = new XElement(XName.Get("disapprovalReasons", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(disapprovalReasonsItem);
					xE.Add(xItem);
				}
			}
			if (DestinationUrl != null)
			{
				xItem = new XElement(XName.Get("destinationUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DestinationUrl);
				xE.Add(xItem);
			}
			if (FirstPageCpc != null)
			{
				xItem = new XElement(XName.Get("firstPageCpc", "https://adwords.google.com/api/adwords/cm/v201609"));
				FirstPageCpc.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (TopOfPageCpc != null)
			{
				xItem = new XElement(XName.Get("topOfPageCpc", "https://adwords.google.com/api/adwords/cm/v201609"));
				TopOfPageCpc.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (FirstPositionCpc != null)
			{
				xItem = new XElement(XName.Get("firstPositionCpc", "https://adwords.google.com/api/adwords/cm/v201609"));
				FirstPositionCpc.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (QualityInfo != null)
			{
				xItem = new XElement(XName.Get("qualityInfo", "https://adwords.google.com/api/adwords/cm/v201609"));
				QualityInfo.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (BiddingStrategyConfiguration != null)
			{
				xItem = new XElement(XName.Get("biddingStrategyConfiguration", "https://adwords.google.com/api/adwords/cm/v201609"));
				BiddingStrategyConfiguration.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (BidModifier != null)
			{
				xItem = new XElement(XName.Get("bidModifier", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BidModifier.Value.ToString());
				xE.Add(xItem);
			}
			if (FinalUrls != null)
			{
				xItem = new XElement(XName.Get("finalUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
				FinalUrls.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (FinalMobileUrls != null)
			{
				xItem = new XElement(XName.Get("finalMobileUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
				FinalMobileUrls.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (FinalAppUrls != null)
			{
				xItem = new XElement(XName.Get("finalAppUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
				FinalAppUrls.WriteTo(xItem);
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
