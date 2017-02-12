using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// AdGroupAd service operations.
	/// </summary>
	public class AdGroupAdOperation : Operation, ISoapable
	{
		/// <summary>
		/// AdGroupAd to operate on.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public AdGroupAd Operand { get; set; }
		/// <summary>
		/// Exemption requests for any policy violations in this Ad.  This field is
		/// only used for ADD operations
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
					Operand = new AdGroupAd();
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
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AdGroupAdOperation");
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
