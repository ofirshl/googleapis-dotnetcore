using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Manychois.GoogleApis.DevConsole.AdWords
{
	class WsdlService
	{
		private List<WsdlServicePort> _ports = new List<WsdlServicePort>();
		public XmlQualifiedName XName { get; set; }
		public string CodeName { get; set; }
		public IList<WsdlServicePort> Ports { get { return _ports; } }
	}

	class WsdlServicePort
	{
		public WsdlBinding Binding { get; set; }
		public string SoapLocation { get; set; }
	}
}
