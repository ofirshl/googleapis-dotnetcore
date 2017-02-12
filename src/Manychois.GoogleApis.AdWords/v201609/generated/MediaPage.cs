using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Page of media returned by the {@link MediaService} which includes
	/// the media.
	/// </summary>
	public class MediaPage : ISoapable
	{
		/// <summary>
		/// The result entries in this page.
		/// </summary>
		public List<Media> Entries { get; set; }
		/// <summary>
		/// Total number of entries in the result that this page is a part of.
		/// </summary>
		public int? TotalNumEntries { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Entries = null;
			TotalNumEntries = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "entries")
				{
					if (Entries == null) Entries = new List<Media>();
					var entriesItem = new Media();
					entriesItem.ReadFrom(xItem);
					Entries.Add(entriesItem);
				}
				else if (localName == "totalNumEntries")
				{
					TotalNumEntries = int.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
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
			if (TotalNumEntries != null)
			{
				xItem = new XElement(XName.Get("totalNumEntries", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TotalNumEntries.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
