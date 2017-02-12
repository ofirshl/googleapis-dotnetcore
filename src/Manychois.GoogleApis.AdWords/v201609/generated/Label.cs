using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a label that can be attached to entities such as campaign, ad group, ads,
	/// criterion etc.
	/// </summary>
	public class Label : ISoapable
	{
		/// <summary>
		/// Id of label.
		/// <span class="constraint Selectable">This field can be selected using the value "LabelId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET, REMOVE.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// Name of label.
		/// <span class="constraint Selectable">This field can be selected using the value "LabelName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 80, inclusive.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Status of the label.
		/// <span class="constraint Selectable">This field can be selected using the value "LabelStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public LabelStatus? Status { get; set; }
		/// <summary>
		/// Attributes of the label.
		/// <span class="constraint Selectable">This field can be selected using the value "LabelAttribute".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// </summary>
		public LabelAttribute Attribute { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of Label.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string LabelType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			Name = null;
			Status = null;
			Attribute = null;
			LabelType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "status")
				{
					Status = LabelStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "attribute")
				{
					Attribute = new LabelAttribute();
					Attribute.ReadFrom(xItem);
				}
				else if (localName == "Label.Type")
				{
					LabelType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Attribute != null)
			{
				xItem = new XElement(XName.Get("attribute", "https://adwords.google.com/api/adwords/cm/v201609"));
				Attribute.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (LabelType != null)
			{
				xItem = new XElement(XName.Get("Label.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(LabelType);
				xE.Add(xItem);
			}
		}
	}
}
