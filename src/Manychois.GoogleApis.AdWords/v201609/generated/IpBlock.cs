using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Criterion used for IP exclusions. We allow:
	///
	/// <ul>
	/// <li>IPv4 and IPv6 addresses</li>
	/// <li>individual addresses (192.168.0.1)</li>
	/// <li>CIDR IP address blocks (e.g., 1.2.3.0/24, 2001:db8::/32).
	/// </ul>
	///
	/// <p> Note that for a CIDR IP address block, the specified IP address portion must be properly
	/// truncated (i.e. all the host bits must be zero) or the input is considered malformed.
	/// For example, "1.2.3.0/24" is accepted but "1.2.3.4/24" is not.
	/// Similarly, for IPv6, "2001:db8::/32" is accepted whereas "2001:db8::1/32" is not.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class IpBlock : Criterion, ISoapable
	{
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "IpAddress".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public string IpAddress { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			IpAddress = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "ipAddress")
				{
					IpAddress = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "IpBlock");
			XElement xItem = null;
			if (IpAddress != null)
			{
				xItem = new XElement(XName.Get("ipAddress", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IpAddress);
				xE.Add(xItem);
			}
		}
	}
}
