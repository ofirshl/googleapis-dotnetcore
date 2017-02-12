using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents violations of a single policy by some text in a field.
	///
	/// Violations of a single policy by the same string in multiple places
	/// within a field is reported in one instance of this class and only one
	/// exemption needs to be filed.
	/// Violations of a single policy by two different strings is reported
	/// as two separate instances of this class.
	///
	/// e.g. If 'ACME' violates 'capitalization' and occurs twice in a text ad it
	/// would be represented by one instance. If the ad also contains 'INC' which
	/// also violates 'capitalization' it would be represented in a separate
	/// instance.
	/// </summary>
	public class PolicyViolationError : ApiError, ISoapable
	{
		/// <summary>
		/// Unique identifier for the violation.
		/// </summary>
		public PolicyViolationKey Key { get; set; }
		/// <summary>
		/// Name of policy suitable for display to users. In the user's preferred
		/// language.
		/// </summary>
		public string ExternalPolicyName { get; set; }
		/// <summary>
		/// Url with writeup about the policy.
		/// </summary>
		public string ExternalPolicyUrl { get; set; }
		/// <summary>
		/// Localized description of the violation.
		/// </summary>
		public string ExternalPolicyDescription { get; set; }
		/// <summary>
		/// Whether user can file an exemption request for this violation.
		/// </summary>
		public bool? IsExemptable { get; set; }
		/// <summary>
		/// Lists the parts that violate the policy.
		/// </summary>
		public List<PolicyViolationErrorPart> ViolatingParts { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Key = null;
			ExternalPolicyName = null;
			ExternalPolicyUrl = null;
			ExternalPolicyDescription = null;
			IsExemptable = null;
			ViolatingParts = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "key")
				{
					Key = new PolicyViolationKey();
					Key.ReadFrom(xItem);
				}
				else if (localName == "externalPolicyName")
				{
					ExternalPolicyName = xItem.Value;
				}
				else if (localName == "externalPolicyUrl")
				{
					ExternalPolicyUrl = xItem.Value;
				}
				else if (localName == "externalPolicyDescription")
				{
					ExternalPolicyDescription = xItem.Value;
				}
				else if (localName == "isExemptable")
				{
					IsExemptable = bool.Parse(xItem.Value);
				}
				else if (localName == "violatingParts")
				{
					if (ViolatingParts == null) ViolatingParts = new List<PolicyViolationErrorPart>();
					var violatingPartsItem = new PolicyViolationErrorPart();
					violatingPartsItem.ReadFrom(xItem);
					ViolatingParts.Add(violatingPartsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "PolicyViolationError");
			XElement xItem = null;
			if (Key != null)
			{
				xItem = new XElement(XName.Get("key", "https://adwords.google.com/api/adwords/cm/v201609"));
				Key.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (ExternalPolicyName != null)
			{
				xItem = new XElement(XName.Get("externalPolicyName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ExternalPolicyName);
				xE.Add(xItem);
			}
			if (ExternalPolicyUrl != null)
			{
				xItem = new XElement(XName.Get("externalPolicyUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ExternalPolicyUrl);
				xE.Add(xItem);
			}
			if (ExternalPolicyDescription != null)
			{
				xItem = new XElement(XName.Get("externalPolicyDescription", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ExternalPolicyDescription);
				xE.Add(xItem);
			}
			if (IsExemptable != null)
			{
				xItem = new XElement(XName.Get("isExemptable", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsExemptable.Value.ToString());
				xE.Add(xItem);
			}
			if (ViolatingParts != null)
			{
				foreach (var violatingPartsItem in ViolatingParts)
				{
					xItem = new XElement(XName.Get("violatingParts", "https://adwords.google.com/api/adwords/cm/v201609"));
					violatingPartsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
