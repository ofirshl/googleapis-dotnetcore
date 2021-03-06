﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns traffic estimates for specified criteria.
	///
	/// @param selector Campaigns, ad groups and keywords for which traffic
	/// should be estimated.
	/// @return Traffic estimation results.
	/// @throws ApiException if problems occurred while retrieving estimates
	/// </summary>
	internal class TrafficEstimatorServiceGet : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public TrafficEstimatorSelector Selector { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Selector = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "selector")
				{
					Selector = new TrafficEstimatorSelector();
					Selector.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Selector != null)
			{
				xItem = new XElement(XName.Get("selector", "https://adwords.google.com/api/adwords/o/v201609"));
				Selector.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
