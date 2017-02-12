using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// An operation on a {@code BatchJob}.
	///
	/// <p class="note"><b>Note:</b> Only the <code>ADD</code> and <code>SET</code>
	/// operators are supported.
	/// </summary>
	public class BatchJobOperation : Operation, ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public BatchJob Operand { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Operand = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operand")
				{
					Operand = new BatchJob();
					Operand.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "BatchJobOperation");
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
