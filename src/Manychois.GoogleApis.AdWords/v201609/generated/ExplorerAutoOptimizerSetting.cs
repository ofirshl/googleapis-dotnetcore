using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Settings for the
	/// <a href="//support.google.com/adwords/answer/190596">Display Campaign Optimizer</a>,
	/// initially termed "Explorer".
	/// </summary>
	public class ExplorerAutoOptimizerSetting : Setting, ISoapable
	{
		public bool? OptIn { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			OptIn = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "optIn")
				{
					OptIn = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ExplorerAutoOptimizerSetting");
			XElement xItem = null;
			if (OptIn != null)
			{
				xItem = new XElement(XName.Get("optIn", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OptIn.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
