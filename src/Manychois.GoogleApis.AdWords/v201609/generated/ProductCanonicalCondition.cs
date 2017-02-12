using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A canonical condition. Only supported by campaigns of
	/// {@link AdvertisingChannelType#SHOPPING}.
	/// </summary>
	public class ProductCanonicalCondition : ProductDimension, ISoapable
	{
		public ProductCanonicalConditionCondition? Condition { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Condition = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "condition")
				{
					Condition = ProductCanonicalConditionConditionExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ProductCanonicalCondition");
			XElement xItem = null;
			if (Condition != null)
			{
				xItem = new XElement(XName.Get("condition", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Condition.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
