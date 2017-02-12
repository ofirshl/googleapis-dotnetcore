using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a {@link TargetingIdea} returned by search criteria specified in
	/// the {@link TargetingIdeaSelector}. Targeting ideas are keywords or placements
	/// that are similar to those the user inputs.
	/// </summary>
	public class TargetingIdea : ISoapable
	{
		/// <summary>
		/// Map of {@link AttributeType} to {@link Attribute}. Stores all data retrieved for each key
		/// {@code AttributeType}.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<Type_AttributeMapEntry> Data { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Data = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "data")
				{
					if (Data == null) Data = new List<Type_AttributeMapEntry>();
					var dataItem = new Type_AttributeMapEntry();
					dataItem.ReadFrom(xItem);
					Data.Add(dataItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Data != null)
			{
				foreach (var dataItem in Data)
				{
					xItem = new XElement(XName.Get("data", "https://adwords.google.com/api/adwords/o/v201609"));
					dataItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
