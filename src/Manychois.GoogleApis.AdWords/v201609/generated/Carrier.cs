using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a Carrier Criterion.
	/// <p>A criterion of this type can only be created using an ID.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class Carrier : Criterion, ISoapable
	{
		/// <summary>
		/// Name of the carrier.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Country code of the carrier.
		/// Can be {@code null} if not applicable, e.g., for Carrier "Wifi".
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string CountryCode { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Name = null;
			CountryCode = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "countryCode")
				{
					CountryCode = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Carrier");
			XElement xItem = null;
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (CountryCode != null)
			{
				xItem = new XElement(XName.Get("countryCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CountryCode);
				xE.Add(xItem);
			}
		}
	}
}
