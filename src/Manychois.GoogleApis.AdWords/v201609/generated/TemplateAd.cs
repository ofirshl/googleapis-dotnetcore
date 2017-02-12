using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a <a href=
	/// "//www.google.com/adwords/displaynetwork/plan-creative-campaigns/display-ad-builder.html"
	/// >Display Ad Builder</a> template ad. A template ad is
	/// composed of a template (specified by its ID) and the data that populates
	/// the template's fields. For a list of available templates and their required
	/// fields, see <a href="/adwords/api/docs/appendix/templateads">Template Ads</a>.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class TemplateAd : Ad, ISoapable
	{
		/// <summary>
		/// ID of the template to use.
		/// <span class="constraint Selectable">This field can be selected using the value "TemplateId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? TemplateId { get; set; }
		/// <summary>
		/// Group ID of all template ads, which should be created together.
		/// Template ads in the same union reference the same data but have different
		/// dimensions. Single ads do not have a union ID. If a template ad specifies
		/// an ad union with only one ad, no union will be created.
		/// <span class="constraint Selectable">This field can be selected using the value "TemplateAdUnionId".</span>
		/// </summary>
		public AdUnionId AdUnionId { get; set; }
		/// <summary>
		/// List of elements (each containing a set of fields) for the template
		/// referenced by {@code templateId}. See
		/// <a href="/adwords/api/docs/appendix/templateads">Template
		/// Ads</a> for the elements and fields required for each template.
		/// </summary>
		public List<TemplateElement> TemplateElements { get; set; }
		/// <summary>
		/// The template ad rendered as an image.
		/// </summary>
		public Image AdAsImage { get; set; }
		/// <summary>
		/// The dimensions for this ad.
		/// </summary>
		public Dimensions Dimensions { get; set; }
		/// <summary>
		/// Name of this ad.
		/// <span class="constraint Required">
		/// This field is required and should not be {@code null}.</span>
		/// <span class="constraint Selectable">This field can be selected using the value "TemplateAdName".</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Duration of this ad (if it contains playable media).
		/// <span class="constraint Selectable">This field can be selected using the value "TemplateAdDuration".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public int? Duration { get; set; }
		/// <summary>
		/// For copies, the ad id of the ad this was or should be copied from.
		/// <span class="constraint Selectable">This field can be selected using the value "TemplateOriginAdId".</span>
		/// </summary>
		public long? OriginAdId { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			TemplateId = null;
			AdUnionId = null;
			TemplateElements = null;
			AdAsImage = null;
			Dimensions = null;
			Name = null;
			Duration = null;
			OriginAdId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "templateId")
				{
					TemplateId = long.Parse(xItem.Value);
				}
				else if (localName == "adUnionId")
				{
					AdUnionId = new AdUnionId();
					AdUnionId.ReadFrom(xItem);
				}
				else if (localName == "templateElements")
				{
					if (TemplateElements == null) TemplateElements = new List<TemplateElement>();
					var templateElementsItem = new TemplateElement();
					templateElementsItem.ReadFrom(xItem);
					TemplateElements.Add(templateElementsItem);
				}
				else if (localName == "adAsImage")
				{
					AdAsImage = new Image();
					AdAsImage.ReadFrom(xItem);
				}
				else if (localName == "dimensions")
				{
					Dimensions = new Dimensions();
					Dimensions.ReadFrom(xItem);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "duration")
				{
					Duration = int.Parse(xItem.Value);
				}
				else if (localName == "originAdId")
				{
					OriginAdId = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "TemplateAd");
			XElement xItem = null;
			if (TemplateId != null)
			{
				xItem = new XElement(XName.Get("templateId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TemplateId.Value.ToString());
				xE.Add(xItem);
			}
			if (AdUnionId != null)
			{
				xItem = new XElement(XName.Get("adUnionId", "https://adwords.google.com/api/adwords/cm/v201609"));
				AdUnionId.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (TemplateElements != null)
			{
				foreach (var templateElementsItem in TemplateElements)
				{
					xItem = new XElement(XName.Get("templateElements", "https://adwords.google.com/api/adwords/cm/v201609"));
					templateElementsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (AdAsImage != null)
			{
				xItem = new XElement(XName.Get("adAsImage", "https://adwords.google.com/api/adwords/cm/v201609"));
				AdAsImage.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Dimensions != null)
			{
				xItem = new XElement(XName.Get("dimensions", "https://adwords.google.com/api/adwords/cm/v201609"));
				Dimensions.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (Duration != null)
			{
				xItem = new XElement(XName.Get("duration", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Duration.Value.ToString());
				xE.Add(xItem);
			}
			if (OriginAdId != null)
			{
				xItem = new XElement(XName.Get("originAdId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OriginAdId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
