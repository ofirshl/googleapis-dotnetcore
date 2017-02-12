using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Enhanced text ad format.
	///
	/// <p class="caution"><b>Caution:</b> Expanded text ads do not use {@link #url url},
	/// {@link #displayUrl displayUrl}, {@link #finalAppUrls finalAppUrls}, or
	/// {@link #devicePreference devicePreference};
	/// setting these fields on an expanded text ad will cause an error.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class ExpandedTextAd : Ad, ISoapable
	{
		/// <summary>
		/// First part of the headline.
		/// <span class="constraint Selectable">This field can be selected using the value "HeadlinePart1".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string HeadlinePart1 { get; set; }
		/// <summary>
		/// Second part of the headline.
		/// <span class="constraint Selectable">This field can be selected using the value "HeadlinePart2".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string HeadlinePart2 { get; set; }
		/// <summary>
		/// The descriptive text of the ad.
		/// <span class="constraint Selectable">This field can be selected using the value "Description".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Text that appears in the ad with the displayed URL.
		/// <span class="constraint Selectable">This field can be selected using the value "Path1".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Path1 { get; set; }
		/// <summary>
		/// In addition to {@link #path1}, more text that appears with the displayed URL.
		/// <span class="constraint Selectable">This field can be selected using the value "Path2".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Path2 { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			HeadlinePart1 = null;
			HeadlinePart2 = null;
			Description = null;
			Path1 = null;
			Path2 = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "headlinePart1")
				{
					HeadlinePart1 = xItem.Value;
				}
				else if (localName == "headlinePart2")
				{
					HeadlinePart2 = xItem.Value;
				}
				else if (localName == "description")
				{
					Description = xItem.Value;
				}
				else if (localName == "path1")
				{
					Path1 = xItem.Value;
				}
				else if (localName == "path2")
				{
					Path2 = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ExpandedTextAd");
			XElement xItem = null;
			if (HeadlinePart1 != null)
			{
				xItem = new XElement(XName.Get("headlinePart1", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(HeadlinePart1);
				xE.Add(xItem);
			}
			if (HeadlinePart2 != null)
			{
				xItem = new XElement(XName.Get("headlinePart2", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(HeadlinePart2);
				xE.Add(xItem);
			}
			if (Description != null)
			{
				xItem = new XElement(XName.Get("description", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description);
				xE.Add(xItem);
			}
			if (Path1 != null)
			{
				xItem = new XElement(XName.Get("path1", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Path1);
				xE.Add(xItem);
			}
			if (Path2 != null)
			{
				xItem = new XElement(XName.Get("path2", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Path2);
				xE.Add(xItem);
			}
		}
	}
}
