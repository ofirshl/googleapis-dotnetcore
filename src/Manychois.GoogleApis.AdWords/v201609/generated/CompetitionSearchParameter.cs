using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A {@link SearchParameter} for {@code KEYWORD} {@link IdeaType}s used to
	/// filter the results by the amount of competition (eg: LOW, MEDIUM, HIGH).
	/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
	/// <p>This element is supported by following {@link RequestType}s: IDEAS, STATS.
	/// </summary>
	public class CompetitionSearchParameter : SearchParameter, ISoapable
	{
		/// <summary>
		/// A set of {@link Level}s indicating a relative amount of competition that
		/// {@code KEYWORD} {@link IdeaType}s should have in the  results.
		/// <span class="constraint ContentsDistinct">This field must contain distinct elements.</span>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<CompetitionSearchParameterLevel> Levels { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Levels = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "levels")
				{
					if (Levels == null) Levels = new List<CompetitionSearchParameterLevel>();
					Levels.Add(CompetitionSearchParameterLevelExtensions.Parse(xItem.Value));
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "CompetitionSearchParameter");
			XElement xItem = null;
			if (Levels != null)
			{
				foreach (var levelsItem in Levels)
				{
					xItem = new XElement(XName.Get("levels", "https://adwords.google.com/api/adwords/o/v201609"));
					xItem.Add(levelsItem.ToXmlValue());
					xE.Add(xItem);
				}
			}
		}
	}
}
