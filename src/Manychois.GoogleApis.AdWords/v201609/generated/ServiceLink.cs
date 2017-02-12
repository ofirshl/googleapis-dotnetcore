using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A data-sharing connection between an AdWords customer and another Google service.
	/// </summary>
	public class ServiceLink : ISoapable
	{
		/// <summary>
		/// The service being linked.
		/// <span class="constraint Filterable">This field can be filtered on using the value "ServiceType".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public ServiceType? ServiceType { get; set; }
		/// <summary>
		/// An ID uniquely identifying this link within a given {@link serviceType}.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET, REMOVE.</span>
		/// </summary>
		public long? ServiceLinkId { get; set; }
		/// <summary>
		/// Status of the link.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET.</span>
		/// </summary>
		public ServiceLinkLinkStatus? LinkStatus { get; set; }
		/// <summary>
		/// An identifier for the service account to which the AdWords account is linked.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Name { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ServiceType = null;
			ServiceLinkId = null;
			LinkStatus = null;
			Name = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "serviceType")
				{
					ServiceType = ServiceTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "serviceLinkId")
				{
					ServiceLinkId = long.Parse(xItem.Value);
				}
				else if (localName == "linkStatus")
				{
					LinkStatus = ServiceLinkLinkStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ServiceType != null)
			{
				xItem = new XElement(XName.Get("serviceType", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(ServiceType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ServiceLinkId != null)
			{
				xItem = new XElement(XName.Get("serviceLinkId", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(ServiceLinkId.Value.ToString());
				xE.Add(xItem);
			}
			if (LinkStatus != null)
			{
				xItem = new XElement(XName.Get("linkStatus", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(LinkStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
		}
	}
}
