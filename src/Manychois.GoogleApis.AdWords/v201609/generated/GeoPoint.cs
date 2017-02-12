using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Specifies a geo location with the supplied latitude/longitude.
	/// </summary>
	public class GeoPoint : ISoapable
	{
		/// <summary>
		/// Micro degrees for the latitude.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public int? LatitudeInMicroDegrees { get; set; }
		/// <summary>
		/// Micro degrees for the longitude.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public int? LongitudeInMicroDegrees { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			LatitudeInMicroDegrees = null;
			LongitudeInMicroDegrees = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "latitudeInMicroDegrees")
				{
					LatitudeInMicroDegrees = int.Parse(xItem.Value);
				}
				else if (localName == "longitudeInMicroDegrees")
				{
					LongitudeInMicroDegrees = int.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (LatitudeInMicroDegrees != null)
			{
				xItem = new XElement(XName.Get("latitudeInMicroDegrees", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LatitudeInMicroDegrees.Value.ToString());
				xE.Add(xItem);
			}
			if (LongitudeInMicroDegrees != null)
			{
				xItem = new XElement(XName.Get("longitudeInMicroDegrees", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LongitudeInMicroDegrees.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
