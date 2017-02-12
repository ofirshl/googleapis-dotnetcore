using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns the list of campaigns that meet the selector criteria.
	///
	/// @param serviceSelector the selector specifying the {@link Campaign}s to return.
	/// @return A list of campaigns.
	/// @throws ApiException if problems occurred while fetching campaign information.
	/// </summary>
	internal class CampaignServiceGet : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Selector ServiceSelector { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ServiceSelector = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "serviceSelector")
				{
					ServiceSelector = new Selector();
					ServiceSelector.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ServiceSelector != null)
			{
				xItem = new XElement(XName.Get("serviceSelector", "https://adwords.google.com/api/adwords/cm/v201609"));
				ServiceSelector.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
