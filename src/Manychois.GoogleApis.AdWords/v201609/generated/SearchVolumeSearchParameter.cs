using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A {@link SearchParameter} that specifies the level of search volume expected in results,
	/// and it has a direct relationship to {@link AttributeType#SEARCH_VOLUME SEARCH_VOLUME}. Absence of
	/// a {@link SearchVolumeSearchParameter} in a {@link TargetingIdeaSelector} is equivalent to having
	/// no constraint on search volume specified.
	/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
	/// <p>This element is supported by following {@link RequestType}s: IDEAS, STATS.
	/// </summary>
	public class SearchVolumeSearchParameter : SearchParameter, ISoapable
	{
		/// <summary>
		/// Used to specify the range of search volume.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public LongComparisonOperation Operation { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Operation = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operation")
				{
					Operation = new LongComparisonOperation();
					Operation.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "SearchVolumeSearchParameter");
			XElement xItem = null;
			if (Operation != null)
			{
				xItem = new XElement(XName.Get("operation", "https://adwords.google.com/api/adwords/o/v201609"));
				Operation.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
