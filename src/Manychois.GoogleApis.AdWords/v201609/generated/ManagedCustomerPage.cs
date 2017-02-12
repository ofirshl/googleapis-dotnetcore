using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Return result of {@link ManagedCustomerService}
	/// </summary>
	public class ManagedCustomerPage : Page, ISoapable
	{
		/// <summary>
		/// Subset of the managed customers' information that are being retrieved.
		/// </summary>
		public List<ManagedCustomer> Entries { get; set; }
		/// <summary>
		/// Links between manager and client customers.
		/// </summary>
		public List<ManagedCustomerLink> Links { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Entries = null;
			Links = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "entries")
				{
					if (Entries == null) Entries = new List<ManagedCustomer>();
					var entriesItem = new ManagedCustomer();
					entriesItem.ReadFrom(xItem);
					Entries.Add(entriesItem);
				}
				else if (localName == "links")
				{
					if (Links == null) Links = new List<ManagedCustomerLink>();
					var linksItem = new ManagedCustomerLink();
					linksItem.ReadFrom(xItem);
					Links.Add(linksItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/mcm/v201609", "ManagedCustomerPage");
			XElement xItem = null;
			if (Entries != null)
			{
				foreach (var entriesItem in Entries)
				{
					xItem = new XElement(XName.Get("entries", "https://adwords.google.com/api/adwords/mcm/v201609"));
					entriesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (Links != null)
			{
				foreach (var linksItem in Links)
				{
					xItem = new XElement(XName.Get("links", "https://adwords.google.com/api/adwords/mcm/v201609"));
					linksItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
