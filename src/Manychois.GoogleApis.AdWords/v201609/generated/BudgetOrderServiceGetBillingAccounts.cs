using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns all the open/active BillingAccounts associated with the current
	/// manager.
	/// @return A list of {@link BillingAccount}s.
	/// @throws ApiException
	/// </summary>
	internal class BudgetOrderServiceGetBillingAccounts : ISoapable
	{
		public virtual void ReadFrom(XElement xE)
		{
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
			}
		}
		public virtual void WriteTo(XElement xE)
		{
		}
	}
}
