using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Object representing integer comparison operations. This is usually used within
	/// a particular {@link SearchParameter} to specify the valid values requested for the specific
	/// {@link Attribute}.
	/// </summary>
	public class LongComparisonOperation : ISoapable
	{
		/// <summary>
		/// The minimum value of elements returned by this operation (inclusive).
		/// </summary>
		public long? Minimum { get; set; }
		/// <summary>
		/// The maximum value of elements returned by this operation (inclusive).
		/// </summary>
		public long? Maximum { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Minimum = null;
			Maximum = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "minimum")
				{
					Minimum = long.Parse(xItem.Value);
				}
				else if (localName == "maximum")
				{
					Maximum = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Minimum != null)
			{
				xItem = new XElement(XName.Get("minimum", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(Minimum.Value.ToString());
				xE.Add(xItem);
			}
			if (Maximum != null)
			{
				xItem = new XElement(XName.Get("maximum", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(Maximum.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
