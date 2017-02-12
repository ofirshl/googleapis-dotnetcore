using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Dimension by which to subdivide or filter products.
	/// </summary>
	public abstract class ProductDimension : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of ProductDimension.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string ProductDimensionType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ProductDimensionType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "ProductDimension.Type")
				{
					ProductDimensionType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ProductDimensionType != null)
			{
				xItem = new XElement(XName.Get("ProductDimension.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ProductDimensionType);
				xE.Add(xItem);
			}
		}
	}
}
