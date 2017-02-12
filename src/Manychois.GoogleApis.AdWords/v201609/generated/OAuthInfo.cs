using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Data used for authorization using OAuth.
	/// For more information about OAuth, see:
	/// {@link "https://developers.google.com/accounts/docs/OAuth2"}
	/// </summary>
	public class OAuthInfo : ISoapable
	{
		/// <summary>
		/// The HTTP method used to obtain authorization.
		/// </summary>
		public string HttpMethod { get; set; }
		/// <summary>
		/// The HTTP request URL used to obtain authorization.
		/// </summary>
		public string HttpRequestUrl { get; set; }
		/// <summary>
		/// The HTTP authorization header used to obtain authorization.
		/// </summary>
		public string HttpAuthorizationHeader { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			HttpMethod = null;
			HttpRequestUrl = null;
			HttpAuthorizationHeader = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "httpMethod")
				{
					HttpMethod = xItem.Value;
				}
				else if (localName == "httpRequestUrl")
				{
					HttpRequestUrl = xItem.Value;
				}
				else if (localName == "httpAuthorizationHeader")
				{
					HttpAuthorizationHeader = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (HttpMethod != null)
			{
				xItem = new XElement(XName.Get("httpMethod", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(HttpMethod);
				xE.Add(xItem);
			}
			if (HttpRequestUrl != null)
			{
				xItem = new XElement(XName.Get("httpRequestUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(HttpRequestUrl);
				xE.Add(xItem);
			}
			if (HttpAuthorizationHeader != null)
			{
				xItem = new XElement(XName.Get("httpAuthorizationHeader", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(HttpAuthorizationHeader);
				xE.Add(xItem);
			}
		}
	}
}
