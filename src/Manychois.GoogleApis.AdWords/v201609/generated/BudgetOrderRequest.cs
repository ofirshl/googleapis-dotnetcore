using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Holds fields that provide information on the last set of values that were passed in through
	/// the parent BudgetOrder for mutate.add and mutate.set.
	/// <span class="constraint Billing">This element only applies if manager account is whitelisted for new billing backend.</span>
	/// </summary>
	public class BudgetOrderRequest : ISoapable
	{
		/// <summary>
		/// Status of the last {@link BudgetOrder} change.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public BudgetOrderRequestStatus? Status { get; set; }
		/// <summary>
		/// {@link DateTime} of when the request was received.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Date { get; set; }
		/// <summary>
		/// Enables user to specify meaningful name for a billing account
		/// to aid in reconciling monthly invoices. This name will be printed in the monthly invoices.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string BillingAccountName { get; set; }
		/// <summary>
		/// Enables user to enter a value that helps them reference this budget order
		/// in their monthly invoices. This number will be printed in the monthly invoices.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string PoNumber { get; set; }
		/// <summary>
		/// Enables user to specify meaningful name for referencing this budget order. A default name
		/// will be provided if none is specified. This name will be printed in the monthly invoices.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string BudgetOrderName { get; set; }
		/// <summary>
		/// The spending limit in micros. To specify an unlimited budget, set spendingLimit to -1,
		/// otherwise spendingLimit must be greater than 0.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public Money SpendingLimit { get; set; }
		/// <summary>
		/// StartDateTime cannot be in the past, it must be on or before
		/// "20361231 235959 America/Los_Angeles". StartDateTime and EndDateTime
		/// must use the same time zone.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string StartDateTime { get; set; }
		/// <summary>
		/// EndDateTime must be on or before "20361231 235959 America/Los_Angeles" or
		/// must set the same instant as "20371230 235959 America/Los_Angeles" to
		/// indicate infinite end date. StartDateTime and EndDateTime
		/// must use the same time zone.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string EndDateTime { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Status = null;
			Date = null;
			BillingAccountName = null;
			PoNumber = null;
			BudgetOrderName = null;
			SpendingLimit = null;
			StartDateTime = null;
			EndDateTime = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "status")
				{
					Status = BudgetOrderRequestStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "date")
				{
					Date = xItem.Value;
				}
				else if (localName == "billingAccountName")
				{
					BillingAccountName = xItem.Value;
				}
				else if (localName == "poNumber")
				{
					PoNumber = xItem.Value;
				}
				else if (localName == "budgetOrderName")
				{
					BudgetOrderName = xItem.Value;
				}
				else if (localName == "spendingLimit")
				{
					SpendingLimit = new Money();
					SpendingLimit.ReadFrom(xItem);
				}
				else if (localName == "startDateTime")
				{
					StartDateTime = xItem.Value;
				}
				else if (localName == "endDateTime")
				{
					EndDateTime = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Date != null)
			{
				xItem = new XElement(XName.Get("date", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(Date);
				xE.Add(xItem);
			}
			if (BillingAccountName != null)
			{
				xItem = new XElement(XName.Get("billingAccountName", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(BillingAccountName);
				xE.Add(xItem);
			}
			if (PoNumber != null)
			{
				xItem = new XElement(XName.Get("poNumber", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(PoNumber);
				xE.Add(xItem);
			}
			if (BudgetOrderName != null)
			{
				xItem = new XElement(XName.Get("budgetOrderName", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(BudgetOrderName);
				xE.Add(xItem);
			}
			if (SpendingLimit != null)
			{
				xItem = new XElement(XName.Get("spendingLimit", "https://adwords.google.com/api/adwords/billing/v201609"));
				SpendingLimit.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (StartDateTime != null)
			{
				xItem = new XElement(XName.Get("startDateTime", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(StartDateTime);
				xE.Add(xItem);
			}
			if (EndDateTime != null)
			{
				xItem = new XElement(XName.Get("endDateTime", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(EndDateTime);
				xE.Add(xItem);
			}
		}
	}
}
