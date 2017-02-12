using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Base type for AdWords campaign settings.
	/// </summary>
	public abstract class Setting : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of Setting.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string SettingType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			SettingType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "Setting.Type")
				{
					SettingType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (SettingType != null)
			{
				xItem = new XElement(XName.Get("Setting.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SettingType);
				xE.Add(xItem);
			}
		}
	}
}
