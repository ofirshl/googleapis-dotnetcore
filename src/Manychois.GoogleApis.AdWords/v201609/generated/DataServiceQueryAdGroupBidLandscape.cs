using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns a list of {@link AdGroupBidLandscape}s for the ad groups that match the query. In the
	/// result, the returned {@link LandscapePoint}s are grouped into {@link AdGroupBidLandscape}s
	/// by their ad groups, and numberResults of paging limits the total number of
	/// {@link LandscapePoint}s instead of number of {@link AdGroupBidLandscape}s.
	///
	/// @param query The SQL-like AWQL query string.
	/// @return A list of bid landscapes.
	/// @throws ApiException if problems occur while parsing the query or fetching bid landscapes.
	/// </summary>
	internal class DataServiceQueryAdGroupBidLandscape : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string Query { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Query = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "query")
				{
					Query = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Query != null)
			{
				xItem = new XElement(XName.Get("query", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Query);
				xE.Add(xItem);
			}
		}
	}
}
