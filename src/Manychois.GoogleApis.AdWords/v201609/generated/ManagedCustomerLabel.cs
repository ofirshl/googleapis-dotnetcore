using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A label ID and customer ID the label applies to.
	/// </summary>
	public class ManagedCustomerLabel : ISoapable
	{
		/// <summary>
		/// The ID of an existing label to be applied to the account.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? LabelId { get; set; }
		/// <summary>
		/// The 10-digit customer ID that identifies this account. Note that this is a {@code long} (do not
		/// include hyphens in the middle), just like {@link ManagedCustomer#customerId}.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? CustomerId { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			LabelId = null;
			CustomerId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "labelId")
				{
					LabelId = long.Parse(xItem.Value);
				}
				else if (localName == "customerId")
				{
					CustomerId = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (LabelId != null)
			{
				xItem = new XElement(XName.Get("labelId", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(LabelId.Value.ToString());
				xE.Add(xItem);
			}
			if (CustomerId != null)
			{
				xItem = new XElement(XName.Get("customerId", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(CustomerId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
