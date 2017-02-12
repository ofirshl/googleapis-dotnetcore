using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A page of {@link BudgetOrder}s from {@link BudgetOrderService#get}
	/// method.
	/// </summary>
	public class BudgetOrderPage : Page, ISoapable
	{
		/// <summary>
		/// The result entries in this page.
		/// </summary>
		public List<BudgetOrder> Entries { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Entries = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "entries")
				{
					if (Entries == null) Entries = new List<BudgetOrder>();
					var entriesItem = new BudgetOrder();
					entriesItem.ReadFrom(xItem);
					Entries.Add(entriesItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/billing/v201609", "BudgetOrderPage");
			XElement xItem = null;
			if (Entries != null)
			{
				foreach (var entriesItem in Entries)
				{
					xItem = new XElement(XName.Get("entries", "https://adwords.google.com/api/adwords/billing/v201609"));
					entriesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
