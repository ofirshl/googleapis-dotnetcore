using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns information about changed entities inside a customer's account.
	///
	/// @param selector Specifies the filter for selecting changehistory events for a customer.
	/// @return A Customer->Campaign->AdGroup hierarchy containing information about the objects
	/// changed at each level. All Campaigns that are requested in the selector will be returned,
	/// regardless of whether or not they have changed, but unchanged AdGroups will be ignored.
	/// </summary>
	internal class CustomerSyncServiceGet : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public CustomerSyncSelector Selector { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Selector = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "selector")
				{
					Selector = new CustomerSyncSelector();
					Selector.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Selector != null)
			{
				xItem = new XElement(XName.Get("selector", "https://adwords.google.com/api/adwords/ch/v201609"));
				Selector.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
