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

		private string _indent = "";

		private StreamWriter _writer = null;

		public void Code(string path, WsdlStructure wsdl, string namespaceName)
		{
			SetCodeNames(wsdl);

			using (_writer = new StreamWriter(path, false, Encoding.UTF8))
			{
				WriteLine("using Manychois.GoogleApis.AdWords.v201609.EnumExtensions;");
				WriteLine("using Microsoft.Extensions.Logging;");
				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using System.Threading.Tasks;");
				WriteLine("using System.Xml.Linq;");
				WriteLine("");
				WriteLine($"namespace {namespaceName}");
				Open();

				CodeInstanceCreator(wsdl);
				foreach (var t in wsdl.Types.OrderBy(x => x.CodeName))
				{
					if (t is WsdlEnumType)
					{
						CodeEnumType(t as WsdlEnumType);
					}
					else
					{
						if (t.XName.Name == "ApiError")
						{
							CodeApiError(t);
						}
						else
						{
							CodeComplexType(t, true);
						}
					}
				}
				foreach (var e in wsdl.Elements.OrderBy(x => x.CodeName))
				{
					CodeComplexType(e, e.Wsdl.Name == "");
				}
				foreach (var pt in wsdl.PortTypes.OrderBy(x => x.CodeName))
				{
					CodePortType(pt);
				}
				foreach (var b in wsdl.Bindings.OrderBy(x => x.CodeName))
				{
					CodeBinding(b);
				}
				foreach (var s in wsdl.Services.OrderBy(x => x.CodeName))
				{
					CodeService(s);
				}

				using (var nsScope = new CodeScope(this, "namespace EnumExtensions"))
				{
					foreach (var et in wsdl.Types.OfType<WsdlEnumType>().OrderBy(x => x.CodeName))
					{
						CodeEnumExtensions(et);
					}
				}

				Close();
			}
		}

		private void CodeEnumExtensions(WsdlEnumType et)
		{
			WriteLine($"public static class {et.CodeName}Extensions");
			Open();
			using (var methodScope = new CodeScope(this, $"public static string ToXmlValue(this {et.CodeName} enumValue)"))
			{
				WriteLine("switch (enumValue)");
				Open();
				foreach (var item in et.Items)
				{
					WriteLine($"case {et.CodeName}.{item.CodeName}: return \"{item.Name}\";");
				}
				WriteLine("default: return null;");
				Close();
			}
			using (var methodScope = new CodeScope(this, $"public static {et.CodeName} Parse(string xmlValue)"))
			{
				WriteLine("switch (xmlValue)");
				Open();
				foreach (var item in et.Items)
				{
					WriteLine($"case \"{item.Name}\": return {et.CodeName}.{item.CodeName};");
				}
				WriteLine($"default: throw new ArgumentException($\"Unknown value \\\"{{xmlValue}}\\\" for type {et.CodeName}.\", nameof(xmlValue));");
				Close();
			}
			Close();
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

		private void CodeService(WsdlService s)
		{
			var sb = new StringBuilder();
			sb.Append($"public class {s.CodeName} : ");
			bool isFirst = true;
			foreach (var p in s.Ports)
			{
				if (!isFirst) sb.Append(", ");
				sb.Append(p.Binding.PortType.CodeName);
				isFirst = false;
			}
			WriteLine(sb.ToString());
			Open();

			WriteLine("public AdWordsApiConfig Config { get; }");

			// constructor
			WriteLine($"public {s.CodeName}(AdWordsApiConfig config)");
			Open();
			WriteLine("Config = config;");
			Close();

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
					Comment(op.Documentation);
					WriteLine($"public async Task<{outputType}> {op.CodeName}Async({inputs})");
					Open();
					WriteLine($"var binding = new {p.Binding.CodeName}(\"{p.SoapLocation}\", Config.AccessToken, Config.Timeout, Config.EnableGzipCompression,  Config.Logger);");
					WriteLine($"var inData = new SoapData<{opBinding.InputSoapHeader.CodeName}, {op.InputElement.CodeName}>();");
					WriteLine($"inData.Header = new {opBinding.InputSoapHeader.CodeName}();");
					WriteLine("AssignHeaderValues(inData.Header);");
					if (!headerElements.Contains(opBinding.InputSoapHeader)) headerElements.Add(opBinding.InputSoapHeader);
					WriteLine($"inData.Body = new {op.InputElement.CodeName}();");
					if (inputParamName != null)
					{
						var prop = op.InputElement.Properties[0];
						if (prop.AllowMultiple)
						{
							WriteLine($"inData.Body.{prop.CodeName} = new {GetPropertyTypeCode(prop, false)}({inputParamName});");
						}
						else
						{
							WriteLine($"inData.Body.{prop.CodeName} = {inputParamName};");
						}
					}
					WriteLine($"var outData = await binding.{op.CodeName}Async(inData).ConfigureAwait(false);");
					WriteLine($"return outData.Body.{op.OutputElement.Properties[0].CodeName};");
					Close();
				}
				foreach (var hEle in headerElements)
				{
					WriteLine($"private void AssignHeaderValues({hEle.CodeName} header)");
					Open();
					WriteLine("header.ClientCustomerId = Config.ClientCustomerId;");
					WriteLine("header.DeveloperToken = Config.DeveloperToken;");
					WriteLine("header.PartialFailure = Config.PartialFailure;");
					WriteLine("header.UserAgent = Config.UserAgent;");
					WriteLine("header.ValidateOnly = Config.ValidateOnly;");
					Close();
				}
			}
			Close();
		}

		private void CodeBinding(WsdlBinding binding)
		{
			WriteLine($"internal class {binding.CodeName} : BaseSoapBinding");
			Open();

			// constructor
			WriteLine($"public {binding.CodeName}(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, ILogger logger)");
			Indent();
			WriteLine(": base(soapLocation, accessToken, timeout, enableGzipCompression, logger)");
			Unindent();
			Open();
			Close();

			foreach (var op in binding.Operations)
			{
				var portTypeOperation = binding.PortType.Operations.First(x => x.Name == op.Name);
				var inputHeaderType = op.InputSoapHeader.CodeName;
				var outputHeaderType = op.OutputSoapHeader.CodeName;
				var inputType = portTypeOperation.InputElement.CodeName;
				var outputType = portTypeOperation.OutputElement.CodeName;
				WriteLine($"public async Task<SoapData<{outputHeaderType}, {outputType}>> {StringUtil.ToPascalCaseName(op.Name)}Async(SoapData<{inputHeaderType}, {inputType}> inData)");
				Open();
				WriteLine($"var xHeaderData = new XElement(XName.Get(\"{op.InputSoapHeader.XName.Name}\", \"{op.InputSoapHeader.XName.Namespace}\"));");
				WriteLine("inData.Header.WriteTo(xHeaderData);");
				WriteLine($"var xBodyData = new XElement(XName.Get(\"{portTypeOperation.InputElement.XName.Name}\", \"{portTypeOperation.InputElement.XName.Namespace}\"));");
				WriteLine("inData.Body.WriteTo(xBodyData);");
				WriteLine($"var outData = new SoapData<{outputHeaderType}, {outputType}>();");
				WriteLine($"outData.Header = new {outputHeaderType}();");
				WriteLine($"outData.Body = new {outputType}();");
				WriteLine($"var faultData = new {portTypeOperation.FaultElement.CodeName}();");
				WriteLine($"var isSuccessful = await GetSoapResultAsync(\"{op.SoapAction}\", xHeaderData, xBodyData, outData, faultData).ConfigureAwait(false);");

				using (var isScope = new CodeScope(this, "if (!isSuccessful)"))
				{
					WriteLine("if (faultData.Errors.Count == 1)");
					Open();
					WriteLine("throw faultData.Errors[0];");
					Close();
					WriteLine("else");
					Open();
					WriteLine("throw new AggregateException(faultData.Errors);");
					Close();
				}

				WriteLine("return outData;");
				Close();
			}
			Close();
		}

		private void CodePortType(WsdlPortType portType)
		{
			Comment(portType.Documentation);
			WriteLine($"public interface {portType.CodeName}");
			Open();
			foreach (var op in portType.Operations)
			{
				var outputType = GetPropertyTypeCode(op.OutputElement.Properties[0], true);
				string inputs = null;
				if (op.InputElement.Properties.Count > 0)
				{
					inputs = GetPropertyTypeCode(op.InputElement.Properties[0], true) + " " + EscapeKeyword(op.InputElement.Properties[0].CodeName);
				}
				Comment(op.Documentation);
				WriteLine($"Task<{outputType}> {op.CodeName}Async({inputs});");
			}
			Close();
		}

		private void CodeInstanceCreator(WsdlStructure wsdl)
		{
			var allAbstractTypes = wsdl.Types.Where(x => x.IsAbstract).OrderBy(x => x.CodeName).ToList();
			WriteLine($"internal static class InstanceCreator");
			Open();
			foreach (var t in allAbstractTypes)
			{
				WriteLine($"public static {t.CodeName} Create{t.CodeName}(XElement xElement)");
				Open();
				WriteLine("var type = XmlUtility.GetXmlTypeLocalName(xElement);");
				bool isFirst = true;
				foreach (var concreteType in wsdl.GetConcreteTypes(t).OrderBy(x => x.CodeName))
				{
					var elseKeyword = isFirst ? "" : "else ";
					WriteLine($"{elseKeyword}if (type == \"{concreteType.XName.Name}\")");
					Open();
					WriteLine($"return new {concreteType.CodeName}();");
					Close();
					isFirst = false;
				}
				WriteLine("throw new ArgumentException($\"Unknown type {type}\", \"xElement\");");
				Close();
			}
			Close();
		}

		private void Comment(string comment)
		{
			if (string.IsNullOrWhiteSpace(comment)) return;
			var lines = comment.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
			WriteLine("/// <summary>");
			foreach (var line in lines)
			{
				WriteLine($"/// {line}".Trim());
			}
			WriteLine("/// </summary>");
		}


		private void CodeEnumType(WsdlEnumType t)
		{
			Comment(t.Documentation);
			WriteLine($"public enum {t.CodeName}");
			Open();
			var lastItem = t.Items.Last();
			foreach (var enumItem in t.Items)
			{
				Comment(enumItem.Documentation);
				WriteLine(enumItem.CodeName + (enumItem == lastItem ? "" : ","));
			}
			Close();
		}

		private void CodeApiError(WsdlType t)
		{
			Comment(t.Documentation);
			var abstractKeyword = t.IsAbstract ? "abstract " : "";
			WriteLine($"public {abstractKeyword}class {t.CodeName} : Exception, ISoapable");
			Open();
			WriteLine("public override string Message { get { return ErrorString; } }");
			foreach (var p in t.Properties)
			{
				Comment(p.Documentation);
				WriteLine($"public {GetPropertyTypeCode(p, false)} {p.CodeName} {{ get; set; }}");
			}
			ImplementISoapableReadFrom(t);
			ImplementISoapableWriteTo(t);
			Close();
		}

		private void CodeComplexType(WsdlType t, bool isPublic)
		{
			Comment(t.Documentation);
			var publicKeyword = isPublic ? "public" : "internal";
			var abstractKeyword = t.IsAbstract ? "abstract " : "";
			var baseClassDeclaration = t.BaseType == null ? "" : $"{t.BaseType.CodeName}, ";
			WriteLine($"{publicKeyword} {abstractKeyword}class {t.CodeName} : {baseClassDeclaration}ISoapable");
			Open();
			foreach (var p in t.Properties)
			{
				Comment(p.Documentation);
				WriteLine($"public {GetPropertyTypeCode(p, false)} {p.CodeName} {{ get; set; }}");
			}
			ImplementISoapableReadFrom(t);
			ImplementISoapableWriteTo(t);
			Close();
		}

		private void ImplementISoapableReadFrom(WsdlType t)
		{
			var overrideKeyword = t.BaseType == null ? "virtual" : "override";
			WriteLine($"public {overrideKeyword} void ReadFrom(XElement xE)");
			Open();
			if (t.BaseType != null)
			{
				WriteLine("base.ReadFrom(xE);");
			}
			foreach (var p in t.Properties)
			{
				if (p.AllowMultiple || p.AllowNull)
				{
					WriteLine($"{p.CodeName} = null;");
				}
			}
			WriteLine("foreach (var xItem in xE.Elements())");
			Open();
			WriteLine("var localName = xItem.Name.LocalName;");
			bool isFirst = true;
			foreach (var p in t.Properties)
			{
				WriteLine((isFirst ? "" : "else ") + $"if (localName == \"{p.XName.Name}\")");
				Open();
				if (p.AllowMultiple)
				{
					WriteLine($"if ({p.CodeName} == null) {p.CodeName} = new {GetPropertyTypeCode(p, false)}();");
					if (p.DataType.IsPrimitiveType)
					{
						WriteLine($"{p.CodeName}.Add({GetSinglePrimitiveTypeConversionExpression(p, "xItem.Value")});");
					}
					else
					{
						string ItemVarName = StringUtil.ToCamelCaseName(p.CodeName + "Item");
						if (p.DataType.IsAbstract)
						{
							WriteLine($"var {ItemVarName} = InstanceCreator.Create{p.DataType.CodeName}(xItem);");
						}
						else
						{
							WriteLine($"var {ItemVarName} = new {p.DataType.CodeName}();");
						}
						WriteLine($"{ItemVarName}.ReadFrom(xItem);");
						WriteLine($"{p.CodeName}.Add({ItemVarName});");
					}
				}
				else
				{
					if (p.DataType.IsPrimitiveType)
					{
						WriteLine($"{p.CodeName} = {GetSinglePrimitiveTypeConversionExpression(p, "xItem.Value")};");
					}
					else
					{
						if (p.DataType.IsAbstract)
						{
							WriteLine($"{p.CodeName} = InstanceCreator.Create{p.DataType.CodeName}(xItem);");
						}
						else
						{
							WriteLine($"{p.CodeName} = new {p.DataType.CodeName}();");
						}
						WriteLine($"{p.CodeName}.ReadFrom(xItem);");
					}
				}
				Close();
				isFirst = false;
			}
			Close(); // close foreach
			Close(); // close method
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

		private void ImplementISoapableWriteTo(WsdlType t)
		{
			var overrideKeyword = t.BaseType == null ? "virtual" : "override";
			WriteLine($"public {overrideKeyword} void WriteTo(XElement xE)");
			Open();
			if (t.BaseType != null)
			{
				WriteLine("base.WriteTo(xE);");
				WriteLine($"XmlUtility.SetXsiType(xE, \"{t.XName.Namespace}\", \"{t.XName.Name}\");");
			}
			if (t.Properties.Count > 0)
			{
				WriteLine("XElement xItem = null;");
			}
			foreach (var p in t.Properties)
			{
				bool checkNull = p.AllowMultiple || p.AllowNull;
				if (checkNull)
				{
					WriteLine($"if ({p.CodeName} != null)");
					Open();
				}
				string valueExpr = null;
				if (p.AllowMultiple)
				{
					valueExpr = StringUtil.ToCamelCaseName(p.CodeName + "Item");
					WriteLine($"foreach (var {valueExpr} in {p.CodeName})");
					Open();
				}
				else
				{
					valueExpr = p.CodeName;
					if (p.AllowNull && p.DataType.IsPrimitiveType && p.DataType.CodeName != "string" && p.DataType.CodeName != "byte[]")
					{
						valueExpr += ".Value";
					}
				}
				WriteLine($"xItem = new XElement(XName.Get(\"{p.XName.Name}\", \"{p.XName.Namespace}\"));");
				if (p.DataType.IsPrimitiveType)
				{
					WriteLine($"xItem.Add({GetSinglePrimitiveTypeToXmlValueExpression(p, valueExpr)});");
				}
				else
				{
					WriteLine($"{valueExpr}.WriteTo(xItem);");
				}
				WriteLine("xE.Add(xItem);");

				if (p.AllowMultiple) Close(); // close foreach

				if (checkNull) Close(); // close check if null
			}
			Close();
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

		private void Indent()
		{
			_indent += '\t';
		}
		private void Close()
		{
			Unindent();
			WriteLine("}");
		}

		private void Open()
		{
			WriteLine("{");
			Indent();
		}

		private void Unindent()
		{
			if (_indent.Length > 0)
			{
				_indent = _indent.Substring(1);
			}
		}

		private void WriteLine(string line)
		{
			_writer.Write(_indent);
			_writer.WriteLine(line);
		}

		private class CodeScope : IDisposable
		{
			private Programmer _p;
			public CodeScope(Programmer p, string line)
			{
				_p = p;
				p.WriteLine(line);
				p.Open();
			}
			public void Dispose()
			{
				_p.Close();
			}
		}
	}
}
