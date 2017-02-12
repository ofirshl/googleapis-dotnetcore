using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns a list of {@link CriterionBidLandscape}s for the campaign criteria that match the
	/// query. In the result, the returned {@link LandscapePoint}s are grouped into
	/// {@link CriterionBidLandscape}s by their campaign id and criterion id, and numberResults
	/// of paging limits the total number of {@link LandscapePoint}s instead of number of
	/// {@link CriterionBidLandscape}s.
	///
	/// @param query The SQL-like AWQL query string.
	/// @return A list of bid landscapes.
	/// @throws ApiException if problems occur while parsing the query or fetching bid landscapes.
	/// </summary>
	internal class DataServiceQueryCampaignCriterionBidLandscape : ISoapable
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
