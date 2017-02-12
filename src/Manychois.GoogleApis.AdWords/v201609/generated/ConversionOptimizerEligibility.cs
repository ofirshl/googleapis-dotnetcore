using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Eligibility data for Campaign to transition to Conversion Optimizer
	/// </summary>
	public class ConversionOptimizerEligibility : ISoapable
	{
		/// <summary>
		/// If the campaign is eligible to enter conversion optimizer.
		/// <span class="constraint Selectable">This field can be selected using the value "Eligible".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? Eligible { get; set; }
		/// <summary>
		/// Reason why a campaign would be rejected for conversion optimizer.
		/// <span class="constraint Selectable">This field can be selected using the value "RejectionReasons".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<ConversionOptimizerEligibilityRejectionReason> RejectionReasons { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Eligible = null;
			RejectionReasons = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "eligible")
				{
					Eligible = bool.Parse(xItem.Value);
				}
				else if (localName == "rejectionReasons")
				{
					if (RejectionReasons == null) RejectionReasons = new List<ConversionOptimizerEligibilityRejectionReason>();
					RejectionReasons.Add(ConversionOptimizerEligibilityRejectionReasonExtensions.Parse(xItem.Value));
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Eligible != null)
			{
				xItem = new XElement(XName.Get("eligible", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Eligible.Value.ToString());
				xE.Add(xItem);
			}
			if (RejectionReasons != null)
			{
				foreach (var rejectionReasonsItem in RejectionReasons)
				{
					xItem = new XElement(XName.Get("rejectionReasons", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(rejectionReasonsItem.ToXmlValue());
					xE.Add(xItem);
				}
			}
		}
	}
}
