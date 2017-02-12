using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Data associated with rich media extension attributes.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class ThirdPartyRedirectAd : RichMediaAd, ISoapable
	{
		/// <summary>
		/// Defines whether or not the ad is cookie targeted.
		/// (i.e. user list targeting, or the network's equivalent).
		/// <span class="constraint Selectable">This field can be selected using the value "IsCookieTargeted".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public bool? IsCookieTargeted { get; set; }
		/// <summary>
		/// Defines whether or not the ad is targeting user interest.
		/// <span class="constraint Selectable">This field can be selected using the value "IsUserInterestTargeted".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public bool? IsUserInterestTargeted { get; set; }
		/// <summary>
		/// Defines whether or not the ad contains a tracking pixel of any kind.
		/// <span class="constraint Selectable">This field can be selected using the value "IsTagged".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public bool? IsTagged { get; set; }
		/// <summary>
		/// Video Types of the ad. (RealMedia, Quick Time etc.)
		/// <span class="constraint Selectable">This field can be selected using the value "VideoTypes".</span>
		/// </summary>
		public List<VideoType> VideoTypes { get; set; }
		/// <summary>
		/// Allowed expanding directions. These directions are used to match
		/// publishers' ad slots. For example, if a slot allows expansion toward the
		/// right, only ads with EXPANDING_RIGHT specified will show up there.
		/// <span class="constraint Selectable">This field can be selected using the value "ExpandingDirections".</span>
		/// </summary>
		public List<ThirdPartyRedirectAdExpandingDirection> ExpandingDirections { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			IsCookieTargeted = null;
			IsUserInterestTargeted = null;
			IsTagged = null;
			VideoTypes = null;
			ExpandingDirections = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "isCookieTargeted")
				{
					IsCookieTargeted = bool.Parse(xItem.Value);
				}
				else if (localName == "isUserInterestTargeted")
				{
					IsUserInterestTargeted = bool.Parse(xItem.Value);
				}
				else if (localName == "isTagged")
				{
					IsTagged = bool.Parse(xItem.Value);
				}
				else if (localName == "videoTypes")
				{
					if (VideoTypes == null) VideoTypes = new List<VideoType>();
					VideoTypes.Add(VideoTypeExtensions.Parse(xItem.Value));
				}
				else if (localName == "expandingDirections")
				{
					if (ExpandingDirections == null) ExpandingDirections = new List<ThirdPartyRedirectAdExpandingDirection>();
					ExpandingDirections.Add(ThirdPartyRedirectAdExpandingDirectionExtensions.Parse(xItem.Value));
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ThirdPartyRedirectAd");
			XElement xItem = null;
			if (IsCookieTargeted != null)
			{
				xItem = new XElement(XName.Get("isCookieTargeted", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsCookieTargeted.Value.ToString());
				xE.Add(xItem);
			}
			if (IsUserInterestTargeted != null)
			{
				xItem = new XElement(XName.Get("isUserInterestTargeted", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsUserInterestTargeted.Value.ToString());
				xE.Add(xItem);
			}
			if (IsTagged != null)
			{
				xItem = new XElement(XName.Get("isTagged", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsTagged.Value.ToString());
				xE.Add(xItem);
			}
			if (VideoTypes != null)
			{
				foreach (var videoTypesItem in VideoTypes)
				{
					xItem = new XElement(XName.Get("videoTypes", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(videoTypesItem.ToXmlValue());
					xE.Add(xItem);
				}
			}
			if (ExpandingDirections != null)
			{
				foreach (var expandingDirectionsItem in ExpandingDirections)
				{
					xItem = new XElement(XName.Get("expandingDirections", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(expandingDirectionsItem.ToXmlValue());
					xE.Add(xItem);
				}
			}
		}
	}
}
