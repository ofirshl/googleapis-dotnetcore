using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Base class for all bids.
	/// </summary>
	public abstract class Bids : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of Bids.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string BidsType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			BidsType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "Bids.Type")
				{
					BidsType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (BidsType != null)
			{
				xItem = new XElement(XName.Get("Bids.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BidsType);
				xE.Add(xItem);
			}
		}
	}
}
