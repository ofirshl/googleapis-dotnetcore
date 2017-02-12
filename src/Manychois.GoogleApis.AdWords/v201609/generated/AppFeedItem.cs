using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an App extension.
	/// </summary>
	public class AppFeedItem : ExtensionFeedItem, ISoapable
	{
		/// <summary>
		/// The application store that the target application belongs to.
		/// </summary>
		public AppFeedItemAppStore? AppStore { get; set; }
		/// <summary>
		/// The store-specific ID for the target application.
		/// <span class="constraint StringLength">This string must not be empty, (trimmed).</span>
		/// </summary>
		public string AppId { get; set; }
		/// <summary>
		/// The visible text displayed when the link is rendered in an ad.
		/// <span class="constraint StringLength">The length of this string should be between 1 and 25, inclusive, (trimmed).</span>
		/// </summary>
		public string AppLinkText { get; set; }
		/// <summary>
		/// The destination URL of the in-app link.
		/// <span class="constraint StringLength">The length of this string should be between 0 and 2076, inclusive, (trimmed).</span>
		/// </summary>
		public string AppUrl { get; set; }
		/// <summary>
		/// A list of possible final URLs after all cross domain redirects.
		/// </summary>
		public UrlList AppFinalUrls { get; set; }
		/// <summary>
		/// A list of possible final mobile URLs after all cross domain redirects.
		/// </summary>
		public UrlList AppFinalMobileUrls { get; set; }
		/// <summary>
		/// URL template for constructing a tracking URL. To clear this field, set its value to the empty
		/// string.
		/// </summary>
		public string AppTrackingUrlTemplate { get; set; }
		/// <summary>
		/// A list of mappings to be used for substituting URL custom parameter tags in the
		/// trackingUrlTemplate, finalUrls, and/or finalMobileUrls.
		/// </summary>
		public CustomParameters AppUrlCustomParameters { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			AppStore = null;
			AppId = null;
			AppLinkText = null;
			AppUrl = null;
			AppFinalUrls = null;
			AppFinalMobileUrls = null;
			AppTrackingUrlTemplate = null;
			AppUrlCustomParameters = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "appStore")
				{
					AppStore = AppFeedItemAppStoreExtensions.Parse(xItem.Value);
				}
				else if (localName == "appId")
				{
					AppId = xItem.Value;
				}
				else if (localName == "appLinkText")
				{
					AppLinkText = xItem.Value;
				}
				else if (localName == "appUrl")
				{
					AppUrl = xItem.Value;
				}
				else if (localName == "appFinalUrls")
				{
					AppFinalUrls = new UrlList();
					AppFinalUrls.ReadFrom(xItem);
				}
				else if (localName == "appFinalMobileUrls")
				{
					AppFinalMobileUrls = new UrlList();
					AppFinalMobileUrls.ReadFrom(xItem);
				}
				else if (localName == "appTrackingUrlTemplate")
				{
					AppTrackingUrlTemplate = xItem.Value;
				}
				else if (localName == "appUrlCustomParameters")
				{
					AppUrlCustomParameters = new CustomParameters();
					AppUrlCustomParameters.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AppFeedItem");
			XElement xItem = null;
			if (AppStore != null)
			{
				xItem = new XElement(XName.Get("appStore", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AppStore.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (AppId != null)
			{
				xItem = new XElement(XName.Get("appId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AppId);
				xE.Add(xItem);
			}
			if (AppLinkText != null)
			{
				xItem = new XElement(XName.Get("appLinkText", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AppLinkText);
				xE.Add(xItem);
			}
			if (AppUrl != null)
			{
				xItem = new XElement(XName.Get("appUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AppUrl);
				xE.Add(xItem);
			}
			if (AppFinalUrls != null)
			{
				xItem = new XElement(XName.Get("appFinalUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
				AppFinalUrls.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (AppFinalMobileUrls != null)
			{
				xItem = new XElement(XName.Get("appFinalMobileUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
				AppFinalMobileUrls.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (AppTrackingUrlTemplate != null)
			{
				xItem = new XElement(XName.Get("appTrackingUrlTemplate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AppTrackingUrlTemplate);
				xE.Add(xItem);
			}
			if (AppUrlCustomParameters != null)
			{
				xItem = new XElement(XName.Get("appUrlCustomParameters", "https://adwords.google.com/api/adwords/cm/v201609"));
				AppUrlCustomParameters.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
