using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a Review extension.
	/// </summary>
	public class ReviewFeedItem : ExtensionFeedItem, ISoapable
	{
		/// <summary>
		/// An exact quote or paraphrase from a third-party source.
		/// <span class="constraint StringLength">This string must not be empty, (trimmed).</span>
		/// </summary>
		public string ReviewText { get; set; }
		/// <summary>
		/// Name of the third-party publisher of the review.
		/// <span class="constraint StringLength">This string must not be empty, (trimmed).</span>
		/// </summary>
		public string ReviewSourceName { get; set; }
		/// <summary>
		/// Landing page of the third-party website of the review.
		/// <span class="constraint StringLength">This string must not be empty, (trimmed).</span>
		/// </summary>
		public string ReviewSourceUrl { get; set; }
		/// <summary>
		/// Indicates if your review is formatted as an exact quote. Use a value of false to indicate that
		/// the review is paraphrased. If not set, the value is treated as false.
		/// </summary>
		public bool? ReviewTextExactlyQuoted { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			ReviewText = null;
			ReviewSourceName = null;
			ReviewSourceUrl = null;
			ReviewTextExactlyQuoted = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reviewText")
				{
					ReviewText = xItem.Value;
				}
				else if (localName == "reviewSourceName")
				{
					ReviewSourceName = xItem.Value;
				}
				else if (localName == "reviewSourceUrl")
				{
					ReviewSourceUrl = xItem.Value;
				}
				else if (localName == "reviewTextExactlyQuoted")
				{
					ReviewTextExactlyQuoted = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ReviewFeedItem");
			XElement xItem = null;
			if (ReviewText != null)
			{
				xItem = new XElement(XName.Get("reviewText", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ReviewText);
				xE.Add(xItem);
			}
			if (ReviewSourceName != null)
			{
				xItem = new XElement(XName.Get("reviewSourceName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ReviewSourceName);
				xE.Add(xItem);
			}
			if (ReviewSourceUrl != null)
			{
				xItem = new XElement(XName.Get("reviewSourceUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ReviewSourceUrl);
				xE.Add(xItem);
			}
			if (ReviewTextExactlyQuoted != null)
			{
				xItem = new XElement(XName.Get("reviewTextExactlyQuoted", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ReviewTextExactlyQuoted.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
