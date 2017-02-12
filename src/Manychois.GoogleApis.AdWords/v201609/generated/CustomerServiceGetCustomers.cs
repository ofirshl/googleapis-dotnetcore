using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns details of all the customers directly accessible by the user authenticating the call.
	/// <p>
	/// Starting with v201607, if {@code clientCustomerId} is specified in the request header,
	/// only details of that customer will be returned. To do this for prior versions, use the
	/// {@code get()} method instead.
	/// </summary>
	internal class CustomerServiceGetCustomers : ISoapable
	{
		public virtual void ReadFrom(XElement xE)
		{
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
			}
		}
		public virtual void WriteTo(XElement xE)
		{
		}
	}
}
