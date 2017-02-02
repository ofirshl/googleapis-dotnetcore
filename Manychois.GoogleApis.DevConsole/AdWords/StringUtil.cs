using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.DevConsole.AdWords
{
	public static class StringUtil
	{
		public static string ToCamelCaseName(string name)
		{
			if (string.IsNullOrWhiteSpace(name)) return "";
			var result = name.Replace(".", "");
			if (char.IsUpper(result[0])) result = char.ToLowerInvariant(result[0]) + result.Substring(1);
			return result;
		}

		public static string ToPascalCaseName(string name)
		{
			if (string.IsNullOrWhiteSpace(name)) return "";
			var result = name.Replace(".", "");
			if (char.IsLower(result[0])) result = char.ToUpperInvariant(result[0]) + result.Substring(1);
			return result;
		}
	}
}
