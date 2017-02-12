using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a ZIP archive media the content of which contains HTML5 assets.
	/// </summary>
	public class MediaBundle : Media, ISoapable
	{
		/// <summary>
		/// Raw zipped data.
		/// </summary>
		public byte[] Data { get; set; }
		/// <summary>
		/// URL pointing to the data for the MediaBundle data.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public string MediaBundleUrl { get; set; }
		/// <summary>
		/// Entry in the ZIP archive used to display the <code>MediaBundle</code> in an
		/// <code>Ad</code>. This field can only be set and returned when the <code>MediaBundle</code> is
		/// used with the <code>AdGroupAdService</code>. If this field is set when calling
		/// <code>MediaService</code>, an error will be returned.
		///
		/// <p>To use a <code>MediaBundle</code> that was created with the <code>MediaService</code> in
		/// an <code>Ad</code>, create a bundle and set the <code>mediaId</code> and
		/// <code>entryPoint</code> fields.
		/// </summary>
		public string EntryPoint { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Data = null;
			MediaBundleUrl = null;
			EntryPoint = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "data")
				{
					Data = Convert.FromBase64String(xItem.Value);
				}
				else if (localName == "mediaBundleUrl")
				{
					MediaBundleUrl = xItem.Value;
				}
				else if (localName == "entryPoint")
				{
					EntryPoint = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "MediaBundle");
			XElement xItem = null;
			if (Data != null)
			{
				xItem = new XElement(XName.Get("data", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Convert.ToBase64String(Data));
				xE.Add(xItem);
			}
			if (MediaBundleUrl != null)
			{
				xItem = new XElement(XName.Get("mediaBundleUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(MediaBundleUrl);
				xE.Add(xItem);
			}
			if (EntryPoint != null)
			{
				xItem = new XElement(XName.Get("entryPoint", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EntryPoint);
				xE.Add(xItem);
			}
		}
	}
}
