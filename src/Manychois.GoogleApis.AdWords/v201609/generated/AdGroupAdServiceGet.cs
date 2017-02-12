using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns a list of AdGroupAds.
	/// AdGroupAds that had been removed are not returned by default.
	///
	/// @param serviceSelector The selector specifying the {@link AdGroupAd}s to return.
	/// @return The page containing the AdGroupAds that meet the criteria specified by the selector.
	/// @throws ApiException when there is at least one error with the request.
	/// </summary>
	internal class AdGroupAdServiceGet : ISoapable
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
