using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a deprecated ad.
	///
	/// Deprecated ads can be deleted, but cannot be created.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class DeprecatedAd : Ad, ISoapable
	{
		/// <summary>
		/// Name of the ad.
		/// <span class="constraint Selectable">This field can be selected using the value "Name".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Type of the creative.
		/// <span class="constraint Selectable">This field can be selected using the value "Type".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public DeprecatedAdType? DeprecatedAdType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Name = null;
			DeprecatedAdType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "deprecatedAdType")
				{
					DeprecatedAdType = DeprecatedAdTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "DeprecatedAd");
			XElement xItem = null;
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (DeprecatedAdType != null)
			{
				xItem = new XElement(XName.Get("deprecatedAdType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DeprecatedAdType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
