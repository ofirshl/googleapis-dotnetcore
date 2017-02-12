using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Operation used to create or mutate a CustomerExtensionSetting.
	/// </summary>
	public class CustomerExtensionSettingOperation : Operation, ISoapable
	{
		/// <summary>
		/// CustomerExtensionSetting to operate on.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public CustomerExtensionSetting Operand { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Operand = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operand")
				{
					Operand = new CustomerExtensionSetting();
					Operand.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CustomerExtensionSettingOperation");
			XElement xItem = null;
			if (Operand != null)
			{
				xItem = new XElement(XName.Get("operand", "https://adwords.google.com/api/adwords/cm/v201609"));
				Operand.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
