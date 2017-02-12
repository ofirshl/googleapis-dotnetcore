using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Mutate members of user lists by either adding or removing their lists of members.
	/// The following {@link Operator}s are supported: ADD and REMOVE.
	///
	/// <p>Note that operations cannot have same user list id but different operators.
	///
	/// @param operations the mutate members operations to apply
	/// @return a list of UserList objects
	/// @throws ApiException when there are one or more errors with the request
	/// </summary>
	internal class AdwordsUserListServiceMutateMembers : ISoapable
	{
		/// <summary>
		/// <span class="constraint CollectionSize">The minimum size of this collection is 1. The maximum size of this collection is 10000.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint SupportedOperators">The following {@link Operator}s are supported: ADD, REMOVE.</span>
		/// </summary>
		public List<MutateMembersOperation> Operations { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operations")
				{
					if (Operations == null) Operations = new List<MutateMembersOperation>();
					var operationsItem = new MutateMembersOperation();
					operationsItem.ReadFrom(xItem);
					Operations.Add(operationsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Operations != null)
			{
				foreach (var operationsItem in Operations)
				{
					xItem = new XElement(XName.Get("operations", "https://adwords.google.com/api/adwords/rm/v201609"));
					operationsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
