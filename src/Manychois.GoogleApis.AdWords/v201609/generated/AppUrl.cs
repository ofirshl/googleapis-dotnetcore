using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A URL for deep linking into an app for the given operating system.
	/// </summary>
	public class AppUrl : ISoapable
	{
		/// <summary>
		/// The app deep link url. E.g. "android-app://com.my.App"
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// The operating system targeted by this url.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public AppUrlOsType? OsType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Url = null;
			OsType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "url")
				{
					Url = xItem.Value;
				}
				else if (localName == "osType")
				{
					OsType = AppUrlOsTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Url != null)
			{
				xItem = new XElement(XName.Get("url", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Url);
				xE.Add(xItem);
			}
			if (OsType != null)
			{
				xItem = new XElement(XName.Get("osType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OsType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
