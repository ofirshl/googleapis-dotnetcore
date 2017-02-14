using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A Feed identifies a source of data and its schema. The data for the Feed can either be
	/// user-entered via the FeedItemService or system-generated, in which case the data is provided
	/// automatically.
	/// </summary>
	public class Feed : ISoapable
	{
		/// <summary>
		/// Id of the Feed.
		/// <span class="constraint Selectable">This field can be selected using the value "Id".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : REMOVE, SET.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// Name of the Feed.
		/// <span class="constraint Selectable">This field can be selected using the value "Name".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 128, inclusive, (trimmed).</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The Feed's schema. In SET operations, these attributes will be considered new attributes and
		/// will be appended to the existing list of attributes unless this list is an exact copy of the
		/// existing list (as would be obtained via {@link FeedService#get}).
		/// If an empty attributes list is provided, the existing list of attributes will not be changed.
		/// <span class="constraint Selectable">This field can be selected using the value "Attributes".</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public List<FeedAttribute> Attributes { get; set; }
		/// <summary>
		/// Status of the Feed.
		/// <span class="constraint Selectable">This field can be selected using the value "FeedStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public FeedStatus? Status { get; set; }
		/// <summary>
		/// Specifies who manages the {@link FeedAttribute}s for the {@link Feed}.
		/// <span class="constraint Selectable">This field can be selected using the value "Origin".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public FeedOrigin? Origin { get; set; }
		/// <summary>
		/// The system data for the Feed. This data specifies information for generating the feed items
		/// of the system generated feed.
		/// <span class="constraint Selectable">This field can be selected using the value "SystemFeedGenerationData".</span>
		/// </summary>
		public SystemFeedGenerationData SystemFeedGenerationData { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			Name = null;
			Attributes = null;
			Status = null;
			Origin = null;
			SystemFeedGenerationData = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "attributes")
				{
					if (Attributes == null) Attributes = new List<FeedAttribute>();
					var attributesItem = new FeedAttribute();
					attributesItem.ReadFrom(xItem);
					Attributes.Add(attributesItem);
				}
				else if (localName == "status")
				{
					Status = FeedStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "origin")
				{
					Origin = FeedOriginExtensions.Parse(xItem.Value);
				}
				else if (localName == "systemFeedGenerationData")
				{
					SystemFeedGenerationData = InstanceCreator.CreateSystemFeedGenerationData(xItem);
					SystemFeedGenerationData.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (Attributes != null)
			{
				foreach (var attributesItem in Attributes)
				{
					xItem = new XElement(XName.Get("attributes", "https://adwords.google.com/api/adwords/cm/v201609"));
					attributesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Origin != null)
			{
				xItem = new XElement(XName.Get("origin", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Origin.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (SystemFeedGenerationData != null)
			{
				xItem = new XElement(XName.Get("systemFeedGenerationData", "https://adwords.google.com/api/adwords/cm/v201609"));
				SystemFeedGenerationData.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
