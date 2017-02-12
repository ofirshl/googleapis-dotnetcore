using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Gets campaign criteria.
	///
	/// @param serviceSelector The selector specifying the {@link CampaignCriterion}s to return.
	/// @return A list of campaign criteria.
	/// @throws ApiException when there is at least one error with the request.
	/// </summary>
	internal class CampaignCriterionServiceGet : ISoapable
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
