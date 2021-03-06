﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// FeedAttributes define the types of data expected to be present in a Feed. A single FeedAttribute
	/// specifies the expected type of the FeedItemAttributes with the same FeedAttributeId. Optionally,
	/// a FeedAttribute can be marked as being part of a FeedItem's unique key.
	/// </summary>
	public class FeedAttribute : ISoapable
	{
		/// <summary>
		/// Id of the attribute.
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// The name of the attribute.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, SET.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 30, inclusive, (trimmed).</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The expected type of the data.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, SET.</span>
		/// </summary>
		public FeedAttributeType? Type { get; set; }
		/// <summary>
		/// Indicates that data corresponding to this attribute is part of a FeedItem's unique key. It
		/// defaults to false if it is unspecified. Note that a unique key is not required in a Feed's
		/// schema, in which case the FeedItems must be referenced by their FeedItemId.
		/// </summary>
		public bool? IsPartOfKey { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			Name = null;
			Type = null;
			IsPartOfKey = null;
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
				else if (localName == "type")
				{
					Type = FeedAttributeTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "isPartOfKey")
				{
					IsPartOfKey = bool.Parse(xItem.Value);
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
			if (Type != null)
			{
				xItem = new XElement(XName.Get("type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Type.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (IsPartOfKey != null)
			{
				xItem = new XElement(XName.Get("isPartOfKey", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsPartOfKey.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
