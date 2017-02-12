using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The taxonomy of ProductBiddingCategory dimension values.
	///
	/// <p>Clients use this to convert between human-readable category names / display strings and
	/// ProductBiddingCategory instances.
	/// </summary>
	public class ProductBiddingCategoryData : ConstantData, ISoapable
	{
		/// <summary>
		/// The dimension value that corresponds to this category.
		/// </summary>
		public ProductBiddingCategory DimensionValue { get; set; }
		/// <summary>
		/// The dimension value that corresponds to parent category.
		/// </summary>
		public ProductBiddingCategory ParentDimensionValue { get; set; }
		/// <summary>
		/// The country of the taxonomy. It applies to all categories from the taxonomy.
		/// <span class="constraint Selectable">This field can be selected using the value "Country".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Country { get; set; }
		/// <summary>
		/// The status of the taxonomy. It applies to all categories from the taxonomy.
		/// <span class="constraint Selectable">This field can be selected using the value "BiddingCategoryStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public ShoppingBiddingDimensionStatus? Status { get; set; }
		/// <summary>
		/// A map of displayValues by their language code. The language code is a 2-letter string
		/// conforming with ISO 639-1 standard.
		/// </summary>
		public List<String_StringMapEntry> DisplayValue { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			DimensionValue = null;
			ParentDimensionValue = null;
			Country = null;
			Status = null;
			DisplayValue = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "dimensionValue")
				{
					DimensionValue = new ProductBiddingCategory();
					DimensionValue.ReadFrom(xItem);
				}
				else if (localName == "parentDimensionValue")
				{
					ParentDimensionValue = new ProductBiddingCategory();
					ParentDimensionValue.ReadFrom(xItem);
				}
				else if (localName == "country")
				{
					Country = xItem.Value;
				}
				else if (localName == "status")
				{
					Status = ShoppingBiddingDimensionStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "displayValue")
				{
					if (DisplayValue == null) DisplayValue = new List<String_StringMapEntry>();
					var displayValueItem = new String_StringMapEntry();
					displayValueItem.ReadFrom(xItem);
					DisplayValue.Add(displayValueItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ProductBiddingCategoryData");
			XElement xItem = null;
			if (DimensionValue != null)
			{
				xItem = new XElement(XName.Get("dimensionValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				DimensionValue.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (ParentDimensionValue != null)
			{
				xItem = new XElement(XName.Get("parentDimensionValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				ParentDimensionValue.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Country != null)
			{
				xItem = new XElement(XName.Get("country", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Country);
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (DisplayValue != null)
			{
				foreach (var displayValueItem in DisplayValue)
				{
					xItem = new XElement(XName.Get("displayValue", "https://adwords.google.com/api/adwords/cm/v201609"));
					displayValueItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
