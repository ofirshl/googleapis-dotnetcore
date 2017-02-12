using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// CustomParameter is used to map a custom parameter key to its value.
	/// </summary>
	public class CustomParameter : ISoapable
	{
		/// <summary>
		/// The parameter key to be mapped.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 16, inclusive, in UTF-8 bytes, (trimmed).</span>
		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// The value this parameter should be mapped to. It should be null if isRemove is true.
		/// <span class="constraint StringLength">The length of this string should be between 0 and 200, inclusive, in UTF-8 bytes, (trimmed).</span>
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// On SET operation, indicates that the parameter should be removed from the existing parameters.
		/// If set to true, the value field must be null.
		/// </summary>
		public bool? IsRemove { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Key = null;
			Value = null;
			IsRemove = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "key")
				{
					Key = xItem.Value;
				}
				else if (localName == "value")
				{
					Value = xItem.Value;
				}
				else if (localName == "isRemove")
				{
					IsRemove = bool.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Key != null)
			{
				xItem = new XElement(XName.Get("key", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Key);
				xE.Add(xItem);
			}
			if (Value != null)
			{
				xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Value);
				xE.Add(xItem);
			}
			if (IsRemove != null)
			{
				xItem = new XElement(XName.Get("isRemove", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IsRemove.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
