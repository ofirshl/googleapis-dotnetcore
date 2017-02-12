using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class CustomerSyncServiceResponseHeader : ISoapable
	{
		public string RequestId { get; set; }
		public string ServiceName { get; set; }
		public string MethodName { get; set; }
		public long? Operations { get; set; }
		public long? ResponseTime { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			RequestId = null;
			ServiceName = null;
			MethodName = null;
			Operations = null;
			ResponseTime = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "requestId")
				{
					RequestId = xItem.Value;
				}
				else if (localName == "serviceName")
				{
					ServiceName = xItem.Value;
				}
				else if (localName == "methodName")
				{
					MethodName = xItem.Value;
				}
				else if (localName == "operations")
				{
					Operations = long.Parse(xItem.Value);
				}
				else if (localName == "responseTime")
				{
					ResponseTime = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (RequestId != null)
			{
				xItem = new XElement(XName.Get("requestId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(RequestId);
				xE.Add(xItem);
			}
			if (ServiceName != null)
			{
				xItem = new XElement(XName.Get("serviceName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ServiceName);
				xE.Add(xItem);
			}
			if (MethodName != null)
			{
				xItem = new XElement(XName.Get("methodName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(MethodName);
				xE.Add(xItem);
			}
			if (Operations != null)
			{
				xItem = new XElement(XName.Get("operations", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Operations.Value.ToString());
				xE.Add(xItem);
			}
			if (ResponseTime != null)
			{
				xItem = new XElement(XName.Get("responseTime", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ResponseTime.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
