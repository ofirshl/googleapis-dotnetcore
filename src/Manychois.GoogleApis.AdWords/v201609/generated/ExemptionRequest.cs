using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A request to be exempted from a {@link PolicyViolationError}.
	/// </summary>
	public class ExemptionRequest : ISoapable
	{
		/// <summary>
		/// Identifies the violation to request an exemption for.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public PolicyViolationKey Key { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Key = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "key")
				{
					Key = new PolicyViolationKey();
					Key.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Key != null)
			{
				xItem = new XElement(XName.Get("key", "https://adwords.google.com/api/adwords/cm/v201609"));
				Key.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
