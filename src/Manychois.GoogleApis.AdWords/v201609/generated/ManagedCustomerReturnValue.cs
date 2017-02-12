using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A container for return values from the ManagedCustomerService.
	/// </summary>
	public class ManagedCustomerReturnValue : ISoapable
	{
		/// <summary>
		/// List of managed customers.
		/// </summary>
		public List<ManagedCustomer> Value { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					if (Value == null) Value = new List<ManagedCustomer>();
					var valueItem = new ManagedCustomer();
					valueItem.ReadFrom(xItem);
					Value.Add(valueItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Value != null)
			{
				foreach (var valueItem in Value)
				{
					xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/mcm/v201609"));
					valueItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
