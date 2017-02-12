using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an Operating System Version Criterion.
	/// <a href="/adwords/api/docs/appendix/mobileplatforms">View the complete
	/// list of available mobile platforms</a>. You can also get the list from
	/// {@link ConstantDataService#getOperatingSystemVersionCriterion ConstantDataService}.
	/// <p>A criterion of this type can only be created using an ID.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class OperatingSystemVersion : Criterion, ISoapable
	{
		/// <summary>
		/// The name of the operating system.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The OS Major Version number.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public int? OsMajorVersion { get; set; }
		/// <summary>
		/// The OS Minor Version number.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public int? OsMinorVersion { get; set; }
		/// <summary>
		/// The operator type.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public OperatingSystemVersionOperatorType? OperatorType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Name = null;
			OsMajorVersion = null;
			OsMinorVersion = null;
			OperatorType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "osMajorVersion")
				{
					OsMajorVersion = int.Parse(xItem.Value);
				}
				else if (localName == "osMinorVersion")
				{
					OsMinorVersion = int.Parse(xItem.Value);
				}
				else if (localName == "operatorType")
				{
					OperatorType = OperatingSystemVersionOperatorTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "OperatingSystemVersion");
			XElement xItem = null;
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (OsMajorVersion != null)
			{
				xItem = new XElement(XName.Get("osMajorVersion", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OsMajorVersion.Value.ToString());
				xE.Add(xItem);
			}
			if (OsMinorVersion != null)
			{
				xItem = new XElement(XName.Get("osMinorVersion", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OsMinorVersion.Value.ToString());
				xE.Add(xItem);
			}
			if (OperatorType != null)
			{
				xItem = new XElement(XName.Get("operatorType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OperatorType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
