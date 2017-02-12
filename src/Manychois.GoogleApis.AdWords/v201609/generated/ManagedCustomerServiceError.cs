using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Error for {@link ManagedCustomerService}
	/// </summary>
	public class ManagedCustomerServiceError : ApiError, ISoapable
	{
		public ManagedCustomerServiceErrorReason? Reason { get; set; }
		/// <summary>
		/// The list of customer ids associated with the error.
		/// </summary>
		public List<long> CustomerIds { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Reason = null;
			CustomerIds = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reason")
				{
					Reason = ManagedCustomerServiceErrorReasonExtensions.Parse(xItem.Value);
				}
				else if (localName == "customerIds")
				{
					if (CustomerIds == null) CustomerIds = new List<long>();
					CustomerIds.Add(long.Parse(xItem.Value));
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/mcm/v201609", "ManagedCustomerServiceError");
			XElement xItem = null;
			if (Reason != null)
			{
				xItem = new XElement(XName.Get("reason", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(Reason.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (CustomerIds != null)
			{
				foreach (var customerIdsItem in CustomerIds)
				{
					xItem = new XElement(XName.Get("customerIds", "https://adwords.google.com/api/adwords/mcm/v201609"));
					xItem.Add(customerIdsItem.ToString());
					xE.Add(xItem);
				}
			}
		}
	}
}
