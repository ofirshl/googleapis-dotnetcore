﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns a list of {@link LocationCriterion}'s that match the specified selector.
	///
	/// @param selector filters the LocationCriterion to be returned.
	/// @return A list of location criterion.
	/// @throws ApiException when there is at least one error with the request.
	/// </summary>
	internal class LocationCriterionServiceGet : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Selector Selector { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Selector = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "selector")
				{
					Selector = new Selector();
					Selector.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Selector != null)
			{
				xItem = new XElement(XName.Get("selector", "https://adwords.google.com/api/adwords/cm/v201609"));
				Selector.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
