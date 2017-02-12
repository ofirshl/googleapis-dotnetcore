using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A constant operand in a matching function.
	/// </summary>
	public class ConstantOperand : FunctionArgumentOperand, ISoapable
	{
		/// <summary>
		/// Type of constant in this operand.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public ConstantOperandConstantType? Type { get; set; }
		/// <summary>
		/// Units of constant in this operand.
		/// </summary>
		public ConstantOperandUnit? Unit { get; set; }
		/// <summary>
		/// Long value of the operand if it is a long type.
		/// </summary>
		public long? LongValue { get; set; }
		/// <summary>
		/// Boolean value of the operand if it is a boolean type.
		/// </summary>
		public bool? BooleanValue { get; set; }
		/// <summary>
		/// Double value of the operand if it is a double type.
		/// </summary>
		public double? DoubleValue { get; set; }
		/// <summary>
		/// String value of the operand if it is a string type.
		/// </summary>
		public string StringValue { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Type = null;
			Unit = null;
			LongValue = null;
			BooleanValue = null;
			DoubleValue = null;
			StringValue = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "type")
				{
					Type = ConstantOperandConstantTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "unit")
				{
					Unit = ConstantOperandUnitExtensions.Parse(xItem.Value);
				}
				else if (localName == "longValue")
				{
					LongValue = long.Parse(xItem.Value);
				}
				else if (localName == "booleanValue")
				{
					BooleanValue = bool.Parse(xItem.Value);
				}
				else if (localName == "doubleValue")
				{
					DoubleValue = double.Parse(xItem.Value);
				}
				else if (localName == "stringValue")
				{
					StringValue = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ConstantOperand");
			XElement xItem = null;
			if (Type != null)
			{
				xItem = new XElement(XName.Get("type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Type.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Unit != null)
			{
				xItem = new XElement(XName.Get("unit", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Unit.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (LongValue != null)
			{
				xItem = new XElement(XName.Get("longValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LongValue.Value.ToString());
				xE.Add(xItem);
			}
			if (BooleanValue != null)
			{
				xItem = new XElement(XName.Get("booleanValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BooleanValue.Value.ToString());
				xE.Add(xItem);
			}
			if (DoubleValue != null)
			{
				xItem = new XElement(XName.Get("doubleValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DoubleValue.Value.ToString());
				xE.Add(xItem);
			}
			if (StringValue != null)
			{
				xItem = new XElement(XName.Get("stringValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StringValue);
				xE.Add(xItem);
			}
		}
	}
}
