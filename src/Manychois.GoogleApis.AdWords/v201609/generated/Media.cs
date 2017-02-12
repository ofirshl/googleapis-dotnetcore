using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents some kind of media.
	/// </summary>
	public class Media : ISoapable
	{
		/// <summary>
		/// ID of this media object.
		/// <span class="constraint Selectable">This field can be selected using the value "MediaId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET, REMOVE.</span>
		/// </summary>
		public long? MediaId { get; set; }
		/// <summary>
		/// Type of media object. Required when using {@link MediaService#upload} to upload a new media
		/// file.
		/// <span class="constraint Selectable">This field can be selected using the value "Type".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// </summary>
		public MediaMediaType? Type { get; set; }
		/// <summary>
		/// Media reference ID key.
		/// <span class="constraint Selectable">This field can be selected using the value "ReferenceId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// </summary>
		public long? ReferenceId { get; set; }
		/// <summary>
		/// Various dimension sizes for the media. Only applies to image media (and video media for
		/// video thumbnails).
		/// <span class="constraint Selectable">This field can be selected using the value "Dimensions".</span>
		/// </summary>
		public List<Media_Size_DimensionsMapEntry> Dimensions { get; set; }
		/// <summary>
		/// URLs pointing to the resized media for the given sizes. Only applies to image media.
		/// <span class="constraint Selectable">This field can be selected using the value "Urls".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<Media_Size_StringMapEntry> Urls { get; set; }
		/// <summary>
		/// The mime type of the media.
		/// <span class="constraint Selectable">This field can be selected using the value "MimeType".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// </summary>
		public MediaMimeType? MimeType { get; set; }
		/// <summary>
		/// The URL of where the original media was downloaded from (or a file name).
		/// <span class="constraint Selectable">This field can be selected using the value "SourceUrl".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// </summary>
		public string SourceUrl { get; set; }
		/// <summary>
		/// The name of the media. The name can be used by clients to
		/// help identify previously uploaded media.
		/// <span class="constraint Selectable">This field can be selected using the value "Name".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The size of the media file in bytes.
		/// <span class="constraint Selectable">This field can be selected using the value "FileSize".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// </summary>
		public long? FileSize { get; set; }
		/// <summary>
		/// Media creation date in the format YYYY-MM-DD HH:MM:SS+TZ.
		/// This is not updatable and not specifiable.
		/// <span class="constraint Selectable">This field can be selected using the value "CreationTime".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE and SET.</span>
		/// </summary>
		public string CreationTime { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of Media.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string MediaType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			MediaId = null;
			Type = null;
			ReferenceId = null;
			Dimensions = null;
			Urls = null;
			MimeType = null;
			SourceUrl = null;
			Name = null;
			FileSize = null;
			CreationTime = null;
			MediaType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "mediaId")
				{
					MediaId = long.Parse(xItem.Value);
				}
				else if (localName == "type")
				{
					Type = MediaMediaTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "referenceId")
				{
					ReferenceId = long.Parse(xItem.Value);
				}
				else if (localName == "dimensions")
				{
					if (Dimensions == null) Dimensions = new List<Media_Size_DimensionsMapEntry>();
					var dimensionsItem = new Media_Size_DimensionsMapEntry();
					dimensionsItem.ReadFrom(xItem);
					Dimensions.Add(dimensionsItem);
				}
				else if (localName == "urls")
				{
					if (Urls == null) Urls = new List<Media_Size_StringMapEntry>();
					var urlsItem = new Media_Size_StringMapEntry();
					urlsItem.ReadFrom(xItem);
					Urls.Add(urlsItem);
				}
				else if (localName == "mimeType")
				{
					MimeType = MediaMimeTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "sourceUrl")
				{
					SourceUrl = xItem.Value;
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "fileSize")
				{
					FileSize = long.Parse(xItem.Value);
				}
				else if (localName == "creationTime")
				{
					CreationTime = xItem.Value;
				}
				else if (localName == "Media.Type")
				{
					MediaType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (MediaId != null)
			{
				xItem = new XElement(XName.Get("mediaId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(MediaId.Value.ToString());
				xE.Add(xItem);
			}
			if (Type != null)
			{
				xItem = new XElement(XName.Get("type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Type.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ReferenceId != null)
			{
				xItem = new XElement(XName.Get("referenceId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ReferenceId.Value.ToString());
				xE.Add(xItem);
			}
			if (Dimensions != null)
			{
				foreach (var dimensionsItem in Dimensions)
				{
					xItem = new XElement(XName.Get("dimensions", "https://adwords.google.com/api/adwords/cm/v201609"));
					dimensionsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (Urls != null)
			{
				foreach (var urlsItem in Urls)
				{
					xItem = new XElement(XName.Get("urls", "https://adwords.google.com/api/adwords/cm/v201609"));
					urlsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (MimeType != null)
			{
				xItem = new XElement(XName.Get("mimeType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(MimeType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (SourceUrl != null)
			{
				xItem = new XElement(XName.Get("sourceUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SourceUrl);
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (FileSize != null)
			{
				xItem = new XElement(XName.Get("fileSize", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FileSize.Value.ToString());
				xE.Add(xItem);
			}
			if (CreationTime != null)
			{
				xItem = new XElement(XName.Get("creationTime", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CreationTime);
				xE.Add(xItem);
			}
			if (MediaType != null)
			{
				xItem = new XElement(XName.Get("Media.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(MediaType);
				xE.Add(xItem);
			}
		}
	}
}
