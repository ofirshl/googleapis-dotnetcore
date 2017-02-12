using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains a list of AccountLabels.
	/// </summary>
	public class AccountLabelReturnValue : ISoapable
	{
		/// <summary>
		/// List of account labels.
		/// </summary>
		public List<AccountLabel> Labels { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Labels = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "labels")
				{
					if (Labels == null) Labels = new List<AccountLabel>();
					var labelsItem = new AccountLabel();
					labelsItem.ReadFrom(xItem);
					Labels.Add(labelsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Labels != null)
			{
				foreach (var labelsItem in Labels)
				{
					xItem = new XElement(XName.Get("labels", "https://adwords.google.com/api/adwords/mcm/v201609"));
					labelsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
