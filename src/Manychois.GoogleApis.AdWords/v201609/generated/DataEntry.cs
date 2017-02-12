using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The base class of all return types of the table service.
	/// </summary>
	public abstract class DataEntry : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of DataEntry.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string DataEntryType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			DataEntryType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "DataEntry.Type")
				{
					DataEntryType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (DataEntryType != null)
			{
				xItem = new XElement(XName.Get("DataEntry.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DataEntryType);
				xE.Add(xItem);
			}
		}
	}
}
