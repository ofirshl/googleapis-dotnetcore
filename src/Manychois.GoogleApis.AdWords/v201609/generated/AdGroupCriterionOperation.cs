using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Operation (add, remove and set) on adgroup criteria.
	/// </summary>
	public class AdGroupCriterionOperation : Operation, ISoapable
	{
		/// <summary>
		/// The adgroup criterion being operated on.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public AdGroupCriterion Operand { get; set; }
		/// <summary>
		/// List of exemption requests for policy violations flagged by this criterion.
		///
		/// <p>Only set this field when adding criteria that trigger policy violations
		/// for which you wish to get exemptions for.
		/// </summary>
		public List<ExemptionRequest> ExemptionRequests { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Operand = null;
			ExemptionRequests = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operand")
				{
					Operand = InstanceCreator.CreateAdGroupCriterion(xItem);
					Operand.ReadFrom(xItem);
				}
				else if (localName == "exemptionRequests")
				{
					if (ExemptionRequests == null) ExemptionRequests = new List<ExemptionRequest>();
					var exemptionRequestsItem = new ExemptionRequest();
					exemptionRequestsItem.ReadFrom(xItem);
					ExemptionRequests.Add(exemptionRequestsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AdGroupCriterionOperation");
			XElement xItem = null;
			if (Operand != null)
			{
				xItem = new XElement(XName.Get("operand", "https://adwords.google.com/api/adwords/cm/v201609"));
				Operand.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (ExemptionRequests != null)
			{
				foreach (var exemptionRequestsItem in ExemptionRequests)
				{
					xItem = new XElement(XName.Get("exemptionRequests", "https://adwords.google.com/api/adwords/cm/v201609"));
					exemptionRequestsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
