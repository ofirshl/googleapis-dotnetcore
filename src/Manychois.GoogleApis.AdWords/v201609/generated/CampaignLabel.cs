using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Manages the labels associated with a campaign.
	/// </summary>
	public class CampaignLabel : ISoapable
	{
		/// <summary>
		/// The id of the campaign that the label is applied to.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, REMOVE.</span>
		/// </summary>
		public long? CampaignId { get; set; }
		/// <summary>
		/// The id of an existing label to be applied to the campaign.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, REMOVE.</span>
		/// </summary>
		public long? LabelId { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			CampaignId = null;
			LabelId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "campaignId")
				{
					CampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "labelId")
				{
					LabelId = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (CampaignId != null)
			{
				xItem = new XElement(XName.Get("campaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (LabelId != null)
			{
				xItem = new XElement(XName.Get("labelId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LabelId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
