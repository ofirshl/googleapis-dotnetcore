using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents Platform criterion.
	/// <p>A criterion of this type can only be created using an ID.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class Platform : Criterion, ISoapable
	{
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string PlatformName { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			PlatformName = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "platformName")
				{
					PlatformName = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Platform");
			XElement xItem = null;
			if (PlatformName != null)
			{
				xItem = new XElement(XName.Get("platformName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PlatformName);
				xE.Add(xItem);
			}
		}
	}
}
