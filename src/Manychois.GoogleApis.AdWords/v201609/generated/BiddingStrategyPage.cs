using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains a list of bidding strategies resulting from the filtering and paging
	/// of {@link BiddingStrategy#get} call.
	/// </summary>
	public class BiddingStrategyPage : Page, ISoapable
	{
		public List<SharedBiddingStrategy> Entries { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Entries = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "entries")
				{
					if (Entries == null) Entries = new List<SharedBiddingStrategy>();
					var entriesItem = new SharedBiddingStrategy();
					entriesItem.ReadFrom(xItem);
					Entries.Add(entriesItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "BiddingStrategyPage");
			XElement xItem = null;
			if (Entries != null)
			{
				foreach (var entriesItem in Entries)
				{
					xItem = new XElement(XName.Get("entries", "https://adwords.google.com/api/adwords/cm/v201609"));
					entriesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
