using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class ConstantDataServiceGetMobileDeviceCriterionResponse : ISoapable
	{
		public List<MobileDevice> Rval { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Rval = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "rval")
				{
					if (Rval == null) Rval = new List<MobileDevice>();
					var rvalItem = new MobileDevice();
					rvalItem.ReadFrom(xItem);
					Rval.Add(rvalItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Rval != null)
			{
				foreach (var rvalItem in Rval)
				{
					xItem = new XElement(XName.Get("rval", "https://adwords.google.com/api/adwords/cm/v201609"));
					rvalItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
