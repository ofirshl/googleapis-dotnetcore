using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A container for return values from {@link ManagedCustomerService#mutateLabel}.
	/// <p>For successful {@linkplain ADD} operations, the input {@linkplain ManagedCustomerLabel}
	/// is returned.
	/// <p>For successful {@linkplain REMOVE} operations, the returned {@linkplain ManagedCustomerLabel}
	/// will contain the customer ID and a null label ID.
	/// </summary>
	public class ManagedCustomerLabelReturnValue : ISoapable
	{
		/// <summary>
		/// List of managed customer labels.
		/// </summary>
		public List<ManagedCustomerLabel> Value { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					if (Value == null) Value = new List<ManagedCustomerLabel>();
					var valueItem = new ManagedCustomerLabel();
					valueItem.ReadFrom(xItem);
					Value.Add(valueItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Value != null)
			{
				foreach (var valueItem in Value)
				{
					xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/mcm/v201609"));
					valueItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
