using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// {@link Attribute} type that contains a list of {@link MonthlySearchVolume}
	/// values. The list contains the past 12 {@link MonthlySearchVolume}s
	/// (excluding the current month). The first item is the data for the most
	/// recent month and the last item is the data for the oldest month.
	/// </summary>
	public class MonthlySearchVolumeAttribute : Attribute, ISoapable
	{
		/// <summary>
		/// List of {@link MonthlySearchVolume} values contained by this
		/// {@link Attribute}. The list contains the data for the past 12 months
		/// (excluding the current month) in sorted order started with the most recent
		/// month.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<MonthlySearchVolume> Value { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					if (Value == null) Value = new List<MonthlySearchVolume>();
					var valueItem = new MonthlySearchVolume();
					valueItem.ReadFrom(xItem);
					Value.Add(valueItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "MonthlySearchVolumeAttribute");
			XElement xItem = null;
			if (Value != null)
			{
				foreach (var valueItem in Value)
				{
					xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/o/v201609"));
					valueItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
