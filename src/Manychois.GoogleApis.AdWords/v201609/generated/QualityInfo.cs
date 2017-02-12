using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Container for criterion quality information.
	/// </summary>
	public class QualityInfo : ISoapable
	{
		/// <summary>
		/// The keyword quality score ranges from 1 (lowest) to 10 (highest).
		/// For v201509 and later, this field may be returned as NULL if AdWords
		/// does not have enough information to determine an appropriate quality
		/// score value.
		/// <span class="constraint Selectable">This field can be selected using the value "QualityScore".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public int? QualityScore { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			QualityScore = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "qualityScore")
				{
					QualityScore = int.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (QualityScore != null)
			{
				xItem = new XElement(XName.Get("qualityScore", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(QualityScore.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
