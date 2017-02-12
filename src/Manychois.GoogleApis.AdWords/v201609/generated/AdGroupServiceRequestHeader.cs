using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class AdGroupServiceRequestHeader : ISoapable
	{
		/// <summary>
		/// The header identifies the customer id of the client of the AdWords manager, if an AdWords
		/// manager is acting on behalf of their client or the customer id of the advertiser managing their
		/// own account.
		/// </summary>
		public string ClientCustomerId { get; set; }
		/// <summary>
		/// Developer token to identify that the person making the call has enough
		/// quota.
		/// </summary>
		public string DeveloperToken { get; set; }
		/// <summary>
		/// UserAgent is used to track distribution of API client programs and
		/// application usage. The client is responsible for putting in a meaningful
		/// value for tracking purposes. To be clear this is not the same as an HTTP
		/// user agent.
		/// </summary>
		public string UserAgent { get; set; }
		/// <summary>
		/// Used to validate the request without executing it.
		/// </summary>
		public bool? ValidateOnly { get; set; }
		/// <summary>
		/// If true, API will try to commit as many error free operations as possible and
		/// report the other operations' errors.
		///
		/// <p>Ignored for non-mutate calls.
		/// </summary>
		public bool? PartialFailure { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ClientCustomerId = null;
			DeveloperToken = null;
			UserAgent = null;
			ValidateOnly = null;
			PartialFailure = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "clientCustomerId")
				{
					ClientCustomerId = xItem.Value;
				}
				else if (localName == "developerToken")
				{
					DeveloperToken = xItem.Value;
				}
				else if (localName == "userAgent")
				{
					UserAgent = xItem.Value;
				}
				else if (localName == "validateOnly")
				{
					ValidateOnly = bool.Parse(xItem.Value);
				}
				else if (localName == "partialFailure")
				{
					PartialFailure = bool.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ClientCustomerId != null)
			{
				xItem = new XElement(XName.Get("clientCustomerId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ClientCustomerId);
				xE.Add(xItem);
			}
			if (DeveloperToken != null)
			{
				xItem = new XElement(XName.Get("developerToken", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DeveloperToken);
				xE.Add(xItem);
			}
			if (UserAgent != null)
			{
				xItem = new XElement(XName.Get("userAgent", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UserAgent);
				xE.Add(xItem);
			}
			if (ValidateOnly != null)
			{
				xItem = new XElement(XName.Get("validateOnly", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ValidateOnly.Value.ToString());
				xE.Add(xItem);
			}
			if (PartialFailure != null)
			{
				xItem = new XElement(XName.Get("partialFailure", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PartialFailure.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
