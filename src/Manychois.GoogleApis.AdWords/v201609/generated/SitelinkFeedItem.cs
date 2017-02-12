using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a sitelink extension.
	/// </summary>
	public class SitelinkFeedItem : ExtensionFeedItem, ISoapable
	{
		/// <summary>
		/// URL display text for the sitelink.
		/// <span class="constraint StringLength">The length of this string should be between 1 and 25, inclusive, (trimmed).</span>
		/// </summary>
		public string SitelinkText { get; set; }
		/// <summary>
		/// Destination URL for the sitelink.
		/// <span class="constraint StringLength">The length of this string should be between 0 and 2076, inclusive, (trimmed).</span>
		/// </summary>
		public string SitelinkUrl { get; set; }
		/// <summary>
		/// First line of the description for the sitelink. To clear this field, set its value to the empty
		/// string. If this value is set, sitelinkLine3 must also be set.
		/// <span class="constraint StringLength">The length of this string should be between 0 and 35, inclusive, (trimmed).</span>
		/// </summary>
		public string SitelinkLine2 { get; set; }
		/// <summary>
		/// Second line of the description for the sitelink. To clear this field, set its value to the
		/// empty string. If this value is set, sitelinkLine2 must also be set.
		/// <span class="constraint StringLength">The length of this string should be between 0 and 35, inclusive, (trimmed).</span>
		/// </summary>
		public string SitelinkLine3 { get; set; }
		/// <summary>
		/// A list of possible final URLs after all cross domain redirects.
		/// </summary>
		public UrlList SitelinkFinalUrls { get; set; }
		/// <summary>
		/// A list of possible final mobile URLs after all cross domain redirects.
		/// </summary>
		public UrlList SitelinkFinalMobileUrls { get; set; }
		/// <summary>
		/// URL template for constructing a tracking URL. To clear this field, set its value to the empty
		/// string.
		/// </summary>
		public string SitelinkTrackingUrlTemplate { get; set; }
		/// <summary>
		/// A list of mappings to be used for substituting URL custom parameter tags in the
		/// trackingUrlTemplate, finalUrls, and/or finalMobileUrls.
		/// </summary>
		public CustomParameters SitelinkUrlCustomParameters { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			SitelinkText = null;
			SitelinkUrl = null;
			SitelinkLine2 = null;
			SitelinkLine3 = null;
			SitelinkFinalUrls = null;
			SitelinkFinalMobileUrls = null;
			SitelinkTrackingUrlTemplate = null;
			SitelinkUrlCustomParameters = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "sitelinkText")
				{
					SitelinkText = xItem.Value;
				}
				else if (localName == "sitelinkUrl")
				{
					SitelinkUrl = xItem.Value;
				}
				else if (localName == "sitelinkLine2")
				{
					SitelinkLine2 = xItem.Value;
				}
				else if (localName == "sitelinkLine3")
				{
					SitelinkLine3 = xItem.Value;
				}
				else if (localName == "sitelinkFinalUrls")
				{
					SitelinkFinalUrls = new UrlList();
					SitelinkFinalUrls.ReadFrom(xItem);
				}
				else if (localName == "sitelinkFinalMobileUrls")
				{
					SitelinkFinalMobileUrls = new UrlList();
					SitelinkFinalMobileUrls.ReadFrom(xItem);
				}
				else if (localName == "sitelinkTrackingUrlTemplate")
				{
					SitelinkTrackingUrlTemplate = xItem.Value;
				}
				else if (localName == "sitelinkUrlCustomParameters")
				{
					SitelinkUrlCustomParameters = new CustomParameters();
					SitelinkUrlCustomParameters.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "SitelinkFeedItem");
			XElement xItem = null;
			if (SitelinkText != null)
			{
				xItem = new XElement(XName.Get("sitelinkText", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SitelinkText);
				xE.Add(xItem);
			}
			if (SitelinkUrl != null)
			{
				xItem = new XElement(XName.Get("sitelinkUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SitelinkUrl);
				xE.Add(xItem);
			}
			if (SitelinkLine2 != null)
			{
				xItem = new XElement(XName.Get("sitelinkLine2", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SitelinkLine2);
				xE.Add(xItem);
			}
			if (SitelinkLine3 != null)
			{
				xItem = new XElement(XName.Get("sitelinkLine3", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SitelinkLine3);
				xE.Add(xItem);
			}
			if (SitelinkFinalUrls != null)
			{
				xItem = new XElement(XName.Get("sitelinkFinalUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
				SitelinkFinalUrls.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (SitelinkFinalMobileUrls != null)
			{
				xItem = new XElement(XName.Get("sitelinkFinalMobileUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
				SitelinkFinalMobileUrls.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (SitelinkTrackingUrlTemplate != null)
			{
				xItem = new XElement(XName.Get("sitelinkTrackingUrlTemplate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SitelinkTrackingUrlTemplate);
				xE.Add(xItem);
			}
			if (SitelinkUrlCustomParameters != null)
			{
				xItem = new XElement(XName.Get("sitelinkUrlCustomParameters", "https://adwords.google.com/api/adwords/cm/v201609"));
				SitelinkUrlCustomParameters.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
