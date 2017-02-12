using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// SimilarUserList is a list of users which are similar to users from another UserList.
	/// These lists are readonly and automatically created by google.
	/// </summary>
	public class SimilarUserList : UserList, ISoapable
	{
		/// <summary>
		/// Seed UserListId from which this list is derived.
		/// <span class="constraint Selectable">This field can be selected using the value "SeedUserListId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: SET.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public long? SeedUserListId { get; set; }
		/// <summary>
		/// Name of the seed user list.
		/// <span class="constraint Selectable">This field can be selected using the value "SeedUserListName".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string SeedUserListName { get; set; }
		/// <summary>
		/// Description of this seed user list.
		/// <span class="constraint Selectable">This field can be selected using the value "SeedUserListDescription".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string SeedUserListDescription { get; set; }
		/// <summary>
		/// Membership status of this seed user list.
		/// <span class="constraint Selectable">This field can be selected using the value "SeedUserListStatus".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public UserListMembershipStatus? SeedUserListStatus { get; set; }
		/// <summary>
		/// Estimated number of users in this seed user list.
		/// This value is null if the number of users has not yet been determined.
		/// <span class="constraint Selectable">This field can be selected using the value "SeedListSize".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? SeedListSize { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			SeedUserListId = null;
			SeedUserListName = null;
			SeedUserListDescription = null;
			SeedUserListStatus = null;
			SeedListSize = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "seedUserListId")
				{
					SeedUserListId = long.Parse(xItem.Value);
				}
				else if (localName == "seedUserListName")
				{
					SeedUserListName = xItem.Value;
				}
				else if (localName == "seedUserListDescription")
				{
					SeedUserListDescription = xItem.Value;
				}
				else if (localName == "seedUserListStatus")
				{
					SeedUserListStatus = UserListMembershipStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "seedListSize")
				{
					SeedListSize = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/rm/v201609", "SimilarUserList");
			XElement xItem = null;
			if (SeedUserListId != null)
			{
				xItem = new XElement(XName.Get("seedUserListId", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(SeedUserListId.Value.ToString());
				xE.Add(xItem);
			}
			if (SeedUserListName != null)
			{
				xItem = new XElement(XName.Get("seedUserListName", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(SeedUserListName);
				xE.Add(xItem);
			}
			if (SeedUserListDescription != null)
			{
				xItem = new XElement(XName.Get("seedUserListDescription", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(SeedUserListDescription);
				xE.Add(xItem);
			}
			if (SeedUserListStatus != null)
			{
				xItem = new XElement(XName.Get("seedUserListStatus", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(SeedUserListStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (SeedListSize != null)
			{
				xItem = new XElement(XName.Get("seedListSize", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(SeedListSize.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
