using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.DevConsole.AdWords
{
	class Programmer
	{
		private static readonly string[] CSharpContexualKeywords = new string[]
		{
			"add", "alias", "ascending", "async", "await", "descending", "dynamic", "from", "get", "global", "group", "into", "join", "let", "orderby", "partial", "remove", "select", "set", "value", "var", "where", "yield"
		};
		private static readonly string[] CSharpKeywords = new string[]
		{
			"abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while"
		};

		public void Code(WsdlStructure wsdl, string directory, string namespaceName)
		{
			/*
			WriteLine("using Manychois.GoogleApis.AdWords.v201609.EnumExtensions;");
			WriteLine("using Microsoft.Extensions.Logging;");
			WriteLine("using System;");
			WriteLine("using System.Collections.Generic;");
			WriteLine("using System.Threading.Tasks;");
			WriteLine("using System.Xml.Linq;");
			WriteLine("");
			WriteLine($"namespace {namespaceName}");
			Ocb();
			*/
			SetCodeNames(wsdl);
			CodeInstanceCreator(wsdl, directory, namespaceName);
			CodeEnums(wsdl, directory, namespaceName);
			foreach (var t in wsdl.Types.OrderBy(x => x.CodeName))
			{
				if (t is WsdlEnumType) continue;
				if (t.XName.Name == "ApiError")
				{
					CodeApiError(t, directory, namespaceName);
				}
				else
				{
					CodeComplexType(t, true, directory, namespaceName);
				}

			}
			foreach (var e in wsdl.Elements.OrderBy(x => x.CodeName))
			{
				CodeComplexType(e, e.Wsdl.Name == "", directory, namespaceName);
			}
			foreach (var pt in wsdl.PortTypes.OrderBy(x => x.CodeName))
			{
				CodePortType(pt, directory, namespaceName);
			}
			foreach (var b in wsdl.Bindings.OrderBy(x => x.CodeName))
			{
				CodeBinding(b, directory, namespaceName);
			}
			foreach (var s in wsdl.Services.OrderBy(x => x.CodeName))
			{
				CodeService(s, directory, namespaceName);
			}
			CodeEnumExtensions(wsdl, directory, namespaceName);
		}

		private void CodeEnums(WsdlStructure wsdl, string directory, string namespaceName)
		{
			using (var file = new CodeFile(directory, "Enums.cs"))
			{
				using (var nsScope = file.CreateNamespaceScope(namespaceName))
				{
					foreach (var t in wsdl.Types.OfType<WsdlEnumType>().OrderBy(x => x.CodeName))
					{

						file.Comment(t.Documentation);
						file.WriteLine($"public enum {t.CodeName}");
						file.Ocb();
						var lastItem = t.Items.Last();
						foreach (var enumItem in t.Items)
						{
							file.Comment(enumItem.Documentation);
							file.WriteLine(enumItem.CodeName + (enumItem == lastItem ? "" : ","));
						}
						file.Ccb();
						file.WriteLine("");
					}
				}
			}
		}

		private void CodeEnumExtensions(WsdlStructure wsdl, string directory, string namespaceName)
		{
			using (var file = new CodeFile(directory, "EnumExtensions.cs"))
			{
				file.WriteLine("using System;");
				file.WriteLine("");
				using (var nsScope = file.CreateNamespaceScope(namespaceName))
				{
					foreach (var et in wsdl.Types.OfType<WsdlEnumType>().OrderBy(x => x.CodeName))
					{
						using (var classScope = file.CreateClassScope("public static", $"{et.CodeName}Extensions"))
						{
							using (var methodScope = file.CreateMethodScope("public static", "string", "ToXmlValue", $"this {et.CodeName} enumValue"))
							{
								file.WriteLine("switch (enumValue)");
								file.Ocb();
								foreach (var item in et.Items)
								{
									file.WriteLine($"case {et.CodeName}.{item.CodeName}: return \"{item.Name}\";");
								}
								file.WriteLine("default: return null;");
								file.Ccb();
							}
							using (var methodScope = file.CreateMethodScope("public static", et.CodeName, "Parse", "string xmlValue"))
							{
								file.WriteLine("switch (xmlValue)");
								file.Ocb();
								foreach (var item in et.Items)
								{
									file.WriteLine($"case \"{item.Name}\": return {et.CodeName}.{item.CodeName};");
								}
								file.WriteLine($"default: throw new ArgumentException($\"Unknown value \\\"{{xmlValue}}\\\" for type {et.CodeName}.\", nameof(xmlValue));");
								file.Ccb();
							}
						}

					}
				}
			}
		}

		private void SetCodeNames(WsdlStructure wsdl)
		{
			foreach (var t in wsdl.Types)
			{
				t.CodeName = StringUtil.ToPascalCaseName(t.XName.Name);
				bool isErrorType = t.BaseType?.XName.Name == "ApiError";
				foreach (var p in t.Properties)
				{
					p.CodeName = StringUtil.ToPascalCaseName(p.XName.Name);
					if (isErrorType && p.CodeName == "Message") p.CodeName = t.CodeName + p.CodeName;
				}
				if (t is WsdlEnumType)
				{
					var et = t as WsdlEnumType;
					foreach (var i in et.Items)
					{
						i.CodeName = string.Join("", i.Name.Split('_').Select(x => StringUtil.ToPascalCaseName(x.ToLowerInvariant())));
					}
				}
			}
			foreach (var e in wsdl.Elements)
			{
				string serviceName = "";
				if (e.Wsdl.Services.Count > 0) serviceName = e.Wsdl.Services[0].Name;
				e.CodeName = serviceName + StringUtil.ToPascalCaseName(e.XName.Name);
				foreach (var p in e.Properties)
				{
					p.CodeName = StringUtil.ToPascalCaseName(p.XName.Name);
				}
			}
			foreach (var pt in wsdl.PortTypes)
			{
				pt.CodeName = "I" + StringUtil.ToPascalCaseName(pt.XName.Name.Replace("Interface", ""));
				foreach (var op in pt.Operations)
				{
					op.CodeName = StringUtil.ToPascalCaseName(op.Name);
				}
			}
			foreach (var b in wsdl.Bindings)
			{
				b.CodeName = StringUtil.ToPascalCaseName(b.XName.Name);
			}
			foreach (var s in wsdl.Services)
			{
				s.CodeName = StringUtil.ToPascalCaseName(s.XName.Name);
			}
		}

		private void CodeService(WsdlService s, string directory, string namespaceName)
		{
			using (var file = new CodeFile(directory, $"{s.CodeName}.cs"))
			{
				file.WriteLine("using System.Collections.Generic;");
				file.WriteLine("using System.Threading.Tasks;");
				file.WriteLine("");
				using (var nsScope = file.CreateNamespaceScope(namespaceName))
				{
					using (var classScope = file.CreateClassScope("public", s.CodeName, s.Ports.Select(x => x.Binding.PortType.CodeName).ToArray()))
					{
						file.WriteLine("public AdWordsApiConfig Config { get; }");

						// constructor
						file.WriteLine($"public {s.CodeName}(AdWordsApiConfig config)");
						file.Ocb();
						file.WriteLine("Config = config;");
						file.Ccb();

						foreach (var p in s.Ports)
						{
							var headerElements = new List<WsdlType>();
							foreach (var opBinding in p.Binding.Operations)
							{
								var pt = p.Binding.PortType;
								var op = pt.Operations.First(x => x.Name == opBinding.Name);

								var outputType = GetPropertyTypeCode(op.OutputElement.Properties[0], true);
								string inputs = null;
								string inputParamName = null;
								if (op.InputElement.Properties.Count > 0)
								{
									var prop = op.InputElement.Properties[0];
									inputParamName = EscapeKeyword(StringUtil.ToCamelCaseName(prop.CodeName));
									inputs = GetPropertyTypeCode(prop, true) + " " + inputParamName;
								}
								file.Comment(op.Documentation);
								file.WriteLine($"public async Task<{outputType}> {op.CodeName}Async({inputs})");
								file.Ocb();
								file.WriteLine($"var binding = new {p.Binding.CodeName}(\"{p.SoapLocation}\", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression, Config.NetUtility, Config.Logger);");
								file.WriteLine($"var inData = new SoapData<{opBinding.InputSoapHeader.CodeName}, {op.InputElement.CodeName}>();");
								file.WriteLine($"inData.Header = new {opBinding.InputSoapHeader.CodeName}();");
								file.WriteLine("AssignHeaderValues(inData.Header);");
								if (!headerElements.Contains(opBinding.InputSoapHeader)) headerElements.Add(opBinding.InputSoapHeader);
								file.WriteLine($"inData.Body = new {op.InputElement.CodeName}();");
								if (inputParamName != null)
								{
									var prop = op.InputElement.Properties[0];
									if (prop.AllowMultiple)
									{
										file.WriteLine($"inData.Body.{prop.CodeName} = new {GetPropertyTypeCode(prop, false)}({inputParamName});");
									}
									else
									{
										file.WriteLine($"inData.Body.{prop.CodeName} = {inputParamName};");
									}
								}
								file.WriteLine($"var outData = await binding.{op.CodeName}Async(inData).ConfigureAwait(false);");
								file.WriteLine($"return outData.Body.{op.OutputElement.Properties[0].CodeName};");
								file.Ccb();
							}
							foreach (var hEle in headerElements)
							{
								file.WriteLine($"private void AssignHeaderValues({hEle.CodeName} header)");
								file.Ocb();
								file.WriteLine("header.ClientCustomerId = Config.ClientCustomerId;");
								file.WriteLine("header.DeveloperToken = Config.DeveloperToken;");
								file.WriteLine("header.PartialFailure = Config.PartialFailure;");
								file.WriteLine("header.UserAgent = Config.UserAgent;");
								file.WriteLine("header.ValidateOnly = Config.ValidateOnly;");
								file.Ccb();
							}
						}
					}
				}
			}
		}

		private void CodeBinding(WsdlBinding binding, string directory, string namespaceName)
		{
			using (var file = new CodeFile(directory, $"{binding.CodeName}.cs"))
			{
				file.WriteLine("using Microsoft.Extensions.Logging;");
				file.WriteLine("using System;");
				file.WriteLine("using System.Threading.Tasks;");
				file.WriteLine("using System.Xml.Linq;");
				file.WriteLine("");
				using (var nsScope = file.CreateNamespaceScope(namespaceName))
				{
					using (var classScope = file.CreateClassScope("internal", binding.CodeName, "BaseSoapBinding"))
					{
						// constructor
						file.WriteLine($"public {binding.CodeName}(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, INetUtility net, ILogger logger)");
						file.Indent();
						file.WriteLine(": base(soapLocation, accessToken, timeout, enableGzipCompression, net, logger)");
						file.Unindent();
						file.Ocb();
						file.Ccb();

						foreach (var op in binding.Operations)
						{
							var portTypeOperation = binding.PortType.Operations.First(x => x.Name == op.Name);
							var inputHeaderType = op.InputSoapHeader.CodeName;
							var outputHeaderType = op.OutputSoapHeader.CodeName;
							var inputType = portTypeOperation.InputElement.CodeName;
							var outputType = portTypeOperation.OutputElement.CodeName;
							file.WriteLine($"public async Task<SoapData<{outputHeaderType}, {outputType}>> {StringUtil.ToPascalCaseName(op.Name)}Async(SoapData<{inputHeaderType}, {inputType}> inData)");
							file.Ocb();
							file.WriteLine($"var xHeaderData = new XElement(XName.Get(\"{op.InputSoapHeader.XName.Name}\", \"{op.InputSoapHeader.XName.Namespace}\"));");
							file.WriteLine("inData.Header.WriteTo(xHeaderData);");
							file.WriteLine($"var xBodyData = new XElement(XName.Get(\"{portTypeOperation.InputElement.XName.Name}\", \"{portTypeOperation.InputElement.XName.Namespace}\"));");
							file.WriteLine("inData.Body.WriteTo(xBodyData);");
							file.WriteLine($"var outData = new SoapData<{outputHeaderType}, {outputType}>();");
							file.WriteLine($"outData.Header = new {outputHeaderType}();");
							file.WriteLine($"outData.Body = new {outputType}();");
							file.WriteLine($"var faultData = new {portTypeOperation.FaultElement.CodeName}();");
							file.WriteLine($"var isSuccessful = await GetSoapResultAsync(\"{op.SoapAction}\", xHeaderData, xBodyData, outData, faultData).ConfigureAwait(false);");

							using (var ifScope = file.CreateScope("if (!isSuccessful)"))
							{
								file.WriteLine("if (faultData.Errors.Count == 1)");
								file.Ocb();
								file.WriteLine("throw faultData.Errors[0];");
								file.Ccb();
								file.WriteLine("else");
								file.Ocb();
								file.WriteLine("throw new AggregateException(faultData.Errors);");
								file.Ccb();
							}

							file.WriteLine("return outData;");
							file.Ccb();
						}
					}
				}
			}
		}

		private void CodePortType(WsdlPortType portType, string directory, string namespaceName)
		{
			using (var file = new CodeFile(directory, $"{portType.CodeName}.cs"))
			{
				file.WriteLine("using System.Collections.Generic;");
				file.WriteLine("using System.Threading.Tasks;");
				file.WriteLine("");
				using (var nsScope = file.CreateNamespaceScope(namespaceName))
				{
					file.Comment(portType.Documentation);
					file.WriteLine($"public interface {portType.CodeName}");
					file.Ocb();
					foreach (var op in portType.Operations)
					{
						var outputType = GetPropertyTypeCode(op.OutputElement.Properties[0], true);
						string inputs = null;
						if (op.InputElement.Properties.Count > 0)
						{
							inputs = GetPropertyTypeCode(op.InputElement.Properties[0], true) + " " + EscapeKeyword(op.InputElement.Properties[0].CodeName);
						}
						file.Comment(op.Documentation);
						file.WriteLine($"Task<{outputType}> {op.CodeName}Async({inputs});");
					}
					file.Ccb();
				}
			}
		}

		private void CodeInstanceCreator(WsdlStructure wsdl, string directory, string namespaceName)
		{
			using (var file = new CodeFile(directory, "InstanceCreator.cs"))
			{
				file.WriteLine("using System;");
				file.WriteLine("using System.Xml.Linq;");
				file.WriteLine("");
				using (var nsScope = file.CreateNamespaceScope(namespaceName))
				{
					var allAbstractTypes = wsdl.Types.Where(x => x.IsAbstract).OrderBy(x => x.CodeName).ToList();
					using (var classScope = file.CreateClassScope("internal static", "InstanceCreator"))
					{
						foreach (var t in allAbstractTypes)
						{
							using (var methodScope = file.CreateMethodScope("public static", t.CodeName, $"Create{t.CodeName}", "XElement xElement"))
							{
								file.WriteLine("var type = XmlUtility.GetXmlTypeLocalName(xElement);");
								bool isFirst = true;
								foreach (var concreteType in wsdl.GetConcreteTypes(t).OrderBy(x => x.CodeName))
								{
									var elseKeyword = isFirst ? "" : "else ";
									file.WriteLine($"{elseKeyword}if (type == \"{concreteType.XName.Name}\")");
									file.Ocb();
									file.WriteLine($"return new {concreteType.CodeName}();");
									file.Ccb();
									isFirst = false;
								}
								file.WriteLine("throw new ArgumentException($\"Unknown type {type}\", \"xElement\");");
							}
						}
					}
				}
			}
		}

		private void CodeApiError(WsdlType t, string directory, string namespaceName)
		{
			using (var file = new CodeFile(directory, $"{t.CodeName}.cs"))
			{
				file.WriteLine("using System;");
				file.WriteLine("using System.Xml.Linq;");
				file.WriteLine("");
				using (var nsScope = file.CreateNamespaceScope(namespaceName))
				{
					file.Comment(t.Documentation);
					var abstractKeyword = t.IsAbstract ? " abstract" : "";
					using (var classScope = file.CreateClassScope($"public{abstractKeyword}", t.CodeName, "Exception", "ISoapable"))
					{
						file.WriteLine("public override string Message { get { return ErrorString; } }");
						foreach (var p in t.Properties)
						{
							file.Comment(p.Documentation);
							file.WriteLine($"public {GetPropertyTypeCode(p, false)} {p.CodeName} {{ get; set; }}");
						}
						ImplementISoapableReadFrom(t, file);
						ImplementISoapableWriteTo(t, file);
					}
				}
			}
		}

		private void CodeComplexType(WsdlType t, bool isPublic, string directory, string namespaceName)
		{
			using (var file = new CodeFile(directory, $"{t.CodeName}.cs"))
			{
				file.WriteLine("using System;");
				file.WriteLine("using System.Collections.Generic;");
				file.WriteLine("using System.Xml.Linq;");
				file.WriteLine("");
				using (var nsScope = file.CreateNamespaceScope(namespaceName))
				{
					file.Comment(t.Documentation);
					string modifier = isPublic ? "public" : "internal";
					if (t.IsAbstract) modifier += " abstract";
					var inherits = new List<string>();
					if (t.BaseType != null) inherits.Add(t.BaseType.CodeName);
					inherits.Add("ISoapable");
					using (var classScope = file.CreateClassScope(modifier, t.CodeName, inherits.ToArray()))
					{
						foreach (var p in t.Properties)
						{
							file.Comment(p.Documentation);
							file.WriteLine($"public {GetPropertyTypeCode(p, false)} {p.CodeName} {{ get; set; }}");
						}
						ImplementISoapableReadFrom(t, file);
						ImplementISoapableWriteTo(t, file);
					}
				}
			}
		}

		private void ImplementISoapableReadFrom(WsdlType t, CodeFile f)
		{
			var overrideKeyword = t.BaseType == null ? "virtual" : "override";
			using (var methodScope = f.CreateMethodScope($"public {overrideKeyword}", "void", "ReadFrom", "XElement xE"))
			{
				if (t.BaseType != null)
				{
					f.WriteLine("base.ReadFrom(xE);");
				}
				foreach (var p in t.Properties)
				{
					if (p.AllowMultiple || p.AllowNull)
					{
						f.WriteLine($"{p.CodeName} = null;");
					}
				}
				f.WriteLine("foreach (var xItem in xE.Elements())");
				f.Ocb();
				f.WriteLine("var localName = xItem.Name.LocalName;");
				bool isFirst = true;
				foreach (var p in t.Properties)
				{
					f.WriteLine((isFirst ? "" : "else ") + $"if (localName == \"{p.XName.Name}\")");
					f.Ocb();
					if (p.AllowMultiple)
					{
						f.WriteLine($"if ({p.CodeName} == null) {p.CodeName} = new {GetPropertyTypeCode(p, false)}();");
						if (p.DataType.IsPrimitiveType)
						{
							f.WriteLine($"{p.CodeName}.Add({GetSinglePrimitiveTypeConversionExpression(p, "xItem.Value")});");
						}
						else
						{
							string ItemVarName = StringUtil.ToCamelCaseName(p.CodeName + "Item");
							if (p.DataType.IsAbstract)
							{
								f.WriteLine($"var {ItemVarName} = InstanceCreator.Create{p.DataType.CodeName}(xItem);");
							}
							else
							{
								f.WriteLine($"var {ItemVarName} = new {p.DataType.CodeName}();");
							}
							f.WriteLine($"{ItemVarName}.ReadFrom(xItem);");
							f.WriteLine($"{p.CodeName}.Add({ItemVarName});");
						}
					}
					else
					{
						if (p.DataType.IsPrimitiveType)
						{
							f.WriteLine($"{p.CodeName} = {GetSinglePrimitiveTypeConversionExpression(p, "xItem.Value")};");
						}
						else
						{
							if (p.DataType.IsAbstract)
							{
								f.WriteLine($"{p.CodeName} = InstanceCreator.Create{p.DataType.CodeName}(xItem);");
							}
							else
							{
								f.WriteLine($"{p.CodeName} = new {p.DataType.CodeName}();");
							}
							f.WriteLine($"{p.CodeName}.ReadFrom(xItem);");
						}
					}
					f.Ccb();
					isFirst = false;
				}
				f.Ccb(); // close foreach
			}
		}

		private string GetSinglePrimitiveTypeConversionExpression(WsdlTypeProperty prop, string valueExpression)
		{
			string expression = null;
			string typeName = prop.DataType.CodeName;
			if (prop.DataType.IsEnum)
			{
				expression = $"{prop.DataType.CodeName}Extensions.Parse({valueExpression})";
			}
			else if (typeName == "string")
			{
				expression = valueExpression;
			}
			else if (typeName == "byte[]")
			{
				expression = $"Convert.FromBase64String({valueExpression})";
			}
			else
			{
				expression = $"{typeName}.Parse({valueExpression})";
			}
			return expression;
		}

		private void ImplementISoapableWriteTo(WsdlType t, CodeFile f)
		{
			var overrideKeyword = t.BaseType == null ? "virtual" : "override";
			using (var methodScope = f.CreateMethodScope($"public {overrideKeyword}", "void", "WriteTo", "XElement xE"))
			{
				if (t.BaseType != null)
				{
					f.WriteLine("base.WriteTo(xE);");
					f.WriteLine($"XmlUtility.SetXsiType(xE, \"{t.XName.Namespace}\", \"{t.XName.Name}\");");
				}
				if (t.Properties.Count > 0)
				{
					f.WriteLine("XElement xItem = null;");
				}
				foreach (var p in t.Properties)
				{
					bool checkNull = p.AllowMultiple || p.AllowNull;
					if (checkNull)
					{
						f.WriteLine($"if ({p.CodeName} != null)");
						f.Ocb();
					}
					string valueExpr = null;
					if (p.AllowMultiple)
					{
						valueExpr = StringUtil.ToCamelCaseName(p.CodeName + "Item");
						f.WriteLine($"foreach (var {valueExpr} in {p.CodeName})");
						f.Ocb();
					}
					else
					{
						valueExpr = p.CodeName;
						if (p.AllowNull && p.DataType.IsPrimitiveType && p.DataType.CodeName != "string" && p.DataType.CodeName != "byte[]")
						{
							valueExpr += ".Value";
						}
					}
					f.WriteLine($"xItem = new XElement(XName.Get(\"{p.XName.Name}\", \"{p.XName.Namespace}\"));");
					if (p.DataType.IsPrimitiveType)
					{
						f.WriteLine($"xItem.Add({GetSinglePrimitiveTypeToXmlValueExpression(p, valueExpr)});");
					}
					else
					{
						f.WriteLine($"{valueExpr}.WriteTo(xItem);");
					}
					f.WriteLine("xE.Add(xItem);");

					if (p.AllowMultiple) f.Ccb(); // close foreach

					if (checkNull) f.Ccb(); // close check if null
				}
			}
		}

		private string GetSinglePrimitiveTypeToXmlValueExpression(WsdlTypeProperty prop, string valueExpression)
		{
			string expression = null;
			string typeName = prop.DataType.CodeName;
			if (prop.DataType.IsEnum)
			{
				expression = $"{valueExpression}.ToXmlValue()";
			}
			else if (typeName == "string")
			{
				expression = valueExpression;
			}
			else if (typeName == "byte[]")
			{
				expression = $"Convert.ToBase64String({valueExpression})";
			}
			else
			{
				expression = $"{valueExpression}.ToString()";
			}
			return expression;
		}

		private string GetPropertyTypeCode(WsdlTypeProperty p, bool useInterface)
		{
			var type = p.DataType.CodeName;
			if (p.AllowMultiple)
			{
				type = useInterface ? $"IEnumerable<{type}>" : $"List<{type}>";
			}
			else
			{
				if (p.AllowNull)
				{
					if (p.DataType.IsPrimitiveType && p.DataType.CodeName != "string" && p.DataType.CodeName != "byte[]")
					{
						type += "?";
					}
				}
			}
			return type;
		}

		private static string EscapeKeyword(string text)
		{
			if (CSharpKeywords.Contains(text) || CSharpContexualKeywords.Contains(text))
			{
				return "@" + text;
			}
			else
			{
				return text;
			}
		}
	}
}
