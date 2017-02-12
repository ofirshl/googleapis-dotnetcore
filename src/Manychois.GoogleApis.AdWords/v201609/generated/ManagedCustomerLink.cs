using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an AdWords manager-client link.
	/// </summary>
	public class ManagedCustomerLink : ISoapable
	{
		/// <summary>
		/// The manager customer id in this link.
		/// </summary>
		public long? ManagerCustomerId { get; set; }
		/// <summary>
		/// The client customer id in this link.
		/// </summary>
		public long? ClientCustomerId { get; set; }
		/// <summary>
		/// The status of the link.  For get operations, this will always be ACTIVE.  For mutates,
		/// this is the field used to modify links (PENDING, ACTIVE, INACTIVE, CANCELLED, REFUSED).
		/// </summary>
		public LinkStatus? LinkStatus { get; set; }
		/// <summary>
		/// The pending descriptive name of the client for link invitations.
		/// </summary>
		public string PendingDescriptiveName { get; set; }
		/// <summary>
		/// Whether the link is hidden.
		///
		/// <p> Hiding accounts removes them from your manager account views without unlinking them
		/// in the Adwords UI. Ads in those accounts will continue running normally.
		/// </summary>
		public bool? IsHidden { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ManagerCustomerId = null;
			ClientCustomerId = null;
			LinkStatus = null;
			PendingDescriptiveName = null;
			IsHidden = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "managerCustomerId")
				{
					ManagerCustomerId = long.Parse(xItem.Value);
				}
				else if (localName == "clientCustomerId")
				{
					ClientCustomerId = long.Parse(xItem.Value);
				}
				else if (localName == "linkStatus")
				{
					LinkStatus = LinkStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "pendingDescriptiveName")
				{
					PendingDescriptiveName = xItem.Value;
				}
				else if (localName == "isHidden")
				{
					IsHidden = bool.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ManagerCustomerId != null)
			{
				xItem = new XElement(XName.Get("managerCustomerId", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(ManagerCustomerId.Value.ToString());
				xE.Add(xItem);
			}
			if (ClientCustomerId != null)
			{
				xItem = new XElement(XName.Get("clientCustomerId", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(ClientCustomerId.Value.ToString());
				xE.Add(xItem);
			}
			if (LinkStatus != null)
			{
				xItem = new XElement(XName.Get("linkStatus", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(LinkStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (PendingDescriptiveName != null)
			{
				xItem = new XElement(XName.Get("pendingDescriptiveName", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(PendingDescriptiveName);
				xE.Add(xItem);
			}
			if (IsHidden != null)
			{
				xItem = new XElement(XName.Get("isHidden", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(IsHidden.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
