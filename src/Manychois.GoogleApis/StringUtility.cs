using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis
{
	public static class StringUtility
	{
		/// <summary>
		/// Replaces the format items in a specified string with the string representations of corresponding objects in a specified array.
		/// </summary>
		/// <param name="format">A composite culture-independent format string.</param>
		/// <param name="args">An object array that contains zero or more objects to format.</param>
		/// <returns>A copy of format in which the format items have been replaced by the string representation of the corresponding objects in args.</returns>
		/// <exception cref="System.ArgumentNullException">format or args is null.</exception>
		/// <exception cref="System.FormatException">format is invalid.-or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
		public static string Format(string format, params object[] args)
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture, format, args);
		}

		public static List<string> List(params object[] args)
		{
			var list = new List<string>();
			foreach (var arg in args)
			{
				if (arg == null)
					list.Add(null);
				else
					list.Add(arg.ToString());
			}
			return list;
		}
	}
}
