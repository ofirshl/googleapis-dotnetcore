using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Budgets are used for managing the amount of money spent on AdWords.
	/// </summary>
	public class Budget : ISoapable
	{
		/// <summary>
		/// A Budget is created using the BudgetService ADD operation and is
		/// assigned a BudgetId. The BudgetId is used when modifying the
		/// Budget with BudgetService, or associating the Budget to a
		/// Campaign with CampaignService. A BudgetId can be shared across
		/// different campaigns--the system will then allocate the Budget
		/// among the Campaigns to get the optimum result.
		/// <span class="constraint Selectable">This field can be selected using the value "BudgetId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? BudgetId { get; set; }
		/// <summary>
		/// Name of the Budget. When creating a Budget through BudgetService, every explicitly shared
		/// Budget must have a non-null non-empty name. In addition, all explicitly shared Budget
		/// names owned by an account must be distinct. Budgets that are not explicitly shared derive
		/// their name from the attached Campaign's name.
		/// <span class="constraint Selectable">This field can be selected using the value "BudgetName".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 255, inclusive, in UTF-8 bytes, (trimmed).</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Amount of budget in the local currency for the account.
		/// <span class="constraint Selectable">This field can be selected using the value "Amount".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint InRange">This field must be greater than or equal to 1.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// </summary>
		public Money Amount { get; set; }
		/// <summary>
		/// Delivery method for the Budget which determines the rate at which the
		/// Budget is spent. Defaults to STANDARD and can be changed through
		/// BudgetService ADD or SET operations.
		/// <span class="constraint Selectable">This field can be selected using the value "DeliveryMethod".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// </summary>
		public BudgetBudgetDeliveryMethod? DeliveryMethod { get; set; }
		/// <summary>
		/// Number of campaigns actively using this budget. This field is only
		/// populated for Get operations.
		/// <span class="constraint Selectable">This field can be selected using the value "BudgetReferenceCount".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public int? ReferenceCount { get; set; }
		/// <summary>
		/// If true, this budget was created with the purpose of sharing
		/// this budget across one or more campaigns.
		/// <p>If false, this budget was created with the intention to be
		/// dedicatedly used with a single campaign, and the Budget's name
		/// and status will stay in the sync with the associated Campaign's name
		/// and status. Attempting to share this budget with a second Campaign will
		/// result in an error.</p>
		/// <span class="constraint Selectable">This field can be selected using the value "IsBudgetExplicitlyShared".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// </summary>
		public bool? IsExplicitlyShared { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "BudgetStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public BudgetBudgetStatus? Status { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			BudgetId = null;
			Name = null;
			Amount = null;
			DeliveryMethod = null;
			ReferenceCount = null;
			IsExplicitlyShared = null;
			Status = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "budgetId")
				{
					BudgetId = long.Parse(xItem.Value);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "amount")
				{
					Amount = new Money();
					Amount.ReadFrom(xItem);
				}
				else if (localName == "deliveryMethod")
				{
					DeliveryMethod = BudgetBudgetDeliveryMethodExtensions.Parse(xItem.Value);
				}
				else if (localName == "referenceCount")
				{
					ReferenceCount = int.Parse(xItem.Value);
				}
				else if (localName == "isExplicitlyShared")
				{
					IsExplicitlyShared = bool.Parse(xItem.Value);
				}
				else if (localName == "status")
				{
					Status = BudgetBudgetStatusExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
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
			if (Amount != null)
			{
				xItem = new XElement(XName.Get("amount", "https://adwords.google.com/api/adwords/cm/v201609"));
				Amount.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (DeliveryMethod != null)
			{
				xItem = new XElement(XName.Get("deliveryMethod", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DeliveryMethod.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ReferenceCount != null)
			{
				xItem = new XElement(XName.Get("referenceCount", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ReferenceCount.Value.ToString());
				xE.Add(xItem);
			}
			if (IsExplicitlyShared != null)
			{
				xItem = new XElement(XName.Get("isExplicitlyShared", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsExplicitlyShared.Value.ToString());
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
