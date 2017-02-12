using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Configuration data allowing feed items to be populated for a system feed.
	/// </summary>
	public class SystemFeedGenerationData : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of SystemFeedGenerationData.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string SystemFeedGenerationDataType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			SystemFeedGenerationDataType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "SystemFeedGenerationData.Type")
				{
					SystemFeedGenerationDataType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (SystemFeedGenerationDataType != null)
			{
				xItem = new XElement(XName.Get("SystemFeedGenerationData.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SystemFeedGenerationDataType);
				xE.Add(xItem);
			}
		}
	}
}
