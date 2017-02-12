using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains a subset of {@link TargetingIdea}s from the search criteria
	/// specified by a {@link TargetingIdeaSelector}.
	/// </summary>
	public class TargetingIdeaPage : ISoapable
	{
		/// <summary>
		/// Total number of entries that can be retrieved using the get method.
		/// </summary>
		public int? TotalNumEntries { get; set; }
		/// <summary>
		/// The result entries in this page, as list of {@link TargetingIdea}s.
		/// </summary>
		public List<TargetingIdea> Entries { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			TotalNumEntries = null;
			Entries = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "totalNumEntries")
				{
					TotalNumEntries = int.Parse(xItem.Value);
				}
				else if (localName == "entries")
				{
					if (Entries == null) Entries = new List<TargetingIdea>();
					var entriesItem = new TargetingIdea();
					entriesItem.ReadFrom(xItem);
					Entries.Add(entriesItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (TotalNumEntries != null)
			{
				xItem = new XElement(XName.Get("totalNumEntries", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(TotalNumEntries.Value.ToString());
				xE.Add(xItem);
			}
			if (Entries != null)
			{
				foreach (var entriesItem in Entries)
				{
					xItem = new XElement(XName.Get("entries", "https://adwords.google.com/api/adwords/o/v201609"));
					entriesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
