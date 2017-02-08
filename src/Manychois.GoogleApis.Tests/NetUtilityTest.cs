using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using Xunit.Extensions;

namespace Manychois.GoogleApis.Tests
{
	public class NetUtilityTest
	{
		[Fact]
		public void TestGetQueryString_EmptyInput_Passed()
		{
			INetUtility net = new NetUtility();
			IDictionary<string, string> values = null;
			Assert.Equal("", net.GetQueryString(values));

			values = new Dictionary<string, string>();
			Assert.Equal("", net.GetQueryString(values));
		}

		[Theory, MemberData(nameof(GetQueryStringData))]
		public void TestGetQueryString(IDictionary<string, string> values, string expected)
		{
			INetUtility net = new NetUtility();
			Assert.Equal(expected, net.GetQueryString(values));
		}

		public static IEnumerable<object[]> GetQueryStringData
		{
			get
			{
				var values = new Dictionary<string, string>();
				values.Add("A1", "abc");
				yield return new object[] { values, "A1=abc" };

				values = new Dictionary<string, string>();
				values.Add("B2", "Hello World");
				yield return new object[] { values, "B2=Hello%20World" };

				values = new Dictionary<string, string>();
				values.Add("C3", "1+2");
				values.Add("D4", "3&4");
				yield return new object[] { values, "C3=1%2B2&D4=3%264" };
			}
		}

		[Fact]
		public void TestCreateHttp()
		{
			INetUtility net = new NetUtility();
			var request = net.CreateHttp("http://localhost:12345/");
			Assert.Equal("http://localhost:12345/", request.RequestUri.AbsoluteUri);

			request.Accept = "*/*";
			Assert.Equal("*/*", request.Accept);

			request.ContentType = "text/html";
			Assert.Equal("text/html", request.ContentType);

			request.Headers[HttpRequestHeader.Authorization] = "Bearer 12345";
			Assert.Equal(3, request.Headers.Count); // because of Accept and ContentType
			Assert.Equal("Bearer 12345", request.Headers[HttpRequestHeader.Authorization]);

			request.Method = HttpMethod.Post.Method;
			Assert.Equal(HttpMethod.Post.Method, request.Method);
		}

		[Fact]
		public async Task TestGetResponseTextAsync_NormalPost_Passed()
		{
			INetUtility net = new NetUtility();
			var request = net.CreateHttp("https://httpbin.org/post");
			request.Method = HttpMethod.Post.Method;
			request.ContentType = "application/x-www-form-urlencoded";

			string name = "陳大文";
			using (var stream = await request.GetRequestStreamAsync())
			using (var writer = new StreamWriter(stream))
			{
				string postData = "name=" + WebUtility.UrlEncode(name);
				writer.Write(postData);
			}

			using (var response = await request.GetResponseAsync())
			{
				Assert.Equal(HttpStatusCode.OK, response.StatusCode);
				string content = await net.GetResponseTextAsync(response);
				var obj = new
				{
					form = new
					{
						name = ""
					}
				};
				obj = JsonConvert.DeserializeAnonymousType(content, obj);
				Assert.Equal(obj.form.name, name);
			}
		}

		[Fact]
		public async Task TestGetResponseTextAsync_GzippedData_Passed()
		{
			INetUtility net = new NetUtility();
			var request = net.CreateHttp("https://httpbin.org/gzip");
			request.ContentType = "application/json";

			using (var response = await request.GetResponseAsync())
			{
				Assert.Equal(HttpStatusCode.OK, response.StatusCode);
				string content = await net.GetResponseTextAsync(response);
				var obj = new
				{
					gzipped = false
				};
				obj = JsonConvert.DeserializeAnonymousType(content, obj);
				Assert.True(obj.gzipped);
			}
		}

		[Fact]
		public async Task TestGetResponseAsync_ErrorStatusCode_NoException()
		{
			INetUtility net = new NetUtility();
			var request = net.CreateHttp("https://httpbin.org/status/400");
			request.ContentType = "text/html";

			using (var response = await request.GetResponseAsync())
			{
				Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
			}
		}

		[Fact]
		public async Task TestGetResponseAsync_InvalidUrl_NoException()
		{
			INetUtility net = new NetUtility();
			var request = net.CreateHttp("http://sf93h4f9h3sf3f39fh49.com/");
			request.ContentType = "text/html";

			using (var response = await request.GetResponseAsync())
			{
				Assert.Null(response);
			}
		}
	}
}
