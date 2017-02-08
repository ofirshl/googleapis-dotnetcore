using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis
{
	public interface INetUtility
	{
		IHttpWebRequest CreateHttp(string url);
		string GetQueryString(IDictionary<string, string> values);
		Task<string> GetResponseTextAsync(IHttpWebResponse response);
	}
}
