using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// This represents an entry in a map with a key of type Type
	/// and value of type Attribute.
	/// </summary>
	public class Type_AttributeMapEntry : ISoapable
	{
		public AttributeType? Key { get; set; }
		public Attribute Value { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Key = null;
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "key")
				{
					Key = AttributeTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "value")
				{
					Value = InstanceCreator.CreateAttribute(xItem);
					Value.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Key != null)
			{
				xItem = new XElement(XName.Get("key", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(Key.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Value != null)
			{
				xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/o/v201609"));
				Value.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
