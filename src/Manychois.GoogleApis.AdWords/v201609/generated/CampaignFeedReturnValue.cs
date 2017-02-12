using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The result of a call to {@link CampaignFeedService#mutate}.
	/// </summary>
	public class CampaignFeedReturnValue : ListReturnValue, ISoapable
	{
		/// <summary>
		/// The resulting CampaignFeeds.
		/// </summary>
		public List<CampaignFeed> Value { get; set; }
		public List<ApiError> PartialFailureErrors { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Value = null;
			PartialFailureErrors = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					if (Value == null) Value = new List<CampaignFeed>();
					var valueItem = new CampaignFeed();
					valueItem.ReadFrom(xItem);
					Value.Add(valueItem);
				}
				else if (localName == "partialFailureErrors")
				{
					if (PartialFailureErrors == null) PartialFailureErrors = new List<ApiError>();
					var partialFailureErrorsItem = InstanceCreator.CreateApiError(xItem);
					partialFailureErrorsItem.ReadFrom(xItem);
					PartialFailureErrors.Add(partialFailureErrorsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CampaignFeedReturnValue");
			XElement xItem = null;
			if (Value != null)
			{
				foreach (var valueItem in Value)
				{
					xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/cm/v201609"));
					valueItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (PartialFailureErrors != null)
			{
				foreach (var partialFailureErrorsItem in PartialFailureErrors)
				{
					xItem = new XElement(XName.Get("partialFailureErrors", "https://adwords.google.com/api/adwords/cm/v201609"));
					partialFailureErrorsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
