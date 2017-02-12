using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a FeedItem device preference.
	/// </summary>
	public class FeedItemDevicePreference : ISoapable
	{
		/// <summary>
		/// CriterionId of the type of device the feed item is preferred to serve on.
		/// Only CriterionId 30001 (mobile devices) is currently supported.
		/// If unspecified, the device preference will be cleared indicating that the feed item
		/// is not preferred for any device type.
		/// </summary>
		public long? DevicePreference { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			DevicePreference = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "devicePreference")
				{
					DevicePreference = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (DevicePreference != null)
			{
				xItem = new XElement(XName.Get("devicePreference", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DevicePreference.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
