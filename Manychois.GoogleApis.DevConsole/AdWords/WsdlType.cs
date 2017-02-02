using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Xml;

namespace Manychois.GoogleApis.DevConsole.AdWords
{
	class WsdlType
	{
		public WsdlType()
		{
			Properties = new List<WsdlTypeProperty>();
		}
		public XmlQualifiedName XName { get; set; }

		public string CodeName { get; set; }

		public string Documentation { get; set; }

		public bool IsPrimitiveType { get; set; }

		public bool IsEnum { get; set; }

		public bool IsAbstract { get; set; }

		public XmlQualifiedName BaseTypeXName { get; set; }
		public WsdlType BaseType { get; set; }

		public IList<WsdlTypeProperty> Properties { get; }

	}

	class WsdlEnumType : WsdlType
	{
		public WsdlEnumType()
		{
			IsPrimitiveType = true;
			IsEnum = true;
			Items = new List<WsdlEnumItem>();
		}

		public IList<WsdlEnumItem> Items { get; }
	}

	class WsdlEnumItem
	{
		public string Name { get; set; }
		public string Documentation { get; set; }
		public string CodeName { get; set; }
	}

	class WsdlTypeProperty
	{
		public XmlQualifiedName XName { get; set; }

		public string CodeName { get; set; }
		public string Documentation { get; set; }

		public WsdlType DataType { get; set; }
		public bool AllowNull { get; set; }
		public bool AllowMultiple { get; set; }
		public bool IsTypeProperty { get; set; }
	}

	class WsdlElementType : WsdlType
	{
		public ServiceDescription Wsdl { get; set; }
	}
}
