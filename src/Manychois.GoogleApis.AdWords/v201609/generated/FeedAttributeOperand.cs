using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a feed attribute reference to use in a function.
	/// </summary>
	public class FeedAttributeOperand : FunctionArgumentOperand, ISoapable
	{
		/// <summary>
		/// Id of associated feed.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? FeedId { get; set; }
		/// <summary>
		/// Id of the referenced feed attribute.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? FeedAttributeId { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			FeedId = null;
			FeedAttributeId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "feedId")
				{
					FeedId = long.Parse(xItem.Value);
				}
				else if (localName == "feedAttributeId")
				{
					FeedAttributeId = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "FeedAttributeOperand");
			XElement xItem = null;
			if (FeedId != null)
			{
				xItem = new XElement(XName.Get("feedId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedId.Value.ToString());
				xE.Add(xItem);
			}
			if (FeedAttributeId != null)
			{
				xItem = new XElement(XName.Get("feedAttributeId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedAttributeId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
