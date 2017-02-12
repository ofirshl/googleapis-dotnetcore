using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// SharedSets are used for sharing entities across multiple campaigns
	/// under the same account.
	/// </summary>
	public class SharedSet : ISoapable
	{
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "SharedSetId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET, REMOVE.</span>
		/// </summary>
		public long? SharedSetId { get; set; }
		/// <summary>
		/// Shared Sets must have names that are case-insensitive unique across all
		/// other shared sets in the account (active and deleted).
		/// <span class="constraint Selectable">This field can be selected using the value "Name".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 255, inclusive, in UTF-8 bytes, (trimmed).</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "Type".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public SharedSetType? Type { get; set; }
		/// <summary>
		/// The number of entities in the shared set.
		/// <span class="constraint Selectable">This field can be selected using the value "MemberCount".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public int? MemberCount { get; set; }
		/// <summary>
		/// The number of campaigns that actively use the shared set.
		/// <span class="constraint Selectable">This field can be selected using the value "ReferenceCount".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public int? ReferenceCount { get; set; }
		/// <summary>
		/// The status of the shared set.
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public SharedSetStatus? Status { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			SharedSetId = null;
			Name = null;
			Type = null;
			MemberCount = null;
			ReferenceCount = null;
			Status = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "sharedSetId")
				{
					SharedSetId = long.Parse(xItem.Value);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "type")
				{
					Type = SharedSetTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "memberCount")
				{
					MemberCount = int.Parse(xItem.Value);
				}
				else if (localName == "referenceCount")
				{
					ReferenceCount = int.Parse(xItem.Value);
				}
				else if (localName == "status")
				{
					Status = SharedSetStatusExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (SharedSetId != null)
			{
				xItem = new XElement(XName.Get("sharedSetId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SharedSetId.Value.ToString());
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (Type != null)
			{
				xItem = new XElement(XName.Get("type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Type.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (MemberCount != null)
			{
				xItem = new XElement(XName.Get("memberCount", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(MemberCount.Value.ToString());
				xE.Add(xItem);
			}
			if (ReferenceCount != null)
			{
				xItem = new XElement(XName.Get("referenceCount", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ReferenceCount.Value.ToString());
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
