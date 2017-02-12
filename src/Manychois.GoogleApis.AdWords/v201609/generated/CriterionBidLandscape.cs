using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The bid landscape for a criterion.  A bid landscape estimates how a
	/// a criterion will perform based on different bid amounts.
	/// </summary>
	public class CriterionBidLandscape : BidLandscape, ISoapable
	{
		/// <summary>
		/// ID of the criterion associated with this landscape.
		/// <span class="constraint Selectable">This field can be selected using the value "CriterionId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? CriterionId { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			CriterionId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "criterionId")
				{
					CriterionId = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CriterionBidLandscape");
			XElement xItem = null;
			if (CriterionId != null)
			{
				xItem = new XElement(XName.Get("criterionId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CriterionId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
