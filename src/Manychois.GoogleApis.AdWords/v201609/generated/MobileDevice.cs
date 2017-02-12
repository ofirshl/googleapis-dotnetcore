using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a Mobile Device Criterion.
	/// <p>A criterion of this type can only be created using an ID.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class MobileDevice : Criterion, ISoapable
	{
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string DeviceName { get; set; }
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string ManufacturerName { get; set; }
		/// <summary>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public MobileDeviceDeviceType? DeviceType { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "OperatingSystemName".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string OperatingSystemName { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			DeviceName = null;
			ManufacturerName = null;
			DeviceType = null;
			OperatingSystemName = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "deviceName")
				{
					DeviceName = xItem.Value;
				}
				else if (localName == "manufacturerName")
				{
					ManufacturerName = xItem.Value;
				}
				else if (localName == "deviceType")
				{
					DeviceType = MobileDeviceDeviceTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "operatingSystemName")
				{
					OperatingSystemName = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "MobileDevice");
			XElement xItem = null;
			if (DeviceName != null)
			{
				xItem = new XElement(XName.Get("deviceName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DeviceName);
				xE.Add(xItem);
			}
			if (ManufacturerName != null)
			{
				xItem = new XElement(XName.Get("manufacturerName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ManufacturerName);
				xE.Add(xItem);
			}
			if (DeviceType != null)
			{
				xItem = new XElement(XName.Get("deviceType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DeviceType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (OperatingSystemName != null)
			{
				xItem = new XElement(XName.Get("operatingSystemName", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(OperatingSystemName);
				xE.Add(xItem);
			}
		}
	}
}
