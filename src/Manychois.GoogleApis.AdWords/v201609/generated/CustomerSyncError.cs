using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents CustomerSyncService specific errors
	/// </summary>
	public class CustomerSyncError : ApiError, ISoapable
	{
		public CustomerSyncErrorReason? Reason { get; set; }
		public long? CampaignId { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Reason = null;
			CampaignId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reason")
				{
					Reason = CustomerSyncErrorReasonExtensions.Parse(xItem.Value);
				}
				else if (localName == "campaignId")
				{
					CampaignId = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/ch/v201609", "CustomerSyncError");
			XElement xItem = null;
			if (Reason != null)
			{
				xItem = new XElement(XName.Get("reason", "https://adwords.google.com/api/adwords/ch/v201609"));
				xItem.Add(Reason.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (CampaignId != null)
			{
				xItem = new XElement(XName.Get("campaignId", "https://adwords.google.com/api/adwords/ch/v201609"));
				xItem.Add(CampaignId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
