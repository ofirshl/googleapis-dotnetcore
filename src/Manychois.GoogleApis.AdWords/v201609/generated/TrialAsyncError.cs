using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An error that has occurred while asynchronously processing the creation or promotion of a trial.
	/// </summary>
	public class TrialAsyncError : ISoapable
	{
		/// <summary>
		/// The trial that was attempted to be created or promoted.
		/// <span class="constraint Selectable">This field can be selected using the value "TrialId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? TrialId { get; set; }
		/// <summary>
		/// The error that occurred while processing the trial.
		/// <span class="constraint Selectable">This field can be selected using the value "AsyncError".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public ApiError AsyncError { get; set; }
		/// <summary>
		/// The error occurred during trial creation while updating this Campaign or an entity in this
		/// Campaign.
		/// <span class="constraint Selectable">This field can be selected using the value "TrialCampaignId".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? TrialCampaignId { get; set; }
		/// <summary>
		/// The error occurred during trial creation while updating this AdGroup or an entity in this
		/// AdGroup.
		/// <span class="constraint Selectable">This field can be selected using the value "TrialAdGroupId".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? TrialAdGroupId { get; set; }
		/// <summary>
		/// The error occurred during trial promotion while updating this Campaign or an entity in this
		/// Campaign.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseCampaignId".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? BaseCampaignId { get; set; }
		/// <summary>
		/// The error occurred during trial promotion while updating this AdGroup or an entity in this
		/// AdGroup.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseAdGroupId".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? BaseAdGroupId { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			TrialId = null;
			AsyncError = null;
			TrialCampaignId = null;
			TrialAdGroupId = null;
			BaseCampaignId = null;
			BaseAdGroupId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "trialId")
				{
					TrialId = long.Parse(xItem.Value);
				}
				else if (localName == "asyncError")
				{
					AsyncError = InstanceCreator.CreateApiError(xItem);
					AsyncError.ReadFrom(xItem);
				}
				else if (localName == "trialCampaignId")
				{
					TrialCampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "trialAdGroupId")
				{
					TrialAdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "baseCampaignId")
				{
					BaseCampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "baseAdGroupId")
				{
					BaseAdGroupId = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (TrialId != null)
			{
				xItem = new XElement(XName.Get("trialId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TrialId.Value.ToString());
				xE.Add(xItem);
			}
			if (AsyncError != null)
			{
				xItem = new XElement(XName.Get("asyncError", "https://adwords.google.com/api/adwords/cm/v201609"));
				AsyncError.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (TrialCampaignId != null)
			{
				xItem = new XElement(XName.Get("trialCampaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TrialCampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (TrialAdGroupId != null)
			{
				xItem = new XElement(XName.Get("trialAdGroupId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TrialAdGroupId.Value.ToString());
				xE.Add(xItem);
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
		}
	}
}
