using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an ImageAd.
	/// <span class="constraint AdxEnabled">This is enabled for AdX.</span>
	/// </summary>
	public class ImageAd : Ad, ISoapable
	{
		/// <summary>
		/// The image data for the ad.
		/// </summary>
		public Image Image { get; set; }
		/// <summary>
		/// The name label for this ad.
		/// <span class="constraint Required">
		/// This field is required and should not be {@code null}.</span>
		/// <span class="constraint Selectable">This field can be selected using the value "ImageCreativeName".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// For ADD operations only: use this field to specify an existing
		/// image ad to copy the image from, in which case the "image" field
		/// can be left empty. This is the preferred way of copying images
		/// over re-uploading the same image.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// </summary>
		public long? AdToCopyImageFrom { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Image = null;
			Name = null;
			AdToCopyImageFrom = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "image")
				{
					Image = new Image();
					Image.ReadFrom(xItem);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "adToCopyImageFrom")
				{
					AdToCopyImageFrom = long.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ImageAd");
			XElement xItem = null;
			if (Image != null)
			{
				xItem = new XElement(XName.Get("image", "https://adwords.google.com/api/adwords/cm/v201609"));
				Image.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (AdToCopyImageFrom != null)
			{
				xItem = new XElement(XName.Get("adToCopyImageFrom", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdToCopyImageFrom.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
