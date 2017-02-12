using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Statistics on the progress of a {@code BatchJob}.
	/// </summary>
	public class ProgressStats : ISoapable
	{
		/// <summary>
		/// The number of operations executed.
		/// </summary>
		public long? NumOperationsExecuted { get; set; }
		/// <summary>
		/// The number of operations succeeded.
		/// </summary>
		public long? NumOperationsSucceeded { get; set; }
		/// <summary>
		/// An estimate of the percent of this job that has been executed.
		/// </summary>
		public int? EstimatedPercentExecuted { get; set; }
		/// <summary>
		/// The number of results written.
		/// </summary>
		public long? NumResultsWritten { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			NumOperationsExecuted = null;
			NumOperationsSucceeded = null;
			EstimatedPercentExecuted = null;
			NumResultsWritten = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "numOperationsExecuted")
				{
					NumOperationsExecuted = long.Parse(xItem.Value);
				}
				else if (localName == "numOperationsSucceeded")
				{
					NumOperationsSucceeded = long.Parse(xItem.Value);
				}
				else if (localName == "estimatedPercentExecuted")
				{
					EstimatedPercentExecuted = int.Parse(xItem.Value);
				}
				else if (localName == "numResultsWritten")
				{
					NumResultsWritten = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (NumOperationsExecuted != null)
			{
				xItem = new XElement(XName.Get("numOperationsExecuted", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(NumOperationsExecuted.Value.ToString());
				xE.Add(xItem);
			}
			if (NumOperationsSucceeded != null)
			{
				xItem = new XElement(XName.Get("numOperationsSucceeded", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(NumOperationsSucceeded.Value.ToString());
				xE.Add(xItem);
			}
			if (EstimatedPercentExecuted != null)
			{
				xItem = new XElement(XName.Get("estimatedPercentExecuted", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(EstimatedPercentExecuted.Value.ToString());
				xE.Add(xItem);
			}
			if (NumResultsWritten != null)
			{
				xItem = new XElement(XName.Get("numResultsWritten", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(NumResultsWritten.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
