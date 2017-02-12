using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns the available report fields for a given report type.
	/// When using this method the {@code clientCustomerId} header field is
	/// optional. Callers are discouraged from setting the clientCustomerId
	/// header field in calls to this method as its presence will trigger an
	/// authorization error if the caller does not have access to the customer
	/// with the included ID.
	///
	/// @param reportType The type of report.
	/// @return The list of available report fields. Each
	/// {@link ReportDefinitionField} encapsulates the field name, the
	/// field data type, and the enum values (if the field's type is
	/// {@code enum}).
	/// @throws ApiException if a problem occurred while fetching the
	/// ReportDefinitionField information.
	/// </summary>
	internal class ReportDefinitionServiceGetReportFields : ISoapable
	{
		/// <summary>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public ReportDefinitionReportType? ReportType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ReportType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "reportType")
				{
					ReportType = ReportDefinitionReportTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ReportType != null)
			{
				xItem = new XElement(XName.Get("reportType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ReportType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
