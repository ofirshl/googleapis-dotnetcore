using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// User list targeting as a collection of conversion types.
	/// </summary>
	public class BasicUserList : UserList, ISoapable
	{
		/// <summary>
		/// Conversion types associated with this user list.
		/// <span class="constraint Selectable">This field can be selected using the value "ConversionTypes".</span>
		/// </summary>
		public List<UserListConversionType> ConversionTypes { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			ConversionTypes = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "conversionTypes")
				{
					if (ConversionTypes == null) ConversionTypes = new List<UserListConversionType>();
					var conversionTypesItem = new UserListConversionType();
					conversionTypesItem.ReadFrom(xItem);
					ConversionTypes.Add(conversionTypesItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/rm/v201609", "BasicUserList");
			XElement xItem = null;
			if (ConversionTypes != null)
			{
				foreach (var conversionTypesItem in ConversionTypes)
				{
					xItem = new XElement(XName.Get("conversionTypes", "https://adwords.google.com/api/adwords/rm/v201609"));
					conversionTypesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
