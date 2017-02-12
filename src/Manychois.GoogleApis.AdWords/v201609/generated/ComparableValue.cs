using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Comparable types for constructing ranges with.
	/// </summary>
	public abstract class ComparableValue : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of ComparableValue.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string ComparableValueType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ComparableValueType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "ComparableValue.Type")
				{
					ComparableValueType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ComparableValueType != null)
			{
				xItem = new XElement(XName.Get("ComparableValue.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ComparableValueType);
				xE.Add(xItem);
			}
		}
	}
}
