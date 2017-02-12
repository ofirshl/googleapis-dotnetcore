using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents the mobile application to be targeted.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class MobileApplication : Criterion, ISoapable
	{
		/// <summary>
		/// A string that uniquely identifies a mobile application to AdWords API. The format of this
		/// string is "<code>{platform}-{platform_native_id}</code>", where <code>platform</code> is "1"
		/// for iOS apps and "2" for Android apps, and where <code>platform_native_id</code> is the mobile
		/// application identifier native to the corresponding platform.
		/// For iOS, this native identifier is the 9 digit string that appears at the end of an App Store
		/// URL (e.g., "476943146" for "Flood-It! 2" whose App Store link is
		/// http://itunes.apple.com/us/app/flood-it!-2/id476943146).
		/// For Android, this native identifier is the application's package name (e.g.,
		/// "com.labpixies.colordrips" for "Color Drips" given Google Play link
		/// https://play.google.com/store/apps/details?id=com.labpixies.colordrips).
		/// A well formed app id for AdWords API would thus be "1-476943146" for iOS and
		/// "2-com.labpixies.colordrips" for Android.
		/// <span class="constraint Selectable">This field can be selected using the value "AppId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string AppId { get; set; }
		/// <summary>
		/// Title of this mobile application.
		/// <span class="constraint Selectable">This field can be selected using the value "DisplayName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string DisplayName { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			AppId = null;
			DisplayName = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "appId")
				{
					AppId = xItem.Value;
				}
				else if (localName == "displayName")
				{
					DisplayName = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "MobileApplication");
			XElement xItem = null;
			if (AppId != null)
			{
				xItem = new XElement(XName.Get("appId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AppId);
				xE.Add(xItem);
			}
			if (DisplayName != null)
			{
				xItem = new XElement(XName.Get("displayName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DisplayName);
				xE.Add(xItem);
			}
		}
	}
}
