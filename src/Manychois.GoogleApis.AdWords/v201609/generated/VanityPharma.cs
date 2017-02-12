using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Describes how unbranded pharma ads will be displayed.
	/// </summary>
	public class VanityPharma : ISoapable
	{
		/// <summary>
		/// The display mode for vanity pharma URLs.
		/// <span class="constraint Selectable">This field can be selected using the value "VanityPharmaDisplayUrlMode".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public VanityPharmaDisplayUrlMode? VanityPharmaDisplayUrlMode { get; set; }
		/// <summary>
		/// The text that will be displayed in display URL of the text ad when website description
		/// is the selected display mode for vanity pharma URLs.
		/// <span class="constraint Selectable">This field can be selected using the value "VanityPharmaText".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public VanityPharmaText? VanityPharmaText { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			VanityPharmaDisplayUrlMode = null;
			VanityPharmaText = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "vanityPharmaDisplayUrlMode")
				{
					VanityPharmaDisplayUrlMode = VanityPharmaDisplayUrlModeExtensions.Parse(xItem.Value);
				}
				else if (localName == "vanityPharmaText")
				{
					VanityPharmaText = VanityPharmaTextExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (VanityPharmaDisplayUrlMode != null)
			{
				xItem = new XElement(XName.Get("vanityPharmaDisplayUrlMode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(VanityPharmaDisplayUrlMode.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (VanityPharmaText != null)
			{
				xItem = new XElement(XName.Get("vanityPharmaText", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(VanityPharmaText.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
