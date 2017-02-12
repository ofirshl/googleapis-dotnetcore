using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a criterion (such as a keyword, placement, or vertical).
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class Criterion : ISoapable
	{
		/// <summary>
		/// ID of this criterion.
		/// <span class="constraint Selectable">This field can be selected using the value "Id".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET, REMOVE.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "CriteriaType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public CriterionType? Type { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of Criterion.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string CriterionType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			Type = null;
			CriterionType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "type")
				{
					Type = CriterionTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "Criterion.Type")
				{
					CriterionType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (Type != null)
			{
				xItem = new XElement(XName.Get("type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Type.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (CriterionType != null)
			{
				xItem = new XElement(XName.Get("Criterion.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CriterionType);
				xE.Add(xItem);
			}
		}
	}
}
