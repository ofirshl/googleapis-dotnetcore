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
	public static class NetUtility
	{
		public static string GetQueryString(IDictionary<string, string> values)
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
		public static async Task<HttpWebResponse> GetSafeResponseAsync(HttpWebRequest request)
		{
			HttpWebResponse response;
			try
			{
				response = await request.GetResponseAsync().ConfigureAwait(false) as HttpWebResponse;
			}
			catch (WebException webEx)
			{
				response = webEx.Response as HttpWebResponse;
			}
			return response;
		}

		public static async Task<string> GetResponseTextAsync(WebResponse response)
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
	}
}
