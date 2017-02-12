using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// UserList of CRM users provided by the advertiser.
	/// </summary>
	public class CrmBasedUserList : UserList, ISoapable
	{
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/rm/v201609", "CrmBasedUserList");
		}
	}
}
