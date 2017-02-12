using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A QueryError represents possible errors for query parsing and execution.
	/// </summary>
	public class QueryError : ApiError, ISoapable
	{
		public QueryErrorReason? Reason { get; set; }
		public string QueryErrorMessage { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Reason = null;
			QueryErrorMessage = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reason")
				{
					Reason = QueryErrorReasonExtensions.Parse(xItem.Value);
				}
				else if (localName == "message")
				{
					QueryErrorMessage = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "QueryError");
			XElement xItem = null;
			if (Reason != null)
			{
				xItem = new XElement(XName.Get("reason", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Reason.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (QueryErrorMessage != null)
			{
				xItem = new XElement(XName.Get("message", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(QueryErrorMessage);
				xE.Add(xItem);
			}
		}
	}
}
