using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Wrapper object for a list of AppUrls. The list can be cleared if a request contains
	/// an AppUrlList with an empty urls list.
	/// </summary>
	public class AppUrlList : ISoapable
	{
		/// <summary>
		/// List of URLs. On SET operation, empty list indicates to clear the list.
		/// <span class="constraint CollectionSize">The maximum size of this collection is 10.</span>
		/// </summary>
		public List<AppUrl> AppUrls { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			AppUrls = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "appUrls")
				{
					if (AppUrls == null) AppUrls = new List<AppUrl>();
					var appUrlsItem = new AppUrl();
					appUrlsItem.ReadFrom(xItem);
					AppUrls.Add(appUrlsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (AppUrls != null)
			{
				foreach (var appUrlsItem in AppUrls)
				{
					xItem = new XElement(XName.Get("appUrls", "https://adwords.google.com/api/adwords/cm/v201609"));
					appUrlsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
