using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a mapping between a feed attribute and a placeholder field.
	///
	/// <p>For a list of feed placeholders, see
	/// <a href="/adwords/api/docs/appendix/placeholders">
	/// https://developers.google.com/adwords/api/docs/appendix/placeholders
	/// </a></p>
	/// </summary>
	public class AttributeFieldMapping : ISoapable
	{
		/// <summary>
		/// The feed attribute that this mapping references.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? FeedAttributeId { get; set; }
		/// <summary>
		/// The constant placeholder field that this mapping references.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public int? FieldId { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FeedAttributeId = null;
			FieldId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "feedAttributeId")
				{
					FeedAttributeId = long.Parse(xItem.Value);
				}
				else if (localName == "fieldId")
				{
					FieldId = int.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FeedAttributeId != null)
			{
				xItem = new XElement(XName.Get("feedAttributeId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedAttributeId.Value.ToString());
				xE.Add(xItem);
			}
			if (FieldId != null)
			{
				xItem = new XElement(XName.Get("fieldId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FieldId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
