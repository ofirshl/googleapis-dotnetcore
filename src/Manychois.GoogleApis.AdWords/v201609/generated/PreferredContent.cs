using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a PreferredContent criterion.
	///
	/// <p>Possible IDs: {@code 400} ({@code YOUTUBE_TOP_CONTENT}).</p>
	/// <p>A criterion of this type can only be created using an ID.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class PreferredContent : Criterion, ISoapable
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
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "PreferredContent");
		}
	}
}
