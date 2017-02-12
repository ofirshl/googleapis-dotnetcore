using System;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// The API error base class that provides details about an error that occurred
	/// while processing a service request.
	///
	/// <p>The OGNL field path is provided for parsers to identify the request data
	/// element that may have caused the error.</p>
	/// </summary>
	public abstract class ApiError : Exception, ISoapable
	{
		public override string Message { get { return ErrorString; } }
		/// <summary>
		/// The OGNL field path to identify cause of error.
		/// </summary>
		public string FieldPath { get; set; }
		/// <summary>
		/// The data that caused the error.
		/// </summary>
		public string Trigger { get; set; }
		/// <summary>
		/// A simple string representation of the error and reason.
		/// </summary>
		public string ErrorString { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of ApiError.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string ApiErrorType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FieldPath = null;
			Trigger = null;
			ErrorString = null;
			ApiErrorType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "fieldPath")
				{
					FieldPath = xItem.Value;
				}
				else if (localName == "trigger")
				{
					Trigger = xItem.Value;
				}
				else if (localName == "errorString")
				{
					ErrorString = xItem.Value;
				}
				else if (localName == "ApiError.Type")
				{
					ApiErrorType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FieldPath != null)
			{
				xItem = new XElement(XName.Get("fieldPath", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FieldPath);
				xE.Add(xItem);
			}
			if (Trigger != null)
			{
				xItem = new XElement(XName.Get("trigger", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Trigger);
				xE.Add(xItem);
			}
			if (ErrorString != null)
			{
				xItem = new XElement(XName.Get("errorString", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ErrorString);
				xE.Add(xItem);
			}
			if (ApiErrorType != null)
			{
				xItem = new XElement(XName.Get("ApiError.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ApiErrorType);
				xE.Add(xItem);
			}
		}
	}
}
