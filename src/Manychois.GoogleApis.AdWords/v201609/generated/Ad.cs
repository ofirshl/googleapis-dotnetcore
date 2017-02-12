using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The base class of all ad types. {@code Ad} objects themselves cannot be modified. If you want to
	/// make a change to an {@code Ad} object, you must REMOVE its AdGroupAd and ADD a new AdGroupAd with
	/// the new {@code Ad}. This will result in a new {@code Ad} ID, so stats for the original {@code Ad}
	/// and the new {@code Ad} will appear under separate IDs in reports.
	///
	/// <p>When calling {@code AdGroupAdService} to update the {@code status} of an {@code AdGroupAd},
	/// you can construct an {@code Ad} object (instead of the {@code Ad}'s concrete type) with the
	/// {@link #id} field set.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class Ad : ISoapable
	{
		/// <summary>
		/// ID of this ad. This field is ignored when creating
		/// ads using {@code AdGroupAdService}.
		/// <span class="constraint Selectable">This field can be selected using the value "Id".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// Destination URL.
		/// <p>Do not set this field if you are using upgraded URLs, as described at:
		/// https://developers.google.com/adwords/api/docs/guides/upgraded-urls
		/// <span class="constraint Selectable">This field can be selected using the value "Url".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Visible URL.
		/// <span class="constraint Selectable">This field can be selected using the value "DisplayUrl".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string DisplayUrl { get; set; }
		/// <summary>
		/// A list of possible final URLs after all cross domain redirects.
		/// <p>This field is used for upgraded urls only, as described at:
		/// https://developers.google.com/adwords/api/docs/guides/upgraded-urls
		/// <span class="constraint Selectable">This field can be selected using the value "CreativeFinalUrls".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint CollectionSize">The maximum size of this collection is 10.</span>
		/// </summary>
		public List<string> FinalUrls { get; set; }
		/// <summary>
		/// A list of possible final mobile URLs after all cross domain redirects.
		/// <p>This field is used for upgraded urls only, as described at:
		/// https://developers.google.com/adwords/api/docs/guides/upgraded-urls
		/// <span class="constraint Selectable">This field can be selected using the value "CreativeFinalMobileUrls".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint CollectionSize">The maximum size of this collection is 10.</span>
		/// </summary>
		public List<string> FinalMobileUrls { get; set; }
		/// <summary>
		/// A list of final app URLs that will be used on mobile if the user has the specific app
		/// installed.
		/// <p>This field is used for upgraded urls only, as described at:
		/// https://developers.google.com/adwords/api/docs/guides/upgraded-urls
		/// <span class="constraint Selectable">This field can be selected using the value "CreativeFinalAppUrls".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public List<AppUrl> FinalAppUrls { get; set; }
		/// <summary>
		/// URL template for constructing a tracking URL.
		/// <p>This field is used for upgraded urls only, as described at:
		/// https://developers.google.com/adwords/api/docs/guides/upgraded-urls
		/// <span class="constraint Selectable">This field can be selected using the value "CreativeTrackingUrlTemplate".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string TrackingUrlTemplate { get; set; }
		/// <summary>
		/// A list of mappings to be used for substituting URL custom parameter tags in the
		/// trackingUrlTemplate, finalUrls, and/or finalMobileUrls.
		/// <p>This field is used for upgraded urls only, as described at:
		/// https://developers.google.com/adwords/api/docs/guides/upgraded-urls
		/// <span class="constraint Selectable">This field can be selected using the value "CreativeUrlCustomParameters".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public CustomParameters UrlCustomParameters { get; set; }
		/// <summary>
		/// Type of ad.
		/// <span class="constraint Selectable">This field can be selected using the value "AdType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public AdType? Type { get; set; }
		/// <summary>
		/// The device preference for the ad. You can only specify a preference for
		/// mobile devices (CriterionId 30001). If unspecified (no device preference),
		/// all devices are targeted.
		/// <span class="constraint Selectable">This field can be selected using the value "DevicePreference".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? DevicePreference { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of Ad.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string AdType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			Url = null;
			DisplayUrl = null;
			FinalUrls = null;
			FinalMobileUrls = null;
			FinalAppUrls = null;
			TrackingUrlTemplate = null;
			UrlCustomParameters = null;
			Type = null;
			DevicePreference = null;
			AdType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "url")
				{
					Url = xItem.Value;
				}
				else if (localName == "displayUrl")
				{
					DisplayUrl = xItem.Value;
				}
				else if (localName == "finalUrls")
				{
					if (FinalUrls == null) FinalUrls = new List<string>();
					FinalUrls.Add(xItem.Value);
				}
				else if (localName == "finalMobileUrls")
				{
					if (FinalMobileUrls == null) FinalMobileUrls = new List<string>();
					FinalMobileUrls.Add(xItem.Value);
				}
				else if (localName == "finalAppUrls")
				{
					if (FinalAppUrls == null) FinalAppUrls = new List<AppUrl>();
					var finalAppUrlsItem = new AppUrl();
					finalAppUrlsItem.ReadFrom(xItem);
					FinalAppUrls.Add(finalAppUrlsItem);
				}
				else if (localName == "trackingUrlTemplate")
				{
					TrackingUrlTemplate = xItem.Value;
				}
				else if (localName == "urlCustomParameters")
				{
					UrlCustomParameters = new CustomParameters();
					UrlCustomParameters.ReadFrom(xItem);
				}
				else if (localName == "type")
				{
					Type = AdTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "devicePreference")
				{
					DevicePreference = long.Parse(xItem.Value);
				}
				else if (localName == "Ad.Type")
				{
					AdType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (Url != null)
			{
				xItem = new XElement(XName.Get("url", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Url);
				xE.Add(xItem);
			}
			if (DisplayUrl != null)
			{
				xItem = new XElement(XName.Get("displayUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DisplayUrl);
				xE.Add(xItem);
			}
			if (FinalUrls != null)
			{
				foreach (var finalUrlsItem in FinalUrls)
				{
					xItem = new XElement(XName.Get("finalUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(finalUrlsItem);
					xE.Add(xItem);
				}
			}
			if (FinalMobileUrls != null)
			{
				foreach (var finalMobileUrlsItem in FinalMobileUrls)
				{
					xItem = new XElement(XName.Get("finalMobileUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(finalMobileUrlsItem);
					xE.Add(xItem);
				}
			}
			if (FinalAppUrls != null)
			{
				foreach (var finalAppUrlsItem in FinalAppUrls)
				{
					xItem = new XElement(XName.Get("finalAppUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
					finalAppUrlsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (TrackingUrlTemplate != null)
			{
				xItem = new XElement(XName.Get("trackingUrlTemplate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TrackingUrlTemplate);
				xE.Add(xItem);
			}
			if (UrlCustomParameters != null)
			{
				xItem = new XElement(XName.Get("urlCustomParameters", "https://adwords.google.com/api/adwords/cm/v201609"));
				UrlCustomParameters.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Type != null)
			{
				xItem = new XElement(XName.Get("type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Type.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (DevicePreference != null)
			{
				xItem = new XElement(XName.Get("devicePreference", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DevicePreference.Value.ToString());
				xE.Add(xItem);
			}
			if (AdType != null)
			{
				xItem = new XElement(XName.Get("Ad.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdType);
				xE.Add(xItem);
			}
		}
	}
}
