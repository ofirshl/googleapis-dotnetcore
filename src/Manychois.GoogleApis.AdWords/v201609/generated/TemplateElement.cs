using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an element in a template. Each template element is composed
	/// of a list of fields (actual value data).
	/// </summary>
	public class TemplateElement : ISoapable
	{
		/// <summary>
		/// Unique name for this element.
		/// <span class="constraint Selectable">This field can be selected using the value "UniqueName".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string UniqueName { get; set; }
		/// <summary>
		/// List of fields to use for this template element.
		/// These must be the same for all template ads in the same template ad union.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<TemplateElementField> Fields { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			UniqueName = null;
			Fields = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "uniqueName")
				{
					UniqueName = xItem.Value;
				}
				else if (localName == "fields")
				{
					if (Fields == null) Fields = new List<TemplateElementField>();
					var fieldsItem = new TemplateElementField();
					fieldsItem.ReadFrom(xItem);
					Fields.Add(fieldsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (UniqueName != null)
			{
				xItem = new XElement(XName.Get("uniqueName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UniqueName);
				xE.Add(xItem);
			}
			if (Fields != null)
			{
				foreach (var fieldsItem in Fields)
				{
					xItem = new XElement(XName.Get("fields", "https://adwords.google.com/api/adwords/cm/v201609"));
					fieldsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
