using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Results of a {@link ManagedCustomerService#mutateLink} call which changes
	/// manager/client links.
	/// </summary>
	public class MutateLinkResults : ISoapable
	{
		/// <summary>
		/// Links that were changed as a result of this call.
		/// </summary>
		public List<ManagedCustomerLink> Links { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Links = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "links")
				{
					if (Links == null) Links = new List<ManagedCustomerLink>();
					var linksItem = new ManagedCustomerLink();
					linksItem.ReadFrom(xItem);
					Links.Add(linksItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
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
