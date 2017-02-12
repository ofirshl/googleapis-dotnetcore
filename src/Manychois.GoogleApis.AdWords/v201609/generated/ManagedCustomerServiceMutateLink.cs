using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Modifies the ManagedCustomer forest. These actions are possible (categorized by
	/// Operator + Link Status):
	///
	/// <ul>
	/// <li>ADD + PENDING:   manager extends invitations</li>
	/// <li>SET + CANCELLED: manager rescinds invitations</li>
	/// <li>SET + INACTIVE:  manager/client terminates links</li>
	/// <li>SET + ACTIVE:    client accepts invitations</li>
	/// <li>SET + REFUSED:   client declines invitations</li>
	/// </ul>
	///
	/// In addition to these, active links can also be marked hidden / unhidden.
	/// <ul>
	/// <li> An ACTIVE link can be marked hidden with SET + ACTIVE along with setting the
	/// isHidden bit to true. </li>
	/// <li> An ACTIVE link can be marked unhidden with SET + ACTIVE along with setting the
	/// isHidden bit to false. </li>
	/// </ul>
	///
	/// @param operations the list of operations
	/// @return results for the given operations
	/// @throws ApiException with a {@link ManagedCustomerServiceError}
	/// </summary>
	internal class ManagedCustomerServiceMutateLink : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint SupportedOperators">The following {@link Operator}s are supported: SET, ADD.</span>
		/// </summary>
		public List<LinkOperation> Operations { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operations")
				{
					if (Operations == null) Operations = new List<LinkOperation>();
					var operationsItem = new LinkOperation();
					operationsItem.ReadFrom(xItem);
					Operations.Add(operationsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Operations != null)
			{
				foreach (var operationsItem in Operations)
				{
					xItem = new XElement(XName.Get("operations", "https://adwords.google.com/api/adwords/mcm/v201609"));
					operationsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
