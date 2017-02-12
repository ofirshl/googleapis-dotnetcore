using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Operation for moving ManagedCustomer links. See {@link ManagedCustomerService#mutateManager}.
	/// </summary>
	public class MoveOperation : Operation, ISoapable
	{
		public ManagedCustomerLink Operand { get; set; }
		/// <summary>
		/// The ID of the old Manager.
		/// </summary>
		public long? OldManagerCustomerId { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Operand = null;
			OldManagerCustomerId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operand")
				{
					Operand = new ManagedCustomerLink();
					Operand.ReadFrom(xItem);
				}
				else if (localName == "oldManagerCustomerId")
				{
					OldManagerCustomerId = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/mcm/v201609", "MoveOperation");
			XElement xItem = null;
			if (Operand != null)
			{
				xItem = new XElement(XName.Get("operand", "https://adwords.google.com/api/adwords/mcm/v201609"));
				Operand.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (OldManagerCustomerId != null)
			{
				xItem = new XElement(XName.Get("oldManagerCustomerId", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(OldManagerCustomerId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
