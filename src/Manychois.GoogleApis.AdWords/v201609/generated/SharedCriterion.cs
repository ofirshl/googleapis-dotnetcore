using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a criterion belonging to a shared set.
	/// </summary>
	public class SharedCriterion : ISoapable
	{
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "SharedSetId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? SharedSetId { get; set; }
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Criterion Criterion { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "Negative".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public bool? Negative { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			SharedSetId = null;
			Criterion = null;
			Negative = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "sharedSetId")
				{
					SharedSetId = long.Parse(xItem.Value);
				}
				else if (localName == "criterion")
				{
					Criterion = new Criterion();
					Criterion.ReadFrom(xItem);
				}
				else if (localName == "negative")
				{
					Negative = bool.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (SharedSetId != null)
			{
				xItem = new XElement(XName.Get("sharedSetId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SharedSetId.Value.ToString());
				xE.Add(xItem);
			}
			if (Criterion != null)
			{
				xItem = new XElement(XName.Get("criterion", "https://adwords.google.com/api/adwords/cm/v201609"));
				Criterion.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Negative != null)
			{
				xItem = new XElement(XName.Get("negative", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Negative.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
