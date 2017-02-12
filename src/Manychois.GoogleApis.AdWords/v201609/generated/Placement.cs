using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A placement used for modifying bids for sites when targeting the content
	/// network.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class Placement : Criterion, ISoapable
	{
		/// <summary>
		/// Url of the placement.
		///
		/// <p>For example, "http://www.domain.com".
		/// <span class="constraint Selectable">This field can be selected using the value "PlacementUrl".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string Url { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Url = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "url")
				{
					Url = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Placement");
			XElement xItem = null;
			if (Url != null)
			{
				xItem = new XElement(XName.Get("url", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Url);
				xE.Add(xItem);
			}
		}
	}
}
