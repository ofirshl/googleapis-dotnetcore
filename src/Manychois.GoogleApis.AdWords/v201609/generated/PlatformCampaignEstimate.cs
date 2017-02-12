using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Contains a campaign level estimate for a specified {@link Platform}.
	/// </summary>
	public class PlatformCampaignEstimate : ISoapable
	{
		/// <summary>
		/// The {@link Platform} associated with this estimate.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Platform Platform { get; set; }
		/// <summary>
		/// Minimum estimate for the specified {@link Platform}.
		/// </summary>
		public StatsEstimate MinEstimate { get; set; }
		/// <summary>
		/// Maximum estimate for the specified {@link Platform}.
		/// </summary>
		public StatsEstimate MaxEstimate { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Platform = null;
			MinEstimate = null;
			MaxEstimate = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "platform")
				{
					Platform = new Platform();
					Platform.ReadFrom(xItem);
				}
				else if (localName == "minEstimate")
				{
					MinEstimate = new StatsEstimate();
					MinEstimate.ReadFrom(xItem);
				}
				else if (localName == "maxEstimate")
				{
					MaxEstimate = new StatsEstimate();
					MaxEstimate.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Platform != null)
			{
				xItem = new XElement(XName.Get("platform", "https://adwords.google.com/api/adwords/o/v201609"));
				Platform.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (MinEstimate != null)
			{
				xItem = new XElement(XName.Get("minEstimate", "https://adwords.google.com/api/adwords/o/v201609"));
				MinEstimate.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (MaxEstimate != null)
			{
				xItem = new XElement(XName.Get("maxEstimate", "https://adwords.google.com/api/adwords/o/v201609"));
				MaxEstimate.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
