using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a collection of settings related to ads geotargeting.
	///
	/// <p>AdWords ads can be geotargeted using <b>Location of Presence</b> (<b>LOP</b>),
	/// <b>Area of Interest</b> (<b>AOI</b>), or both. LOP is the physical location
	/// of the user performing the search; AOI is the geographical region
	/// in which the searcher is interested. For example, if a user in
	/// New York City performs a search "hotels california", their LOP
	/// is New York City and their AOI is California.
	///
	/// <p>Additionally, ads can be <b>positively</b> or <b>negatively</b> geotargeted.
	/// An ad that is positively geotargeted to New York City only appears
	/// to users whose location is related (via AOI or LOP) to New York City. An ad
	/// that is negatively geotargeted to New York City appears for <i>all</i>
	/// users <i>except</i> those whose location is related to New York City. Ads can
	/// only be negatively geotargeted if a positive geotargeting is also supplied, and
	/// the negatively geotargeted region must be contained within the positive
	/// region.
	///
	/// <p>Geotargeting settings allow ads to be targeted in the following way:
	/// <ul>
	/// <li> Positively geotargeted using solely AOI, solely LOP, or either.
	/// <li> Negatively geotargeted using solely LOP, or both.
	/// </ul>
	///
	/// <p>This setting applies only to ads shown on the search network, and does
	/// not affect ads shown on the Google Display Network.
	/// </summary>
	public class GeoTargetTypeSetting : Setting, ISoapable
	{
		/// <summary>
		/// The setting used for positive geotargeting in this particular campaign.
		///
		/// <p>Again, the campaign can be positively targeted using solely LOP, solely
		/// AOI, or either. Positive targeting triggers ads <i>only</i> for users
		/// whose location is related to the given locations.
		///
		/// <p>The default value is DONT_CARE.
		/// </summary>
		public GeoTargetTypeSettingPositiveGeoTargetType? PositiveGeoTargetType { get; set; }
		/// <summary>
		/// The setting used for negative geotargeting in this particular campaign.
		///
		/// <p>Again, the campaign can be negatively targeted using solely LOP or
		/// both AOI and LOP. Negative targeting triggers ads for <i>all</i> users
		/// <i>except</i> those whose location is related to the given locations.
		///
		/// <p>The default value is DONT_CARE.
		/// </summary>
		public GeoTargetTypeSettingNegativeGeoTargetType? NegativeGeoTargetType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			PositiveGeoTargetType = null;
			NegativeGeoTargetType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "positiveGeoTargetType")
				{
					PositiveGeoTargetType = GeoTargetTypeSettingPositiveGeoTargetTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "negativeGeoTargetType")
				{
					NegativeGeoTargetType = GeoTargetTypeSettingNegativeGeoTargetTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "GeoTargetTypeSetting");
			XElement xItem = null;
			if (PositiveGeoTargetType != null)
			{
				xItem = new XElement(XName.Get("positiveGeoTargetType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PositiveGeoTargetType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (NegativeGeoTargetType != null)
			{
				xItem = new XElement(XName.Get("negativeGeoTargetType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(NegativeGeoTargetType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
