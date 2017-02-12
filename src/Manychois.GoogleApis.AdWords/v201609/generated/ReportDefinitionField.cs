using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents the fields that can be used to create a ReportDefinition.
	/// This class allows the user to query the list of fields applicable to a
	/// given report type. Consumers of reports will be able use the retrieved
	/// fields through the {@link ReportDefinitionService#getReportFields}
	/// api and run the corresponding reports.
	/// </summary>
	public class ReportDefinitionField : ISoapable
	{
		/// <summary>
		/// The field name.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string FieldName { get; set; }
		/// <summary>
		/// The name that is displayed in the downloaded report.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string DisplayFieldName { get; set; }
		/// <summary>
		/// The XML attribute in the downloaded report.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string XmlAttributeName { get; set; }
		/// <summary>
		/// The type of field. Useful for knowing what operation type to pass in for
		/// a given field in a predicate.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string FieldType { get; set; }
		/// <summary>
		/// The behavior of this field. Possible values are: "ATTRIBUTE", "METRIC"
		/// and "SEGMENT".
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string FieldBehavior { get; set; }
		/// <summary>
		/// List of enum values for the corresponding field if and only if the
		/// field is an enum type.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<string> EnumValues { get; set; }
		/// <summary>
		/// Indicates if the user can select this field.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? CanSelect { get; set; }
		/// <summary>
		/// Indicates if the user can filter on this field.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? CanFilter { get; set; }
		/// <summary>
		/// Indicates that the field is an enum type.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? IsEnumType { get; set; }
		/// <summary>
		/// Indicates that the field is only available with beta access.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? IsBeta { get; set; }
		/// <summary>
		/// Indicates if the field can be selected in queries that explicitly request zero rows.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? IsZeroRowCompatible { get; set; }
		/// <summary>
		/// List of enum values in api to their corresponding display values in the
		/// downloaded reports.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<EnumValuePair> EnumValuePairs { get; set; }
		/// <summary>
		/// List of mutually exclusive fields of this field. This field cannot be selected or used in
		/// a predicate together with any of the mutually exclusive fields in this list.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<string> ExclusiveFields { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FieldName = null;
			DisplayFieldName = null;
			XmlAttributeName = null;
			FieldType = null;
			FieldBehavior = null;
			EnumValues = null;
			CanSelect = null;
			CanFilter = null;
			IsEnumType = null;
			IsBeta = null;
			IsZeroRowCompatible = null;
			EnumValuePairs = null;
			ExclusiveFields = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "fieldName")
				{
					FieldName = xItem.Value;
				}
				else if (localName == "displayFieldName")
				{
					DisplayFieldName = xItem.Value;
				}
				else if (localName == "xmlAttributeName")
				{
					XmlAttributeName = xItem.Value;
				}
				else if (localName == "fieldType")
				{
					FieldType = xItem.Value;
				}
				else if (localName == "fieldBehavior")
				{
					FieldBehavior = xItem.Value;
				}
				else if (localName == "enumValues")
				{
					if (EnumValues == null) EnumValues = new List<string>();
					EnumValues.Add(xItem.Value);
				}
				else if (localName == "canSelect")
				{
					CanSelect = bool.Parse(xItem.Value);
				}
				else if (localName == "canFilter")
				{
					CanFilter = bool.Parse(xItem.Value);
				}
				else if (localName == "isEnumType")
				{
					IsEnumType = bool.Parse(xItem.Value);
				}
				else if (localName == "isBeta")
				{
					IsBeta = bool.Parse(xItem.Value);
				}
				else if (localName == "isZeroRowCompatible")
				{
					IsZeroRowCompatible = bool.Parse(xItem.Value);
				}
				else if (localName == "enumValuePairs")
				{
					if (EnumValuePairs == null) EnumValuePairs = new List<EnumValuePair>();
					var enumValuePairsItem = new EnumValuePair();
					enumValuePairsItem.ReadFrom(xItem);
					EnumValuePairs.Add(enumValuePairsItem);
				}
				else if (localName == "exclusiveFields")
				{
					if (ExclusiveFields == null) ExclusiveFields = new List<string>();
					ExclusiveFields.Add(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FieldName != null)
			{
				xItem = new XElement(XName.Get("fieldName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FieldName);
				xE.Add(xItem);
			}
			if (DisplayFieldName != null)
			{
				xItem = new XElement(XName.Get("displayFieldName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DisplayFieldName);
				xE.Add(xItem);
			}
			if (XmlAttributeName != null)
			{
				xItem = new XElement(XName.Get("xmlAttributeName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(XmlAttributeName);
				xE.Add(xItem);
			}
			if (FieldType != null)
			{
				xItem = new XElement(XName.Get("fieldType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FieldType);
				xE.Add(xItem);
			}
			if (FieldBehavior != null)
			{
				xItem = new XElement(XName.Get("fieldBehavior", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FieldBehavior);
				xE.Add(xItem);
			}
			if (EnumValues != null)
			{
				foreach (var enumValuesItem in EnumValues)
				{
					xItem = new XElement(XName.Get("enumValues", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(enumValuesItem);
					xE.Add(xItem);
				}
			}
			if (CanSelect != null)
			{
				xItem = new XElement(XName.Get("canSelect", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CanSelect.Value.ToString());
				xE.Add(xItem);
			}
			if (CanFilter != null)
			{
				xItem = new XElement(XName.Get("canFilter", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CanFilter.Value.ToString());
				xE.Add(xItem);
			}
			if (IsEnumType != null)
			{
				xItem = new XElement(XName.Get("isEnumType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsEnumType.Value.ToString());
				xE.Add(xItem);
			}
			if (IsBeta != null)
			{
				xItem = new XElement(XName.Get("isBeta", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsBeta.Value.ToString());
				xE.Add(xItem);
			}
			if (IsZeroRowCompatible != null)
			{
				xItem = new XElement(XName.Get("isZeroRowCompatible", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsZeroRowCompatible.Value.ToString());
				xE.Add(xItem);
			}
			if (EnumValuePairs != null)
			{
				foreach (var enumValuePairsItem in EnumValuePairs)
				{
					xItem = new XElement(XName.Get("enumValuePairs", "https://adwords.google.com/api/adwords/cm/v201609"));
					enumValuePairsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (ExclusiveFields != null)
			{
				foreach (var exclusiveFieldsItem in ExclusiveFields)
				{
					xItem = new XElement(XName.Get("exclusiveFields", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(exclusiveFieldsItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
