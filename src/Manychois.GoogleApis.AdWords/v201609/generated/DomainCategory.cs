using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents categories that AdWords finds automatically for your website.
	///
	/// <p>
	/// No categories available means that AdWords couldn't automatically find categories for your
	/// website. To control how categories are assigned, manually add breadcrumbs to your webpages.
	///
	/// <p>
	/// Categories can be filtered by domain name or by a set of campaign IDs.
	/// </summary>
	public class DomainCategory : DimensionProperties, ISoapable
	{
		/// <summary>
		/// Recommended category for the website domain.
		/// <span class="constraint Selectable">This field can be selected using the value "Category".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Category { get; set; }
		/// <summary>
		/// Coverage is the number of docs that match a label / number of docs that match the
		/// immediate parent label.
		/// <p>
		/// Example : united states/ca/sfo matches 500 docs and united states/ca matches 1000
		/// docs. The coverage will be 50%.
		/// <span class="constraint Selectable">This field can be selected using the value "Coverage".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public double? Coverage { get; set; }
		/// <summary>
		/// The domain for the website. Since many different domains can have the same categories, the
		/// domain and the language are used to uniquely identify the categories.
		/// <p>
		/// The domain can be specified in the DynamicSearchAdsSetting required for dynamic search ads.
		/// <span class="constraint Selectable">This field can be selected using the value "DomainName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string DomainName { get; set; }
		/// <summary>
		/// The language for the website. Since many different domains can have the same categories, the
		/// domain and the language are used to uniquely identify the categories.
		/// <p>
		/// The language can be specified in the DynamicSearchAdsSetting required for dynamic search ads.
		/// <span class="constraint Selectable">This field can be selected using the value "IsoLanguage".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string IsoLanguage { get; set; }
		/// <summary>
		/// The recommended cost per click for the category.
		/// <span class="constraint Selectable">This field can be selected using the value "RecommendedCpc".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public Money RecommendedCpc { get; set; }
		/// <summary>
		/// Used to determine whether a category has sub-categories associated with it.
		/// <span class="constraint Selectable">This field can be selected using the value "HasChild".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public bool? HasChild { get; set; }
		/// <summary>
		/// The position of this category in the recommended set of categories.
		/// <span class="constraint Selectable">This field can be selected using the value "CategoryRank".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public int? CategoryRank { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Category = null;
			Coverage = null;
			DomainName = null;
			IsoLanguage = null;
			RecommendedCpc = null;
			HasChild = null;
			CategoryRank = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "category")
				{
					Category = xItem.Value;
				}
				else if (localName == "coverage")
				{
					Coverage = double.Parse(xItem.Value);
				}
				else if (localName == "domainName")
				{
					DomainName = xItem.Value;
				}
				else if (localName == "isoLanguage")
				{
					IsoLanguage = xItem.Value;
				}
				else if (localName == "recommendedCpc")
				{
					RecommendedCpc = new Money();
					RecommendedCpc.ReadFrom(xItem);
				}
				else if (localName == "hasChild")
				{
					HasChild = bool.Parse(xItem.Value);
				}
				else if (localName == "categoryRank")
				{
					CategoryRank = int.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "DomainCategory");
			XElement xItem = null;
			if (Category != null)
			{
				xItem = new XElement(XName.Get("category", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Category);
				xE.Add(xItem);
			}
			if (Coverage != null)
			{
				xItem = new XElement(XName.Get("coverage", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Coverage.Value.ToString());
				xE.Add(xItem);
			}
			if (DomainName != null)
			{
				xItem = new XElement(XName.Get("domainName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DomainName);
				xE.Add(xItem);
			}
			if (IsoLanguage != null)
			{
				xItem = new XElement(XName.Get("isoLanguage", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsoLanguage);
				xE.Add(xItem);
			}
			if (RecommendedCpc != null)
			{
				xItem = new XElement(XName.Get("recommendedCpc", "https://adwords.google.com/api/adwords/cm/v201609"));
				RecommendedCpc.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (HasChild != null)
			{
				xItem = new XElement(XName.Get("hasChild", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(HasChild.Value.ToString());
				xE.Add(xItem);
			}
			if (CategoryRank != null)
			{
				xItem = new XElement(XName.Get("categoryRank", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CategoryRank.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
