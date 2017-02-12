using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A fault element of type ApiException.
	/// </summary>
	internal class AdGroupFeedServiceApiExceptionFault : ApplicationException, ISoapable
	{
		/// <summary>
		/// List of errors.
		/// </summary>
		public List<ApiError> Errors { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Errors = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "errors")
				{
					if (Errors == null) Errors = new List<ApiError>();
					var errorsItem = InstanceCreator.CreateApiError(xItem);
					errorsItem.ReadFrom(xItem);
					Errors.Add(errorsItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ApiExceptionFault");
			XElement xItem = null;
			if (Errors != null)
			{
				foreach (var errorsItem in Errors)
				{
					xItem = new XElement(XName.Get("errors", "https://adwords.google.com/api/adwords/cm/v201609"));
					errorsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
