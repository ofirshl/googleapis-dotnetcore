using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns a list of {@link AdGroupBidLandscape}s for the ad groups specified in the selector.
	/// In the result, the returned {@link LandscapePoint}s are grouped into
	/// {@link AdGroupBidLandscape}s by their ad groups, and numberResults of paging limits the total
	/// number of {@link LandscapePoint}s instead of number of {@link AdGroupBidLandscape}s.
	///
	/// @param serviceSelector Selects the entities to return bid landscapes for.
	/// @return A list of bid landscapes.
	/// @throws ApiException when there is at least one error with the request.
	/// </summary>
	internal class DataServiceGetAdGroupBidLandscape : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Selector ServiceSelector { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ServiceSelector = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "serviceSelector")
				{
					ServiceSelector = new Selector();
					ServiceSelector.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ServiceSelector != null)
			{
				xItem = new XElement(XName.Get("serviceSelector", "https://adwords.google.com/api/adwords/cm/v201609"));
				ServiceSelector.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
