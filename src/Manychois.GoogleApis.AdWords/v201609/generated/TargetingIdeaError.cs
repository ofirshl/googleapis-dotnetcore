﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Base error class for the {@link TargetingIdeaService}.
	/// </summary>
	public class TargetingIdeaError : ApiError, ISoapable
	{
		/// <summary>
		/// The error reason represented by an enum.
		/// </summary>
		public TargetingIdeaErrorReason? Reason { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Reason = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reason")
				{
					Reason = TargetingIdeaErrorReasonExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "TargetingIdeaError");
			XElement xItem = null;
			if (Reason != null)
			{
				xItem = new XElement(XName.Get("reason", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(Reason.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
