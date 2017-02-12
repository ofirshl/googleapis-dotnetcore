using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An operand in a function referring to a value in the request context.
	/// </summary>
	public class RequestContextOperand : FunctionArgumentOperand, ISoapable
	{
		/// <summary>
		/// Type of value to be referred in the request context.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public RequestContextOperandContextType? ContextType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			ContextType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "contextType")
				{
					ContextType = RequestContextOperandContextTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "RequestContextOperand");
			XElement xItem = null;
			if (ContextType != null)
			{
				xItem = new XElement(XName.Get("contextType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ContextType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
