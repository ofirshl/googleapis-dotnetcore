using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A URL that expires at a particular time.
	/// </summary>
	public class TemporaryUrl : ISoapable
	{
		/// <summary>
		/// The URL.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// When the URL expires, in account time.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Expiration { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Url = null;
			Expiration = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "url")
				{
					Url = xItem.Value;
				}
				else if (localName == "expiration")
				{
					Expiration = xItem.Value;
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
			if (Expiration != null)
			{
				xItem = new XElement(XName.Get("expiration", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Expiration);
				xE.Add(xItem);
			}
		}
	}
}
