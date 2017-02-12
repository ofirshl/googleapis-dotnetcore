using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A <a href="https://support.google.com/adwords/answer/2393037">budget order</a>
	/// links an account-wide budget with a {@link BillingAccount}.
	/// </summary>
	public class BudgetOrder : ISoapable
	{
		/// <summary>
		/// This must be passed as a string with dashes, e.g. "1234-5678-9012-3456".
		/// <span class="constraint Selectable">This field can be selected using the value "BillingAccountId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string BillingAccountId { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "Id".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET, REMOVE.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// Enables user to specify meaningful name for a billing account
		/// to aid in reconciling monthly invoices.
		///
		/// This name will be printed in the monthly invoices.
		/// <span class="constraint Billing">This element only applies if manager account is whitelisted for new billing backend.</span>
		/// <span class="constraint Selectable">This field can be selected using the value "BillingAccountName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint StringLength">The length of this string should be between 0 and 80, inclusive, (trimmed).</span>
		/// </summary>
		public string BillingAccountName { get; set; }
		/// <summary>
		/// Enables user to enter a value that helps them reference this budget order
		/// in their monthly invoices.
		///
		/// This number will be printed in the monthly invoices.
		/// <span class="constraint Billing">This element only applies if manager account is whitelisted for new billing backend.</span>
		/// <span class="constraint Selectable">This field can be selected using the value "PoNumber".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint StringLength">The length of this string should be between 0 and 30, inclusive, (trimmed).</span>
		/// </summary>
		public string PoNumber { get; set; }
		/// <summary>
		/// Enables user to specify meaningful name for referencing this budget order. A default name
		/// will be provided if none is specified.
		///
		/// This name will be printed in the monthly invoices.
		/// <span class="constraint Billing">This element only applies if manager account is whitelisted for new billing backend.</span>
		/// <span class="constraint Selectable">This field can be selected using the value "BudgetOrderName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint StringLength">The length of this string should be between 0 and 40, inclusive, (trimmed).</span>
		/// </summary>
		public string BudgetOrderName { get; set; }
		/// <summary>
		/// A 12 digit billing ID assigned to the user by Google. This must be passed in
		/// as a string with dashes, e.g. "1234-5678-9012".
		///
		/// For mutate.add, this field is required if billingAccountId is not specified.
		/// <span class="constraint Billing">This element only applies if manager account is whitelisted for new billing backend.</span>
		/// <span class="constraint Selectable">This field can be selected using the value "PrimaryBillingId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint StringLength">The length of this string should be between 0 and 14, inclusive, (trimmed).</span>
		/// </summary>
		public string PrimaryBillingId { get; set; }
		/// <summary>
		/// For certain users, a secondary billing ID will be required on mutate.add.
		/// If this requirement was not communicated to the user, the user may ignore this parameter.
		/// If specified, this must be passed in as a string with dashes, e.g. "1234-5678-9012".
		/// <span class="constraint Billing">This element only applies if manager account is whitelisted for new billing backend.</span>
		/// <span class="constraint Selectable">This field can be selected using the value "SecondaryBillingId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint StringLength">The length of this string should be between 0 and 14, inclusive, (trimmed).</span>
		/// </summary>
		public string SecondaryBillingId { get; set; }
		/// <summary>
		/// The spending limit in micros. To specify an unlimited budget, set spendingLimit to -1,
		/// otherwise spendingLimit must be greater than 0. Note, that for get requests the spending limit
		/// includes any adjustments that have been applied to the budget order. For mutate,
		/// the spending limit represents the maximum allowed spend prior to considering any adjustments.
		/// When making mutate requests, make sure to account for any adjustments that may be reported
		/// in the get value of the spending limit.
		/// <span class="constraint Selectable">This field can be selected using the value "SpendingLimit".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public Money SpendingLimit { get; set; }
		/// <summary>
		/// The adjustments amount in micros. Adjustments from Google come in the form of credits or
		/// debits to your budget order. You can use the adjustments amount to compute your current base
		/// spendingLimit by subtracting your adjustments from the value returned from spendingLimit
		/// in get requests.
		/// <span class="constraint Selectable">This field can be selected using the value "TotalAdjustments".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public Money TotalAdjustments { get; set; }
		/// <summary>
		/// StartDateTime cannot be in the past, it must be on or before
		/// "20361231 235959 America/Los_Angeles". StartDateTime and EndDateTime
		/// must use the same time zone.
		/// <span class="constraint Selectable">This field can be selected using the value "StartDateTime".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string StartDateTime { get; set; }
		/// <summary>
		/// EndDateTime must be on or before "20361231 235959 America/Los_Angeles" or
		/// must set the same instant as "20371230 235959 America/Los_Angeles" to
		/// indicate infinite end date. StartDateTime and EndDateTime
		/// must use the same time zone.
		/// <span class="constraint Selectable">This field can be selected using the value "EndDateTime".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string EndDateTime { get; set; }
		/// <summary>
		/// Contains fields that provide information on the last set of values that
		/// were passed in through the parent BudgetOrder for mutate.add and
		/// mutate.set.
		/// <span class="constraint Billing">This element only applies if manager account is whitelisted for new billing backend.</span>
		/// <span class="constraint Selectable">This field can be selected using the value "LastRequest".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public BudgetOrderRequest LastRequest { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			BillingAccountId = null;
			Id = null;
			BillingAccountName = null;
			PoNumber = null;
			BudgetOrderName = null;
			PrimaryBillingId = null;
			SecondaryBillingId = null;
			SpendingLimit = null;
			TotalAdjustments = null;
			StartDateTime = null;
			EndDateTime = null;
			LastRequest = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "billingAccountId")
				{
					BillingAccountId = xItem.Value;
				}
				else if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
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
				else if (localName == "primaryBillingId")
				{
					PrimaryBillingId = xItem.Value;
				}
				else if (localName == "secondaryBillingId")
				{
					SecondaryBillingId = xItem.Value;
				}
				else if (localName == "spendingLimit")
				{
					SpendingLimit = new Money();
					SpendingLimit.ReadFrom(xItem);
				}
				else if (localName == "totalAdjustments")
				{
					TotalAdjustments = new Money();
					TotalAdjustments.ReadFrom(xItem);
				}
				else if (localName == "startDateTime")
				{
					StartDateTime = xItem.Value;
				}
				else if (localName == "endDateTime")
				{
					EndDateTime = xItem.Value;
				}
				else if (localName == "lastRequest")
				{
					LastRequest = new BudgetOrderRequest();
					LastRequest.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (BillingAccountId != null)
			{
				xItem = new XElement(XName.Get("billingAccountId", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(BillingAccountId);
				xE.Add(xItem);
			}
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(Id.Value.ToString());
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
			if (PrimaryBillingId != null)
			{
				xItem = new XElement(XName.Get("primaryBillingId", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(PrimaryBillingId);
				xE.Add(xItem);
			}
			if (SecondaryBillingId != null)
			{
				xItem = new XElement(XName.Get("secondaryBillingId", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(SecondaryBillingId);
				xE.Add(xItem);
			}
			if (SpendingLimit != null)
			{
				xItem = new XElement(XName.Get("spendingLimit", "https://adwords.google.com/api/adwords/billing/v201609"));
				SpendingLimit.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (TotalAdjustments != null)
			{
				xItem = new XElement(XName.Get("totalAdjustments", "https://adwords.google.com/api/adwords/billing/v201609"));
				TotalAdjustments.WriteTo(xItem);
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
			if (LastRequest != null)
			{
				xItem = new XElement(XName.Get("lastRequest", "https://adwords.google.com/api/adwords/billing/v201609"));
				LastRequest.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
