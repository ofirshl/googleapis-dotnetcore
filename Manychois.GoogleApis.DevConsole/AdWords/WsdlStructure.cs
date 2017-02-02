using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Xml;
using System.Xml.Schema;

namespace Manychois.GoogleApis.DevConsole.AdWords
{
	class WsdlStructure
	{
		private static ILogger Log = LogManager.GetCurrentClassLogger();

		private Dictionary<ServiceDescription, Dictionary<string, WsdlElementType>> _elementLookup;
		private Dictionary<string, WsdlPortType> _portTypeLookup;
		private Dictionary<string, WsdlType> _typeLookup;
		private Dictionary<string, WsdlBinding> _bindingLookup;
		private Dictionary<string, WsdlService> _serviceLookup;

		public WsdlStructure()
		{
			_typeLookup = new Dictionary<string, WsdlType>();
			_elementLookup = new Dictionary<ServiceDescription, Dictionary<string, WsdlElementType>>();
			_portTypeLookup = new Dictionary<string, WsdlPortType>();
			_bindingLookup = new Dictionary<string, WsdlBinding>();
			_serviceLookup = new Dictionary<string, WsdlService>();
		}



		public IEnumerable<WsdlService> Services { get { return _serviceLookup.Values; } }

		public IEnumerable<WsdlElementType> Elements
		{
			get
			{
				return _elementLookup.Values.SelectMany(x => x.Values);
			}
		}

		public IEnumerable<WsdlPortType> PortTypes { get { return _portTypeLookup.Values; } }
		public IEnumerable<WsdlType> Types { get { return _typeLookup.Values; } }

		public IEnumerable<WsdlBinding> Bindings { get { return _bindingLookup.Values; } }

		private static readonly ServiceDescription DummyWsdl = new ServiceDescription
		{
			Name = ""
		};

		public void AddXmlSchema(XmlSchema xsd)
		{
			foreach (XmlQualifiedName xname in xsd.SchemaTypes.Names)
			{
				var schemaObj = xsd.SchemaTypes[xname] as XmlSchemaType;
				if (_typeLookup.ContainsKey(schemaObj.QualifiedName.Name)) continue;
				WsdlType t;
				if (schemaObj is XmlSchemaSimpleType)
				{
					t = CreateSimpleType(schemaObj as XmlSchemaSimpleType);
				}
				else
				{
					t = new WsdlType();
					AssignComplexTypeValues(t, schemaObj as XmlSchemaComplexType);
				}
				_typeLookup.Add(t.XName.Name, t);
			}
			Dictionary<string, WsdlElementType> elementLookup = null;
			if (_elementLookup.ContainsKey(DummyWsdl))
			{
				elementLookup = _elementLookup[DummyWsdl];
			}
			else
			{
				elementLookup = new Dictionary<string, WsdlElementType>();
				_elementLookup.Add(DummyWsdl, elementLookup);
			}
			foreach (XmlQualifiedName xname in xsd.Elements.Names)
			{
				var element = xsd.Elements[xname] as XmlSchemaElement;
				var e = CreateElement(DummyWsdl, element);
				elementLookup.Add(e.XName.Name, e);
			}
		}
		public void AddServiceDescription(ServiceDescription wsdl)
		{
			var elementLookup = new Dictionary<string, WsdlElementType>();
			foreach (XmlSchema schema in wsdl.Types.Schemas)
			{
				foreach (XmlQualifiedName xname in schema.SchemaTypes.Names)
				{
					var schemaObj = schema.SchemaTypes[xname] as XmlSchemaType;
					if (_typeLookup.ContainsKey(schemaObj.QualifiedName.Name)) continue;
					WsdlType t;
					if (schemaObj is XmlSchemaSimpleType)
					{
						t = CreateSimpleType(schemaObj as XmlSchemaSimpleType);
					}
					else
					{
						t = new WsdlType();
						AssignComplexTypeValues(t, schemaObj as XmlSchemaComplexType);
					}
					_typeLookup.Add(t.XName.Name, t);
				}
				foreach (XmlQualifiedName xname in schema.Elements.Names)
				{
					var element = schema.Elements[xname] as XmlSchemaElement;
					var e = CreateElement(wsdl, element);
					elementLookup.Add(e.XName.Name, e);
				}
			}
			_elementLookup.Add(wsdl, elementLookup);

			foreach (PortType portType in wsdl.PortTypes)
			{
				var pt = CreatePortType(wsdl, portType);
				_portTypeLookup.Add(pt.XName.Name, pt);
			}
			foreach (Binding binding in wsdl.Bindings)
			{
				var b = CreateBinding(wsdl, binding);
				_bindingLookup.Add(b.XName.Name, b);
			}
			foreach (Service service in wsdl.Services)
			{
				var s = CreateService(wsdl, service);
				_serviceLookup.Add(s.XName.Name, s);
			}
		}

		private WsdlService CreateService(ServiceDescription wsdl, Service service)
		{
			var s = new WsdlService();
			s.XName = new XmlQualifiedName(service.Name, service.ServiceDescription.TargetNamespace);
			foreach (Port p in service.Ports)
			{
				var wsp = new WsdlServicePort();
				wsp.Binding = _bindingLookup[p.Binding.Name];
				foreach (ServiceDescriptionFormatExtension extension in p.Extensions)
				{
					if (extension is SoapAddressBinding)
					{
						wsp.SoapLocation = (extension as SoapAddressBinding).Location;
					}
				}
				s.Ports.Add(wsp);
			}
			return s;
		}

		private WsdlBinding CreateBinding(ServiceDescription wsdl, Binding binding)
		{
			var b = new WsdlBinding();
			b.Wsdl = wsdl;
			b.XName = new XmlQualifiedName(binding.Name, binding.ServiceDescription.TargetNamespace);
			b.PortType = _portTypeLookup[binding.Type.Name];
			foreach (OperationBinding operationBinding in binding.Operations)
			{
				var ob = new WsdlOperationBinding();
				b.Operations.Add(ob);
				ob.Name = operationBinding.Name;
				foreach (ServiceDescriptionFormatExtension extension in operationBinding.Extensions)
				{
					if (extension is SoapAddressBinding)
					{
						ob.SoapAction = (extension as SoapAddressBinding).Location;
					}
				}
				foreach (ServiceDescriptionFormatExtension extension in operationBinding.Input.Extensions)
				{
					if (extension is SoapHeaderBinding)
					{
						var header = extension as SoapHeaderBinding;
						var msg = wsdl.Messages[header.Message.Name];
						var part = msg.Parts[header.Part];
						ob.InputSoapHeader = new WsdlType
						{
							XName = part.Element
						};
					}
				}
				foreach (ServiceDescriptionFormatExtension extension in operationBinding.Output.Extensions)
				{
					if (extension is SoapHeaderBinding)
					{
						var header = extension as SoapHeaderBinding;
						var msg = wsdl.Messages[header.Message.Name];
						var part = msg.Parts[header.Part];
						ob.OutputSoapHeader = new WsdlType
						{
							XName = part.Element
						};
					}
				}
			}
			return b;
		}

		public void Compile()
		{
			var types = new List<WsdlType>();
			types.AddRange(Types);
			types.AddRange(Elements);
			foreach (var t in types)
			{
				if (t.BaseTypeXName != null)
				{
					t.BaseType = _typeLookup[t.BaseTypeXName.Name];
				}
				foreach (var p in t.Properties)
				{
					var typeName = p.DataType.XName.Name;
					if (_typeLookup.ContainsKey(typeName))
					{
						p.DataType = _typeLookup[typeName];
					}
					else
					{
						SetPrimitiveType(p.DataType);
					}
				}
			}
			foreach (var pt in PortTypes)
			{
				pt.Documentation = pt.Documentation.Replace("&lt;", "<").Replace("&gt;", ">");
				var elementLookup = _elementLookup[pt.Wsdl];
				foreach (var op in pt.Operations)
				{
					op.Documentation = op.Documentation.Replace("&lt;", "<").Replace("&gt;", ">");
					if (op.InputElement != null)
					{
						op.InputElement = elementLookup[op.InputElement.XName.Name];
					}
					if (op.OutputElement != null)
					{
						op.OutputElement = elementLookup[op.OutputElement.XName.Name];
					}
					if (op.FaultElement != null)
					{
						op.FaultElement = elementLookup[op.FaultElement.XName.Name];
					}
				}
			}
			foreach (var b in Bindings)
			{
				var elementLookup = _elementLookup[b.Wsdl];
				foreach (var op in b.Operations)
				{
					op.InputSoapHeader = elementLookup[op.InputSoapHeader.XName.Name];
					op.OutputSoapHeader = elementLookup[op.OutputSoapHeader.XName.Name];
				}
			}
		}

		public IEnumerable<WsdlType> GetConcreteTypes(WsdlType abstractType)
		{
			var subclasses = _typeLookup.Values.Where(x => x.BaseType == abstractType);
			foreach (var sc in subclasses)
			{
				if (sc.IsAbstract)
				{
					foreach (var secondSubclass in GetConcreteTypes(sc))
					{
						yield return secondSubclass;
					}
				}
				else
				{
					yield return sc;
				}
			}
		}

		private static string GetDocumentation(XmlSchemaAnnotation annotation)
		{
			if (annotation == null) return null;
			var xDoc = annotation.Items.OfType<XmlSchemaDocumentation>().FirstOrDefault();
			return GetDocumentation(xDoc);
		}

		private static string GetDocumentation(XmlSchemaDocumentation documentation)
		{
			if (documentation == null) return null;
			var lines = new List<string>();
			foreach (var node in documentation.Markup)
			{
				var multi = node.Value.Trim().Split('\n');
				foreach (var line in multi)
				{
					lines.Add(line.Trim());
				}
			}
			return string.Join(Environment.NewLine, lines);
		}

		private static string GetDocumentation(string rawText)
		{
			if (string.IsNullOrWhiteSpace(rawText)) return null;
			var lines = new List<string>();
			var multi = rawText.Trim().Split('\n');
			foreach (var line in multi)
			{
				lines.Add(line.Trim());
			}
			return string.Join(Environment.NewLine, lines);
		}

		private void AssignComplexTypeValues(WsdlType t, XmlSchemaComplexType type)
		{
			t.XName = type.QualifiedName;
			t.IsPrimitiveType = false;
			t.Documentation = GetDocumentation(type.Annotation);
			t.IsAbstract = type.IsAbstract;
			XmlSchemaObjectCollection propertyItems = null;
			if (type.ContentModel == null)
			{
				var typeSequence = type.Particle as XmlSchemaSequence;
				if (typeSequence != null)
				{
					propertyItems = typeSequence.Items;

				}
				else
				{
					var typeChoice = type.Particle as XmlSchemaChoice;
					propertyItems = typeChoice.Items;
				}
			}
			else
			{
				var content = type.ContentModel as XmlSchemaComplexContent;
				var contentExt = content.Content as XmlSchemaComplexContentExtension;
				t.BaseTypeXName = contentExt.BaseTypeName;
				var typeSequence = contentExt.Particle as XmlSchemaSequence;
				propertyItems = typeSequence.Items;
			}

			foreach (XmlSchemaElement item in propertyItems)
			{
				t.Properties.Add(CreateDataProperty(item as XmlSchemaElement));
			}
		}

		private WsdlTypeProperty CreateDataProperty(XmlSchemaElement xElement)
		{
			var dataProp = new WsdlTypeProperty();
			dataProp.XName = xElement.QualifiedName;
			dataProp.Documentation = GetDocumentation(xElement.Annotation);
			dataProp.AllowNull = xElement.MinOccurs == 0m;
			dataProp.AllowMultiple = xElement.MaxOccurs > 1m;
			dataProp.DataType = new WsdlType();
			dataProp.DataType.XName = xElement.ElementSchemaType.QualifiedName;
			dataProp.IsTypeProperty = dataProp.XName.Name.EndsWith(".Type");
			return dataProp;
		}

		private WsdlElementType CreateElement(ServiceDescription wsdl, XmlSchemaElement element)
		{
			var complexType = element.ElementSchemaType as XmlSchemaComplexType;
			var t = new WsdlElementType();
			AssignComplexTypeValues(t, complexType);
			t.XName = element.QualifiedName;
			t.Wsdl = wsdl;
			t.Documentation = GetDocumentation(element.Annotation);
			return t;
		}

		private WsdlPortType CreatePortType(ServiceDescription wsdl, PortType portType)
		{
			var pt = new WsdlPortType();
			pt.Wsdl = wsdl;
			pt.XName = new XmlQualifiedName(portType.Name, portType.ServiceDescription.TargetNamespace);
			pt.Documentation = GetDocumentation(portType.Documentation);
			foreach (Operation operation in portType.Operations)
			{
				var ptOpr = new WsdlPortTypeOperation();
				pt.Operations.Add(ptOpr);
				ptOpr.Name = operation.Name;
				ptOpr.Documentation = GetDocumentation(operation.Documentation);
				foreach (OperationMessage msg in operation.Messages)
				{
					var elementName = wsdl.Messages[msg.Name].Parts[0].Element;
					if (msg is OperationInput)
					{
						ptOpr.InputElement = new WsdlType
						{
							XName = elementName
						};
					}
					else if (msg is OperationOutput)
					{
						ptOpr.OutputElement = new WsdlType
						{
							XName = elementName
						};
					}
				}
				foreach (OperationFault msg in operation.Faults)
				{
					var elementName = wsdl.Messages[msg.Name].Parts[0].Element;
					ptOpr.FaultElement = new WsdlType
					{
						XName = elementName
					};
				}
			}
			return pt;
		}
		private WsdlType CreateSimpleType(XmlSchemaSimpleType type)
		{
			WsdlType t = null;
			if (type.TypeCode == XmlTypeCode.String)
			{
				var restriction = type.Content as XmlSchemaSimpleTypeRestriction;
				if (restriction != null)
				{
					var enumType = new WsdlEnumType();
					t = enumType;
					foreach (XmlSchemaFacet facet in restriction.Facets.Cast<XmlSchemaFacet>())
					{
						var enumFacet = facet as XmlSchemaEnumerationFacet;
						if (enumFacet == null) continue;
						var item = new WsdlEnumItem();
						item.Name = enumFacet.Value;
						item.Documentation = GetDocumentation(enumFacet.Annotation);
						enumType.Items.Add(item);
					}
				}
			}
			if (t == null) throw new Exception($"Unhandled SOAP simple type {type.QualifiedName}");
			t.XName = type.QualifiedName;
			t.IsPrimitiveType = true;
			t.Documentation = GetDocumentation(type.Annotation);
			return t;
		}

		private void SetPrimitiveType(WsdlType dataType)
		{
			dataType.IsPrimitiveType = true;
			dataType.CodeName = dataType.XName.Name;
			switch (dataType.CodeName)
			{
				case "boolean": dataType.CodeName = "bool"; break;
				case "base64Binary": dataType.CodeName = "byte[]"; break;
			}
		}
	}
}
