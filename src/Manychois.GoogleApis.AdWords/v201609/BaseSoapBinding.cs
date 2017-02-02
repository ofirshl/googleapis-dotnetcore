using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal class BaseSoapBinding
	{
		public const string NsSoap = "http://schemas.xmlsoap.org/soap/envelope/";
		public static readonly string NsXmlns = XNamespace.Xmlns.NamespaceName;
		public const string NsXsd = "http://www.w3.org/2001/XMLSchema";
		public const string NsXsi = "http://www.w3.org/2001/XMLSchema-instance";
		private static readonly XName SoapFaultXName = XName.Get("Fault", NsSoap);

		private readonly string _accessToken;
		private readonly int _timeout;
		private readonly bool _enableGzipCompression;
		private readonly ILogger _logger;
		private readonly string _soapLocation;
		public BaseSoapBinding(string soapLocation, string accessToken, int timeout, bool enableGzipCompression, ILogger logger)
		{
			_soapLocation = soapLocation;
			_accessToken = accessToken;
			_timeout = timeout;
			_enableGzipCompression = enableGzipCompression;
			_logger = logger;
		}

		protected async Task<bool> GetSoapResultAsync<TOutHeader, TOutBody, TError>(string soapAction, XElement xHeaderData, XElement xBodyData, SoapData<TOutHeader, TOutBody> outData, TError errorData)
			where TOutHeader : ISoapable
			where TOutBody : ISoapable
			where TError : ISoapable
		{
			CancellationToken ct;
			if (_timeout > 0)
			{
				var cts = new CancellationTokenSource(_timeout);
				ct = cts.Token;
			}
			else
			{
				ct = CancellationToken.None;
			}
			var xDoc = await GetSoapResultAsync(soapAction, xHeaderData, xBodyData, ct).ConfigureAwait(false);
			var xRoot = xDoc.Root;
			xHeaderData = xRoot.Element(XName.Get("Header", NsSoap)).Elements().First();
			xBodyData = xRoot.Element(XName.Get("Body", NsSoap)).Elements().First();
			outData.Header.ReadFrom(xHeaderData);
			if (xBodyData.Name == SoapFaultXName)
			{
				var detailErrorObj = xBodyData.Element(XName.Get("detail", "")).Elements().FirstOrDefault();
				errorData.ReadFrom(detailErrorObj);
				return false;
			}
			else
			{
				outData.Body.ReadFrom(xBodyData);
				return true;
			}
		}

		private async Task<XDocument> GetSoapResultAsync(string soapAction, XElement xHeaderData, XElement xBodyData, CancellationToken cancellationToken)
		{
			var xDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
			var xEnvelope = new XElement(XName.Get("Envelope", NsSoap),
				new XAttribute(XName.Get("soap", NsXmlns), NsSoap),
				new XAttribute(XName.Get("xsd", NsXmlns), NsXsd),
				new XAttribute(XName.Get("xsi", NsXmlns), NsXsi)
			);
			xDoc.Add(xEnvelope);
			var xHeader = new XElement(XName.Get("Header", NsSoap), xHeaderData);
			xEnvelope.Add(xHeader);
			var xBody = new XElement(XName.Get("Body", NsSoap), xBodyData);
			xEnvelope.Add(xBody);

			string requestText = XmlUtility.ConvertToString(xDoc, SaveOptions.DisableFormatting);
			if (_logger != null)
			{
				_logger.LogDebug("POST: {0}", _soapLocation);
				_logger.LogDebug("SOAP Action: {0}", soapAction);
				_logger.LogDebug("Request Body:{0}{1}", Environment.NewLine, requestText);
			}

			var request = WebRequest.CreateHttp(_soapLocation);
			request.Method = "POST";
			request.ContentType = "application/soap+xml; charset=utf-8";
			if (_enableGzipCompression) request.Headers[HttpRequestHeader.AcceptEncoding] = "gzip";
			request.Headers[HttpRequestHeader.Authorization] = $"Bearer {_accessToken}";
			request.Headers[HttpRequestHeader.ContentLength] = Encoding.UTF8.GetByteCount(requestText).ToString();
			request.Headers["SOAPAction"] = soapAction;
			using (var requestStream = await request.GetRequestStreamAsync().ConfigureAwait(false))
			using (var writer = new StreamWriter(requestStream))
			{
				await writer.WriteAsync(requestText).ConfigureAwait(false);
			}

			cancellationToken.ThrowIfCancellationRequested();

			using (var response = await NetUtility.GetSafeResponseAsync(request).ConfigureAwait(false))
			{
				string responseText = await NetUtility.GetResponseTextAsync(response).ConfigureAwait(false);
				if (_logger != null)
				{
					_logger.LogDebug("Response status code: {0}", (int)response.StatusCode);
					_logger.LogDebug("Response body:{0}{1}", Environment.NewLine, responseText);
				}
				return XDocument.Parse(responseText);
			}
		}
	}
}
