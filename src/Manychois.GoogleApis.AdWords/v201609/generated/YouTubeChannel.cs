using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// YouTube channel criterion.
	/// <p>
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class YouTubeChannel : Criterion, ISoapable
	{
		/// <summary>
		/// The YouTube uploader channel id or the channel code of a YouTube content channel.
		/// <p>The uploader channel id can be obtained from the YouTube id-based URL. For example, in
		/// <code>https://www.youtube.com/channel/UCEN58iXQg82TXgsDCjWqIkg</code> the channel id is
		/// <code>UCEN58iXQg82TXgsDCjWqIkg</code>
		/// <p>For more information see: https://support.google.com/youtube/answer/6180214
		/// <span class="constraint Selectable">This field can be selected using the value "ChannelId".</span>
		/// </summary>
		public string ChannelId { get; set; }
		/// <summary>
		/// The public name for a YouTube user channel.
		/// <span class="constraint Selectable">This field can be selected using the value "ChannelName".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string ChannelName { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			ChannelId = null;
			ChannelName = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "channelId")
				{
					ChannelId = xItem.Value;
				}
				else if (localName == "channelName")
				{
					ChannelName = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "YouTubeChannel");
			XElement xItem = null;
			if (ChannelId != null)
			{
				xItem = new XElement(XName.Get("channelId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ChannelId);
				xE.Add(xItem);
			}
			if (ChannelName != null)
			{
				xItem = new XElement(XName.Get("channelName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ChannelName);
				xE.Add(xItem);
			}
		}
	}
}
