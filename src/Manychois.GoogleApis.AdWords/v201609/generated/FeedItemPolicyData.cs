using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains offline-validation and approval results for a given FeedItem and FeedMapping. Each
	/// validation data indicates any issues found on the feed item when used in the context of the
	/// feed mapping.
	/// </summary>
	public class FeedItemPolicyData : PolicyData, ISoapable
	{
		/// <summary>
		/// Mapped placeholder type used in validation/approvals checks.
		/// </summary>
		public int? PlaceholderType { get; set; }
		/// <summary>
		/// Id of FeedMapping used in validation/approvals checks.
		/// </summary>
		public long? FeedMappingId { get; set; }
		/// <summary>
		/// Validation status of feed item for a particular feed mapping.
		/// </summary>
		public FeedItemValidationStatus? ValidationStatus { get; set; }
		/// <summary>
		/// Feed item approval status.
		/// </summary>
		public FeedItemApprovalStatus? ApprovalStatus { get; set; }
		/// <summary>
		/// List of error codes specifying what errors were found during validation.
		/// </summary>
		public List<FeedItemAttributeError> ValidationErrors { get; set; }
		/// <summary>
		/// Feed item quality evaluation approval status for a particular feed mapping.
		/// </summary>
		public FeedItemQualityApprovalStatus? QualityApprovalStatus { get; set; }
		/// <summary>
		/// Feed item quality evaluation disapproval reasons.
		/// </summary>
		public List<FeedItemQualityDisapprovalReasons> QualityDisapprovalReasons { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			PlaceholderType = null;
			FeedMappingId = null;
			ValidationStatus = null;
			ApprovalStatus = null;
			ValidationErrors = null;
			QualityApprovalStatus = null;
			QualityDisapprovalReasons = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "placeholderType")
				{
					PlaceholderType = int.Parse(xItem.Value);
				}
				else if (localName == "feedMappingId")
				{
					FeedMappingId = long.Parse(xItem.Value);
				}
				else if (localName == "validationStatus")
				{
					ValidationStatus = FeedItemValidationStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "approvalStatus")
				{
					ApprovalStatus = FeedItemApprovalStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "validationErrors")
				{
					if (ValidationErrors == null) ValidationErrors = new List<FeedItemAttributeError>();
					var validationErrorsItem = new FeedItemAttributeError();
					validationErrorsItem.ReadFrom(xItem);
					ValidationErrors.Add(validationErrorsItem);
				}
				else if (localName == "qualityApprovalStatus")
				{
					QualityApprovalStatus = FeedItemQualityApprovalStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "qualityDisapprovalReasons")
				{
					if (QualityDisapprovalReasons == null) QualityDisapprovalReasons = new List<FeedItemQualityDisapprovalReasons>();
					QualityDisapprovalReasons.Add(FeedItemQualityDisapprovalReasonsExtensions.Parse(xItem.Value));
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "FeedItemPolicyData");
			XElement xItem = null;
			if (PlaceholderType != null)
			{
				xItem = new XElement(XName.Get("placeholderType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PlaceholderType.Value.ToString());
				xE.Add(xItem);
			}
			if (FeedMappingId != null)
			{
				xItem = new XElement(XName.Get("feedMappingId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedMappingId.Value.ToString());
				xE.Add(xItem);
			}
			if (ValidationStatus != null)
			{
				xItem = new XElement(XName.Get("validationStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ValidationStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ApprovalStatus != null)
			{
				xItem = new XElement(XName.Get("approvalStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ApprovalStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ValidationErrors != null)
			{
				foreach (var validationErrorsItem in ValidationErrors)
				{
					xItem = new XElement(XName.Get("validationErrors", "https://adwords.google.com/api/adwords/cm/v201609"));
					validationErrorsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (QualityApprovalStatus != null)
			{
				xItem = new XElement(XName.Get("qualityApprovalStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(QualityApprovalStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (QualityDisapprovalReasons != null)
			{
				foreach (var qualityDisapprovalReasonsItem in QualityDisapprovalReasons)
				{
					xItem = new XElement(XName.Get("qualityDisapprovalReasons", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(qualityDisapprovalReasonsItem.ToXmlValue());
					xE.Add(xItem);
				}
			}
		}
	}
}
