using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manychois.GoogleApis
{
	public static class XmlUtility
	{
		public const string NsXsi = "http://www.w3.org/2001/XMLSchema-instance";
		public static readonly XName XsiTypeXName = XName.Get("type", NsXsi);
		public static string GetXmlTypeLocalName(XElement xElement)
		{
			var xAttr = xElement.Attribute(XsiTypeXName);
			if (xAttr == null) return null;
			string value = xElement.Attribute(XsiTypeXName).Value;
			if (value.Contains(':'))
			{
				return value.Substring(value.IndexOf(':') + 1);
			}
			else
			{
				return value;
			}
		}
		public static void SetXsiType(XElement xE, string namespaceName, string typeName)
		{
			var xAttr = xE.Attribute(XsiTypeXName);
			string value;
			if (string.IsNullOrEmpty(namespaceName))
			{
				value = typeName;
			}
			else
			{
				var prefix = xE.GetPrefixOfNamespace(XNamespace.Get(namespaceName));
				if (string.IsNullOrEmpty(prefix))
				{
					var rand = new Random();
					XAttribute xNs = null;
					do
					{
						prefix = $"ns{rand.Next(1000)}";
						var xname = XName.Get(prefix, XNamespace.Xmlns.NamespaceName);
						xNs = xE.Attribute(xname);
						if (xNs == null)
						{
							xE.Add(new XAttribute(xname, namespaceName));
							break;
						}
					} while (xNs == null);
				}
				value = $"{prefix}:{typeName}";
			}
			if (xAttr == null)
			{
				xAttr = new XAttribute(XsiTypeXName, value);
				xE.Add(xAttr);
			}
			else
			{
				xAttr.Value = value;
			}
		}
		public static string ConvertToString(XDocument xDoc, SaveOptions saveOptions)
		{
			var sb = new StringBuilder();
			using (var writer = new Utf8StringWriter(sb))
			{
				xDoc.Save(writer, saveOptions);
			}
			return sb.ToString();
		}

		private class Utf8StringWriter : StringWriter
		{
			public Utf8StringWriter(StringBuilder sb) : base(sb) { }

			public override Encoding Encoding { get { return Encoding.UTF8; } }
		}

	}
}
