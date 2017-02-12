using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a bid of a certain amount.
	/// </summary>
	public class Bid : ISoapable
	{
		/// <summary>
		/// Bid amount.
		/// </summary>
		public Money Amount { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Amount = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "amount")
				{
					Amount = new Money();
					Amount.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Amount != null)
			{
				xItem = new XElement(XName.Get("amount", "https://adwords.google.com/api/adwords/cm/v201609"));
				Amount.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
