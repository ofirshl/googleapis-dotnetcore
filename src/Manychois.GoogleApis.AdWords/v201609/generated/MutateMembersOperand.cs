using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Operand containing user list id and members to be added or removed.
	/// </summary>
	public class MutateMembersOperand : ISoapable
	{
		/// <summary>
		/// The id of the user list.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? UserListId { get; set; }
		/// <summary>
		/// The data type indicating the type of member data entity in
		/// {@code members} list. If it's not specified, it'll default to
		/// {@link DataType#EMAIL_SHA256}.
		/// </summary>
		public MutateMembersOperandDataType? DataType { get; set; }
		/// <summary>
		/// Set to indicate a purge operation which will remove all members from the user list.
		/// Can only be set with {@code Operator#REMOVE} and
		/// when set to true {@link #members} must be null or empty.
		/// </summary>
		public bool? RemoveAll { get; set; }
		/// <summary>
		/// A list of members to be added or removed.
		///
		/// <p>If {@link #removeAll} is {@code true}, this list must be {@code null} or empty. Otherwise,
		/// this field is required and there must be at least one member.
		///
		/// <p>Each element in members list should be in format according to the specified
		/// {@code dataType}.
		/// <span class="constraint CollectionSize">The maximum size of this collection is 1000000.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// </summary>
		public List<string> Members { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			UserListId = null;
			DataType = null;
			RemoveAll = null;
			Members = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "userListId")
				{
					UserListId = long.Parse(xItem.Value);
				}
				else if (localName == "dataType")
				{
					DataType = MutateMembersOperandDataTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "removeAll")
				{
					RemoveAll = bool.Parse(xItem.Value);
				}
				else if (localName == "members")
				{
					if (Members == null) Members = new List<string>();
					Members.Add(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (UserListId != null)
			{
				xItem = new XElement(XName.Get("userListId", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(UserListId.Value.ToString());
				xE.Add(xItem);
			}
			if (DataType != null)
			{
				xItem = new XElement(XName.Get("dataType", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(DataType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (RemoveAll != null)
			{
				xItem = new XElement(XName.Get("removeAll", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(RemoveAll.Value.ToString());
				xE.Add(xItem);
			}
			if (Members != null)
			{
				foreach (var membersItem in Members)
				{
					xItem = new XElement(XName.Get("members", "https://adwords.google.com/api/adwords/rm/v201609"));
					xItem.Add(membersItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
