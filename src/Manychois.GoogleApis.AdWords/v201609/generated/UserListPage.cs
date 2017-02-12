using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains a list of user lists resulting from the filtering and paging of the
	/// {@link UserListService#get} call.
	/// </summary>
	public class UserListPage : Page, ISoapable
	{
		/// <summary>
		/// The result entries in this page.
		/// </summary>
		public List<UserList> Entries { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Entries = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "entries")
				{
					if (Entries == null) Entries = new List<UserList>();
					var entriesItem = new UserList();
					entriesItem.ReadFrom(xItem);
					Entries.Add(entriesItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/rm/v201609", "UserListPage");
			XElement xItem = null;
			if (Entries != null)
			{
				foreach (var entriesItem in Entries)
				{
					xItem = new XElement(XName.Get("entries", "https://adwords.google.com/api/adwords/rm/v201609"));
					entriesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
