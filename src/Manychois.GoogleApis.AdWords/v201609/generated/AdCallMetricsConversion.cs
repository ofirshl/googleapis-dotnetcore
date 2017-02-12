using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A ConversionTracker for phone calls from conversion-tracked call extensions.
	/// A call made from the call extension is reported as a conversion if it lasts longer
	/// than N seconds. This duration is 60 seconds by default. Each call extension can
	/// specify the desired conversion configuration.
	/// </summary>
	public class AdCallMetricsConversion : ConversionTracker, ISoapable
	{
		/// <summary>
		/// The phone-call duration (in seconds) after which a conversion should be reported for this
		/// AdCallMetricsConversion.
		/// <span class="constraint Selectable">This field can be selected using the value "PhoneCallDuration".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint InRange">This field must be between 0 and 10000, inclusive.</span>
		/// </summary>
		public long? PhoneCallDuration { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			PhoneCallDuration = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "phoneCallDuration")
				{
					PhoneCallDuration = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AdCallMetricsConversion");
			XElement xItem = null;
			if (PhoneCallDuration != null)
			{
				xItem = new XElement(XName.Get("phoneCallDuration", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PhoneCallDuration.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
