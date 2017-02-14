using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Uploads new media. Currently, you can upload {@link Image} files and {@link MediaBundle}s.
	///
	/// @param media A list of {@code Media} objects, each containing the data to
	/// be uploaded.
	/// @return A list of uploaded media in the same order as the argument list.
	/// </summary>
	internal class MediaServiceUpload : ISoapable
	{
		public List<Media> Media { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Media = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "media")
				{
					if (Media == null) Media = new List<Media>();
					var mediaItem = InstanceCreator.CreateMedia(xItem);
					mediaItem.ReadFrom(xItem);
					Media.Add(mediaItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Media != null)
			{
				foreach (var mediaItem in Media)
				{
					xItem = new XElement(XName.Get("media", "https://adwords.google.com/api/adwords/cm/v201609"));
					mediaItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
