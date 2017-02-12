using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A conversion type that receives conversions by having them uploaded
	/// through the OfflineConversionFeedService.
	///
	/// After successfully creating a new UploadConversion, send the name of this conversion type
	/// along with your conversion details to the OfflineConversionFeedService
	/// to attribute those conversions to this conversion type.
	/// </summary>
	public class UploadConversion : ConversionTracker, ISoapable
	{
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "UploadConversion");
		}
	}
}
