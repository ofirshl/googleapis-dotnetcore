using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a money amount.
	/// </summary>
	public class Money : ComparableValue, ISoapable
	{
		/// <summary>
		/// Amount in micros. One million is equivalent to one unit.
		/// </summary>
		public long? MicroAmount { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			MicroAmount = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "microAmount")
				{
					MicroAmount = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Money");
			XElement xItem = null;
			if (MicroAmount != null)
			{
				xItem = new XElement(XName.Get("microAmount", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(MicroAmount.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
