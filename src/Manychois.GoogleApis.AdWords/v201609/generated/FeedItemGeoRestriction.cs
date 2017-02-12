using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a FeedItem geo restriction.
	/// </summary>
	public class FeedItemGeoRestriction : ISoapable
	{
		/// <summary>
		/// The geo targeting restriction of a feed item.  If null then the geo restriction is cleared.
		/// <span class="constraint Selectable">This field can be selected using the value "GeoTargetingRestriction".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public GeoRestriction? GeoRestriction { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			GeoRestriction = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "geoRestriction")
				{
					GeoRestriction = GeoRestrictionExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (GeoRestriction != null)
			{
				xItem = new XElement(XName.Get("geoRestriction", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(GeoRestriction.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
