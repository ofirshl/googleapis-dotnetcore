using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A {@link SearchParameter} for {@code KEYWORD} {@link IdeaType}s that
	/// sets a keyword category that all search results should belong to.
	/// Uses the newer "Products and Services" taxonomy.
	/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
	/// <p>This element is supported by following {@link RequestType}s: IDEAS.
	/// </summary>
	public class CategoryProductsAndServicesSearchParameter : SearchParameter, ISoapable
	{
		/// <summary>
		/// A keyword category ID in the "Products and Services" taxonomy that all
		/// search results should belong to.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public int? CategoryId { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			CategoryId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "categoryId")
				{
					CategoryId = int.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "CategoryProductsAndServicesSearchParameter");
			XElement xItem = null;
			if (CategoryId != null)
			{
				xItem = new XElement(XName.Get("categoryId", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(CategoryId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
