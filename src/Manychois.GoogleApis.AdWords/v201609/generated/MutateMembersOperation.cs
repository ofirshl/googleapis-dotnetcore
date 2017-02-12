using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Operation representing a request to add or remove members from a user list.
	/// </summary>
	public class MutateMembersOperation : Operation, ISoapable
	{
		/// <summary>
		/// The mutate members operand to operate on.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public MutateMembersOperand Operand { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Operand = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operand")
				{
					Operand = new MutateMembersOperand();
					Operand.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/rm/v201609", "MutateMembersOperation");
			XElement xItem = null;
			if (Operand != null)
			{
				xItem = new XElement(XName.Get("operand", "https://adwords.google.com/api/adwords/rm/v201609"));
				Operand.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
