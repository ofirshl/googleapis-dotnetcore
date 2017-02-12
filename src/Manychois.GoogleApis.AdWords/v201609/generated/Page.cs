using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains the results from a get call.
	/// </summary>
	public abstract class Page : ISoapable
	{
		/// <summary>
		/// Total number of entries in the result that this page is a part of.
		/// </summary>
		public int? TotalNumEntries { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of Page.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string PageType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			TotalNumEntries = null;
			PageType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "totalNumEntries")
				{
					TotalNumEntries = int.Parse(xItem.Value);
				}
				else if (localName == "Page.Type")
				{
					PageType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (TotalNumEntries != null)
			{
				xItem = new XElement(XName.Get("totalNumEntries", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TotalNumEntries.Value.ToString());
				xE.Add(xItem);
			}
			if (PageType != null)
			{
				xItem = new XElement(XName.Get("Page.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PageType);
				xE.Add(xItem);
			}
		}
	}
}
