using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Criterion for targeting webpages of an advertiser's website. The
	/// website domain name is specified at the campaign level.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class Webpage : Criterion, ISoapable
	{
		/// <summary>
		/// The webpage criterion parameter.
		/// <span class="constraint Selectable">This field can be selected using the value "Parameter".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public WebpageParameter Parameter { get; set; }
		/// <summary>
		/// Keywordless criteria coverage - Computed percentage of website coverage based on the
		/// website target, negative website targets and negative keywords in the ad group and campaign.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public double? CriteriaCoverage { get; set; }
		/// <summary>
		/// Keywordless criteria samples - List of sample urls that matches with the website target.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<string> CriteriaSamples { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Parameter = null;
			CriteriaCoverage = null;
			CriteriaSamples = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "parameter")
				{
					Parameter = new WebpageParameter();
					Parameter.ReadFrom(xItem);
				}
				else if (localName == "criteriaCoverage")
				{
					CriteriaCoverage = double.Parse(xItem.Value);
				}
				else if (localName == "criteriaSamples")
				{
					if (CriteriaSamples == null) CriteriaSamples = new List<string>();
					CriteriaSamples.Add(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Webpage");
			XElement xItem = null;
			if (Parameter != null)
			{
				xItem = new XElement(XName.Get("parameter", "https://adwords.google.com/api/adwords/cm/v201609"));
				Parameter.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (CriteriaCoverage != null)
			{
				xItem = new XElement(XName.Get("criteriaCoverage", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CriteriaCoverage.Value.ToString());
				xE.Add(xItem);
			}
			if (CriteriaSamples != null)
			{
				foreach (var criteriaSamplesItem in CriteriaSamples)
				{
					xItem = new XElement(XName.Get("criteriaSamples", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(criteriaSamplesItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
