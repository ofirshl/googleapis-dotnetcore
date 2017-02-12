using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a Gender criterion.
	/// <p>A criterion of this type can only be created using an ID.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class Gender : Criterion, ISoapable
	{
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public GenderGenderType? GenderType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			GenderType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "genderType")
				{
					GenderType = GenderGenderTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Gender");
			XElement xItem = null;
			if (GenderType != null)
			{
				xItem = new XElement(XName.Get("genderType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(GenderType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
