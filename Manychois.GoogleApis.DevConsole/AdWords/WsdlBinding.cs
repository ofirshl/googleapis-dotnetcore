using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Xml;

namespace Manychois.GoogleApis.DevConsole.AdWords
{
	class WsdlBinding
	{
		private List<WsdlOperationBinding> _operations = new List<WsdlOperationBinding>();
		public string CodeName { get; set; }
		public XmlQualifiedName XName { get; set; }
		public WsdlPortType PortType { get; set; }
		public IList<WsdlOperationBinding> Operations { get { return _operations; } }
		public ServiceDescription Wsdl { get; set; }
	}

	class WsdlOperationBinding
	{
		public string Name { get; set; }

		public string SoapAction { get; set; }

		public WsdlType InputSoapHeader { get; set; }

		public WsdlType OutputSoapHeader { get; set; }
	}
}
