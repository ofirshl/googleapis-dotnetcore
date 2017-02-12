using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// This represents an operation that includes an operator and an operand
	/// specified type.
	/// </summary>
	public abstract class Operation : ISoapable
	{
		/// <summary>
		/// Operator.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Operator? Operator { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of Operation.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string OperationType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operator = null;
			OperationType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operator")
				{
					Operator = OperatorExtensions.Parse(xItem.Value);
				}
				else if (localName == "Operation.Type")
				{
					OperationType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Operator != null)
			{
				xItem = new XElement(XName.Get("operator", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Operator.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (OperationType != null)
			{
				xItem = new XElement(XName.Get("Operation.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OperationType);
				xE.Add(xItem);
			}
		}
	}
}
