using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an ad group that will be estimated. Ad groups may be all
	/// new or all existing, or a mixture of new and existing. Only existing
	/// campaigns can contain estimates for existing ad groups.<p>
	///
	/// <p>To make a keyword estimates request in which estimates do not consider
	/// existing account information (e.g. historical ad group performance), set both
	/// {@link #adGroupId} and the enclosing {@link CampaignEstimateRequest}'s
	/// {@code campaignId} to {@code null}.
	///
	/// <p>For more details on usage, refer to document at
	/// {@link CampaignEstimateRequest}.
	/// </summary>
	public class AdGroupEstimateRequest : EstimateRequest, ISoapable
	{
		/// <summary>
		/// The adGroupId for an ad group that belongs to the containing campaign from
		/// {@link CampaignEstimateRequest} or {@code null}.
		///
		/// <p>For usage, refer to document from {@link CampaignEstimateRequest}.
		/// </summary>
		public long? AdGroupId { get; set; }
		/// <summary>
		/// The keywords to estimate.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<KeywordEstimateRequest> KeywordEstimateRequests { get; set; }
		/// <summary>
		/// The max CPC bid to use for estimates for this ad group.
		///
		/// <p>This value overrides the max CPC of AdGroup specified by
		/// {@link #adGroupId}.
		/// </summary>
		public Money MaxCpc { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			AdGroupId = null;
			KeywordEstimateRequests = null;
			MaxCpc = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "adGroupId")
				{
					AdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "keywordEstimateRequests")
				{
					if (KeywordEstimateRequests == null) KeywordEstimateRequests = new List<KeywordEstimateRequest>();
					var keywordEstimateRequestsItem = new KeywordEstimateRequest();
					keywordEstimateRequestsItem.ReadFrom(xItem);
					KeywordEstimateRequests.Add(keywordEstimateRequestsItem);
				}
				else if (localName == "maxCpc")
				{
					MaxCpc = new Money();
					MaxCpc.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "AdGroupEstimateRequest");
			XElement xItem = null;
			if (AdGroupId != null)
			{
				xItem = new XElement(XName.Get("adGroupId", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(AdGroupId.Value.ToString());
				xE.Add(xItem);
			}
			if (KeywordEstimateRequests != null)
			{
				foreach (var keywordEstimateRequestsItem in KeywordEstimateRequests)
				{
					xItem = new XElement(XName.Get("keywordEstimateRequests", "https://adwords.google.com/api/adwords/o/v201609"));
					keywordEstimateRequestsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (MaxCpc != null)
			{
				xItem = new XElement(XName.Get("maxCpc", "https://adwords.google.com/api/adwords/o/v201609"));
				MaxCpc.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
