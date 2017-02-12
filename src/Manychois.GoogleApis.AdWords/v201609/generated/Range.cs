using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a range of values that has either an upper or a lower bound.
	/// </summary>
	public class Range : ISoapable
	{
		public ComparableValue Min { get; set; }
		public ComparableValue Max { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Min = null;
			Max = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "min")
				{
					Min = InstanceCreator.CreateComparableValue(xItem);
					Min.ReadFrom(xItem);
				}
				else if (localName == "max")
				{
					Max = InstanceCreator.CreateComparableValue(xItem);
					Max.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Min != null)
			{
				xItem = new XElement(XName.Get("min", "https://adwords.google.com/api/adwords/o/v201609"));
				Min.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Max != null)
			{
				xItem = new XElement(XName.Get("max", "https://adwords.google.com/api/adwords/o/v201609"));
				Max.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
