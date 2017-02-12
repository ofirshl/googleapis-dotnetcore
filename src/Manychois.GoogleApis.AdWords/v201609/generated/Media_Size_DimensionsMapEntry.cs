using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// This represents an entry in a map with a key of type Size
	/// and value of type Dimensions.
	/// </summary>
	public class Media_Size_DimensionsMapEntry : ISoapable
	{
		public MediaSize? Key { get; set; }
		public Dimensions Value { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Key = null;
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "key")
				{
					Key = MediaSizeExtensions.Parse(xItem.Value);
				}
				else if (localName == "value")
				{
					Value = new Dimensions();
					Value.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Key != null)
			{
				xItem = new XElement(XName.Get("key", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Key.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Value != null)
			{
				xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/cm/v201609"));
				Value.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
