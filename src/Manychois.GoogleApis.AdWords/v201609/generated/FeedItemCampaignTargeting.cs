using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Specifies the campaign the request context must match in order for
	/// the feed item to be considered eligible for serving (aka the targeted campaign).
	/// E.g., if the below campaign targeting is set to campaignId = X, then the feed
	/// item can only serve under campaign X.
	/// </summary>
	public class FeedItemCampaignTargeting : ISoapable
	{
		/// <summary>
		/// The ID of the campaign to target.
		/// <span class="constraint Selectable">This field can be selected using the value "TargetingCampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// </summary>
		public long? TargetingCampaignId { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			TargetingCampaignId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "TargetingCampaignId")
				{
					TargetingCampaignId = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (TargetingCampaignId != null)
			{
				xItem = new XElement(XName.Get("TargetingCampaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TargetingCampaignId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
