using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// {@link SearchParameter} that specifies whether adult content should be
	/// returned.<p>
	///
	/// Presence of this {@link SearchParameter} will allow adult keywords
	/// to be included in the results.
	/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
	/// <p>This element is supported by following {@link RequestType}s: IDEAS, STATS.
	/// </summary>
	public class IncludeAdultContentSearchParameter : SearchParameter, ISoapable
	{
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "IncludeAdultContentSearchParameter");
		}
	}
}
