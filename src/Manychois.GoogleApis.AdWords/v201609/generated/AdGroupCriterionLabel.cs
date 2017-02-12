using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Manages the labels associated with an AdGroupCriterion.
	/// </summary>
	public class AdGroupCriterionLabel : ISoapable
	{
		/// <summary>
		/// The id of the adgroup containing the criterion that the label is applied to.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, REMOVE.</span>
		/// </summary>
		public long? AdGroupId { get; set; }
		/// <summary>
		/// The id of the criterion that the label is applied to.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, REMOVE.</span>
		/// </summary>
		public long? CriterionId { get; set; }
		/// <summary>
		/// The id of an existing label to be applied to the adgroup criterion.
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD, REMOVE.</span>
		/// </summary>
		public long? LabelId { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			AdGroupId = null;
			CriterionId = null;
			LabelId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "adGroupId")
				{
					AdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "criterionId")
				{
					CriterionId = long.Parse(xItem.Value);
				}
				else if (localName == "labelId")
				{
					LabelId = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (AdGroupId != null)
			{
				xItem = new XElement(XName.Get("adGroupId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdGroupId.Value.ToString());
				xE.Add(xItem);
			}
			if (CriterionId != null)
			{
				xItem = new XElement(XName.Get("criterionId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CriterionId.Value.ToString());
				xE.Add(xItem);
			}
			if (LabelId != null)
			{
				xItem = new XElement(XName.Get("labelId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LabelId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
