using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A descriptor for finding {@link TargetingIdea}s that match the specified criteria.
	/// </summary>
	public class TargetingIdeaSelector : ISoapable
	{
		/// <summary>
		/// Search for targeting ideas based on these search rules.
		///
		/// <p>An empty set indicates this selector is valid for selecting metadata
		/// with default parameters.
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint DistinctTypes">Elements in this field must have distinct types.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<SearchParameter> SearchParameters { get; set; }
		/// <summary>
		/// Limits the request to responses of this {@link IdeaType}, e.g. {@code KEYWORDS}.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public IdeaType? IdeaType { get; set; }
		/// <summary>
		/// Specifies the {@link RequestType}, e.g. {@code IDEAS} or {@code STATS}.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public RequestType? RequestType { get; set; }
		/// <summary>
		/// Request {@link Attribute}s and associated data for this set of {@link Type}s.
		///
		/// <p>An empty set indicates a request for {@link KeywordAttribute}, {@link PlacementAttribute},
		/// and {@link IdeaType}.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// </summary>
		public List<AttributeType> RequestedAttributeTypes { get; set; }
		/// <summary>
		/// A {@link Paging} object that specifies the desired starting index and
		/// number of results to return.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Paging Paging { get; set; }
		/// <summary>
		/// The locale code (for example "en_US") used for localizing strings,
		/// controlling numeric formatting, and the like.  See RFC 3066 for
		/// information on the format used.
		/// </summary>
		public string LocaleCode { get; set; }
		/// <summary>
		/// The currency code to be used for all monetary values returned in results in
		/// ISO format (see
		/// https://developers.google.com/adwords/api/docs/appendix/currencycodes
		/// for supported currencies). The default is "USD" (US dollars).
		/// </summary>
		public string CurrencyCode { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			SearchParameters = null;
			IdeaType = null;
			RequestType = null;
			RequestedAttributeTypes = null;
			Paging = null;
			LocaleCode = null;
			CurrencyCode = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "searchParameters")
				{
					if (SearchParameters == null) SearchParameters = new List<SearchParameter>();
					var searchParametersItem = InstanceCreator.CreateSearchParameter(xItem);
					searchParametersItem.ReadFrom(xItem);
					SearchParameters.Add(searchParametersItem);
				}
				else if (localName == "ideaType")
				{
					IdeaType = IdeaTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "requestType")
				{
					RequestType = RequestTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "requestedAttributeTypes")
				{
					if (RequestedAttributeTypes == null) RequestedAttributeTypes = new List<AttributeType>();
					RequestedAttributeTypes.Add(AttributeTypeExtensions.Parse(xItem.Value));
				}
				else if (localName == "paging")
				{
					Paging = new Paging();
					Paging.ReadFrom(xItem);
				}
				else if (localName == "localeCode")
				{
					LocaleCode = xItem.Value;
				}
				else if (localName == "currencyCode")
				{
					CurrencyCode = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (SearchParameters != null)
			{
				foreach (var searchParametersItem in SearchParameters)
				{
					xItem = new XElement(XName.Get("searchParameters", "https://adwords.google.com/api/adwords/o/v201609"));
					searchParametersItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (IdeaType != null)
			{
				xItem = new XElement(XName.Get("ideaType", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(IdeaType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (RequestType != null)
			{
				xItem = new XElement(XName.Get("requestType", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(RequestType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (RequestedAttributeTypes != null)
			{
				foreach (var requestedAttributeTypesItem in RequestedAttributeTypes)
				{
					xItem = new XElement(XName.Get("requestedAttributeTypes", "https://adwords.google.com/api/adwords/o/v201609"));
					xItem.Add(requestedAttributeTypesItem.ToXmlValue());
					xE.Add(xItem);
				}
			}
			if (Paging != null)
			{
				xItem = new XElement(XName.Get("paging", "https://adwords.google.com/api/adwords/o/v201609"));
				Paging.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (LocaleCode != null)
			{
				xItem = new XElement(XName.Get("localeCode", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(LocaleCode);
				xE.Add(xItem);
			}
			if (CurrencyCode != null)
			{
				xItem = new XElement(XName.Get("currencyCode", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(CurrencyCode);
				xE.Add(xItem);
			}
		}
	}
}
