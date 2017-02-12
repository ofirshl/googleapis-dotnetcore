using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// {@link Attribute} type that contains a {@link Range} of {@link LongValue}
	/// values.
	/// </summary>
	public class LongRangeAttribute : Attribute, ISoapable
	{
		/// <summary>
		/// {@link Range} of {@link LongValue} values contained by this
		/// {@link Attribute}.
		/// </summary>
		public Range Value { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					Value = new Range();
					Value.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "LongRangeAttribute");
			XElement xItem = null;
			if (Value != null)
			{
				xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/o/v201609"));
				Value.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
