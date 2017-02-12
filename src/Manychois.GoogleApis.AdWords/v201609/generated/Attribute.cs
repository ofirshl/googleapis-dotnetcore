using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// {@link Attribute}s encompass the core information about a particular {@link TargetingIdea}. Some
	/// attributes are for {@code KEYWORD} {@link IdeaType}s, some are for {@code PLACEMENT}
	/// {@link IdeaType}s, and some are for both. Ultimately, an {@link Attribute} instance simply wraps
	/// an actual value of interest. For example, {@link KeywordAttribute} wraps the keyword itself,
	/// while a {@link BooleanAttribute} simply wraps a boolean describing some information about the
	/// keyword idea.
	/// </summary>
	public abstract class Attribute : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of Attribute.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string AttributeType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			AttributeType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "Attribute.Type")
				{
					AttributeType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (AttributeType != null)
			{
				xItem = new XElement(XName.Get("Attribute.Type", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(AttributeType);
				xE.Add(xItem);
			}
		}
	}
}
