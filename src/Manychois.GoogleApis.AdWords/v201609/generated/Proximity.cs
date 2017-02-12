using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a Proximity Criterion.
	///
	/// A proximity is an area within a certain radius of a point with the center point being described
	/// by a lat/long pair. The caller may also alternatively provide address fields which will be
	/// geocoded into a lat/long pair. Note: If a geoPoint value is provided, the address is not
	/// used for calculating the lat/long to target.
	/// <p> A criterion of this type is only targetable.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class Proximity : Criterion, ISoapable
	{
		/// <summary>
		/// Latitude and longitude.
		/// <span class="constraint Selectable">This field can be selected using the value "GeoPoint".</span>
		/// </summary>
		public GeoPoint GeoPoint { get; set; }
		/// <summary>
		/// Radius distance units.
		/// <span class="constraint Selectable">This field can be selected using the value "RadiusDistanceUnits".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public ProximityDistanceUnits? RadiusDistanceUnits { get; set; }
		/// <summary>
		/// Radius expressed in distance units.
		/// <span class="constraint Selectable">This field can be selected using the value "RadiusInUnits".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public double? RadiusInUnits { get; set; }
		/// <summary>
		/// Full address; <code>null</code> if unknonwn.
		/// <span class="constraint Selectable">This field can be selected using the value "Address".</span>
		/// </summary>
		public Address Address { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			GeoPoint = null;
			RadiusDistanceUnits = null;
			RadiusInUnits = null;
			Address = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "geoPoint")
				{
					GeoPoint = new GeoPoint();
					GeoPoint.ReadFrom(xItem);
				}
				else if (localName == "radiusDistanceUnits")
				{
					RadiusDistanceUnits = ProximityDistanceUnitsExtensions.Parse(xItem.Value);
				}
				else if (localName == "radiusInUnits")
				{
					RadiusInUnits = double.Parse(xItem.Value);
				}
				else if (localName == "address")
				{
					Address = new Address();
					Address.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Proximity");
			XElement xItem = null;
			if (GeoPoint != null)
			{
				xItem = new XElement(XName.Get("geoPoint", "https://adwords.google.com/api/adwords/cm/v201609"));
				GeoPoint.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (RadiusDistanceUnits != null)
			{
				xItem = new XElement(XName.Get("radiusDistanceUnits", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(RadiusDistanceUnits.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (RadiusInUnits != null)
			{
				xItem = new XElement(XName.Get("radiusInUnits", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(RadiusInUnits.Value.ToString());
				xE.Add(xItem);
			}
			if (Address != null)
			{
				xItem = new XElement(XName.Get("address", "https://adwords.google.com/api/adwords/cm/v201609"));
				Address.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
