﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// {@link Attribute} type that contains a boolean value.
	/// </summary>
	public class BooleanAttribute : Attribute, ISoapable
	{
		/// <summary>
		/// Boolean value contained by this {@link Attribute}.
		/// </summary>
		public bool? Value { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Value = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "value")
				{
					Value = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "BooleanAttribute");
			XElement xItem = null;
			if (Value != null)
			{
				xItem = new XElement(XName.Get("value", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(Value.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
