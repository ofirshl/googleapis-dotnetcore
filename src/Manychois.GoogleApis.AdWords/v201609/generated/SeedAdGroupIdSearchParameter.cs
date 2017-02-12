using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A {@link SearchParameter} for {@code KEYWORD} {@link IdeaType}s
	/// that specifies that the supplied AdGroup should be used as a seed
	/// for generating new ideas. For example, an AdGroup's keywords
	/// would be used to generate new and related keywords.
	/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
	/// <p>This element is supported by following {@link RequestType}s: IDEAS.
	/// </summary>
	public class SeedAdGroupIdSearchParameter : SearchParameter, ISoapable
	{
		/// <summary>
		/// The id for the ad group that should be used as a seed for generating new ideas.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? AdGroupId { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			AdGroupId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "adGroupId")
				{
					AdGroupId = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "SeedAdGroupIdSearchParameter");
			XElement xItem = null;
			if (AdGroupId != null)
			{
				xItem = new XElement(XName.Get("adGroupId", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(AdGroupId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
