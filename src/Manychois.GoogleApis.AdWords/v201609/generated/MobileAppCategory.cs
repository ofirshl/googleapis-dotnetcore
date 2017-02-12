using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents the mobile app category to be targeted.
	/// <a href="/adwords/api/docs/appendix/mobileappcategories">View the complete list of
	/// available mobile app categories</a>.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class MobileAppCategory : Criterion, ISoapable
	{
		/// <summary>
		/// ID of this mobile app category. A complete list of the available mobile app categories is
		/// available <a href="/adwords/api/docs/appendix/mobileappcategories">here</a>.
		/// <span class="constraint Selectable">This field can be selected using the value "MobileAppCategoryId".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public int? MobileAppCategoryId { get; set; }
		/// <summary>
		/// Name of this mobile app category.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string DisplayName { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			MobileAppCategoryId = null;
			DisplayName = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "mobileAppCategoryId")
				{
					MobileAppCategoryId = int.Parse(xItem.Value);
				}
				else if (localName == "displayName")
				{
					DisplayName = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "MobileAppCategory");
			XElement xItem = null;
			if (MobileAppCategoryId != null)
			{
				xItem = new XElement(XName.Get("mobileAppCategoryId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(MobileAppCategoryId.Value.ToString());
				xE.Add(xItem);
			}
			if (DisplayName != null)
			{
				xItem = new XElement(XName.Get("displayName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DisplayName);
				xE.Add(xItem);
			}
		}
	}
}
