using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Manychois.GoogleApis.AdWords.v201609.EnumExtensions;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class ReportUtility : IReportUtility
	{
		private const string EndPoint = "https://adwords.google.com/api/adwords/reportdownload/v201609";
		private readonly AdWordsApiConfig _config;
		private readonly INetUtility _net;
		private readonly ILogger _logger;

		public ReportUtility(AdWordsApiConfig config)
		{
			_config = config;
			_net = config.NetUtility;
			_logger = config.Logger;
		}

		public async Task<string> GetContentStringAsync(ReportDefinition definition)
		{
			var xDoc = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"));
			var xE = new XElement(XName.Get("reportDefinition", "https://adwords.google.com/api/adwords/cm/v201609"));
			definition.WriteTo(xE);
			xDoc.Add(xE);

			var reportParams = new Dictionary<string, string>();
			reportParams.Add("__rdxml", XmlUtility.ConvertToString(xDoc, SaveOptions.DisableFormatting));

			bool enableGzip = definition.DownloadFormat == DownloadFormat.GzippedCsv || definition.DownloadFormat == DownloadFormat.GzippedXml;

			using (var response = await GetResponseAsync(reportParams, enableGzip).ConfigureAwait(false))
			{
				return await GetResponseTextAsync(response).ConfigureAwait(false);
			}
		}

		public async Task<string> GetContentStringAsync(string awql, DownloadFormat format)
		{
			var reportParams = new Dictionary<string, string>();
			reportParams.Add("__fmt", format.ToXmlValue());
			reportParams.Add("__rdguery", awql);

			bool enableGzip = format == DownloadFormat.GzippedCsv || format == DownloadFormat.GzippedXml;

			using (var response = await GetResponseAsync(reportParams, enableGzip).ConfigureAwait(false))
			{
				return await GetResponseTextAsync(response).ConfigureAwait(false);
			}
		}

		private async Task<IHttpWebResponse> GetResponseAsync(IDictionary<string, string> reportParams, bool enableGzip)
		{
			var request = _net.CreateHttp(EndPoint);
			request.Method = "POST";
			request.Accept = "*/*";
			if (enableGzip) request.Headers[HttpRequestHeader.AcceptEncoding] = "gzip";
			request.Headers[HttpRequestHeader.Authorization] = $"Bearer {_config.AccessToken}";
			request.Headers["developerToken"] = _config.DeveloperToken;
			request.Headers["clientCustomerId"] = _config.ClientCustomerId;
			request.Headers[HttpRequestHeader.Expect] = "100-continue";
			string formDataBoundary = string.Format("--{0}", Guid.NewGuid());
			request.Headers[HttpRequestHeader.ContentType] = $"multipart/form-data; boundary={formDataBoundary}";
			if (!string.IsNullOrWhiteSpace(_config.UserAgent))
			{
				request.Headers[HttpRequestHeader.UserAgent] = _config.UserAgent;
			}

			var sb = new StringBuilder();
			sb.Append("\r\n");
			foreach (var kvp in reportParams)
			{

				sb.AppendFormat("--{0}\r\n", formDataBoundary);
				sb.Append($"Content-Disposition: form-data; name=\"{kvp.Key}\"\r\n");
				sb.Append("\r\n");
				sb.Append(kvp.Value);
				sb.Append("\r\n");
			}
			sb.AppendFormat("--{0}--", formDataBoundary);

			string formData = sb.ToString();
			request.Headers[HttpRequestHeader.ContentLength] = Encoding.UTF8.GetByteCount(formData).ToString();

			if (_logger != null)
			{
				_logger.LogDebug("POST {0}", EndPoint);
				_logger.LogDebug("Request body:{0}{1}", Environment.NewLine, formData);
			}

			using (var stream = await request.GetRequestStreamAsync().ConfigureAwait(false))
			using (var writer = new StreamWriter(stream))
			{
				await writer.WriteAsync(formData).ConfigureAwait(false);
			}

			var response = await request.GetResponseAsync().ConfigureAwait(false);
			return response;
		}

		private async Task<string> GetResponseTextAsync(IHttpWebResponse response)
		{
			string responseText = await _net.GetResponseTextAsync(response).ConfigureAwait(false);
			if (_logger != null)
			{
				_logger.LogDebug("Response status code: {0}", (int)response.StatusCode);
				if (response.StatusCode != HttpStatusCode.OK) // log only error message because successful report content can be very long
				{
					_logger.LogDebug("Response body:{0}{1}", Environment.NewLine, responseText);
				}
			}
			if (response.StatusCode != HttpStatusCode.OK) throw GetReportDownloadError(responseText);
			return responseText;
		}

		private Exception GetReportDownloadError(string responseText)
		{
			var xDoc = XDocument.Parse(responseText);
			var xError = xDoc.Root.Element(XName.Get("ApiError", ""));
			var errorType = xError.Element(XName.Get("type", "")).Value;

			var errorData = errorType.Split('.');
			var errorTypeName = errorData[0];
			var errorReason = errorData[1];
			if (XmlUtility.GetXmlTypeLocalName(xError) == null)
			{
				XmlUtility.SetXsiType(xError, "", errorTypeName);
			}
			XElement xApiErrorType = null;
			XElement xReason = null;
			XElement xErrorString = null;
			foreach (var xE in xError.Elements())
			{
				switch (xE.Name.LocalName)
				{
					case "ApiError.Type": xApiErrorType = xE; break;
					case "reason": xReason = xE; break;
					case "errorString": xErrorString = xE; break;
				}
			}
			if (xApiErrorType == null) xError.Add(new XElement(XName.Get("ApiError.Type", ""), errorTypeName));
			if (xReason == null) xError.Add(new XElement(XName.Get("reason", ""), errorReason));
			if (xErrorString == null) xError.Add(new XElement(XName.Get("errorString", ""), errorType));

			var error = InstanceCreator.CreateApiError(xError);
			error.ReadFrom(xError);
			return error;
		}
	}
}
