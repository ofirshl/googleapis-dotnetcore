using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Specifies the page of results to return in the response. A page is specified
	/// by the result position to start at and the maximum number of results to
	/// return.
	/// </summary>
	public class Paging : ISoapable
	{
		/// <summary>
		/// Index of the first result to return in this page.
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public int? StartIndex { get; set; }
		/// <summary>
		/// Maximum number of results to return in this page. Set this to a reasonable value to limit
		/// the number of results returned per page.
		/// <span class="constraint InRange">This field must be greater than or equal to 0.</span>
		/// </summary>
		public int? NumberResults { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			StartIndex = null;
			NumberResults = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "startIndex")
				{
					StartIndex = int.Parse(xItem.Value);
				}
				else if (localName == "numberResults")
				{
					NumberResults = int.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (StartIndex != null)
			{
				xItem = new XElement(XName.Get("startIndex", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StartIndex.Value.ToString());
				xE.Add(xItem);
			}
			if (NumberResults != null)
			{
				xItem = new XElement(XName.Get("numberResults", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(NumberResults.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
