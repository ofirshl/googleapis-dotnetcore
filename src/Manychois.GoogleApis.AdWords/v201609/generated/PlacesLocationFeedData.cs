using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Data used to configure a location feed populated from
	/// Google My Business Locations.
	/// </summary>
	public class PlacesLocationFeedData : SystemFeedGenerationData, ISoapable
	{
		/// <summary>
		/// Required authentication token (from OAuth API) for the email.</br>
		/// Use the following values when populating the oAuthInfo:
		/// <ul>
		/// <li>httpMethod: {@code GET}</li>
		/// <li>httpRequestUrl: {@code https://www.googleapis.com/auth/adwords}</li>
		/// <li>
		/// httpAuthorizationHeader: {@code Bearer *ACCESS_TOKEN*}
		/// (where *ACCESS_TOKEN* is generated from OAuth credentials for the
		/// emailAddress and a scope matching httpRequestUrl)
		/// </li>
		/// </ul>
		/// </summary>
		public OAuthInfo OAuthInfo { get; set; }
		/// <summary>
		/// Email address of a Google My Business account or email address of a manager of the
		/// Google My Business account.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string EmailAddress { get; set; }
		/// <summary>
		/// Plus page ID of the managed business whose locations should be used. If this field is not set,
		/// then all businesses accessible by the user (specified by the emailAddress) are used.
		/// </summary>
		public string BusinessAccountIdentifier { get; set; }
		/// <summary>
		/// Used to filter Google My Business listings by business name. If businessNameFilter is set,
		/// only listings with a matching business name are candidates to be sync'd into FeedItems.
		/// </summary>
		public string BusinessNameFilter { get; set; }
		/// <summary>
		/// Used to filter Google My Business listings by categories. If entries exist in categoryFilters,
		/// only listings that belong to any of the categories are candidates to be sync'd into FeedItems.
		/// If no entries exist in categoryFilters, then all listings are candidates for syncing.
		/// </summary>
		public List<string> CategoryFilters { get; set; }
		/// <summary>
		/// Used to filter <a href="http://www.google.com/mybusiness">Google My Business</a> listings by
		/// labels. If entries exist in labelFilters, only listings that has any of the labels set are
		/// candidates to be synchronized into FeedItems. If no entries exist in labelFilters, then all
		/// listings are candidates for syncing.
		/// </summary>
		public List<string> LabelFilters { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			OAuthInfo = null;
			EmailAddress = null;
			BusinessAccountIdentifier = null;
			BusinessNameFilter = null;
			CategoryFilters = null;
			LabelFilters = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "oAuthInfo")
				{
					OAuthInfo = new OAuthInfo();
					OAuthInfo.ReadFrom(xItem);
				}
				else if (localName == "emailAddress")
				{
					EmailAddress = xItem.Value;
				}
				else if (localName == "businessAccountIdentifier")
				{
					BusinessAccountIdentifier = xItem.Value;
				}
				else if (localName == "businessNameFilter")
				{
					BusinessNameFilter = xItem.Value;
				}
				else if (localName == "categoryFilters")
				{
					if (CategoryFilters == null) CategoryFilters = new List<string>();
					CategoryFilters.Add(xItem.Value);
				}
				else if (localName == "labelFilters")
				{
					if (LabelFilters == null) LabelFilters = new List<string>();
					LabelFilters.Add(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "PlacesLocationFeedData");
			XElement xItem = null;
			if (OAuthInfo != null)
			{
				xItem = new XElement(XName.Get("oAuthInfo", "https://adwords.google.com/api/adwords/cm/v201609"));
				OAuthInfo.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (EmailAddress != null)
			{
				xItem = new XElement(XName.Get("emailAddress", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EmailAddress);
				xE.Add(xItem);
			}
			if (BusinessAccountIdentifier != null)
			{
				xItem = new XElement(XName.Get("businessAccountIdentifier", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BusinessAccountIdentifier);
				xE.Add(xItem);
			}
			if (BusinessNameFilter != null)
			{
				xItem = new XElement(XName.Get("businessNameFilter", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BusinessNameFilter);
				xE.Add(xItem);
			}
			if (CategoryFilters != null)
			{
				foreach (var categoryFiltersItem in CategoryFilters)
				{
					xItem = new XElement(XName.Get("categoryFilters", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(categoryFiltersItem);
					xE.Add(xItem);
				}
			}
			if (LabelFilters != null)
			{
				foreach (var labelFiltersItem in LabelFilters)
				{
					xItem = new XElement(XName.Get("labelFilters", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(labelFiltersItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
