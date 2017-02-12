using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an ad in an ad group.
	/// </summary>
	public class AdGroupAd : ISoapable
	{
		/// <summary>
		/// The id of the adgroup containing this ad.
		/// <span class="constraint Selectable">This field can be selected using the value "AdGroupId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? AdGroupId { get; set; }
		/// <summary>
		/// The contents of the ad itself.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Ad Ad { get; set; }
		/// <summary>
		/// The status of the ad.
		/// This field is required and should not be {@code null} when it is contained within
		/// {@link Operator}s : SET.
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public AdGroupAdStatus? Status { get; set; }
		/// <summary>
		/// Approval status.
		/// <span class="constraint Selectable">This field can be selected using the value "AdGroupCreativeApprovalStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public AdGroupAdApprovalStatus? ApprovalStatus { get; set; }
		/// <summary>
		/// A list of strings that represents the specific trademarked terms that were found in this ad.
		/// The list returned is empty if the ad has no trademarked terms.
		/// <span class="constraint Selectable">This field can be selected using the value "Trademarks".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<string> Trademarks { get; set; }
		/// <summary>
		/// List of disapproval reasons.
		/// <span class="constraint Selectable">This field can be selected using the value "AdGroupAdDisapprovalReasons".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<string> DisapprovalReasons { get; set; }
		/// <summary>
		/// True if and only if this ad is not serving because it does not meet
		/// trademark policy.
		/// <span class="constraint Selectable">This field can be selected using the value "AdGroupAdTrademarkDisapproved".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? TrademarkDisapproved { get; set; }
		/// <summary>
		/// Labels that are attached to the AdGroupAd. To associate an existing {@link Label} to an
		/// existing {@link AdGroupAd}, use {@link AdGroupAdService#mutateLabel} with ADD operator. To
		/// remove an associated {@link Label} from the {@link AdGroupAd}, use
		/// {@link AdGroupAdService#mutateLabel} with REMOVE operator. To filter on {@link Label}s,
		/// use one of {@link Predicate.Operator#CONTAINS_ALL}, {@link Predicate.Operator#CONTAINS_ANY},
		/// {@link Predicate.Operator#CONTAINS_NONE} operators with a list of {@link Label} ids.
		/// <span class="constraint Selectable">This field can be selected using the value "Labels".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint CampaignType">This field may not be set for campaign channel subtype UNIVERSAL_APP_CAMPAIGN.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// </summary>
		public List<Label> Labels { get; set; }
		/// <summary>
		/// ID of the base campaign from which this draft/trial ad was created.
		/// This field is only returned on get requests.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseCampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? BaseCampaignId { get; set; }
		/// <summary>
		/// ID of the base ad group from which this draft/trial ad was created. For
		/// base ad groups this is equal to the ad group ID.  If the ad group was created
		/// in the draft or trial and has no corresponding base ad group, this field is null.
		/// This field is only returned on get requests.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseAdGroupId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? BaseAdGroupId { get; set; }
		/// <summary>
		/// This Map provides a place to put new features and settings in older versions
		/// of the AdWords API in the rare instance we need to introduce a new feature in
		/// an older version.
		///
		/// It is presently unused.  Do not set a value.
		/// </summary>
		public List<String_StringMapEntry> ForwardCompatibilityMap { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			AdGroupId = null;
			Ad = null;
			Status = null;
			ApprovalStatus = null;
			Trademarks = null;
			DisapprovalReasons = null;
			TrademarkDisapproved = null;
			Labels = null;
			BaseCampaignId = null;
			BaseAdGroupId = null;
			ForwardCompatibilityMap = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "adGroupId")
				{
					AdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "ad")
				{
					Ad = new Ad();
					Ad.ReadFrom(xItem);
				}
				else if (localName == "status")
				{
					Status = AdGroupAdStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "approvalStatus")
				{
					ApprovalStatus = AdGroupAdApprovalStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "trademarks")
				{
					if (Trademarks == null) Trademarks = new List<string>();
					Trademarks.Add(xItem.Value);
				}
				else if (localName == "disapprovalReasons")
				{
					if (DisapprovalReasons == null) DisapprovalReasons = new List<string>();
					DisapprovalReasons.Add(xItem.Value);
				}
				else if (localName == "trademarkDisapproved")
				{
					TrademarkDisapproved = bool.Parse(xItem.Value);
				}
				else if (localName == "labels")
				{
					if (Labels == null) Labels = new List<Label>();
					var labelsItem = new Label();
					labelsItem.ReadFrom(xItem);
					Labels.Add(labelsItem);
				}
				else if (localName == "baseCampaignId")
				{
					BaseCampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "baseAdGroupId")
				{
					BaseAdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "forwardCompatibilityMap")
				{
					if (ForwardCompatibilityMap == null) ForwardCompatibilityMap = new List<String_StringMapEntry>();
					var forwardCompatibilityMapItem = new String_StringMapEntry();
					forwardCompatibilityMapItem.ReadFrom(xItem);
					ForwardCompatibilityMap.Add(forwardCompatibilityMapItem);
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
			if (Ad != null)
			{
				xItem = new XElement(XName.Get("ad", "https://adwords.google.com/api/adwords/cm/v201609"));
				Ad.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ApprovalStatus != null)
			{
				xItem = new XElement(XName.Get("approvalStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ApprovalStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Trademarks != null)
			{
				foreach (var trademarksItem in Trademarks)
				{
					xItem = new XElement(XName.Get("trademarks", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(trademarksItem);
					xE.Add(xItem);
				}
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
			if (TrademarkDisapproved != null)
			{
				xItem = new XElement(XName.Get("trademarkDisapproved", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TrademarkDisapproved.Value.ToString());
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
			if (ForwardCompatibilityMap != null)
			{
				foreach (var forwardCompatibilityMapItem in ForwardCompatibilityMap)
				{
					xItem = new XElement(XName.Get("forwardCompatibilityMap", "https://adwords.google.com/api/adwords/cm/v201609"));
					forwardCompatibilityMapItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
