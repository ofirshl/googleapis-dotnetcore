using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Attributes for Text Labels.
	/// </summary>
	public class DisplayAttribute : LabelAttribute, ISoapable
	{
		/// <summary>
		/// Background color of the label in RGB format.
		/// <span class="constraint MatchesRegex">A background color string must begin with a '#' character followed by either 6 or 3 hexadecimal characters (24 vs. 12 bits). This is checked by the regular expression '^\#([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$'.</span>
		/// </summary>
		public string BackgroundColor { get; set; }
		/// <summary>
		/// A short description of the label.
		/// <span class="constraint StringLength">The length of this string should be between 0 and 200, inclusive.</span>
		/// </summary>
		public string Description { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			BackgroundColor = null;
			Description = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "backgroundColor")
				{
					BackgroundColor = xItem.Value;
				}
				else if (localName == "description")
				{
					Description = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "DisplayAttribute");
			XElement xItem = null;
			if (BackgroundColor != null)
			{
				xItem = new XElement(XName.Get("backgroundColor", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BackgroundColor);
				xE.Add(xItem);
			}
			if (Description != null)
			{
				xItem = new XElement(XName.Get("description", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description);
				xE.Add(xItem);
			}
		}
	}
}
