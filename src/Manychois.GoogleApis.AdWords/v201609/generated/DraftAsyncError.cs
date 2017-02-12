using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An error that has occurred while asynchronously processing the promotion of a draft.
	/// </summary>
	public class DraftAsyncError : ISoapable
	{
		/// <summary>
		/// The error occurred during promotion while updating this Campaign or an entity in this Campaign.
		/// This field can only be used with Predicate Operators EQUALS and IN. When using a Predicate
		/// with this field, also include a Predicate for the field DraftId.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseCampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? BaseCampaignId { get; set; }
		/// <summary>
		/// The draft that was attempted to be promoted.  This field can only be used with Predicate
		/// Operators EQUALS and IN. When using a Predicate with this field, also include a Predicate for
		/// the field BaseCampaignId.
		/// <span class="constraint Selectable">This field can be selected using the value "DraftId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? DraftId { get; set; }
		/// <summary>
		/// The draft Campaign that was attempted to be promoted.
		/// <span class="constraint Selectable">This field can be selected using the value "DraftCampaignId".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? DraftCampaignId { get; set; }
		/// <summary>
		/// The error that occurred while promoting the draft.
		/// <span class="constraint Selectable">This field can be selected using the value "AsyncError".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public ApiError AsyncError { get; set; }
		/// <summary>
		/// The error occurred during promotion while updating this AdGroup or an entity in this AdGroup.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseAdGroupId".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? BaseAdGroupId { get; set; }
		/// <summary>
		/// The draft AdGroup that was attempted to be promoted.
		/// <span class="constraint Selectable">This field can be selected using the value "DraftAdGroupId".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? DraftAdGroupId { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			BaseCampaignId = null;
			DraftId = null;
			DraftCampaignId = null;
			AsyncError = null;
			BaseAdGroupId = null;
			DraftAdGroupId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "baseCampaignId")
				{
					BaseCampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "draftId")
				{
					DraftId = long.Parse(xItem.Value);
				}
				else if (localName == "draftCampaignId")
				{
					DraftCampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "asyncError")
				{
					AsyncError = InstanceCreator.CreateApiError(xItem);
					AsyncError.ReadFrom(xItem);
				}
				else if (localName == "baseAdGroupId")
				{
					BaseAdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "draftAdGroupId")
				{
					DraftAdGroupId = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (BaseCampaignId != null)
			{
				xItem = new XElement(XName.Get("baseCampaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BaseCampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (DraftId != null)
			{
				xItem = new XElement(XName.Get("draftId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DraftId.Value.ToString());
				xE.Add(xItem);
			}
			if (DraftCampaignId != null)
			{
				xItem = new XElement(XName.Get("draftCampaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DraftCampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (AsyncError != null)
			{
				xItem = new XElement(XName.Get("asyncError", "https://adwords.google.com/api/adwords/cm/v201609"));
				AsyncError.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (BaseAdGroupId != null)
			{
				xItem = new XElement(XName.Get("baseAdGroupId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BaseAdGroupId.Value.ToString());
				xE.Add(xItem);
			}
			if (DraftAdGroupId != null)
			{
				xItem = new XElement(XName.Get("draftAdGroupId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DraftAdGroupId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
