using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Adds {@linkplain AccountLabel}s to, and removes
	/// {@linkplain AccountLabel}s from, {@linkplain ManagedCustomer}s.
	///
	/// <p>To add an {@linkplain AccountLabel} to a {@linkplain ManagedCustomer},
	/// use {@link Operator#ADD}.
	/// To remove an {@linkplain AccountLabel} from a {@linkplain ManagedCustomer},
	/// use {@link Operator#REMOVE}.</p>
	/// <p>The label must already exist (see {@link AccountLabelService#mutate} for
	/// how to create them) and be owned by the authenticated user.</p>
	/// <p>The {@linkplain ManagedCustomer} must already exist and be managed by
	/// the customer making the request (either directly or indirectly).</p>
	/// <p>An AccountLabel may be applied to at most 1000 customers.</p>
	/// <p>This method does not support partial failures, and will fail if any
	/// operation is invalid.</p>
	/// </summary>
	internal class ManagedCustomerServiceMutateLabel : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint SupportedOperators">The following {@link Operator}s are supported: ADD, REMOVE.</span>
		/// </summary>
		public List<ManagedCustomerLabelOperation> Operations { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operations")
				{
					if (Operations == null) Operations = new List<ManagedCustomerLabelOperation>();
					var operationsItem = new ManagedCustomerLabelOperation();
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
