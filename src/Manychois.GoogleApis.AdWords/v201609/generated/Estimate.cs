using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Abstract class representing an reply to an {@link EstimateRequest}.
	/// </summary>
	public class Estimate : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of Estimate.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string EstimateType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			EstimateType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "Estimate.Type")
				{
					EstimateType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (EstimateType != null)
			{
				xItem = new XElement(XName.Get("Estimate.Type", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(EstimateType);
				xE.Add(xItem);
			}
		}
	}
}
