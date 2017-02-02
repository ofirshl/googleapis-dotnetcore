using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords
{
	internal class SoapData<THeader, TBody>
		where THeader : ISoapable
		where TBody : ISoapable
	{
		public THeader Header { get; set; }
		public TBody Body { get; set; }
	}
}
