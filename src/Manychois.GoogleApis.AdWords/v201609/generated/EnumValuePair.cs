using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents information about enum values.
	/// </summary>
	public class EnumValuePair : ISoapable
	{
		/// <summary>
		/// The api enum value.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string EnumValue { get; set; }
		/// <summary>
		/// The enum value displayed in the downloaded report.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string EnumDisplayValue { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			EnumValue = null;
			EnumDisplayValue = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "enumValue")
				{
					EnumValue = xItem.Value;
				}
				else if (localName == "enumDisplayValue")
				{
					EnumDisplayValue = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (EnumValue != null)
			{
				xItem = new XElement(XName.Get("enumValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EnumValue);
				xE.Add(xItem);
			}
			if (EnumDisplayValue != null)
			{
				xItem = new XElement(XName.Get("enumDisplayValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EnumDisplayValue);
				xE.Add(xItem);
			}
		}
	}
}
