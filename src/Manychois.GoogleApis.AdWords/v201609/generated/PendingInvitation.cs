using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Pending invitation result for the getPendingInvitations method.
	/// </summary>
	public class PendingInvitation : ISoapable
	{
		public ManagedCustomer Manager { get; set; }
		public ManagedCustomer Client { get; set; }
		public string CreationDate { get; set; }
		public string ExpirationDate { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Manager = null;
			Client = null;
			CreationDate = null;
			ExpirationDate = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "manager")
				{
					Manager = new ManagedCustomer();
					Manager.ReadFrom(xItem);
				}
				else if (localName == "client")
				{
					Client = new ManagedCustomer();
					Client.ReadFrom(xItem);
				}
				else if (localName == "creationDate")
				{
					CreationDate = xItem.Value;
				}
				else if (localName == "expirationDate")
				{
					ExpirationDate = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Manager != null)
			{
				xItem = new XElement(XName.Get("manager", "https://adwords.google.com/api/adwords/mcm/v201609"));
				Manager.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Client != null)
			{
				xItem = new XElement(XName.Get("client", "https://adwords.google.com/api/adwords/mcm/v201609"));
				Client.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (CreationDate != null)
			{
				xItem = new XElement(XName.Get("creationDate", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(CreationDate);
				xE.Add(xItem);
			}
			if (ExpirationDate != null)
			{
				xItem = new XElement(XName.Get("expirationDate", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(ExpirationDate);
				xE.Add(xItem);
			}
		}
	}
}
