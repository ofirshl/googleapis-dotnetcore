using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Specifies how an entity (eg. adgroup, campaign, criterion, ad) should be filtered.
	/// </summary>
	public class Predicate : ISoapable
	{
		/// <summary>
		/// The field by which to filter the returned data. Possible values are marked Filterable on
		/// the entity's reference page. For example, for predicates for the
		/// CampaignService {@link Selector selector}, refer to the filterable fields from the
		/// {@link Campaign} reference page.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string Field { get; set; }
		/// <summary>
		/// The operator to use for filtering the data returned.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public PredicateOperator? Operator { get; set; }
		/// <summary>
		/// The values by which to filter the field. The {@link Operator#CONTAINS_ALL},
		/// {@link Operator#CONTAINS_ANY}, {@link Operator#CONTAINS_NONE}, {@link Operator#IN}
		/// and {@link Operator#NOT_IN} take multiple values. All others take a single value.
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<string> Values { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Field = null;
			Operator = null;
			Values = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "field")
				{
					Field = xItem.Value;
				}
				else if (localName == "operator")
				{
					Operator = PredicateOperatorExtensions.Parse(xItem.Value);
				}
				else if (localName == "values")
				{
					if (Values == null) Values = new List<string>();
					Values.Add(xItem.Value);
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
			if (Operator != null)
			{
				xItem = new XElement(XName.Get("operator", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Operator.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Values != null)
			{
				foreach (var valuesItem in Values)
				{
					xItem = new XElement(XName.Get("values", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(valuesItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
