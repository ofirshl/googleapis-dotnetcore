using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Marker interface for ConstantDataService objects. This is primarily required for field
	/// catalog generation.
	/// </summary>
	public class ConstantData : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of ConstantData.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string ConstantDataType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ConstantDataType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "ConstantData.Type")
				{
					ConstantDataType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ConstantDataType != null)
			{
				xItem = new XElement(XName.Get("ConstantData.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ConstantDataType);
				xE.Add(xItem);
			}
		}
	}
}
