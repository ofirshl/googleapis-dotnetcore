using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace Manychois.GoogleApis.Tests
{
	public class XmlUtilityTest
	{
		[Theory, MemberData(nameof(GetXmlTypeLocalNameData))]
		public void TestGetXmlTypeLocalName(XElement xE, string expectedType)
		{
			Assert.Equal(expectedType, XmlUtility.GetXmlTypeLocalName(xE));
		}

		public static IEnumerable<object[]> GetXmlTypeLocalNameData
		{
			get
			{
				var xE = new XElement(XName.Get("a", ""));
				yield return new object[] { xE, null };

				xE = new XElement(XName.Get("b", ""));
				xE.Add(new XAttribute(XmlUtility.XsiTypeXName, "TypeA"));
				yield return new object[] { xE, "TypeA" };

				xE = new XElement(XName.Get("c", "http://abc.com"));
				xE.Add(new XAttribute(XName.Get("ns1", XNamespace.Xmlns.NamespaceName), "http://abc.com"));
				xE.Add(new XAttribute(XmlUtility.XsiTypeXName, "ns1:TypeB"));
				yield return new object[] { xE, "TypeB" };
			}
		}

		[Theory, MemberData(nameof(SetXsiTypeData))]
		public void TestSetXsiType(XElement xE, string namespaceName, string typeName, string expectedPattern)
		{
			var xType = XmlUtility.SetXsiType(xE, namespaceName, typeName);
			Assert.True(new Regex(expectedPattern).IsMatch(xType.Value), $"Returned type value: {xType.Value}");
		}

		public static IEnumerable<object[]> SetXsiTypeData
		{
			get
			{
				var xE = new XElement(XName.Get("a", ""));
				yield return new object[] { xE, null, "TypeA", "TypeA" };

				xE = new XElement(XName.Get("b", ""));
				yield return new object[] { xE, "", "TypeB", "TypeB" };

				xE = new XElement(XName.Get("c", ""));
				yield return new object[] { xE, "http://abc.com", "TypeC", @"ns\d+:TypeC" };

				xE = new XElement(XName.Get("d", ""));
				xE.Add(new XAttribute(XName.Get("ns1", XNamespace.Xmlns.NamespaceName), "http://abc.com"));
				xE.Add(new XAttribute(XName.Get("ns2", XNamespace.Xmlns.NamespaceName), "http://abcd.com"));
				yield return new object[] { xE, "http://abcd.com", "TypeD", "ns2:TypeD" };

				xE = new XElement(XName.Get("e", ""));
				xE.Add(new XAttribute(XmlUtility.XsiTypeXName, "Type1"));
				yield return new object[] { xE, null, "TypeE", "TypeE" };
			}
		}

		[Theory, MemberData(nameof(ConvertToStringData))]
		public void TestConvertToString(XDocument xDoc, SaveOptions saveOptions, string expected)
		{
			string result = XmlUtility.ConvertToString(xDoc, saveOptions);
			Assert.Equal(expected, result);
		}

		public static IEnumerable<object[]> ConvertToStringData
		{
			get
			{
				var xDocXml = @"<?xml version=""1.0"" encoding=""utf-8"" standalone=""no""?>
<note>
  <to>Tove</to>
  <from>Jani</from>
  <heading>Reminder</heading>
  <body>Don't forget me this weekend!</body>
</note>";
				var xDoc = XDocument.Parse(xDocXml);
				yield return new object[] { xDoc, SaveOptions.None, xDocXml };

				xDocXml = @"<?xml version=""1.0"" encoding=""utf-8"" standalone=""no""?><note><to>Tove</to><from>Jani</from></note>";
				xDoc = XDocument.Parse(xDocXml);
				yield return new object[] { xDoc, SaveOptions.DisableFormatting, xDocXml };
			}
		}
	}
}
