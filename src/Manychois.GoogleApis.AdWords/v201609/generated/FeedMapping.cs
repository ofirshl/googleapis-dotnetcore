using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A FeedMapping represents a mapping between feed attributes in a specific feed
	/// and placeholder fields for a specific placeholder type. This will tell the
	/// ads serving system which parts of the feed item should be used when
	/// populating a placeholder. Without this mapping the placeholder cannot be
	/// populated and the extension can not be displayed.
	///
	/// <p>For a list of feed placeholders, see
	/// <a href="/adwords/api/docs/appendix/placeholders">
	/// https://developers.google.com/adwords/api/docs/appendix/placeholders
	/// </a></p>
	/// </summary>
	public class FeedMapping : ISoapable
	{
		/// <summary>
		/// ID of this FeedMapping.
		/// <span class="constraint Selectable">This field can be selected using the value "FeedMappingId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : REMOVE.</span>
		/// </summary>
		public long? FeedMappingId { get; set; }
		/// <summary>
		/// ID of the Feed that is mapped by this mapping.
		/// <span class="constraint Selectable">This field can be selected using the value "FeedId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? FeedId { get; set; }
		/// <summary>
		/// The placeholder type for this mapping.
		/// <span class="constraint Selectable">This field can be selected using the value "PlaceholderType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public int? PlaceholderType { get; set; }
		/// <summary>
		/// Status of the mapping.
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public FeedMappingStatus? Status { get; set; }
		/// <summary>
		/// The list of feed attributes to placeholder fields mappings.
		/// <span class="constraint Selectable">This field can be selected using the value "AttributeFieldMappings".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public List<AttributeFieldMapping> AttributeFieldMappings { get; set; }
		/// <summary>
		/// The criterion type for this mapping. This field is mutually exclusive with placeholderType.
		/// <span class="constraint Selectable">This field can be selected using the value "CriterionType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public int? CriterionType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FeedMappingId = null;
			FeedId = null;
			PlaceholderType = null;
			Status = null;
			AttributeFieldMappings = null;
			CriterionType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "feedMappingId")
				{
					FeedMappingId = long.Parse(xItem.Value);
				}
				else if (localName == "feedId")
				{
					FeedId = long.Parse(xItem.Value);
				}
				else if (localName == "placeholderType")
				{
					PlaceholderType = int.Parse(xItem.Value);
				}
				else if (localName == "status")
				{
					Status = FeedMappingStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "attributeFieldMappings")
				{
					if (AttributeFieldMappings == null) AttributeFieldMappings = new List<AttributeFieldMapping>();
					var attributeFieldMappingsItem = new AttributeFieldMapping();
					attributeFieldMappingsItem.ReadFrom(xItem);
					AttributeFieldMappings.Add(attributeFieldMappingsItem);
				}
				else if (localName == "criterionType")
				{
					CriterionType = int.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FeedMappingId != null)
			{
				xItem = new XElement(XName.Get("feedMappingId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedMappingId.Value.ToString());
				xE.Add(xItem);
			}
			if (FeedId != null)
			{
				xItem = new XElement(XName.Get("feedId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedId.Value.ToString());
				xE.Add(xItem);
			}
			if (PlaceholderType != null)
			{
				xItem = new XElement(XName.Get("placeholderType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PlaceholderType.Value.ToString());
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (AttributeFieldMappings != null)
			{
				foreach (var attributeFieldMappingsItem in AttributeFieldMappings)
				{
					xItem = new XElement(XName.Get("attributeFieldMappings", "https://adwords.google.com/api/adwords/cm/v201609"));
					attributeFieldMappingsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (CriterionType != null)
			{
				xItem = new XElement(XName.Get("criterionType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CriterionType.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
