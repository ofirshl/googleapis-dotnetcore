using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Base type of criterion parameters.
	/// </summary>
	public abstract class CriterionParameter : ISoapable
	{
		/// <summary>
		/// Indicates that this instance is a subtype of CriterionParameter.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string CriterionParameterType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			CriterionParameterType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "CriterionParameter.Type")
				{
					CriterionParameterType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (CriterionParameterType != null)
			{
				xItem = new XElement(XName.Get("CriterionParameter.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CriterionParameterType);
				xE.Add(xItem);
			}
		}
	}
}
