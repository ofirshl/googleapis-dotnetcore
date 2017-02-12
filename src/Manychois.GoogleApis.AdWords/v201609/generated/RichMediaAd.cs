using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Data associated with a rich media ad.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public abstract class RichMediaAd : Ad, ISoapable
	{
		/// <summary>
		/// Name of the rich media ad.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint Selectable">This field can be selected using the value "RichMediaAdName".</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Dimensions (height and width) of the ad.
		///
		/// This field is optional for ThirdPartyRedirectAd.  Ad Exchange traditional
		/// yield management creatives do not specify the dimension on the
		/// ThirdPartyRedirectAd; instead, the size is specified in the publisher
		/// front end when creating a mediation chain.
		/// </summary>
		public Dimensions Dimensions { get; set; }
		/// <summary>
		/// Snippet for this ad. Required for standard third-party ads.
		/// <p>The length of the string should be between 1 and 3072, inclusive.
		/// <span class="constraint Selectable">This field can be selected using the value "RichMediaAdSnippet".</span>
		/// </summary>
		public string Snippet { get; set; }
		/// <summary>
		/// Impression beacon URL for the ad.
		/// <span class="constraint Selectable">This field can be selected using the value "RichMediaAdImpressionBeaconUrl".</span>
		/// </summary>
		public string ImpressionBeaconUrl { get; set; }
		/// <summary>
		/// Duration for the ad (in milliseconds). Default is 0.
		/// <span class="constraint Selectable">This field can be selected using the value "RichMediaAdDuration".</span>
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public int? AdDuration { get; set; }
		/// <summary>
		/// <a href="/adwords/api/docs/appendix/richmediacodes">
		/// Certified Vendor Format ID</a>.
		/// <span class="constraint Selectable">This field can be selected using the value "RichMediaAdCertifiedVendorFormatId".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? CertifiedVendorFormatId { get; set; }
		/// <summary>
		/// SourceUrl pointing to the third party snippet.
		/// For third party in-stream video ads, this stores the VAST URL. For DFA ads,
		/// it stores the InRed URL.
		/// <span class="constraint Selectable">This field can be selected using the value "RichMediaAdSourceUrl".</span>
		/// </summary>
		public string SourceUrl { get; set; }
		/// <summary>
		/// Type of this rich media ad, the default is Standard.
		/// <span class="constraint Selectable">This field can be selected using the value "RichMediaAdType".</span>
		/// </summary>
		public RichMediaAdRichMediaAdType? RichMediaAdType { get; set; }
		/// <summary>
		/// A list of attributes that describe the rich media ad capabilities.
		/// </summary>
		public List<RichMediaAdAdAttribute> AdAttributes { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Name = null;
			Dimensions = null;
			Snippet = null;
			ImpressionBeaconUrl = null;
			AdDuration = null;
			CertifiedVendorFormatId = null;
			SourceUrl = null;
			RichMediaAdType = null;
			AdAttributes = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "dimensions")
				{
					Dimensions = new Dimensions();
					Dimensions.ReadFrom(xItem);
				}
				else if (localName == "snippet")
				{
					Snippet = xItem.Value;
				}
				else if (localName == "impressionBeaconUrl")
				{
					ImpressionBeaconUrl = xItem.Value;
				}
				else if (localName == "adDuration")
				{
					AdDuration = int.Parse(xItem.Value);
				}
				else if (localName == "certifiedVendorFormatId")
				{
					CertifiedVendorFormatId = long.Parse(xItem.Value);
				}
				else if (localName == "sourceUrl")
				{
					SourceUrl = xItem.Value;
				}
				else if (localName == "richMediaAdType")
				{
					RichMediaAdType = RichMediaAdRichMediaAdTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "adAttributes")
				{
					if (AdAttributes == null) AdAttributes = new List<RichMediaAdAdAttribute>();
					AdAttributes.Add(RichMediaAdAdAttributeExtensions.Parse(xItem.Value));
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "RichMediaAd");
			XElement xItem = null;
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (Dimensions != null)
			{
				xItem = new XElement(XName.Get("dimensions", "https://adwords.google.com/api/adwords/cm/v201609"));
				Dimensions.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Snippet != null)
			{
				xItem = new XElement(XName.Get("snippet", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Snippet);
				xE.Add(xItem);
			}
			if (ImpressionBeaconUrl != null)
			{
				xItem = new XElement(XName.Get("impressionBeaconUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ImpressionBeaconUrl);
				xE.Add(xItem);
			}
			if (AdDuration != null)
			{
				xItem = new XElement(XName.Get("adDuration", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdDuration.Value.ToString());
				xE.Add(xItem);
			}
			if (CertifiedVendorFormatId != null)
			{
				xItem = new XElement(XName.Get("certifiedVendorFormatId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CertifiedVendorFormatId.Value.ToString());
				xE.Add(xItem);
			}
			if (SourceUrl != null)
			{
				xItem = new XElement(XName.Get("sourceUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SourceUrl);
				xE.Add(xItem);
			}
			if (RichMediaAdType != null)
			{
				xItem = new XElement(XName.Get("richMediaAdType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(RichMediaAdType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (AdAttributes != null)
			{
				foreach (var adAttributesItem in AdAttributes)
				{
					xItem = new XElement(XName.Get("adAttributes", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(adAttributesItem.ToXmlValue());
					xE.Add(xItem);
				}
			}
		}
	}
}
