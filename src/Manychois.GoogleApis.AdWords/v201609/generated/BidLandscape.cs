using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents data about a bid landscape for an ad group or criterion.
	/// </summary>
	public abstract class BidLandscape : DataEntry, ISoapable
	{
		/// <summary>
		/// ID of the campaign that contains the criterion with which this bid
		/// landscape is associated.
		/// <span class="constraint Selectable">This field can be selected using the value "CampaignId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? CampaignId { get; set; }
		/// <summary>
		/// ID of the ad group that contains the criterion with which this bid
		/// landscape is associated.
		/// Only available for ad group bid landscapes and ad group criterion bid landscapes.
		/// <span class="constraint Selectable">This field can be selected using the value "AdGroupId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? AdGroupId { get; set; }
		/// <summary>
		/// First day on which this landscape is based. Typically, it could be
		/// up to a week ago.
		/// <span class="constraint Selectable">This field can be selected using the value "StartDate".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string StartDate { get; set; }
		/// <summary>
		/// Last day on which this landscape is based.
		/// <span class="constraint Selectable">This field can be selected using the value "EndDate".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string EndDate { get; set; }
		/// <summary>
		/// List of landscape points, each corresponding to a specifid bid amount.
		/// </summary>
		public List<BidLandscapeLandscapePoint> LandscapePoints { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			CampaignId = null;
			AdGroupId = null;
			StartDate = null;
			EndDate = null;
			LandscapePoints = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "campaignId")
				{
					CampaignId = long.Parse(xItem.Value);
				}
				else if (localName == "adGroupId")
				{
					AdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "startDate")
				{
					StartDate = xItem.Value;
				}
				else if (localName == "endDate")
				{
					EndDate = xItem.Value;
				}
				else if (localName == "landscapePoints")
				{
					if (LandscapePoints == null) LandscapePoints = new List<BidLandscapeLandscapePoint>();
					var landscapePointsItem = new BidLandscapeLandscapePoint();
					landscapePointsItem.ReadFrom(xItem);
					LandscapePoints.Add(landscapePointsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "BidLandscape");
			XElement xItem = null;
			if (CampaignId != null)
			{
				xItem = new XElement(XName.Get("campaignId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CampaignId.Value.ToString());
				xE.Add(xItem);
			}
			if (AdGroupId != null)
			{
				xItem = new XElement(XName.Get("adGroupId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdGroupId.Value.ToString());
				xE.Add(xItem);
			}
			if (StartDate != null)
			{
				xItem = new XElement(XName.Get("startDate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StartDate);
				xE.Add(xItem);
			}
			if (EndDate != null)
			{
				xItem = new XElement(XName.Get("endDate", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EndDate);
				xE.Add(xItem);
			}
			if (LandscapePoints != null)
			{
				foreach (var landscapePointsItem in LandscapePoints)
				{
					xItem = new XElement(XName.Get("landscapePoints", "https://adwords.google.com/api/adwords/cm/v201609"));
					landscapePointsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
