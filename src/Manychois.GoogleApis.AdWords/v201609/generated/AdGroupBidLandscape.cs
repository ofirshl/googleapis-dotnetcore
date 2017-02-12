using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents data about a bidlandscape for an adgroup.
	/// </summary>
	public class AdGroupBidLandscape : BidLandscape, ISoapable
	{
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "LandscapeType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public AdGroupBidLandscapeType? Type { get; set; }
		/// <summary>
		/// Only applies to landscapes with {@code landscapeType == DEFAULT}. If true, then this bid
		/// landscape contains the set of ad group criteria that <em>currently</em> do not have
		/// criterion-level bid overrides. If false, then this bid landscape was derived from an earlier
		/// snapshot of ad group criteria, so it may contain criteria to which bid overrides were recently
		/// added, and may not contain criteria from which bid overrides were recently removed.
		/// <span class="constraint Selectable">This field can be selected using the value "LandscapeCurrent".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public bool? LandscapeCurrent { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Type = null;
			LandscapeCurrent = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "type")
				{
					Type = AdGroupBidLandscapeTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "landscapeCurrent")
				{
					LandscapeCurrent = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AdGroupBidLandscape");
			XElement xItem = null;
			if (Type != null)
			{
				xItem = new XElement(XName.Get("type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Type.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (LandscapeCurrent != null)
			{
				xItem = new XElement(XName.Get("landscapeCurrent", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LandscapeCurrent.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
