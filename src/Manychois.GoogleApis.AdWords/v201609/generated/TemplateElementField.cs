using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a field in a template element.
	/// </summary>
	public class TemplateElementField : ISoapable
	{
		/// <summary>
		/// The name of this field.
		/// <span class="constraint Selectable">This field can be selected using the value "TemplateElementFieldName".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The type of this field.
		/// <span class="constraint Selectable">This field can be selected using the value "TemplateElementFieldType".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public TemplateElementFieldType? Type { get; set; }
		/// <summary>
		/// Text value for text field types. Null if not text field.
		/// The field is a text field if type is ADDRESS, ENUM, TEXT, URL,
		/// or VISIBLE_URL.
		/// <span class="constraint Selectable">This field can be selected using the value "TemplateElementFieldText".</span>
		/// </summary>
		public string FieldText { get; set; }
		/// <summary>
		/// Media value for non-text field types. Null if a text field. This
		/// fields must be specified if fieldText is null.
		/// </summary>
		public Media FieldMedia { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Name = null;
			Type = null;
			FieldText = null;
			FieldMedia = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "type")
				{
					Type = TemplateElementFieldTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "fieldText")
				{
					FieldText = xItem.Value;
				}
				else if (localName == "fieldMedia")
				{
					FieldMedia = new Media();
					FieldMedia.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (Type != null)
			{
				xItem = new XElement(XName.Get("type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Type.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (FieldText != null)
			{
				xItem = new XElement(XName.Get("fieldText", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FieldText);
				xE.Add(xItem);
			}
			if (FieldMedia != null)
			{
				xItem = new XElement(XName.Get("fieldMedia", "https://adwords.google.com/api/adwords/cm/v201609"));
				FieldMedia.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
