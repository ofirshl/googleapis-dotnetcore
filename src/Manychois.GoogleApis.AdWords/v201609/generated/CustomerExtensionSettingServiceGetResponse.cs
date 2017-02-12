using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class CustomerExtensionSettingServiceGetResponse : ISoapable
	{
		public CustomerExtensionSettingPage Rval { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Rval = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "rval")
				{
					Rval = new CustomerExtensionSettingPage();
					Rval.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Rval != null)
			{
				xItem = new XElement(XName.Get("rval", "https://adwords.google.com/api/adwords/cm/v201609"));
				Rval.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
