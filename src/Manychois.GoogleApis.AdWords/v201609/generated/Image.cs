using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Encapsulates an Image media. For {@code SET},{@code REMOVE} operations in
	/// MediaService, use {@code mediaId}.
	/// </summary>
	public class Image : Media, ISoapable
	{
		/// <summary>
		/// Raw image data.
		/// </summary>
		public byte[] Data { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Data = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "data")
				{
					Data = Convert.FromBase64String(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "Image");
			XElement xItem = null;
			if (Data != null)
			{
				xItem = new XElement(XName.Get("data", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Convert.ToBase64String(Data));
				xE.Add(xItem);
			}
		}
	}
}
