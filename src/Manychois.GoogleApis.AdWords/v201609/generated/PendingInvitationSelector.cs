using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Selector for getPendingInvitations method.
	/// </summary>
	public class PendingInvitationSelector : ISoapable
	{
		/// <summary>
		/// Manager customer IDs to check for sent invitations.
		/// </summary>
		public List<long> ManagerCustomerIds { get; set; }
		/// <summary>
		/// Client customer IDs to check for received invitations.
		/// </summary>
		public List<long> ClientCustomerIds { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ManagerCustomerIds = null;
			ClientCustomerIds = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "managerCustomerIds")
				{
					if (ManagerCustomerIds == null) ManagerCustomerIds = new List<long>();
					ManagerCustomerIds.Add(long.Parse(xItem.Value));
				}
				else if (localName == "clientCustomerIds")
				{
					if (ClientCustomerIds == null) ClientCustomerIds = new List<long>();
					ClientCustomerIds.Add(long.Parse(xItem.Value));
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ManagerCustomerIds != null)
			{
				foreach (var managerCustomerIdsItem in ManagerCustomerIds)
				{
					xItem = new XElement(XName.Get("managerCustomerIds", "https://adwords.google.com/api/adwords/mcm/v201609"));
					xItem.Add(managerCustomerIdsItem.ToString());
					xE.Add(xItem);
				}
			}
			if (ClientCustomerIds != null)
			{
				foreach (var clientCustomerIdsItem in ClientCustomerIds)
				{
					xItem = new XElement(XName.Get("clientCustomerIds", "https://adwords.google.com/api/adwords/mcm/v201609"));
					xItem.Add(clientCustomerIdsItem.ToString());
					xE.Add(xItem);
				}
			}
		}
	}
}
