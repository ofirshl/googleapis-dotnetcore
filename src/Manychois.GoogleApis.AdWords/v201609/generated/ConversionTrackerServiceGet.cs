using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns a list of the conversion trackers that match the selector. The
	/// actual objects contained in the page's list of entries will be specific
	/// subclasses of the abstract {@link ConversionTracker} class.
	///
	/// @param serviceSelector The selector specifying the
	/// {@link ConversionTracker}s to return.
	/// @return List of conversion trackers specified by the selector.
	/// @throws com.google.ads.api.services.common.error.ApiException if problems
	/// occurred while retrieving results.
	/// </summary>
	internal class ConversionTrackerServiceGet : ISoapable
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
