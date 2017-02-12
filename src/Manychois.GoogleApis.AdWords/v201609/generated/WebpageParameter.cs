using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Parameter of Webpage criterion, expressed as a list of conditions, or
	/// logical expressions, for targeting webpages of an advertiser's website.
	/// </summary>
	public class WebpageParameter : CriterionParameter, ISoapable
	{
		/// <summary>
		/// The name of the criterion that is defined by this parameter.
		///
		/// <p>This name value will be used for identifying, sorting and filtering
		/// criteria with this type of parameters. For criteria with simpler
		/// parameters, such as keywords and placements, the parameter value itself
		/// is used for identification, sorting and filtering.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 2048, inclusive.</span>
		/// </summary>
		public string CriterionName { get; set; }
		/// <summary>
		/// Conditions, or logical expressions, for webpage targeting.
		///
		/// <p>The list of webpage targeting conditions are {@code and}-ed together
		/// when evaluated for targeting. A {@code null} list of conditions means that
		/// all webpages of the campaign's website are targeted.</p>
		/// <span class="constraint CollectionSize">The maximum size of this collection is 3.</span>
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// </summary>
		public List<WebpageCondition> Conditions { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			CriterionName = null;
			Conditions = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "criterionName")
				{
					CriterionName = xItem.Value;
				}
				else if (localName == "conditions")
				{
					if (Conditions == null) Conditions = new List<WebpageCondition>();
					var conditionsItem = new WebpageCondition();
					conditionsItem.ReadFrom(xItem);
					Conditions.Add(conditionsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "WebpageParameter");
			XElement xItem = null;
			if (CriterionName != null)
			{
				xItem = new XElement(XName.Get("criterionName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CriterionName);
				xE.Add(xItem);
			}
			if (Conditions != null)
			{
				foreach (var conditionsItem in Conditions)
				{
					xItem = new XElement(XName.Get("conditions", "https://adwords.google.com/api/adwords/cm/v201609"));
					conditionsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
