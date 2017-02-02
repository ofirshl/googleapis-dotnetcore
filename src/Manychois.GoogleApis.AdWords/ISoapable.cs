using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords
{
	public interface ISoapable
	{
		void WriteTo(XElement xE);

		void ReadFrom(XElement xE);
	}
}
