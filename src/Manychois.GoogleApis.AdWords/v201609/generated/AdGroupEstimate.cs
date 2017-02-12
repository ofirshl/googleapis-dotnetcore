using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents the estimate results for a single ad group.
	/// </summary>
	public class AdGroupEstimate : Estimate, ISoapable
	{
		/// <summary>
		/// The adGroupId of the ad group specified in the request.
		///
		/// This will be <code>null</code> for new ad groups.
		/// </summary>
		public long? AdGroupId { get; set; }
		/// <summary>
		/// The estimates for the keywords specified in the request.
		///
		/// The list of estimates are returned in the same order as the keywords that
		/// were sent in the request.
		/// </summary>
		public List<KeywordEstimate> KeywordEstimates { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			AdGroupId = null;
			KeywordEstimates = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "adGroupId")
				{
					AdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "keywordEstimates")
				{
					if (KeywordEstimates == null) KeywordEstimates = new List<KeywordEstimate>();
					var keywordEstimatesItem = new KeywordEstimate();
					keywordEstimatesItem.ReadFrom(xItem);
					KeywordEstimates.Add(keywordEstimatesItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "AdGroupEstimate");
			XElement xItem = null;
			if (AdGroupId != null)
			{
				xItem = new XElement(XName.Get("adGroupId", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(AdGroupId.Value.ToString());
				xE.Add(xItem);
			}
			if (KeywordEstimates != null)
			{
				foreach (var keywordEstimatesItem in KeywordEstimates)
				{
					xItem = new XElement(XName.Get("keywordEstimates", "https://adwords.google.com/api/adwords/o/v201609"));
					keywordEstimatesItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
