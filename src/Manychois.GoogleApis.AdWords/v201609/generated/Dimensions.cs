using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a simple height-width dimension.
	/// </summary>
	public class Dimensions : ISoapable
	{
		/// <summary>
		/// Width of the dimension
		/// <span class="constraint Selectable">This field can be selected using the value "Width".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public int? Width { get; set; }
		/// <summary>
		/// Height of the dimension
		/// <span class="constraint Selectable">This field can be selected using the value "Height".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public int? Height { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Width = null;
			Height = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "width")
				{
					Width = int.Parse(xItem.Value);
				}
				else if (localName == "height")
				{
					Height = int.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Width != null)
			{
				xItem = new XElement(XName.Get("width", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Width.Value.ToString());
				xE.Add(xItem);
			}
			if (Height != null)
			{
				xItem = new XElement(XName.Get("height", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Height.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
