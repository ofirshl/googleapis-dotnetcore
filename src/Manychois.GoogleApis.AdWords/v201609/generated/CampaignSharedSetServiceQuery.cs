﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns the list of CampaignSharedSets that match the query.
	///
	/// @param query The SQL-like AWQL query string
	/// @returns A list of CampaignSharedSets
	/// @throws ApiException when the query is invalid or there are errors processing the request.
	/// </summary>
	internal class CampaignSharedSetServiceQuery : ISoapable
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
