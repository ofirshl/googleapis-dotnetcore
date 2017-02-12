using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Base class for exceptions.
	/// </summary>
	public class ApplicationException : ISoapable
	{
		/// <summary>
		/// Error message.
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of ApplicationException.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string ApplicationExceptionType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Message = null;
			ApplicationExceptionType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "message")
				{
					Message = xItem.Value;
				}
				else if (localName == "ApplicationException.Type")
				{
					ApplicationExceptionType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Message != null)
			{
				xItem = new XElement(XName.Get("message", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Message);
				xE.Add(xItem);
			}
			if (ApplicationExceptionType != null)
			{
				xItem = new XElement(XName.Get("ApplicationException.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ApplicationExceptionType);
				xE.Add(xItem);
			}
		}
	}
}
