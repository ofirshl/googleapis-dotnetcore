using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Gets a list of {@link BudgetOrder}s using the generic selector.
	/// @param serviceSelector specifies which BudgetOrder to return.
	/// @return A {@link BudgetOrderPage} of BudgetOrders of the client customer.
	/// All BudgetOrder fields are returned. Stats are not yet supported.
	/// @throws ApiException
	/// </summary>
	internal class BudgetOrderServiceGet : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Selector ServiceSelector { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ServiceSelector = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "serviceSelector")
				{
					ServiceSelector = new Selector();
					ServiceSelector.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ServiceSelector != null)
			{
				xItem = new XElement(XName.Get("serviceSelector", "https://adwords.google.com/api/adwords/billing/v201609"));
				ServiceSelector.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
