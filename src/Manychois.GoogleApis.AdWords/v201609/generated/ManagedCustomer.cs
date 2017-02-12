using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Data object that represents a managed customer.  Member of {@link ManagedCustomerPage}.
	/// </summary>
	public class ManagedCustomer : ISoapable
	{
		/// <summary>
		/// The name used by the manager to refer to the client.
		/// <span class="constraint Selectable">This field can be selected using the value "Name".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The 10-digit ID that uniquely identifies the AdWords account.
		/// <span class="constraint Selectable">This field can be selected using the value "CustomerId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// </summary>
		public long? CustomerId { get; set; }
		/// <summary>
		/// Whether this account can manage clients.
		/// <span class="constraint ReadOnly">This field is read only
		/// and will be ignored when sent to the API.</span>
		/// <span class="constraint Selectable">This field can be selected using the value "CanManageClients".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public bool? CanManageClients { get; set; }
		/// <summary>
		/// The currency in which this account operates.
		/// We support a subset of the currency codes derived from the ISO 4217 standard.
		/// See <a href="https://developers.google.com/adwords/api/docs/appendix/currencycodes"
		/// >Currency Codes</a> for the currently supported currencies.
		/// <span class="constraint Selectable">This field can be selected using the value "CurrencyCode".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint StringLength">The length of this string should be between 3 and 3, inclusive.</span>
		/// </summary>
		public string CurrencyCode { get; set; }
		/// <summary>
		/// The local timezone ID for this customer.
		/// See <a href="https://developers.google.com/adwords/api/docs/appendix/timezones"
		/// >Time Zone Codes</a> for the currently supported list.
		/// <span class="constraint Selectable">This field can be selected using the value "DateTimeZone".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string DateTimeZone { get; set; }
		/// <summary>
		/// Whether this managed customer's account is a test account.
		/// <span class="constraint Selectable">This field can be selected using the value "TestAccount".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? TestAccount { get; set; }
		/// <summary>
		/// The list of account labels associated with this customer. Only labels owned by the requesting
		/// manager will be returned. To change the list of labels applied to this customer, see
		/// {@link ManagedCustomerService#mutateLabels}.
		/// <span class="constraint Selectable">This field can be selected using the value "AccountLabels".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<AccountLabel> AccountLabels { get; set; }
		/// <summary>
		/// Specify ExcludeHiddenAccounts=true to exclude hidden accounts during traversal.
		/// <span class="constraint Filterable">This field can be filtered on using the value "ExcludeHiddenAccounts".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? ExcludeHiddenAccounts { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Name = null;
			CustomerId = null;
			CanManageClients = null;
			CurrencyCode = null;
			DateTimeZone = null;
			TestAccount = null;
			AccountLabels = null;
			ExcludeHiddenAccounts = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "customerId")
				{
					CustomerId = long.Parse(xItem.Value);
				}
				else if (localName == "canManageClients")
				{
					CanManageClients = bool.Parse(xItem.Value);
				}
				else if (localName == "currencyCode")
				{
					CurrencyCode = xItem.Value;
				}
				else if (localName == "dateTimeZone")
				{
					DateTimeZone = xItem.Value;
				}
				else if (localName == "testAccount")
				{
					TestAccount = bool.Parse(xItem.Value);
				}
				else if (localName == "accountLabels")
				{
					if (AccountLabels == null) AccountLabels = new List<AccountLabel>();
					var accountLabelsItem = new AccountLabel();
					accountLabelsItem.ReadFrom(xItem);
					AccountLabels.Add(accountLabelsItem);
				}
				else if (localName == "excludeHiddenAccounts")
				{
					ExcludeHiddenAccounts = bool.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (CustomerId != null)
			{
				xItem = new XElement(XName.Get("customerId", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(CustomerId.Value.ToString());
				xE.Add(xItem);
			}
			if (CanManageClients != null)
			{
				xItem = new XElement(XName.Get("canManageClients", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(CanManageClients.Value.ToString());
				xE.Add(xItem);
			}
			if (CurrencyCode != null)
			{
				xItem = new XElement(XName.Get("currencyCode", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(CurrencyCode);
				xE.Add(xItem);
			}
			if (DateTimeZone != null)
			{
				xItem = new XElement(XName.Get("dateTimeZone", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(DateTimeZone);
				xE.Add(xItem);
			}
			if (TestAccount != null)
			{
				xItem = new XElement(XName.Get("testAccount", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(TestAccount.Value.ToString());
				xE.Add(xItem);
			}
			if (AccountLabels != null)
			{
				foreach (var accountLabelsItem in AccountLabels)
				{
					xItem = new XElement(XName.Get("accountLabels", "https://adwords.google.com/api/adwords/mcm/v201609"));
					accountLabelsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (ExcludeHiddenAccounts != null)
			{
				xItem = new XElement(XName.Get("excludeHiddenAccounts", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(ExcludeHiddenAccounts.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
