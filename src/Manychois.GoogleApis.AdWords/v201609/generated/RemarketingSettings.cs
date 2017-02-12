using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Customer-wide settings related to AdWords remarketing.
	/// </summary>
	public class RemarketingSettings : ISoapable
	{
		/// <summary>
		/// The Adwords remarketing tag snippet for the customer.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Snippet { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Snippet = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "snippet")
				{
					Snippet = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Snippet != null)
			{
				xItem = new XElement(XName.Get("snippet", "https://adwords.google.com/api/adwords/mcm/v201609"));
				xItem.Add(Snippet);
				xE.Add(xItem);
			}
		}
	}
}
