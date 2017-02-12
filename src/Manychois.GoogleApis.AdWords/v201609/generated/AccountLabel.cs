using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A label that can be attached to accounts.
	/// A manager may attach labels to accounts that s/he manages
	/// (either directly or indirectly).
	///
	/// <p>Note that these are not interchangeable with campaign management labels, and are owned
	/// by manager customers.
	/// </summary>
	public class AccountLabel : ISoapable
	{
		/// <summary>
		/// ID of the label.
		/// <p>This field is selectable/filterable in AccountLabelService.  To select labels or filter by
		/// label ID in {@link ManagedCustomerService#get}, use the {@code AccountLabels} field instead.
		/// <span class="constraint Selectable">This field can be selected using the value "LabelId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET, REMOVE.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// Name of the label.
		/// <p>This field is selectable in AccountLabelService. To select labels in
		/// {@link ManagedCustomerService#get}, use the {@code AccountLabels} field instead.
		/// <span class="constraint Selectable">This field can be selected using the value "LabelName".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string Name { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			Name = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
		}
	}
}
