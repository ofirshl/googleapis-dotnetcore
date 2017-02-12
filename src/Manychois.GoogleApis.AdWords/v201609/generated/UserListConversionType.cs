using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a conversion type used for building remarketing user lists.
	/// </summary>
	public class UserListConversionType : ISoapable
	{
		/// <summary>
		/// Conversion type id
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// Name of this conversion type
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The category of the ConversionType based on the location where the
		/// conversion event was generated (from a user's perspective).
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public UserListConversionTypeCategory? Category { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			Name = null;
			Category = null;
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
				else if (localName == "category")
				{
					Category = UserListConversionTypeCategoryExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (Category != null)
			{
				xItem = new XElement(XName.Get("category", "https://adwords.google.com/api/adwords/rm/v201609"));
				xItem.Add(Category.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
