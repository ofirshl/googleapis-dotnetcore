using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A generic selector to specify the type of information to return.
	/// </summary>
	public class Selector : ISoapable
	{
		/// <summary>
		/// List of fields to select.
		/// <a href="/adwords/api/docs/appendix/selectorfields">Possible values</a>
		/// are marked {@code Selectable} on the entity's reference page.
		/// For example, for the {@code CampaignService} selector, refer to the
		/// selectable fields from the {@link Campaign} reference page.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<string> Fields { get; set; }
		/// <summary>
		/// Specifies how an entity (eg. adgroup, campaign, criterion, ad) should be filtered.
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// </summary>
		public List<Predicate> Predicates { get; set; }
		/// <summary>
		/// Range of dates for which you want to include data. If this value is omitted,
		/// results for all dates are returned.
		/// <p class="note"><b>Note:</b> This field is only used by the report download
		/// service. For all other services, it is ignored.</p>
		/// <span class="constraint DateRangeWithinRange">This range must be contained within the range [19700101, 20380101].</span>
		/// </summary>
		public DateRange DateRange { get; set; }
		/// <summary>
		/// The fields on which you want to sort, and the sort order. The order in the list is
		/// significant: The first element in the list indicates the primary sort order, the next
		/// specifies the secondary sort order and so on.
		/// </summary>
		public List<OrderBy> Ordering { get; set; }
		/// <summary>
		/// Pagination information.
		/// </summary>
		public Paging Paging { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Fields = null;
			Predicates = null;
			DateRange = null;
			Ordering = null;
			Paging = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "fields")
				{
					if (Fields == null) Fields = new List<string>();
					Fields.Add(xItem.Value);
				}
				else if (localName == "predicates")
				{
					if (Predicates == null) Predicates = new List<Predicate>();
					var predicatesItem = new Predicate();
					predicatesItem.ReadFrom(xItem);
					Predicates.Add(predicatesItem);
				}
				else if (localName == "dateRange")
				{
					DateRange = new DateRange();
					DateRange.ReadFrom(xItem);
				}
				else if (localName == "ordering")
				{
					if (Ordering == null) Ordering = new List<OrderBy>();
					var orderingItem = new OrderBy();
					orderingItem.ReadFrom(xItem);
					Ordering.Add(orderingItem);
				}
				else if (localName == "paging")
				{
					Paging = new Paging();
					Paging.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Fields != null)
			{
				foreach (var fieldsItem in Fields)
				{
					xItem = new XElement(XName.Get("fields", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(fieldsItem);
					xE.Add(xItem);
				}
			}
			if (Predicates != null)
			{
				foreach (var predicatesItem in Predicates)
				{
					xItem = new XElement(XName.Get("predicates", "https://adwords.google.com/api/adwords/cm/v201609"));
					predicatesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (DateRange != null)
			{
				xItem = new XElement(XName.Get("dateRange", "https://adwords.google.com/api/adwords/cm/v201609"));
				DateRange.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Ordering != null)
			{
				foreach (var orderingItem in Ordering)
				{
					xItem = new XElement(XName.Get("ordering", "https://adwords.google.com/api/adwords/cm/v201609"));
					orderingItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (Paging != null)
			{
				xItem = new XElement(XName.Get("paging", "https://adwords.google.com/api/adwords/cm/v201609"));
				Paging.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
