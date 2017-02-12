using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Xml.Schema;

namespace Manychois.GoogleApis.DevConsole.AdWords
{
	class BuildTask
	{
		public void Run()
		{
			var wsdl = new WsdlStructure();
			foreach (var file in Directory.GetFiles(@"AdWords\v201609\wsdl", "*.wsdl")
				.OrderByDescending(x => x))
			{
				var set = new XmlSchemaSet();
				var sd = ServiceDescription.Read(file);
				foreach (XmlSchema s in sd.Types.Schemas)
				{
					set.Add(s);
				}
				set.Compile();
				wsdl.AddServiceDescription(sd);
			}
			using (var reader = new StreamReader(@"AdWords\v201609\reportDefinition.xsd", Encoding.UTF8))
			{
				var set = new XmlSchemaSet();
				XmlSchema reportDefXsd = XmlSchema.Read(reader, null);
				set.Add(reportDefXsd);
				set.Compile();
				wsdl.AddXmlSchema(reportDefXsd);
			}
			wsdl.Compile();

			var programmer = new Programmer();
			programmer.Code(wsdl, @"Manychois.GoogleApis.AdWords\v201609\generated", "Manychois.GoogleApis.AdWords.v201609");
		}
	}
}
