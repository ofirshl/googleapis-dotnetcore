using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A function operand in a matching function.
	/// Used to represent nested functions.
	/// </summary>
	public class FunctionOperand : FunctionArgumentOperand, ISoapable
	{
		/// <summary>
		/// The function held in this operand.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Function Value { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					Value = new Function();
					Value.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "FunctionOperand");
			XElement xItem = null;
			if (Value != null)
			{
				xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/cm/v201609"));
				Value.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
