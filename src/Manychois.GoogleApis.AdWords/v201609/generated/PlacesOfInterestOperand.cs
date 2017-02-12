using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// This operand specifies a place of interest category for semantic targeting.
	/// </summary>
	public class PlacesOfInterestOperand : FunctionArgumentOperand, ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public PlacesOfInterestOperandCategory? Category { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Category = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "category")
				{
					Category = PlacesOfInterestOperandCategoryExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "PlacesOfInterestOperand");
			XElement xItem = null;
			if (Category != null)
			{
				xItem = new XElement(XName.Get("category", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Category.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
