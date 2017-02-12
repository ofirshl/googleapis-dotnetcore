using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a Language criterion.
	/// <p>A criterion of this type can only be created using an ID.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class Language : Criterion, ISoapable
	{
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Code { get; set; }
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Name { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Code = null;
			Name = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "code")
				{
					Code = xItem.Value;
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Language");
			XElement xItem = null;
			if (Code != null)
			{
				xItem = new XElement(XName.Get("code", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Code);
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
		}
	}
}
