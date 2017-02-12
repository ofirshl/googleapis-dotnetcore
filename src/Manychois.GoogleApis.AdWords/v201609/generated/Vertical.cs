using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use verticals to target or exclude placements in the Google Display Network
	/// based on the category into which the placement falls (for example, "Pets &amp;
	/// Animals/Pets/Dogs").
	/// <a href="/adwords/api/docs/appendix/verticals">View the complete list
	/// of available vertical categories.</a>
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class Vertical : Criterion, ISoapable
	{
		/// <summary>
		/// Id of this vertical.
		/// <span class="constraint Selectable">This field can be selected using the value "VerticalId".</span>
		/// </summary>
		public long? VerticalId { get; set; }
		/// <summary>
		/// Id of the parent of this vertical.
		/// <span class="constraint Selectable">This field can be selected using the value "VerticalParentId".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? VerticalParentId { get; set; }
		/// <summary>
		/// The category to target or exclude. Each subsequent element in the array
		/// describes a more specific sub-category. For example,
		/// <code>{"Pets &amp; Animals", "Pets", "Dogs"}</code> represents the "Pets &amp;
		/// Animals/Pets/Dogs" category. A complete list of available vertical categories
		/// is available <a href="/adwords/api/docs/appendix/verticals">here</a>
		/// This field is required and must not be empty.
		/// <span class="constraint Selectable">This field can be selected using the value "Path".</span>
		/// </summary>
		public List<string> Path { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			VerticalId = null;
			VerticalParentId = null;
			Path = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "verticalId")
				{
					VerticalId = long.Parse(xItem.Value);
				}
				else if (localName == "verticalParentId")
				{
					VerticalParentId = long.Parse(xItem.Value);
				}
				else if (localName == "path")
				{
					if (Path == null) Path = new List<string>();
					Path.Add(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Vertical");
			XElement xItem = null;
			if (VerticalId != null)
			{
				xItem = new XElement(XName.Get("verticalId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(VerticalId.Value.ToString());
				xE.Add(xItem);
			}
			if (VerticalParentId != null)
			{
				xItem = new XElement(XName.Get("verticalParentId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(VerticalParentId.Value.ToString());
				xE.Add(xItem);
			}
			if (Path != null)
			{
				foreach (var pathItem in Path)
				{
					xItem = new XElement(XName.Get("path", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(pathItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
