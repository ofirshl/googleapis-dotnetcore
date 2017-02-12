using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns the list of AdGroupFeeds that match the query.
	///
	/// @param query The SQL-like AWQL query string.
	/// @returns A list of AdGroupFeed.
	/// @throws ApiException if problems occur while parsing the query or fetching AdGroupFeed.
	/// </summary>
	internal class AdGroupFeedServiceQuery : ISoapable
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
