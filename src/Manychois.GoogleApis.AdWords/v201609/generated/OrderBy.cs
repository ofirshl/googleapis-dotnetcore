using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Specifies how the resulting information should be sorted.
	/// </summary>
	public class OrderBy : ISoapable
	{
		/// <summary>
		/// The field to sort the results on.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string Field { get; set; }
		/// <summary>
		/// The order to sort the results on. The default sort order is {@link SortOrder#ASCENDING}.
		/// </summary>
		public SortOrder? SortOrder { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Field = null;
			SortOrder = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "field")
				{
					Field = xItem.Value;
				}
				else if (localName == "sortOrder")
				{
					SortOrder = SortOrderExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Field != null)
			{
				xItem = new XElement(XName.Get("field", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Field);
				xE.Add(xItem);
			}
			if (SortOrder != null)
			{
				xItem = new XElement(XName.Get("sortOrder", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SortOrder.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
