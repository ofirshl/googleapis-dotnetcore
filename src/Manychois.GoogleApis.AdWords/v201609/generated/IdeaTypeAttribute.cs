using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// {@link Attribute} type that contains an {@link IdeaType} value. For example, if a
	/// {@link TargetingIdea} represents a keyword idea, its {@link IdeaTypeAttribute} would contain a
	/// {@code KEYWORD} {@link IdeaType}.
	/// </summary>
	public class IdeaTypeAttribute : Attribute, ISoapable
	{
		/// <summary>
		/// {@link IdeaType} value contained by this {@link Attribute}.
		/// </summary>
		public IdeaType? Value { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					Value = IdeaTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "IdeaTypeAttribute");
			XElement xItem = null;
			if (Value != null)
			{
				xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(Value.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
