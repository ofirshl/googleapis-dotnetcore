using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// User Interest represents a particular interest-based vertical to be targeted.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class CriterionUserInterest : Criterion, ISoapable
	{
		/// <summary>
		/// Id of this user interest. This is a required field.
		/// <span class="constraint Selectable">This field can be selected using the value "UserInterestId".</span>
		/// </summary>
		public long? UserInterestId { get; set; }
		/// <summary>
		/// Parent Id of this user interest.
		/// <span class="constraint Selectable">This field can be selected using the value "UserInterestParentId".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? UserInterestParentId { get; set; }
		/// <summary>
		/// Name of this user interest.
		/// <span class="constraint Selectable">This field can be selected using the value "UserInterestName".</span>
		/// </summary>
		public string UserInterestName { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			UserInterestId = null;
			UserInterestParentId = null;
			UserInterestName = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "userInterestId")
				{
					UserInterestId = long.Parse(xItem.Value);
				}
				else if (localName == "userInterestParentId")
				{
					UserInterestParentId = long.Parse(xItem.Value);
				}
				else if (localName == "userInterestName")
				{
					UserInterestName = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "CriterionUserInterest");
			XElement xItem = null;
			if (UserInterestId != null)
			{
				xItem = new XElement(XName.Get("userInterestId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UserInterestId.Value.ToString());
				xE.Add(xItem);
			}
			if (UserInterestParentId != null)
			{
				xItem = new XElement(XName.Get("userInterestParentId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UserInterestParentId.Value.ToString());
				xE.Add(xItem);
			}
			if (UserInterestName != null)
			{
				xItem = new XElement(XName.Get("userInterestName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(UserInterestName);
				xE.Add(xItem);
			}
		}
	}
}
