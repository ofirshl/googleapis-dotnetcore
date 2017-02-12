using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents Location criterion.
	/// <p>A criterion of this type can only be created using an ID.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class Location : Criterion, ISoapable
	{
		/// <summary>
		/// Name of the location criterion. <b> Note:</b> This field is filterable only in
		/// LocationCriterionService.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string LocationName { get; set; }
		/// <summary>
		/// Display type of the location criterion.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string DisplayType { get; set; }
		/// <summary>
		/// The targeting status of the location criterion.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public LocationTargetingStatus? TargetingStatus { get; set; }
		/// <summary>
		/// Ordered list of parents of the location criterion.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<Location> ParentLocations { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			LocationName = null;
			DisplayType = null;
			TargetingStatus = null;
			ParentLocations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "locationName")
				{
					LocationName = xItem.Value;
				}
				else if (localName == "displayType")
				{
					DisplayType = xItem.Value;
				}
				else if (localName == "targetingStatus")
				{
					TargetingStatus = LocationTargetingStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "parentLocations")
				{
					if (ParentLocations == null) ParentLocations = new List<Location>();
					var parentLocationsItem = new Location();
					parentLocationsItem.ReadFrom(xItem);
					ParentLocations.Add(parentLocationsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Location");
			XElement xItem = null;
			if (LocationName != null)
			{
				xItem = new XElement(XName.Get("locationName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LocationName);
				xE.Add(xItem);
			}
			if (DisplayType != null)
			{
				xItem = new XElement(XName.Get("displayType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DisplayType);
				xE.Add(xItem);
			}
			if (TargetingStatus != null)
			{
				xItem = new XElement(XName.Get("targetingStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TargetingStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ParentLocations != null)
			{
				foreach (var parentLocationsItem in ParentLocations)
				{
					xItem = new XElement(XName.Get("parentLocations", "https://adwords.google.com/api/adwords/cm/v201609"));
					parentLocationsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
