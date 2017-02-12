using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A {@link SearchParameter} used to indicate the locations being targeted.
	/// This can be used, for example, to search for {@code KEYWORD}
	/// {@link IdeaType}s that are best for Japan and Los Angeles.
	///
	/// <p>This parameter replaces the {@code CountryTargetSearchParameter}.</p>
	///
	/// <p>See the
	/// <a href="https://developers.google.com/adwords/api/docs/appendix/geotargeting">Geographical
	/// Targeting</a> page for the complete list of supported geo target types for this service.</p>
	///
	/// <p>The service allows up to 10 locations to be targeted for KEYWORD requests and 50 locations
	/// for PLACEMENT requests.</p>
	/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
	/// <p>This element is supported by following {@link RequestType}s: IDEAS, STATS.
	/// </summary>
	public class LocationSearchParameter : SearchParameter, ISoapable
	{
		/// <summary>
		/// A list of {@link Location}s indicating the desired countries being targeted in the results.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<Location> Locations { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Locations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "locations")
				{
					if (Locations == null) Locations = new List<Location>();
					var locationsItem = new Location();
					locationsItem.ReadFrom(xItem);
					Locations.Add(locationsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "LocationSearchParameter");
			XElement xItem = null;
			if (Locations != null)
			{
				foreach (var locationsItem in Locations)
				{
					xItem = new XElement(XName.Get("locations", "https://adwords.google.com/api/adwords/o/v201609"));
					locationsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
