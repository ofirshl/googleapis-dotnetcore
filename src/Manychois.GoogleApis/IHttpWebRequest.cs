using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Manychois.GoogleApis
{
    public interface IHttpWebRequest
    {
		string Accept { get; set; }
		string ContentType { get; set; }
		WebHeaderCollection Headers { get; }
		string Method { get; set; }
		Task<Stream> GetRequestStreamAsync();
		Task<IHttpWebResponse> GetResponseAsync();

		Uri RequestUri { get; }
	}
}
