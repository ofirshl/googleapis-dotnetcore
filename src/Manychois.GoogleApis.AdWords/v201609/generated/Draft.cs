using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The interface object which contains the basic information of a draft.  Entity specific
	/// information in the campaign tree are represented by their respective entities objects with a
	/// corresponding draftId.
	/// </summary>
	public class Draft : ISoapable
	{
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "DraftId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET.</span>
		/// </summary>
		public long? DraftId { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "BaseCampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? BaseCampaignId { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "DraftName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 1024, inclusive, in UTF-8 bytes, (trimmed).</span>
		/// </summary>
		public string DraftName { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "DraftStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// </summary>
		public DraftStatus? DraftStatus { get; set; }
		/// <summary>
		/// The campaign id that references the draft version of the
		/// original campaign.
		/// <span class="constraint Selectable">This field can be selected using the value "DraftCampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? DraftCampaignId { get; set; }
		/// <summary>
		/// True, if a trial created from this draft is running. Only available via the Get action.
		/// <span class="constraint Selectable">This field can be selected using the value "HasRunningTrial".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? HasRunningTrial { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			DraftId = null;
			BaseCampaignId = null;
			DraftName = null;
			DraftStatus = null;
			DraftCampaignId = null;
			HasRunningTrial = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "draftId")
				{
					DraftId = long.Parse(xItem.Value);
				}
				else if (localName == "baseCampaignId")
				{
					BaseCampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "draftName")
				{
					DraftName = xItem.Value;
				}
				else if (localName == "draftStatus")
				{
					DraftStatus = DraftStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "draftCampaignId")
				{
					DraftCampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "hasRunningTrial")
				{
					HasRunningTrial = bool.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (DraftId != null)
			{
				xItem = new XElement(XName.Get("draftId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DraftId.Value.ToString());
				xE.Add(xItem);
			}
			if (BaseCampaignId != null)
			{
				xItem = new XElement(XName.Get("baseCampaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BaseCampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (DraftName != null)
			{
				xItem = new XElement(XName.Get("draftName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DraftName);
				xE.Add(xItem);
			}
			if (DraftStatus != null)
			{
				xItem = new XElement(XName.Get("draftStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DraftStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (DraftCampaignId != null)
			{
				xItem = new XElement(XName.Get("draftCampaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DraftCampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (HasRunningTrial != null)
			{
				xItem = new XElement(XName.Get("hasRunningTrial", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(HasRunningTrial.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
