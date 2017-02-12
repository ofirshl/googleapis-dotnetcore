using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// CampaignSharedSets are used for managing the shared sets
	/// associated with a campaign.
	/// </summary>
	public class CampaignSharedSet : ISoapable
	{
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "SharedSetId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, REMOVE.</span>
		/// </summary>
		public long? SharedSetId { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "CampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, REMOVE.</span>
		/// </summary>
		public long? CampaignId { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "SharedSetName".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string SharedSetName { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "SharedSetType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint CampaignType">This field may only be set to NEGATIVE_KEYWORDS for campaign channel type SHOPPING.</span>
		/// <span class="constraint CampaignType">This field may only be set to NEGATIVE_PLACEMENTS for campaign channel subtype DISPLAY_MOBILE_APP.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public SharedSetType? SharedSetType { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "CampaignName".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string CampaignName { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public CampaignSharedSetStatus? Status { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			SharedSetId = null;
			CampaignId = null;
			SharedSetName = null;
			SharedSetType = null;
			CampaignName = null;
			Status = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "sharedSetId")
				{
					SharedSetId = long.Parse(xItem.Value);
				}
				else if (localName == "campaignId")
				{
					CampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "sharedSetName")
				{
					SharedSetName = xItem.Value;
				}
				else if (localName == "sharedSetType")
				{
					SharedSetType = SharedSetTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "campaignName")
				{
					CampaignName = xItem.Value;
				}
				else if (localName == "status")
				{
					Status = CampaignSharedSetStatusExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (SharedSetId != null)
			{
				xItem = new XElement(XName.Get("sharedSetId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SharedSetId.Value.ToString());
				xE.Add(xItem);
			}
			if (CampaignId != null)
			{
				xItem = new XElement(XName.Get("campaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (SharedSetName != null)
			{
				xItem = new XElement(XName.Get("sharedSetName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SharedSetName);
				xE.Add(xItem);
			}
			if (SharedSetType != null)
			{
				xItem = new XElement(XName.Get("sharedSetType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SharedSetType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (CampaignName != null)
			{
				xItem = new XElement(XName.Get("campaignName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CampaignName);
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
