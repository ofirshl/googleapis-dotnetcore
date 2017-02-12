using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class ReportDefinition : ISoapable
	{
		public long? Id { get; set; }
		public Selector Selector { get; set; }
		public string ReportName { get; set; }
		public ReportDefinitionReportType ReportType { get; set; }
		public ReportDefinitionDateRangeType DateRangeType { get; set; }
		public DownloadFormat DownloadFormat { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "selector")
				{
					Selector = new Selector();
					Selector.ReadFrom(xItem);
				}
				else if (localName == "reportName")
				{
					ReportName = xItem.Value;
				}
				else if (localName == "reportType")
				{
					ReportType = ReportDefinitionReportTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "dateRangeType")
				{
					DateRangeType = ReportDefinitionDateRangeTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "downloadFormat")
				{
					DownloadFormat = DownloadFormatExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			xItem = new XElement(XName.Get("selector", "https://adwords.google.com/api/adwords/cm/v201609"));
			Selector.WriteTo(xItem);
			xE.Add(xItem);
			xItem = new XElement(XName.Get("reportName", "https://adwords.google.com/api/adwords/cm/v201609"));
			xItem.Add(ReportName);
			xE.Add(xItem);
			xItem = new XElement(XName.Get("reportType", "https://adwords.google.com/api/adwords/cm/v201609"));
			xItem.Add(ReportType.ToXmlValue());
			xE.Add(xItem);
			xItem = new XElement(XName.Get("dateRangeType", "https://adwords.google.com/api/adwords/cm/v201609"));
			xItem.Add(DateRangeType.ToXmlValue());
			xE.Add(xItem);
			xItem = new XElement(XName.Get("downloadFormat", "https://adwords.google.com/api/adwords/cm/v201609"));
			xItem.Add(DownloadFormat.ToXmlValue());
			xE.Add(xItem);
		}
	}
}
