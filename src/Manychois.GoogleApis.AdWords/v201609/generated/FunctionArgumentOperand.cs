using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An operand that can be used in a function expression.
	/// </summary>
	public abstract class FunctionArgumentOperand : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of FunctionArgumentOperand.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string FunctionArgumentOperandType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FunctionArgumentOperandType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "FunctionArgumentOperand.Type")
				{
					FunctionArgumentOperandType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FunctionArgumentOperandType != null)
			{
				xItem = new XElement(XName.Get("FunctionArgumentOperand.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FunctionArgumentOperandType);
				xE.Add(xItem);
			}
		}
	}
}
