using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class ConstantDataServiceGetMobileAppCategoryCriterionResponse : ISoapable
	{
		public List<MobileAppCategory> Rval { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Rval = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "rval")
				{
					if (Rval == null) Rval = new List<MobileAppCategory>();
					var rvalItem = new MobileAppCategory();
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
