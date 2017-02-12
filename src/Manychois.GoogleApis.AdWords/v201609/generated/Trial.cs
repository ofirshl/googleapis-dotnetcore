using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Interface for campaign trial entities. A trial is an experiment created by an advertiser from
	/// changes in a draft.
	/// </summary>
	public class Trial : ISoapable
	{
		/// <summary>
		/// The id of this trial.
		/// <span class="constraint Selectable">This field can be selected using the value "Id".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// Id of the base campaign, which will be the control arm of this trial.
		/// <span class="constraint Selectable">This field can be selected using the value "BaseCampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: SET.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public long? BaseCampaignId { get; set; }
		/// <summary>
		/// Valid id of the draft this trial is based on.
		/// <span class="constraint Selectable">This field can be selected using the value "DraftId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: SET.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public long? DraftId { get; set; }
		/// <summary>
		/// Id of the new budget to assign to the trial campaign when graduating a trial.
		///
		/// <p>Required for {@link Operator#SET SET} operations, when changing the {@link #status} to
		/// {@code GRADUATED}, and read-only otherwise.
		///
		/// <p>When graduating a trial, the same constraints apply to this field as for a budget id passed
		/// to {@code CampaignService} when creating a new campaign.
		///
		/// <p>{@code GET} operations always return a {@code null} budget id.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// </summary>
		public long? BudgetId { get; set; }
		/// <summary>
		/// The name of this trial. Must not conflict with the name of another trial or campaign.
		/// <span class="constraint Selectable">This field can be selected using the value "Name".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 1024, inclusive, in UTF-8 bytes, (trimmed).</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Date the trial begins. On add, defaults to the the base campaign's start date or the
		/// current day in the parent account's local timezone (whichever is later).
		/// <span class="constraint Selectable">This field can be selected using the value "StartDate".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string StartDate { get; set; }
		/// <summary>
		/// Date the campaign ends. On add, defaults to the base campaign's end date.
		/// <span class="constraint Selectable">This field can be selected using the value "EndDate".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string EndDate { get; set; }
		/// <summary>
		/// Traffic share to be directed to the trial arm of this trial, i.e. the arm containing the
		/// trial changes (in percent). The remainder of the traffic (100 - {@code trafficSplitPercent})
		/// will be directed to the base campaign.
		/// <span class="constraint Selectable">This field can be selected using the value "TrafficSplitPercent".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint InRange">This field must be between 1 and 99, inclusive.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: SET.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public int? TrafficSplitPercent { get; set; }
		/// <summary>
		/// Status of this trial. Note that a running trial will always be ACTIVE, but not all ACTIVE
		/// trials are currently running: they may have ended or been scheduled for the future.
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// </summary>
		public TrialStatus? Status { get; set; }
		/// <summary>
		/// Id of the trial campaign. This will be null if the Trial has
		/// status CREATING.
		/// <span class="constraint Selectable">This field can be selected using the value "TrialCampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? TrialCampaignId { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			BaseCampaignId = null;
			DraftId = null;
			BudgetId = null;
			Name = null;
			StartDate = null;
			EndDate = null;
			TrafficSplitPercent = null;
			Status = null;
			TrialCampaignId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "baseCampaignId")
				{
					BaseCampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "draftId")
				{
					DraftId = long.Parse(xItem.Value);
				}
				else if (localName == "budgetId")
				{
					BudgetId = long.Parse(xItem.Value);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "startDate")
				{
					StartDate = xItem.Value;
				}
				else if (localName == "endDate")
				{
					EndDate = xItem.Value;
				}
				else if (localName == "trafficSplitPercent")
				{
					TrafficSplitPercent = int.Parse(xItem.Value);
				}
				else if (localName == "status")
				{
					Status = TrialStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "trialCampaignId")
				{
					TrialCampaignId = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
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
			if (BudgetId != null)
			{
				xItem = new XElement(XName.Get("budgetId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BudgetId.Value.ToString());
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (StartDate != null)
			{
				xItem = new XElement(XName.Get("startDate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StartDate);
				xE.Add(xItem);
			}
			if (EndDate != null)
			{
				xItem = new XElement(XName.Get("endDate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EndDate);
				xE.Add(xItem);
			}
			if (TrafficSplitPercent != null)
			{
				xItem = new XElement(XName.Get("trafficSplitPercent", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TrafficSplitPercent.Value.ToString());
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (TrialCampaignId != null)
			{
				xItem = new XElement(XName.Get("trialCampaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TrialCampaignId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
