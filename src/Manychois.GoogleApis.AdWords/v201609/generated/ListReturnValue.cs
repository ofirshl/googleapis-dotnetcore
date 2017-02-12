using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Base list return value type.
	/// </summary>
	public abstract class ListReturnValue : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of ListReturnValue.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string ListReturnValueType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ListReturnValueType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "ListReturnValue.Type")
				{
					ListReturnValueType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ListReturnValueType != null)
			{
				xItem = new XElement(XName.Get("ListReturnValue.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ListReturnValueType);
				xE.Add(xItem);
			}
		}
	}
}
