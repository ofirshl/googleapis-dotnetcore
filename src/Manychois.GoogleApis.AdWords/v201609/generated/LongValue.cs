using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Number value type for constructing long valued ranges.
	/// </summary>
	public class LongValue : NumberValue, ISoapable
	{
		/// <summary>
		/// the underlying long value.
		/// </summary>
		public long? Number { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Number = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "number")
				{
					Number = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "LongValue");
			XElement xItem = null;
			if (Number != null)
			{
				xItem = new XElement(XName.Get("number", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Number.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
