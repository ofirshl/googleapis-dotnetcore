using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// {@link Attribute} type that contains a Set of integer values.
	/// </summary>
	public class IntegerSetAttribute : Attribute, ISoapable
	{
		/// <summary>
		/// Set of integer values contained by this {@link Attribute}.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<int> Value { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					if (Value == null) Value = new List<int>();
					Value.Add(int.Parse(xItem.Value));
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "IntegerSetAttribute");
			XElement xItem = null;
			if (Value != null)
			{
				foreach (var valueItem in Value)
				{
					xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/o/v201609"));
					xItem.Add(valueItem.ToString());
					xE.Add(xItem);
				}
			}
		}
	}
}
