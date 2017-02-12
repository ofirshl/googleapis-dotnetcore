using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Container for information about why an AdWords entity was disapproved.
	/// </summary>
	public class DisapprovalReason : ISoapable
	{
		/// <summary>
		/// Short description of the disapproval reason, localized for the specific advertiser.
		/// </summary>
		public string ShortName { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ShortName = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "shortName")
				{
					ShortName = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ShortName != null)
			{
				xItem = new XElement(XName.Get("shortName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ShortName);
				xE.Add(xItem);
			}
		}
	}
}
