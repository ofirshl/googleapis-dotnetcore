using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An error indicating a problem with an ad customizer tag.
	/// </summary>
	public class AdCustomizerError : ApiError, ISoapable
	{
		public AdCustomizerErrorReason? Reason { get; set; }
		/// <summary>
		/// String form of the function that contained the error.
		/// </summary>
		public string FunctionString { get; set; }
		/// <summary>
		/// Lowercased string representation of the ad customizer function's operator.
		/// </summary>
		public string OperatorName { get; set; }
		/// <summary>
		/// Index of the operand that caused the error.
		/// </summary>
		public int? OperandIndex { get; set; }
		/// <summary>
		/// Value of the operand that caused the error.
		/// </summary>
		public string OperandValue { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Reason = null;
			FunctionString = null;
			OperatorName = null;
			OperandIndex = null;
			OperandValue = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reason")
				{
					Reason = AdCustomizerErrorReasonExtensions.Parse(xItem.Value);
				}
				else if (localName == "functionString")
				{
					FunctionString = xItem.Value;
				}
				else if (localName == "operatorName")
				{
					OperatorName = xItem.Value;
				}
				else if (localName == "operandIndex")
				{
					OperandIndex = int.Parse(xItem.Value);
				}
				else if (localName == "operandValue")
				{
					OperandValue = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AdCustomizerError");
			XElement xItem = null;
			if (Reason != null)
			{
				xItem = new XElement(XName.Get("reason", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Reason.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (FunctionString != null)
			{
				xItem = new XElement(XName.Get("functionString", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FunctionString);
				xE.Add(xItem);
			}
			if (OperatorName != null)
			{
				xItem = new XElement(XName.Get("operatorName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OperatorName);
				xE.Add(xItem);
			}
			if (OperandIndex != null)
			{
				xItem = new XElement(XName.Get("operandIndex", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OperandIndex.Value.ToString());
				xE.Add(xItem);
			}
			if (OperandValue != null)
			{
				xItem = new XElement(XName.Get("operandValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OperandValue);
				xE.Add(xItem);
			}
		}
	}
}
