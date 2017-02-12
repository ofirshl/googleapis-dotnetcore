using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a money amount with currency.
	/// </summary>
	public class MoneyWithCurrency : ComparableValue, ISoapable
	{
		/// <summary>
		/// The amount of money.
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public Money Money { get; set; }
		/// <summary>
		/// Currency code.
		/// <span class="constraint StringLength">The length of this string should be between 3 and 3, inclusive, (trimmed).</span>
		/// </summary>
		public string CurrencyCode { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Money = null;
			CurrencyCode = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "money")
				{
					Money = new Money();
					Money.ReadFrom(xItem);
				}
				else if (localName == "currencyCode")
				{
					CurrencyCode = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "MoneyWithCurrency");
			XElement xItem = null;
			if (Money != null)
			{
				xItem = new XElement(XName.Get("money", "https://adwords.google.com/api/adwords/cm/v201609"));
				Money.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (CurrencyCode != null)
			{
				xItem = new XElement(XName.Get("currencyCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CurrencyCode);
				xE.Add(xItem);
			}
		}
	}
}
