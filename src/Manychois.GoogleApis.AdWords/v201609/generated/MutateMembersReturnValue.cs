using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A container for return value from {@code UserListService#mutateMembers}
	/// method.
	/// </summary>
	public class MutateMembersReturnValue : ISoapable
	{
		/// <summary>
		/// The user lists associated in mutate members operations.
		/// </summary>
		public List<UserList> UserLists { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			UserLists = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "userLists")
				{
					if (UserLists == null) UserLists = new List<UserList>();
					var userListsItem = new UserList();
					userListsItem.ReadFrom(xItem);
					UserLists.Add(userListsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (UserLists != null)
			{
				foreach (var userListsItem in UserLists)
				{
					xItem = new XElement(XName.Get("userLists", "https://adwords.google.com/api/adwords/rm/v201609"));
					userListsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
