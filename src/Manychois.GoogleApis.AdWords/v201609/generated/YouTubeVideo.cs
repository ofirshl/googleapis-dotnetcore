using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// YouTube video criterion.
	/// <p>
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class YouTubeVideo : Criterion, ISoapable
	{
		/// <summary>
		/// YouTube video id as it appears on the YouTube watch page.
		/// <span class="constraint Selectable">This field can be selected using the value "VideoId".</span>
		/// </summary>
		public string VideoId { get; set; }
		/// <summary>
		/// Name of the video.
		/// <span class="constraint Selectable">This field can be selected using the value "VideoName".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string VideoName { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			VideoId = null;
			VideoName = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "videoId")
				{
					VideoId = xItem.Value;
				}
				else if (localName == "videoName")
				{
					VideoName = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "YouTubeVideo");
			XElement xItem = null;
			if (VideoId != null)
			{
				xItem = new XElement(XName.Get("videoId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(VideoId);
				xE.Add(xItem);
			}
			if (VideoName != null)
			{
				xItem = new XElement(XName.Get("videoName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(VideoName);
				xE.Add(xItem);
			}
		}
	}
}
