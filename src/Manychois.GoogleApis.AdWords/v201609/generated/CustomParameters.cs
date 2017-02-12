using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// CustomParameters holds a list of CustomParameters to be treated as a map.
	/// It has a special field used to indicate that the current map should be cleared and replaced
	/// with this new map.
	/// </summary>
	public class CustomParameters : ISoapable
	{
		/// <summary>
		/// The list of custom parameters.
		///
		/// <p>On update, all parameters can be cleared by providing an empty or null list and setting
		/// doReplace to true.
		/// </summary>
		public List<CustomParameter> Parameters { get; set; }
		/// <summary>
		/// On SET operation, indicates that the current parameters should be cleared and replaced
		/// with these parameters.
		/// </summary>
		public bool? DoReplace { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Parameters = null;
			DoReplace = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "parameters")
				{
					if (Parameters == null) Parameters = new List<CustomParameter>();
					var parametersItem = new CustomParameter();
					parametersItem.ReadFrom(xItem);
					Parameters.Add(parametersItem);
				}
				else if (localName == "doReplace")
				{
					DoReplace = bool.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Parameters != null)
			{
				foreach (var parametersItem in Parameters)
				{
					xItem = new XElement(XName.Get("parameters", "https://adwords.google.com/api/adwords/cm/v201609"));
					parametersItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (DoReplace != null)
			{
				xItem = new XElement(XName.Get("doReplace", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DoReplace.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
