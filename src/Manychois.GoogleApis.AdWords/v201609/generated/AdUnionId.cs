using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an id indicating a grouping of Ads under some heuristic.
	/// </summary>
	public class AdUnionId : ISoapable
	{
		/// <summary>
		/// The ID of the ad union
		/// <span class="constraint InRange">This field must be greater than or equal to 1.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of AdUnionId.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string AdUnionIdType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			AdUnionIdType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "AdUnionId.Type")
				{
					AdUnionIdType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (AdUnionIdType != null)
			{
				xItem = new XElement(XName.Get("AdUnionId.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdUnionIdType);
				xE.Add(xItem);
			}
		}
	}
}
