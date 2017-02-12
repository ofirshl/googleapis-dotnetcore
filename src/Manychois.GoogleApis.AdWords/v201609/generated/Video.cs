using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Encapsulates a Video media identified by a MediaId.
	/// </summary>
	public class Video : Media, ISoapable
	{
		/// <summary>
		/// The duration of the associated video, in milliseconds.
		/// <span class="constraint Selectable">This field can be selected using the value "DurationMillis".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? DurationMillis { get; set; }
		/// <summary>
		/// Streaming URL for the video.
		/// <span class="constraint Selectable">This field can be selected using the value "StreamingUrl".</span>
		/// </summary>
		public string StreamingUrl { get; set; }
		/// <summary>
		/// Indicates whether the video is ready to play on the web.
		/// <span class="constraint Selectable">This field can be selected using the value "ReadyToPlayOnTheWeb".</span>
		/// </summary>
		public bool? ReadyToPlayOnTheWeb { get; set; }
		/// <summary>
		/// The Industry Standard Commercial Identifier code for this media, used
		/// mainly for television commercials.
		/// <span class="constraint Selectable">This field can be selected using the value "IndustryStandardCommercialIdentifier".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string IndustryStandardCommercialIdentifier { get; set; }
		/// <summary>
		/// The Advertising Digital Identification code for this media, as defined by
		/// the American Association of Advertising Agencies, used mainly for
		/// television commercials.
		/// <span class="constraint Selectable">This field can be selected using the value "AdvertisingId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string AdvertisingId { get; set; }
		/// <summary>
		/// For YouTube-hosted videos, the YouTube video ID (as seen in YouTube URLs)
		/// may also be filled in.
		/// <span class="constraint Selectable">This field can be selected using the value "YouTubeVideoIdString".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string YouTubeVideoIdString { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			DurationMillis = null;
			StreamingUrl = null;
			ReadyToPlayOnTheWeb = null;
			IndustryStandardCommercialIdentifier = null;
			AdvertisingId = null;
			YouTubeVideoIdString = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "durationMillis")
				{
					DurationMillis = long.Parse(xItem.Value);
				}
				else if (localName == "streamingUrl")
				{
					StreamingUrl = xItem.Value;
				}
				else if (localName == "readyToPlayOnTheWeb")
				{
					ReadyToPlayOnTheWeb = bool.Parse(xItem.Value);
				}
				else if (localName == "industryStandardCommercialIdentifier")
				{
					IndustryStandardCommercialIdentifier = xItem.Value;
				}
				else if (localName == "advertisingId")
				{
					AdvertisingId = xItem.Value;
				}
				else if (localName == "youTubeVideoIdString")
				{
					YouTubeVideoIdString = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Video");
			XElement xItem = null;
			if (DurationMillis != null)
			{
				xItem = new XElement(XName.Get("durationMillis", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DurationMillis.Value.ToString());
				xE.Add(xItem);
			}
			if (StreamingUrl != null)
			{
				xItem = new XElement(XName.Get("streamingUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StreamingUrl);
				xE.Add(xItem);
			}
			if (ReadyToPlayOnTheWeb != null)
			{
				xItem = new XElement(XName.Get("readyToPlayOnTheWeb", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ReadyToPlayOnTheWeb.Value.ToString());
				xE.Add(xItem);
			}
			if (IndustryStandardCommercialIdentifier != null)
			{
				xItem = new XElement(XName.Get("industryStandardCommercialIdentifier", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IndustryStandardCommercialIdentifier);
				xE.Add(xItem);
			}
			if (AdvertisingId != null)
			{
				xItem = new XElement(XName.Get("advertisingId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdvertisingId);
				xE.Add(xItem);
			}
			if (YouTubeVideoIdString != null)
			{
				xItem = new XElement(XName.Get("youTubeVideoIdString", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(YouTubeVideoIdString);
				xE.Add(xItem);
			}
		}
	}
}
