using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A group of rule items that are ANDed together.
	/// </summary>
	public class RuleItemGroup : ISoapable
	{
		/// <summary>
		/// <span class="constraint CollectionSize">The minimum size of this collection is 1.</span>
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<RuleItem> Items { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Items = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "items")
				{
					if (Items == null) Items = new List<RuleItem>();
					var itemsItem = new RuleItem();
					itemsItem.ReadFrom(xItem);
					Items.Add(itemsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Items != null)
			{
				foreach (var itemsItem in Items)
				{
					xItem = new XElement(XName.Get("items", "https://adwords.google.com/api/adwords/rm/v201609"));
					itemsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
