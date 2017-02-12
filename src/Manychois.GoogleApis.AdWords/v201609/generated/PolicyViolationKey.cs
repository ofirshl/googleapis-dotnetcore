using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Key of the violation. The key is used for referring to a violation when
	/// filing an exemption request.
	/// </summary>
	public class PolicyViolationKey : ISoapable
	{
		/// <summary>
		/// Unique id of the violated policy.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string PolicyName { get; set; }
		/// <summary>
		/// The text that violates the policy if specified. Otherwise, refers to the
		/// policy in general (e.g. when requesting to be exempt from the whole
		/// policy).
		///
		/// May be null for criterion exemptions, in which case this refers to the
		/// whole policy. Must be specified for ad exemptions.
		/// </summary>
		public string ViolatingText { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			PolicyName = null;
			ViolatingText = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "policyName")
				{
					PolicyName = xItem.Value;
				}
				else if (localName == "violatingText")
				{
					ViolatingText = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (PolicyName != null)
			{
				xItem = new XElement(XName.Get("policyName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PolicyName);
				xE.Add(xItem);
			}
			if (ViolatingText != null)
			{
				xItem = new XElement(XName.Get("violatingText", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ViolatingText);
				xE.Add(xItem);
			}
		}
	}
}
