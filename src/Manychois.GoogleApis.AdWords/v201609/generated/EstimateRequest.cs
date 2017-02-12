using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Abstract class representing a request to estimate stats.
	/// </summary>
	public abstract class EstimateRequest : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of EstimateRequest.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string EstimateRequestType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			EstimateRequestType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "EstimateRequest.Type")
				{
					EstimateRequestType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (EstimateRequestType != null)
			{
				xItem = new XElement(XName.Get("EstimateRequest.Type", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(EstimateRequestType);
				xE.Add(xItem);
			}
		}
	}
}
