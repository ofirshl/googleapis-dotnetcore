using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an Age Range criterion.
	/// <p>A criterion of this type can only be created using an ID.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class AgeRange : Criterion, ISoapable
	{
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public AgeRangeAgeRangeType? AgeRangeType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			AgeRangeType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "ageRangeType")
				{
					AgeRangeType = AgeRangeAgeRangeTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AgeRange");
			XElement xItem = null;
			if (AgeRangeType != null)
			{
				xItem = new XElement(XName.Get("ageRangeType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AgeRangeType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
