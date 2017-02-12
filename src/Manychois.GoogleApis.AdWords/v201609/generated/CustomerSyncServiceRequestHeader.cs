using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class CustomerSyncServiceRequestHeader : ISoapable
	{
		public string ClientCustomerId { get; set; }
		public string DeveloperToken { get; set; }
		public string UserAgent { get; set; }
		public bool? ValidateOnly { get; set; }
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
