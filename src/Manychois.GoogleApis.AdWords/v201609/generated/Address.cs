using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Structure to specify an address location.
	/// </summary>
	public class Address : ISoapable
	{
		/// <summary>
		/// Street address line 1; <code>null</code> if unknown.
		/// <span class="constraint StringLength">This string must not be empty.</span>
		/// </summary>
		public string StreetAddress { get; set; }
		/// <summary>
		/// Street address line 2; <code>null</code> if unknown.
		/// <span class="constraint StringLength">This string must not be empty.</span>
		/// </summary>
		public string StreetAddress2 { get; set; }
		/// <summary>
		/// Name of the city; <code>null</code> if unknown.
		/// <span class="constraint StringLength">This string must not be empty.</span>
		/// </summary>
		public string CityName { get; set; }
		/// <summary>
		/// Province or state code; <code>null</code> if unknown.
		/// <span class="constraint StringLength">This string must not be empty.</span>
		/// </summary>
		public string ProvinceCode { get; set; }
		/// <summary>
		/// Province or state name; <code>null</code> if unknown.
		/// <span class="constraint StringLength">This string must not be empty.</span>
		/// </summary>
		public string ProvinceName { get; set; }
		/// <summary>
		/// Postal code; <code>null</code> if unknown.
		/// <span class="constraint StringLength">This string must not be empty.</span>
		/// </summary>
		public string PostalCode { get; set; }
		/// <summary>
		/// Country code; <code>null</code> if unknown.
		/// </summary>
		public string CountryCode { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			StreetAddress = null;
			StreetAddress2 = null;
			CityName = null;
			ProvinceCode = null;
			ProvinceName = null;
			PostalCode = null;
			CountryCode = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "streetAddress")
				{
					StreetAddress = xItem.Value;
				}
				else if (localName == "streetAddress2")
				{
					StreetAddress2 = xItem.Value;
				}
				else if (localName == "cityName")
				{
					CityName = xItem.Value;
				}
				else if (localName == "provinceCode")
				{
					ProvinceCode = xItem.Value;
				}
				else if (localName == "provinceName")
				{
					ProvinceName = xItem.Value;
				}
				else if (localName == "postalCode")
				{
					PostalCode = xItem.Value;
				}
				else if (localName == "countryCode")
				{
					CountryCode = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (StreetAddress != null)
			{
				xItem = new XElement(XName.Get("streetAddress", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StreetAddress);
				xE.Add(xItem);
			}
			if (StreetAddress2 != null)
			{
				xItem = new XElement(XName.Get("streetAddress2", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StreetAddress2);
				xE.Add(xItem);
			}
			if (CityName != null)
			{
				xItem = new XElement(XName.Get("cityName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CityName);
				xE.Add(xItem);
			}
			if (ProvinceCode != null)
			{
				xItem = new XElement(XName.Get("provinceCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ProvinceCode);
				xE.Add(xItem);
			}
			if (ProvinceName != null)
			{
				xItem = new XElement(XName.Get("provinceName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ProvinceName);
				xE.Add(xItem);
			}
			if (PostalCode != null)
			{
				xItem = new XElement(XName.Get("postalCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PostalCode);
				xE.Add(xItem);
			}
			if (CountryCode != null)
			{
				xItem = new XElement(XName.Get("countryCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CountryCode);
				xE.Add(xItem);
			}
		}
	}
}
