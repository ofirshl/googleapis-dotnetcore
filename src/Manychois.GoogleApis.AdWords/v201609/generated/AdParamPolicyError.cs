using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Policy violation for an AdParam.
	/// </summary>
	public class AdParamPolicyError : PolicyViolationError, ISoapable
	{
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AdParamPolicyError");
		}
	}
}
