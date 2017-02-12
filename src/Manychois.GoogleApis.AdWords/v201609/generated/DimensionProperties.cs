using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Top level class for Dimensions.
	/// </summary>
	public abstract class DimensionProperties : DataEntry, ISoapable
	{
		public LevelOfDetail LevelOfDetail { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			LevelOfDetail = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "levelOfDetail")
				{
					LevelOfDetail = new LevelOfDetail();
					LevelOfDetail.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "DimensionProperties");
			XElement xItem = null;
			if (LevelOfDetail != null)
			{
				xItem = new XElement(XName.Get("levelOfDetail", "https://adwords.google.com/api/adwords/cm/v201609"));
				LevelOfDetail.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
