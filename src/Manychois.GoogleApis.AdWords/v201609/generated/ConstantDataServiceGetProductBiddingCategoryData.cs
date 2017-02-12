using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns a list of shopping bidding categories.
	///
	/// A country predicate must be included in the selector, only {@link Predicate.Operator#EQUALS}
	/// and {@link Predicate.Operator#IN} with a single value are supported in the country predicate.
	/// An empty parentDimensionType predicate will filter for root categories.
	///
	/// @return A list of shopping bidding categories.
	/// @throws ApiException when there is at least one error with the request.
	/// </summary>
	internal class ConstantDataServiceGetProductBiddingCategoryData : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Selector Selector { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Selector = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "selector")
				{
					Selector = new Selector();
					Selector.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Selector != null)
			{
				xItem = new XElement(XName.Get("selector", "https://adwords.google.com/api/adwords/cm/v201609"));
				Selector.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
