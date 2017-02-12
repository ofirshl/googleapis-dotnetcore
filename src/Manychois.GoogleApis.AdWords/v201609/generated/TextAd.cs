using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a TextAd.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class TextAd : Ad, ISoapable
	{
		/// <summary>
		/// The headline of the ad.
		/// <span class="constraint Selectable">This field can be selected using the value "Headline".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Headline { get; set; }
		/// <summary>
		/// The first description line.
		/// <span class="constraint Selectable">This field can be selected using the value "Description1".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Description1 { get; set; }
		/// <summary>
		/// The second description line.
		/// <span class="constraint Selectable">This field can be selected using the value "Description2".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Description2 { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Headline = null;
			Description1 = null;
			Description2 = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "headline")
				{
					Headline = xItem.Value;
				}
				else if (localName == "description1")
				{
					Description1 = xItem.Value;
				}
				else if (localName == "description2")
				{
					Description2 = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "TextAd");
			XElement xItem = null;
			if (Headline != null)
			{
				xItem = new XElement(XName.Get("headline", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Headline);
				xE.Add(xItem);
			}
			if (Description1 != null)
			{
				xItem = new XElement(XName.Get("description1", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description1);
				xE.Add(xItem);
			}
			if (Description2 != null)
			{
				xItem = new XElement(XName.Get("description2", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description2);
				xE.Add(xItem);
			}
		}
	}
}
