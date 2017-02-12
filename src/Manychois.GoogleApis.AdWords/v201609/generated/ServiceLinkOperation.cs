using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An operation on an AdWords link.
	/// See {@link ServiceType} for information on the various linking types supported.
	/// </summary>
	public class ServiceLinkOperation : Operation, ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public ServiceLink Operand { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Operand = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operand")
				{
					Operand = new ServiceLink();
					Operand.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/mcm/v201609", "ServiceLinkOperation");
			XElement xItem = null;
			if (Operand != null)
			{
				xItem = new XElement(XName.Get("operand", "https://adwords.google.com/api/adwords/mcm/v201609"));
				Operand.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
