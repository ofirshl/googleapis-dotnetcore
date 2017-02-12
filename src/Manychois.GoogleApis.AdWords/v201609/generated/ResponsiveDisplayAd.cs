using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Enhanced display ad format.
	///
	/// <p class="caution"><b>Caution:</b> Responsive display ads do not use {@link #url url},
	/// {@link #displayUrl displayUrl}, {@link #finalAppUrls finalAppUrls}, or
	/// {@link #devicePreference devicePreference};
	/// setting these fields on a responsive display ad will cause an error.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class ResponsiveDisplayAd : Ad, ISoapable
	{
		/// <summary>
		/// Marketing image to be used in the ad.
		/// This ad format does not allow the creation of an image using the Image.data field. An image
		/// must first be created using the MediaService, and Image.mediaId must be populated when creating
		/// a {@link "ResponsiveDisplayAd"}.
		/// <span class="constraint Selectable">This field can be selected using the value "MarketingImage".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public Image MarketingImage { get; set; }
		/// <summary>
		/// Logo image to be used in the ad.
		/// This ad format does not allow the creation of an image using the Image.data field. An image
		/// must first be created using the MediaService, and Image.mediaId must be populated when creating
		/// a {@link "ResponsiveDisplayAd"}.
		/// <span class="constraint Selectable">This field can be selected using the value "LogoImage".</span>
		/// </summary>
		public Image LogoImage { get; set; }
		/// <summary>
		/// Short format of the headline of the ad.
		/// <span class="constraint Selectable">This field can be selected using the value "ShortHeadline".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string ShortHeadline { get; set; }
		/// <summary>
		/// Long format of the headline of the ad.
		/// <span class="constraint Selectable">This field can be selected using the value "LongHeadline".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string LongHeadline { get; set; }
		/// <summary>
		/// The descriptive text of the ad.
		/// <span class="constraint Selectable">This field can be selected using the value "Description".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// The business name.
		/// <span class="constraint Required">This field is required and should not be {@code null}
		/// when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint Selectable">This field can be selected using the value "BusinessName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string BusinessName { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			MarketingImage = null;
			LogoImage = null;
			ShortHeadline = null;
			LongHeadline = null;
			Description = null;
			BusinessName = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "marketingImage")
				{
					MarketingImage = new Image();
					MarketingImage.ReadFrom(xItem);
				}
				else if (localName == "logoImage")
				{
					LogoImage = new Image();
					LogoImage.ReadFrom(xItem);
				}
				else if (localName == "shortHeadline")
				{
					ShortHeadline = xItem.Value;
				}
				else if (localName == "longHeadline")
				{
					LongHeadline = xItem.Value;
				}
				else if (localName == "description")
				{
					Description = xItem.Value;
				}
				else if (localName == "businessName")
				{
					BusinessName = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ResponsiveDisplayAd");
			XElement xItem = null;
			if (MarketingImage != null)
			{
				xItem = new XElement(XName.Get("marketingImage", "https://adwords.google.com/api/adwords/cm/v201609"));
				MarketingImage.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (LogoImage != null)
			{
				xItem = new XElement(XName.Get("logoImage", "https://adwords.google.com/api/adwords/cm/v201609"));
				LogoImage.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (ShortHeadline != null)
			{
				xItem = new XElement(XName.Get("shortHeadline", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ShortHeadline);
				xE.Add(xItem);
			}
			if (LongHeadline != null)
			{
				xItem = new XElement(XName.Get("longHeadline", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LongHeadline);
				xE.Add(xItem);
			}
			if (Description != null)
			{
				xItem = new XElement(XName.Get("description", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description);
				xE.Add(xItem);
			}
			if (BusinessName != null)
			{
				xItem = new XElement(XName.Get("businessName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BusinessName);
				xE.Add(xItem);
			}
		}
	}
}
