using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a UserList object that is sent over the wire.
	/// This is a list of users an account may target.
	/// </summary>
	public class UserList : ISoapable
	{
		/// <summary>
		/// Id of this user list.
		/// <span class="constraint Selectable">This field can be selected using the value "Id".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// A flag that indicates if a user may edit a list. Depends on the list ownership
		/// and list type. For example, external remarketing user lists are not editable.
		/// <span class="constraint Selectable">This field can be selected using the value "IsReadOnly".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? IsReadOnly { get; set; }
		/// <summary>
		/// Name of this user list. Depending on its AccessReason, the user list name
		/// may not be unique (e.g. if {@code AccessReason=SHARED}).
		/// <span class="constraint Selectable">This field can be selected using the value "Name".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Description of this user list.
		/// <span class="constraint Selectable">This field can be selected using the value "Description".</span>
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Membership status of this user list. Indicates whether a user list is open
		/// or active. Only open user lists can accumulate more users and can be targeted to.
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public UserListMembershipStatus? Status { get; set; }
		/// <summary>
		/// An Id from external system. It is used by user list sellers to correlate ids on their
		/// systems.
		/// <span class="constraint Selectable">This field can be selected using the value "IntegrationCode".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string IntegrationCode { get; set; }
		/// <summary>
		/// Indicates the reason this account has been granted access to the list. The reason can be
		/// Shared, Owned, Licensed or Subscribed.
		/// <span class="constraint Selectable">This field can be selected using the value "AccessReason".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public AccessReason? AccessReason { get; set; }
		/// <summary>
		/// Indicates if this share is still active. When a UserList is shared with the user
		/// this field is set to Active. Later the userList owner can decide to revoke the
		/// share and make it Inactive. The default value of this field is set to Active.
		/// <span class="constraint Selectable">This field can be selected using the value "AccountUserListStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public AccountUserListStatus? AccountUserListStatus { get; set; }
		/// <summary>
		/// Number of days a user's cookie stays on your list since its most recent addition to the list.
		/// This field must be between 0 and 540 inclusive. However, for CRM based userlists, this field
		/// can be set to 10000 which means no expiration.
		///
		/// <p>It'll be ignored for {@link LogicalUserList}.
		/// <span class="constraint Selectable">This field can be selected using the value "MembershipLifeSpan".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? MembershipLifeSpan { get; set; }
		/// <summary>
		/// Estimated number of users in this user list, on the Google Display Network.
		/// This value is null if the number of users has not yet been determined.
		/// <span class="constraint Selectable">This field can be selected using the value "Size".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? Size { get; set; }
		/// <summary>
		/// Size range in terms of number of users of the UserList.
		/// <span class="constraint Selectable">This field can be selected using the value "SizeRange".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public SizeRange? SizeRange { get; set; }
		/// <summary>
		/// Estimated number of users in this user list in the google.com domain.
		/// These are the users available for targeting in search campaigns.
		/// This value is null if the number of users has not yet been determined.
		/// <span class="constraint Selectable">This field can be selected using the value "SizeForSearch".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? SizeForSearch { get; set; }
		/// <summary>
		/// Size range in terms of number of users of the UserList, for Search ads.
		/// <span class="constraint Selectable">This field can be selected using the value "SizeRangeForSearch".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public SizeRange? SizeRangeForSearch { get; set; }
		/// <summary>
		/// Type of this list: remarketing/logical/external remarketing.
		/// <span class="constraint Selectable">This field can be selected using the value "ListType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public UserListType? ListType { get; set; }
		/// <summary>
		/// A flag that indicates this user list is eligible for Google Search Network.
		/// <span class="constraint Selectable">This field can be selected using the value "IsEligibleForSearch".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public bool? IsEligibleForSearch { get; set; }
		/// <summary>
		/// A flag that indicates this user list is eligible for Display Network.
		/// <span class="constraint Selectable">This field can be selected using the value "IsEligibleForDisplay".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? IsEligibleForDisplay { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of UserList.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string UserListType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			IsReadOnly = null;
			Name = null;
			Description = null;
			Status = null;
			IntegrationCode = null;
			AccessReason = null;
			AccountUserListStatus = null;
			MembershipLifeSpan = null;
			Size = null;
			SizeRange = null;
			SizeForSearch = null;
			SizeRangeForSearch = null;
			ListType = null;
			IsEligibleForSearch = null;
			IsEligibleForDisplay = null;
			UserListType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "isReadOnly")
				{
					IsReadOnly = bool.Parse(xItem.Value);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "description")
				{
					Description = xItem.Value;
				}
				else if (localName == "status")
				{
					Status = UserListMembershipStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "integrationCode")
				{
					IntegrationCode = xItem.Value;
				}
				else if (localName == "accessReason")
				{
					AccessReason = AccessReasonExtensions.Parse(xItem.Value);
				}
				else if (localName == "accountUserListStatus")
				{
					AccountUserListStatus = AccountUserListStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "membershipLifeSpan")
				{
					MembershipLifeSpan = long.Parse(xItem.Value);
				}
				else if (localName == "size")
				{
					Size = long.Parse(xItem.Value);
				}
				else if (localName == "sizeRange")
				{
					SizeRange = SizeRangeExtensions.Parse(xItem.Value);
				}
				else if (localName == "sizeForSearch")
				{
					SizeForSearch = long.Parse(xItem.Value);
				}
				else if (localName == "sizeRangeForSearch")
				{
					SizeRangeForSearch = SizeRangeExtensions.Parse(xItem.Value);
				}
				else if (localName == "listType")
				{
					ListType = UserListTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "isEligibleForSearch")
				{
					IsEligibleForSearch = bool.Parse(xItem.Value);
				}
				else if (localName == "isEligibleForDisplay")
				{
					IsEligibleForDisplay = bool.Parse(xItem.Value);
				}
				else if (localName == "UserList.Type")
				{
					UserListType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (IsReadOnly != null)
			{
				xItem = new XElement(XName.Get("isReadOnly", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(IsReadOnly.Value.ToString());
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (Description != null)
			{
				xItem = new XElement(XName.Get("description", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Description);
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (IntegrationCode != null)
			{
				xItem = new XElement(XName.Get("integrationCode", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(IntegrationCode);
				xE.Add(xItem);
			}
			if (AccessReason != null)
			{
				xItem = new XElement(XName.Get("accessReason", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(AccessReason.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (AccountUserListStatus != null)
			{
				xItem = new XElement(XName.Get("accountUserListStatus", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(AccountUserListStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (MembershipLifeSpan != null)
			{
				xItem = new XElement(XName.Get("membershipLifeSpan", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(MembershipLifeSpan.Value.ToString());
				xE.Add(xItem);
			}
			if (Size != null)
			{
				xItem = new XElement(XName.Get("size", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Size.Value.ToString());
				xE.Add(xItem);
			}
			if (SizeRange != null)
			{
				xItem = new XElement(XName.Get("sizeRange", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(SizeRange.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (SizeForSearch != null)
			{
				xItem = new XElement(XName.Get("sizeForSearch", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(SizeForSearch.Value.ToString());
				xE.Add(xItem);
			}
			if (SizeRangeForSearch != null)
			{
				xItem = new XElement(XName.Get("sizeRangeForSearch", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(SizeRangeForSearch.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ListType != null)
			{
				xItem = new XElement(XName.Get("listType", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(ListType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (IsEligibleForSearch != null)
			{
				xItem = new XElement(XName.Get("isEligibleForSearch", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(IsEligibleForSearch.Value.ToString());
				xE.Add(xItem);
			}
			if (IsEligibleForDisplay != null)
			{
				xItem = new XElement(XName.Get("isEligibleForDisplay", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(IsEligibleForDisplay.Value.ToString());
				xE.Add(xItem);
			}
			if (UserListType != null)
			{
				xItem = new XElement(XName.Get("UserList.Type", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(UserListType);
				xE.Add(xItem);
			}
		}
	}
}
