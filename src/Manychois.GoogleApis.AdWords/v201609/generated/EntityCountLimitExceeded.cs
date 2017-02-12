using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Signals that an entity count limit was exceeded for some level.
	/// For example, too many criteria for a campaign.
	/// </summary>
	public class EntityCountLimitExceeded : ApiError, ISoapable
	{
		/// <summary>
		/// Specifies which level's limit was exceeded.
		/// </summary>
		public EntityCountLimitExceededReason? Reason { get; set; }
		/// <summary>
		/// Id of the entity whose limit was exceeded.
		/// </summary>
		public string EnclosingId { get; set; }
		/// <summary>
		/// The limit which was exceeded.
		/// </summary>
		public int? Limit { get; set; }
		/// <summary>
		/// The account limit type which was exceeded.
		/// </summary>
		public string AccountLimitType { get; set; }
		/// <summary>
		/// The count of existing entities.
		/// </summary>
		public int? ExistingCount { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Reason = null;
			EnclosingId = null;
			Limit = null;
			AccountLimitType = null;
			ExistingCount = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reason")
				{
					Reason = EntityCountLimitExceededReasonExtensions.Parse(xItem.Value);
				}
				else if (localName == "enclosingId")
				{
					EnclosingId = xItem.Value;
				}
				else if (localName == "limit")
				{
					Limit = int.Parse(xItem.Value);
				}
				else if (localName == "accountLimitType")
				{
					AccountLimitType = xItem.Value;
				}
				else if (localName == "existingCount")
				{
					ExistingCount = int.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "EntityCountLimitExceeded");
			XElement xItem = null;
			if (Reason != null)
			{
				xItem = new XElement(XName.Get("reason", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Reason.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (EnclosingId != null)
			{
				xItem = new XElement(XName.Get("enclosingId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EnclosingId);
				xE.Add(xItem);
			}
			if (Limit != null)
			{
				xItem = new XElement(XName.Get("limit", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Limit.Value.ToString());
				xE.Add(xItem);
			}
			if (AccountLimitType != null)
			{
				xItem = new XElement(XName.Get("accountLimitType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AccountLimitType);
				xE.Add(xItem);
			}
			if (ExistingCount != null)
			{
				xItem = new XElement(XName.Get("existingCount", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ExistingCount.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
