using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Manychois.GoogleApis
{
    public interface IHttpWebResponse : IDisposable
    {
		WebHeaderCollection Headers { get; }
		Stream GetResponseStream();

		HttpStatusCode StatusCode { get; }
	}
}
