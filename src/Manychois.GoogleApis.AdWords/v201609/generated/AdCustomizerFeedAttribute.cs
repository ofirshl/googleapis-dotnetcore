using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An attribute of an AdCustomizerFeed.
	/// </summary>
	public class AdCustomizerFeedAttribute : ISoapable
	{
		/// <summary>
		/// The ID of the attribute.
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// The name of the attribute.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, SET.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 30, inclusive, (trimmed).</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The type of data this attribute contains.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, SET.</span>
		/// </summary>
		public AdCustomizerFeedAttributeType? Type { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			Name = null;
			Type = null;
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
					Type = AdCustomizerFeedAttributeTypeExtensions.Parse(xItem.Value);
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
		}
	}
}
