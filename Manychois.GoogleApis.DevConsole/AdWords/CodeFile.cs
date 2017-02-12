using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.DevConsole.AdWords
{
	class CodeFile : IDisposable
	{
		private StreamWriter _writer;
		private string _indent = "";
		public CodeFile(string directory, string filename)
		{
			Directory.CreateDirectory(directory);
			_writer = new StreamWriter($"{directory}\\{filename}", false, Encoding.UTF8);
		}

		public void WriteLine(string line)
		{
			_writer.Write(_indent);
			_writer.WriteLine(line);
		}

		public void Indent()
		{
			_indent += "\t";
		}

		public void Unindent()
		{
			if (_indent.Length > 0) _indent = _indent.Substring(1);
		}

		public void Ocb()
		{
			WriteLine("{");
			Indent();
		}

		public void Ccb()
		{
			Unindent();
			WriteLine("}");
		}

		public void Dispose()
		{
			_writer.Dispose();
			_writer = null;
		}

		public void Comment(string comment)
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

		public Scope CreateScope(string line)
		{
			return new Scope(this, line);
		}
		public Scope CreateMethodScope(string modifier, string returnType, string methodName, params string[] inputs)
		{
			var sb = new StringBuilder();
			sb.Append($"{modifier} {returnType} {methodName}(");

			bool isFirst = true;
			foreach (var input in inputs)
			{
				if (!isFirst) sb.Append(", ");
				sb.Append(input);
				isFirst = false;
			}

			sb.Append(")");
			return new Scope(this, sb.ToString());
		}

		public Scope CreateClassScope(string modifier, string className, params string[] inherits)
		{
			var sb = new StringBuilder();
			sb.Append($"{modifier} class {className}");
			if (inherits.Length > 0)
			{
				sb.Append(" : ");
				bool isFirst = true;
				foreach (var inherit in inherits)
				{
					if (!isFirst) sb.Append(", ");
					sb.Append(inherit);
					isFirst = false;
				}
			}
			return new Scope(this, sb.ToString());
		}

		public Scope CreateNamespaceScope(string namespaceName)
		{
			return new Scope(this, $"namespace {namespaceName}");
		}

		public class Scope : IDisposable
		{
			private CodeFile _file;

			public Scope(CodeFile file, string line)
			{
				_file = file;
				_file.WriteLine(line);
				_file.Ocb();
			}

			public void Dispose()
			{
				_file.Ccb();
			}
		}
	}
}
