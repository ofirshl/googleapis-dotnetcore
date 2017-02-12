using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// UserList - represents a user list that is defined by the advertiser to be targeted.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class CriterionUserList : Criterion, ISoapable
	{
		/// <summary>
		/// Id of this user list. This is a required field.
		/// <span class="constraint Selectable">This field can be selected using the value "UserListId".</span>
		/// </summary>
		public long? UserListId { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "UserListName".</span>
		/// </summary>
		public string UserListName { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "UserListMembershipStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public CriterionUserListMembershipStatus? UserListMembershipStatus { get; set; }
		/// <summary>
		/// Determines whether a user list is eligible for targeting in the google.com
		/// (search) network.
		/// <span class="constraint Selectable">This field can be selected using the value "UserListEligibleForSearch".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? UserListEligibleForSearch { get; set; }
		/// <summary>
		/// Determines whether a user list is eligible for targeting in the display network.
		/// <span class="constraint Selectable">This field can be selected using the value "UserListEligibleForDisplay".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? UserListEligibleForDisplay { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			UserListId = null;
			UserListName = null;
			UserListMembershipStatus = null;
			UserListEligibleForSearch = null;
			UserListEligibleForDisplay = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "userListId")
				{
					UserListId = long.Parse(xItem.Value);
				}
				else if (localName == "userListName")
				{
					UserListName = xItem.Value;
				}
				else if (localName == "userListMembershipStatus")
				{
					UserListMembershipStatus = CriterionUserListMembershipStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "userListEligibleForSearch")
				{
					UserListEligibleForSearch = bool.Parse(xItem.Value);
				}
				else if (localName == "userListEligibleForDisplay")
				{
					UserListEligibleForDisplay = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CriterionUserList");
			XElement xItem = null;
			if (UserListId != null)
			{
				xItem = new XElement(XName.Get("userListId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UserListId.Value.ToString());
				xE.Add(xItem);
			}
			if (UserListName != null)
			{
				xItem = new XElement(XName.Get("userListName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UserListName);
				xE.Add(xItem);
			}
			if (UserListMembershipStatus != null)
			{
				xItem = new XElement(XName.Get("userListMembershipStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UserListMembershipStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (UserListEligibleForSearch != null)
			{
				xItem = new XElement(XName.Get("userListEligibleForSearch", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UserListEligibleForSearch.Value.ToString());
				xE.Add(xItem);
			}
			if (UserListEligibleForDisplay != null)
			{
				xItem = new XElement(XName.Get("userListEligibleForDisplay", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UserListEligibleForDisplay.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
