using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Points to a substring within an ad field or criterion.
	/// </summary>
	public class PolicyViolationErrorPart : ISoapable
	{
		/// <summary>
		/// Index of the starting position of the violating text within the line.
		/// </summary>
		public int? Index { get; set; }
		/// <summary>
		/// The length of the violating text.
		/// </summary>
		public int? Length { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Index = null;
			Length = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "index")
				{
					Index = int.Parse(xItem.Value);
				}
				else if (localName == "length")
				{
					Length = int.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Index != null)
			{
				xItem = new XElement(XName.Get("index", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Index.Value.ToString());
				xE.Add(xItem);
			}
			if (Length != null)
			{
				xItem = new XElement(XName.Get("length", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Length.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
