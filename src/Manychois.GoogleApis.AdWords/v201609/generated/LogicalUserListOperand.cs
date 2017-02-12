using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An interface for a logical user list operand. A logical user list is a
	/// combination of logical rules. Each rule is defined as a logical operator and
	/// a list of operands. Those operands can be of type UserList.
	/// </summary>
	public class LogicalUserListOperand : ISoapable
	{
		public UserList UserList { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "UserList")
				{
					UserList = new UserList();
					UserList.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			xItem = new XElement(XName.Get("UserList", "https://adwords.google.com/api/adwords/rm/v201609"));
			UserList.WriteTo(xItem);
			xE.Add(xItem);
		}
	}
}
