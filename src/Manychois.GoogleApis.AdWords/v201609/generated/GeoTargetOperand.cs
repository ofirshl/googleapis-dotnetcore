using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an operand containing geo information, specifying the scope of the
	/// geographical area. Currently, geo targets are restricted to a single
	/// criterion id per operand.
	/// </summary>
	public class GeoTargetOperand : FunctionArgumentOperand, ISoapable
	{
		/// <summary>
		/// CriterionId of locations deciding the geographical scope.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// </summary>
		public List<long> Locations { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Locations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "locations")
				{
					if (Locations == null) Locations = new List<long>();
					Locations.Add(long.Parse(xItem.Value));
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "GeoTargetOperand");
			XElement xItem = null;
			if (Locations != null)
			{
				foreach (var locationsItem in Locations)
				{
					xItem = new XElement(XName.Get("locations", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(locationsItem.ToString());
					xE.Add(xItem);
				}
			}
		}
	}
}
