using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class DateTimeRange : ISoapable
	{
		public string Min { get; set; }
		public string Max { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Min = null;
			Max = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "min")
				{
					Min = xItem.Value;
				}
				else if (localName == "max")
				{
					Max = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Min != null)
			{
				xItem = new XElement(XName.Get("min", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Min);
				xE.Add(xItem);
			}
			if (Max != null)
			{
				xItem = new XElement(XName.Get("max", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Max);
				xE.Add(xItem);
			}
		}
	}
}
