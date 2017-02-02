using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Xml;

namespace Manychois.GoogleApis.DevConsole.AdWords
{
	class WsdlPortType
	{
		private List<WsdlPortTypeOperation> _operations = new List<WsdlPortTypeOperation>();
		public ServiceDescription Wsdl { get; set; }
		public string CodeName { get; set; }
		public string Documentation { get; set; }
		public XmlQualifiedName XName { get; set; }
		public IList<WsdlPortTypeOperation> Operations { get { return _operations; } }
	}

	class WsdlPortTypeOperation
	{
		public string Name { get; set; }
		public string CodeName { get; set; }
		public string Documentation { get; set; }
		public WsdlType InputElement { get; set; }
		public WsdlType OutputElement { get; set; }
		public WsdlType FaultElement { get; set; }
	}
}
