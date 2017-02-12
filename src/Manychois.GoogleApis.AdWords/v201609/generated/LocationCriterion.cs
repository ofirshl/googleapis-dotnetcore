using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents data that encapsulates a location criterion.
	/// </summary>
	public class LocationCriterion : ISoapable
	{
		/// <summary>
		/// Location criterion.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// Canonical name of the location criterion.
		/// <span class="constraint Selectable">This field can be selected using the value "CanonicalName".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string CanonicalName { get; set; }
		/// <summary>
		/// Approximate user population that will be targeted, rounded to the nearest 100.
		/// <span class="constraint Selectable">This field can be selected using the value "Reach".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? Reach { get; set; }
		/// <summary>
		/// Preferred locale to be used as a hint for determining the list of locations to return.
		/// This is also used for language translation. <b>Note:</b> If the specified locale filter
		/// is invalid, or not supported, en_US will be used by default.
		/// <span class="constraint Filterable">This field can be filtered on using the value "Locale".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Locale { get; set; }
		/// <summary>
		/// Original search term, as specified in the input request for search by name. <b>Note:</b>
		/// This field is useful in the case that the original search name does not match the official
		/// name of the location, for example, Florence -> Firenze.
		///
		/// <p>The number of search terms is limited to 25 per request.</p>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string SearchTerm { get; set; }
		/// <summary>
		/// This is used as a hint and suggestions are restricted to this country when applicable.
		///
		/// <p>See the <a href="/adwords/api/docs/appendix/geotargeting">list of countries</a>.</p>
		/// <span class="constraint Filterable">This field can be filtered on using the value "CountryCode".</span>
		/// </summary>
		public string CountryCode { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Location = null;
			CanonicalName = null;
			Reach = null;
			Locale = null;
			SearchTerm = null;
			CountryCode = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "location")
				{
					Location = new Location();
					Location.ReadFrom(xItem);
				}
				else if (localName == "canonicalName")
				{
					CanonicalName = xItem.Value;
				}
				else if (localName == "reach")
				{
					Reach = long.Parse(xItem.Value);
				}
				else if (localName == "locale")
				{
					Locale = xItem.Value;
				}
				else if (localName == "searchTerm")
				{
					SearchTerm = xItem.Value;
				}
				else if (localName == "countryCode")
				{
					CountryCode = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Location != null)
			{
				xItem = new XElement(XName.Get("location", "https://adwords.google.com/api/adwords/cm/v201609"));
				Location.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (CanonicalName != null)
			{
				xItem = new XElement(XName.Get("canonicalName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CanonicalName);
				xE.Add(xItem);
			}
			if (Reach != null)
			{
				xItem = new XElement(XName.Get("reach", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Reach.Value.ToString());
				xE.Add(xItem);
			}
			if (Locale != null)
			{
				xItem = new XElement(XName.Get("locale", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Locale);
				xE.Add(xItem);
			}
			if (SearchTerm != null)
			{
				xItem = new XElement(XName.Get("searchTerm", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SearchTerm);
				xE.Add(xItem);
			}
			if (CountryCode != null)
			{
				xItem = new XElement(XName.Get("countryCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CountryCode);
				xE.Add(xItem);
			}
		}
	}
}
