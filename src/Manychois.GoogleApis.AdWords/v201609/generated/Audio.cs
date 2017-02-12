using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Encapsulates an Audio media identified by a MediaId.
	/// </summary>
	public class Audio : Media, ISoapable
	{
		/// <summary>
		/// The duration of the associated audio, in milliseconds.
		/// <span class="constraint Selectable">This field can be selected using the value "DurationMillis".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? DurationMillis { get; set; }
		/// <summary>
		/// The streaming URL of the audio.
		/// <span class="constraint Selectable">This field can be selected using the value "StreamingUrl".</span>
		/// </summary>
		public string StreamingUrl { get; set; }
		/// <summary>
		/// Indicates whether the audio is ready to play on the web.
		/// <span class="constraint Selectable">This field can be selected using the value "ReadyToPlayOnTheWeb".</span>
		/// </summary>
		public bool? ReadyToPlayOnTheWeb { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			DurationMillis = null;
			StreamingUrl = null;
			ReadyToPlayOnTheWeb = null;
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
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Audio");
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
		}
	}
}
