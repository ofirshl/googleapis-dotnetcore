using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Setting for shopping campaigns. Defines the universe of products covered by the campaign.
	/// Encapsulates a merchant ID, sales country, and campaign priority.
	/// </summary>
	public class ShoppingSetting : Setting, ISoapable
	{
		/// <summary>
		/// ID of the Merchant Center account.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public long? MerchantId { get; set; }
		/// <summary>
		/// Sales country of products to include in the campaign.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string SalesCountry { get; set; }
		/// <summary>
		/// Priority of the campaign. Campaigns with numerically higher priorities take precedence over
		/// those with lower priorities.
		/// <span class="constraint InRange">This field must be between 0 and 2, inclusive.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public int? CampaignPriority { get; set; }
		/// <summary>
		/// Enable local inventory ads.
		/// </summary>
		public bool? EnableLocal { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			MerchantId = null;
			SalesCountry = null;
			CampaignPriority = null;
			EnableLocal = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "merchantId")
				{
					MerchantId = long.Parse(xItem.Value);
				}
				else if (localName == "salesCountry")
				{
					SalesCountry = xItem.Value;
				}
				else if (localName == "campaignPriority")
				{
					CampaignPriority = int.Parse(xItem.Value);
				}
				else if (localName == "enableLocal")
				{
					EnableLocal = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ShoppingSetting");
			XElement xItem = null;
			if (MerchantId != null)
			{
				xItem = new XElement(XName.Get("merchantId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(MerchantId.Value.ToString());
				xE.Add(xItem);
			}
			if (SalesCountry != null)
			{
				xItem = new XElement(XName.Get("salesCountry", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SalesCountry);
				xE.Add(xItem);
			}
			if (CampaignPriority != null)
			{
				xItem = new XElement(XName.Get("campaignPriority", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CampaignPriority.Value.ToString());
				xE.Add(xItem);
			}
			if (EnableLocal != null)
			{
				xItem = new XElement(XName.Get("enableLocal", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EnableLocal.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
