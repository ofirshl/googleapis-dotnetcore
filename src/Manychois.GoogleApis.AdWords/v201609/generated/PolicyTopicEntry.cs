using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains Ads Policy decisions.
	/// </summary>
	public class PolicyTopicEntry : ISoapable
	{
		/// <summary>
		/// The type of the policy topic entry.
		/// </summary>
		public PolicyTopicEntryType? PolicyTopicEntryType { get; set; }
		/// <summary>
		/// The policy topic evidences associated with this policy topic entry.
		/// </summary>
		public List<PolicyTopicEvidence> PolicyTopicEvidences { get; set; }
		/// <summary>
		/// The policy topic id.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string PolicyTopicId { get; set; }
		/// <summary>
		/// The policy topic name (in English).
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string PolicyTopicName { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			PolicyTopicEntryType = null;
			PolicyTopicEvidences = null;
			PolicyTopicId = null;
			PolicyTopicName = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "policyTopicEntryType")
				{
					PolicyTopicEntryType = PolicyTopicEntryTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "policyTopicEvidences")
				{
					if (PolicyTopicEvidences == null) PolicyTopicEvidences = new List<PolicyTopicEvidence>();
					var policyTopicEvidencesItem = new PolicyTopicEvidence();
					policyTopicEvidencesItem.ReadFrom(xItem);
					PolicyTopicEvidences.Add(policyTopicEvidencesItem);
				}
				else if (localName == "policyTopicId")
				{
					PolicyTopicId = xItem.Value;
				}
				else if (localName == "policyTopicName")
				{
					PolicyTopicName = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (PolicyTopicEntryType != null)
			{
				xItem = new XElement(XName.Get("policyTopicEntryType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PolicyTopicEntryType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (PolicyTopicEvidences != null)
			{
				foreach (var policyTopicEvidencesItem in PolicyTopicEvidences)
				{
					xItem = new XElement(XName.Get("policyTopicEvidences", "https://adwords.google.com/api/adwords/cm/v201609"));
					policyTopicEvidencesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (PolicyTopicId != null)
			{
				xItem = new XElement(XName.Get("policyTopicId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PolicyTopicId);
				xE.Add(xItem);
			}
			if (PolicyTopicName != null)
			{
				xItem = new XElement(XName.Get("policyTopicName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PolicyTopicName);
				xE.Add(xItem);
			}
		}
	}
}
