using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// This operand specifies the income bracket a household falls under.
	/// </summary>
	public class IncomeOperand : FunctionArgumentOperand, ISoapable
	{
		/// <summary>
		/// Income tier specifying an income bracket that a household falls under. Tier 1 belongs to the
		/// highest income bracket.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public IncomeTier? Tier { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Tier = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "tier")
				{
					Tier = IncomeTierExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "IncomeOperand");
			XElement xItem = null;
			if (Tier != null)
			{
				xItem = new XElement(XName.Get("tier", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Tier.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
