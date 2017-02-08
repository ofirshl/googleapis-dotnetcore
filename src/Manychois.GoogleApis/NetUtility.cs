using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Manychois.GoogleApis
{
	public class NetUtility : INetUtility
	{
		public virtual IHttpWebRequest CreateHttp(string url)
		{
			var request = WebRequest.CreateHttp(url);
			return new HttpWebRequestWrapper(request);
		}

		public string GetQueryString(IDictionary<string, string> values)
		{
			if (values == null || values.Count == 0) return "";
			var sb = new StringBuilder();
			var encoder = UrlEncoder.Default;
			foreach (var kvp in values)
			{
				if (sb.Length > 0) sb.Append('&');
				sb.AppendFormat("{0}={1}", encoder.Encode(kvp.Key), encoder.Encode(kvp.Value));
			}
			return sb.ToString();
		}
		public virtual async Task<string> GetResponseTextAsync(IHttpWebResponse response)
		{
			string encoding = response.Headers[HttpResponseHeader.ContentEncoding];
			string contentType = response.Headers[HttpResponseHeader.ContentType];
			bool isGzipped = (encoding != null && encoding.Contains("gzip")) || (contentType != null && contentType.Contains("gzip"));
			string responseText;
			using (var responseStream = response.GetResponseStream())
			{
				if (isGzipped)
				{
					using (var unzipStream = new GZipStream(responseStream, CompressionMode.Decompress))
					using (var reader = new StreamReader(unzipStream, Encoding.UTF8))
					{
						responseText = await reader.ReadToEndAsync().ConfigureAwait(false);
					}
				}
				else
				{
					using (var reader = new StreamReader(responseStream, Encoding.UTF8))
					{
						responseText = await reader.ReadToEndAsync().ConfigureAwait(false);
					}
				}
			}
			return responseText;
		}

		private class HttpWebRequestWrapper : IHttpWebRequest
		{
			private HttpWebRequest _request;

			public HttpWebRequestWrapper(HttpWebRequest request)
			{
				_request = request;
			}

			public string Accept
			{
				get { return _request.Accept; }
				set { _request.Accept = value; }
			}

			public string ContentType
			{
				get { return _request.ContentType; }
				set { _request.ContentType = value; }
			}

			public WebHeaderCollection Headers { get { return _request.Headers; } }

			public string Method
			{
				get { return _request.Method; }
				set { _request.Method = value; }
			}

			public Task<Stream> GetRequestStreamAsync()
			{
				return _request.GetRequestStreamAsync();
			}

			public async Task<IHttpWebResponse> GetResponseAsync()
			{
				HttpWebResponse response;
				try
				{
					response = await _request.GetResponseAsync().ConfigureAwait(false) as HttpWebResponse;
				}
				catch (WebException webEx)
				{
					response = webEx.Response as HttpWebResponse;
				}
				if (response == null)
					return null;
				else
					return new HttpWebResponseWrapper(response);
			}

			public Uri RequestUri { get { return _request.RequestUri; } }
		}

		private class HttpWebResponseWrapper : IHttpWebResponse
		{
			private HttpWebResponse _response;

			public HttpWebResponseWrapper(HttpWebResponse response)
			{
				_response = response;
			}

			public WebHeaderCollection Headers { get { return _response.Headers; } }

			public void Dispose()
			{
				_response.Dispose();
				_response = null;
			}

			public Stream GetResponseStream()
			{
				return _response.GetResponseStream();
			}

			public HttpStatusCode StatusCode { get { return _response.StatusCode; } }
		}
	}
}
