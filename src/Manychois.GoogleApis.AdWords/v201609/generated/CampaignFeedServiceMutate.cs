﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Adds, sets or removes CampaignFeeds.
	///
	/// @param operations The operations to apply.
	/// @return The resulting Feeds.
	/// @throws ApiException Indicates a problem with the request.
	/// </summary>
	internal class CampaignFeedServiceMutate : ISoapable
	{
		/// <summary>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint SupportedOperators">The following {@link Operator}s are supported: ADD, SET, REMOVE.</span>
		/// </summary>
		public List<CampaignFeedOperation> Operations { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operations")
				{
					if (Operations == null) Operations = new List<CampaignFeedOperation>();
					var operationsItem = new CampaignFeedOperation();
					operationsItem.ReadFrom(xItem);
					Operations.Add(operationsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Operations != null)
			{
				foreach (var operationsItem in Operations)
				{
					xItem = new XElement(XName.Get("operations", "https://adwords.google.com/api/adwords/cm/v201609"));
					operationsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
