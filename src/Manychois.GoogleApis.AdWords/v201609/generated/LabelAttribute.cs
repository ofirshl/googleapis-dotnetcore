using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Base type for AdWords label attributes.
	/// </summary>
	public class LabelAttribute : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of LabelAttribute.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string LabelAttributeType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			LabelAttributeType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "LabelAttribute.Type")
				{
					LabelAttributeType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (LabelAttributeType != null)
			{
				xItem = new XElement(XName.Get("LabelAttribute.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LabelAttributeType);
				xE.Add(xItem);
			}
		}
	}
}
