using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Content Label for category exclusion.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class ContentLabel : Criterion, ISoapable
	{
		/// <summary>
		/// Content label type
		/// <span class="constraint Selectable">This field can be selected using the value "ContentLabelType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public ContentLabelType? ContentLabelType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			ContentLabelType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "contentLabelType")
				{
					ContentLabelType = ContentLabelTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ContentLabel");
			XElement xItem = null;
			if (ContentLabelType != null)
			{
				xItem = new XElement(XName.Get("contentLabelType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ContentLabelType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
