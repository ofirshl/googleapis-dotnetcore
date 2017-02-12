using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Parent criterion.
	/// <p>A criterion of this type can only be created using an ID. A criterion of this type is only excludable.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class Parent : Criterion, ISoapable
	{
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "ParentType".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public ParentParentType? ParentType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			ParentType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "parentType")
				{
					ParentType = ParentParentTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Parent");
			XElement xItem = null;
			if (ParentType != null)
			{
				xItem = new XElement(XName.Get("parentType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ParentType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
