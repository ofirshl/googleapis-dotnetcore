using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an adgroup level bid modifier override for campaign level criterion
	/// bid modifier values.
	/// </summary>
	public class AdGroupBidModifier : ISoapable
	{
		/// <summary>
		/// The campaign that the criterion is in.
		/// <span class="constraint Selectable">This field can be selected using the value "CampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? CampaignId { get; set; }
		/// <summary>
		/// The adgroup that the bid modifier override is in.
		/// <span class="constraint Selectable">This field can be selected using the value "AdGroupId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? AdGroupId { get; set; }
		/// <summary>
		/// The criterion whose bid value is being overridden.
		///
		/// <p>Currently, bid modifier overrides are supported only for platform criterion
		/// (ID=30000, 30001, 30002) and preferred content criterion (ID = 400).
		/// The {@linkplain AdGroupBidModifierService#get} method returns all platform and
		/// preferred content criteria.
		///
		/// <p>Preferred Content Criteria is available in versions >= V201603.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Criterion Criterion { get; set; }
		/// <summary>
		/// The modifier for bids when the criterion matches.
		///
		/// <p>Valid modifier values range from {@code 0.1} to {@code 10.0}, with {@code 0.0} reserved
		/// for opting out of a platform.
		/// <span class="constraint Selectable">This field can be selected using the value "BidModifier".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, SET.</span>
		/// </summary>
		public double? BidModifier { get; set; }
		/// <summary>
		/// ID of the base adgroup from which this draft/trial adgroup bid modifier was created. For
		/// base adgroups this is equal to the adgroup ID.  If the adgroup was created
		/// in the draft or trial and has no corresponding base adgroup, this field is null.
		/// This field is readonly and only returned on get requests.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseAdGroupId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? BaseAdGroupId { get; set; }
		/// <summary>
		/// Bid modifier source.
		/// <span class="constraint Selectable">This field can be selected using the value "BidModifierSource".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public BidModifierSource? BidModifierSource { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			CampaignId = null;
			AdGroupId = null;
			Criterion = null;
			BidModifier = null;
			BaseAdGroupId = null;
			BidModifierSource = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "campaignId")
				{
					CampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "adGroupId")
				{
					AdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "criterion")
				{
					Criterion = new Criterion();
					Criterion.ReadFrom(xItem);
				}
				else if (localName == "bidModifier")
				{
					BidModifier = double.Parse(xItem.Value);
				}
				else if (localName == "baseAdGroupId")
				{
					BaseAdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "bidModifierSource")
				{
					BidModifierSource = BidModifierSourceExtensions.Parse(xItem.Value);
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
			if (AdGroupId != null)
			{
				xItem = new XElement(XName.Get("adGroupId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdGroupId.Value.ToString());
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
			if (BaseAdGroupId != null)
			{
				xItem = new XElement(XName.Get("baseAdGroupId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BaseAdGroupId.Value.ToString());
				xE.Add(xItem);
			}
			if (BidModifierSource != null)
			{
				xItem = new XElement(XName.Get("bidModifierSource", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BidModifierSource.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
