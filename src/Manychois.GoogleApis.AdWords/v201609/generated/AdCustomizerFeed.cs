using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A Feed which contains data used to populate ad customizers.
	///
	/// <p>An AdCustomizerFeed is a view of a regular Feed, but with some simplifications intended to
	/// support the most common use cases.
	/// </summary>
	public class AdCustomizerFeed : ISoapable
	{
		/// <summary>
		/// ID of the feed.
		/// <span class="constraint Selectable">This field can be selected using the value "FeedId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET, REMOVE.</span>
		/// </summary>
		public long? FeedId { get; set; }
		/// <summary>
		/// Name of the feed.
		/// <span class="constraint Selectable">This field can be selected using the value "FeedName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 128, inclusive, (trimmed).</span>
		/// </summary>
		public string FeedName { get; set; }
		/// <summary>
		/// Status of the feed.
		/// <span class="constraint Selectable">This field can be selected using the value "FeedStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public FeedStatus? FeedStatus { get; set; }
		/// <summary>
		/// The AdCustomizerFeed's schema. In SET operations, these attributes will be considered new
		/// attributes and will be appended to the existing list of attributes unless this list is an exact
		/// copy of the existing list (as would be obtained via {@link AdCustomizerFeedService#get}).
		/// <span class="constraint Selectable">This field can be selected using the value "FeedAttributes".</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, SET.</span>
		/// </summary>
		public List<AdCustomizerFeedAttribute> FeedAttributes { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FeedId = null;
			FeedName = null;
			FeedStatus = null;
			FeedAttributes = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "feedId")
				{
					FeedId = long.Parse(xItem.Value);
				}
				else if (localName == "feedName")
				{
					FeedName = xItem.Value;
				}
				else if (localName == "feedStatus")
				{
					FeedStatus = FeedStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "feedAttributes")
				{
					if (FeedAttributes == null) FeedAttributes = new List<AdCustomizerFeedAttribute>();
					var feedAttributesItem = new AdCustomizerFeedAttribute();
					feedAttributesItem.ReadFrom(xItem);
					FeedAttributes.Add(feedAttributesItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FeedId != null)
			{
				xItem = new XElement(XName.Get("feedId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedId.Value.ToString());
				xE.Add(xItem);
			}
			if (FeedName != null)
			{
				xItem = new XElement(XName.Get("feedName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedName);
				xE.Add(xItem);
			}
			if (FeedStatus != null)
			{
				xItem = new XElement(XName.Get("feedStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (FeedAttributes != null)
			{
				foreach (var feedAttributesItem in FeedAttributes)
				{
					xItem = new XElement(XName.Get("feedAttributes", "https://adwords.google.com/api/adwords/cm/v201609"));
					feedAttributesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
