using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a large mutation job.
	/// </summary>
	public class BatchJob : ISoapable
	{
		/// <summary>
		/// ID of this job.
		/// <span class="constraint Selectable">This field can be selected using the value "Id".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// Status of this job.
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: ADD.</span>
		/// </summary>
		public BatchJobStatus? Status { get; set; }
		/// <summary>
		/// Statistics related to the progress of this job.
		/// <span class="constraint Selectable">This field can be selected using the value "ProgressStats".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public ProgressStats ProgressStats { get; set; }
		/// <summary>
		/// The URL to use to upload operations for this job. The URL is unique to this
		/// job, and will expire 1 week after the job is created. This field is only
		/// returned when calling {@link BatchJobService#mutate} with an {@code ADD}
		/// operation. To upload a file, for versions equal to or older than V201509,
		/// make a PUT request to the uploadUrl with the Content-Type header equal to
		/// "application/xml". The body of the request should contain the operations of
		/// the BatchJob in XML format. For versions newer than V201509, make a POST
		/// request to the uploadUrl and retrieve the "Location" header from the response
		/// as the url to upload operations. For the set of operations that BatchJobService
		/// supports, see
		/// {@link https://adwords.google.com/api/adwords/cm/xsd/v201509/BatchJobOps.xsd}.
		/// For more information about how to upload files, see
		/// {@link https://cloud.google.com/storage/docs/json_api/v1/how-tos/upload}.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public TemporaryUrl UploadUrl { get; set; }
		/// <summary>
		/// The URL to use to download results for this job. Results will be available
		/// for 30 days after job completion. This field is only returned once
		/// {@link #status} is either {@code DONE} or {@code CANCELED}.
		/// <span class="constraint Selectable">This field can be selected using the value "DownloadUrl".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public TemporaryUrl DownloadUrl { get; set; }
		/// <summary>
		/// A list of any errors that occurred during processing, not related to specific
		/// input operations, e.g. input file corruption errors.
		/// <span class="constraint Selectable">This field can be selected using the value "ProcessingErrors".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public List<BatchJobProcessingError> ProcessingErrors { get; set; }
		/// <summary>
		/// Disk quota balance of the batch job's customer in KB, which is the limit of batch job disk
		/// usage for the customer. The field is only returned when calling {@link BatchJobService#mutate}
		/// with an {@code ADD} operation.
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public long? DiskUsageQuotaBalance { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Id = null;
			Status = null;
			ProgressStats = null;
			UploadUrl = null;
			DownloadUrl = null;
			ProcessingErrors = null;
			DiskUsageQuotaBalance = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "status")
				{
					Status = BatchJobStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "progressStats")
				{
					ProgressStats = new ProgressStats();
					ProgressStats.ReadFrom(xItem);
				}
				else if (localName == "uploadUrl")
				{
					UploadUrl = new TemporaryUrl();
					UploadUrl.ReadFrom(xItem);
				}
				else if (localName == "downloadUrl")
				{
					DownloadUrl = new TemporaryUrl();
					DownloadUrl.ReadFrom(xItem);
				}
				else if (localName == "processingErrors")
				{
					if (ProcessingErrors == null) ProcessingErrors = new List<BatchJobProcessingError>();
					var processingErrorsItem = new BatchJobProcessingError();
					processingErrorsItem.ReadFrom(xItem);
					ProcessingErrors.Add(processingErrorsItem);
				}
				else if (localName == "diskUsageQuotaBalance")
				{
					DiskUsageQuotaBalance = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ProgressStats != null)
			{
				xItem = new XElement(XName.Get("progressStats", "https://adwords.google.com/api/adwords/cm/v201609"));
				ProgressStats.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (UploadUrl != null)
			{
				xItem = new XElement(XName.Get("uploadUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				UploadUrl.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (DownloadUrl != null)
			{
				xItem = new XElement(XName.Get("downloadUrl", "https://adwords.google.com/api/adwords/cm/v201609"));
				DownloadUrl.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (ProcessingErrors != null)
			{
				foreach (var processingErrorsItem in ProcessingErrors)
				{
					xItem = new XElement(XName.Get("processingErrors", "https://adwords.google.com/api/adwords/cm/v201609"));
					processingErrorsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (DiskUsageQuotaBalance != null)
			{
				xItem = new XElement(XName.Get("diskUsageQuotaBalance", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DiskUsageQuotaBalance.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
