using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Evidence that caused this policy topic to be reported.
	/// </summary>
	public class PolicyTopicEvidence : ISoapable
	{
		/// <summary>
		/// The type of evidence for the policy topic.
		/// </summary>
		public PolicyTopicEvidenceType? PolicyTopicEvidenceType { get; set; }
		/// <summary>
		/// The actual evidence that triggered this policy topic to be reported. This field is associated
		/// with the policyTopicEvidenceType. So for example, when policyTopicEvidenceType is AD_TEXT the
		/// evidence is the text associated with the Ad.
		/// </summary>
		public string EvidenceText { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			PolicyTopicEvidenceType = null;
			EvidenceText = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "policyTopicEvidenceType")
				{
					PolicyTopicEvidenceType = PolicyTopicEvidenceTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "evidenceText")
				{
					EvidenceText = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (PolicyTopicEvidenceType != null)
			{
				xItem = new XElement(XName.Get("policyTopicEvidenceType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PolicyTopicEvidenceType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (EvidenceText != null)
			{
				xItem = new XElement(XName.Get("evidenceText", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EvidenceText);
				xE.Add(xItem);
			}
		}
	}
}
