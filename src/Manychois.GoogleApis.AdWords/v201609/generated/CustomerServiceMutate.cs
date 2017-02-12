using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Update the authorized customer.
	///
	/// <p>While there are a limited set of properties available to update, please read this
	/// <a href="https://support.google.com/analytics/answer/1033981">help center article
	/// on auto-tagging</a> before updating {@code customer.autoTaggingEnabled}.
	///
	/// @param customer the requested updated value for the customer.
	/// @throws ApiException
	/// </summary>
	internal class CustomerServiceMutate : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Customer Customer { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Customer = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "customer")
				{
					Customer = new Customer();
					Customer.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Customer != null)
			{
				xItem = new XElement(XName.Get("customer", "https://adwords.google.com/api/adwords/mcm/v201609"));
				Customer.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
