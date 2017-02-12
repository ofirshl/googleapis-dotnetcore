using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains validation error details for a set of feed attributes.
	/// </summary>
	public class FeedItemAttributeError : ISoapable
	{
		/// <summary>
		/// Contains the set of feed attribute ids whose attributes together triggered the error.
		/// Null or empty field means error code does not apply to a specific set of attributes.
		/// </summary>
		public List<long> FeedAttributeIds { get; set; }
		/// <summary>
		/// Validation error code. See the
		/// <a href="/adwords/api/docs/appendix/feed-errors">list of error codes</a>.
		/// </summary>
		public int? ValidationErrorCode { get; set; }
		/// <summary>
		/// Extra information about the error, including related field IDs.
		/// </summary>
		public string ErrorInformation { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FeedAttributeIds = null;
			ValidationErrorCode = null;
			ErrorInformation = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "feedAttributeIds")
				{
					if (FeedAttributeIds == null) FeedAttributeIds = new List<long>();
					FeedAttributeIds.Add(long.Parse(xItem.Value));
				}
				else if (localName == "validationErrorCode")
				{
					ValidationErrorCode = int.Parse(xItem.Value);
				}
				else if (localName == "errorInformation")
				{
					ErrorInformation = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FeedAttributeIds != null)
			{
				foreach (var feedAttributeIdsItem in FeedAttributeIds)
				{
					xItem = new XElement(XName.Get("feedAttributeIds", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(feedAttributeIdsItem.ToString());
					xE.Add(xItem);
				}
			}
			if (ValidationErrorCode != null)
			{
				xItem = new XElement(XName.Get("validationErrorCode", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ValidationErrorCode.Value.ToString());
				xE.Add(xItem);
			}
			if (ErrorInformation != null)
			{
				xItem = new XElement(XName.Get("errorInformation", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ErrorInformation);
				xE.Add(xItem);
			}
		}
	}
}
