using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// This operand specifies information required for location extension targeting.
	/// </summary>
	public class LocationExtensionOperand : FunctionArgumentOperand, ISoapable
	{
		/// <summary>
		/// Distance in units specifying the radius around targeted locations.
		/// Only long and double are supported constant types.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public ConstantOperand Radius { get; set; }
		/// <summary>
		/// Used to filter locations present in the location feed by location criterion id.
		/// </summary>
		public long? LocationId { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Radius = null;
			LocationId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "radius")
				{
					Radius = new ConstantOperand();
					Radius.ReadFrom(xItem);
				}
				else if (localName == "locationId")
				{
					LocationId = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "LocationExtensionOperand");
			XElement xItem = null;
			if (Radius != null)
			{
				xItem = new XElement(XName.Get("radius", "https://adwords.google.com/api/adwords/cm/v201609"));
				Radius.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (LocationId != null)
			{
				xItem = new XElement(XName.Get("locationId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LocationId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
