using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Conversion type for a call extension.
	/// </summary>
	public class CallConversionType : ISoapable
	{
		/// <summary>
		/// The ID of an AdCallMetricsConversion object. This object contains the phoneCallDuration field
		/// which is the minimum duration (in seconds) of a call to be considered a conversion.
		/// </summary>
		public long? ConversionTypeId { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ConversionTypeId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "conversionTypeId")
				{
					ConversionTypeId = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ConversionTypeId != null)
			{
				xItem = new XElement(XName.Get("conversionTypeId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ConversionTypeId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
