using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an account to which invoices are sent in
	/// <a href="https://support.google.com/adwords/answer/2375371">consolidated billing</a>.
	/// </summary>
	public class BillingAccount : ISoapable
	{
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string CurrencyCode { get; set; }
		/// <summary>
		/// A 12 digit billing id assigned to the user by Google.
		/// <span class="constraint Billing">This element only applies if manager account is whitelisted for new billing backend.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string PrimaryBillingId { get; set; }
		/// <summary>
		/// An optional secondary billing id assigned to the user by Google.
		/// <span class="constraint Billing">This element only applies if manager account is whitelisted for new billing backend.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string SecondaryBillingId { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			Name = null;
			CurrencyCode = null;
			PrimaryBillingId = null;
			SecondaryBillingId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = xItem.Value;
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "currencyCode")
				{
					CurrencyCode = xItem.Value;
				}
				else if (localName == "primaryBillingId")
				{
					PrimaryBillingId = xItem.Value;
				}
				else if (localName == "secondaryBillingId")
				{
					SecondaryBillingId = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(Id);
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (CurrencyCode != null)
			{
				xItem = new XElement(XName.Get("currencyCode", "https://adwords.google.com/api/adwords/billing/v201609"));
				xItem.Add(CurrencyCode);
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
		}
	}
}
