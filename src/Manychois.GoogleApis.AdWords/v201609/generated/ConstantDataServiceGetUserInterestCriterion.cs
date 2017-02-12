using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns a list of user interests.
	///
	/// @param userInterestTaxonomyType The type of taxonomy to use when requesting user interests.
	/// @return A list of user interests.
	/// @throws ApiException when there is at least one error with the request.
	/// </summary>
	internal class ConstantDataServiceGetUserInterestCriterion : ISoapable
	{
		public ConstantDataServiceUserInterestTaxonomyType? UserInterestTaxonomyType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			UserInterestTaxonomyType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "userInterestTaxonomyType")
				{
					UserInterestTaxonomyType = ConstantDataServiceUserInterestTaxonomyTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (UserInterestTaxonomyType != null)
			{
				xItem = new XElement(XName.Get("userInterestTaxonomyType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UserInterestTaxonomyType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
