using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// A frequency cap is the maximum number of times an ad (or some set of ads) can
	/// be shown to a user over a particular time period.
	/// </summary>
	public class FrequencyCap : ISoapable
	{
		/// <summary>
		/// Maximum number of impressions allowed during the time range by this cap.
		/// To remove the frequency cap on a campaign, set this field to {@code 0}.
		/// <span class="constraint Selectable">This field can be selected using the value "FrequencyCapMaxImpressions".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public long? Impressions { get; set; }
		/// <summary>
		/// Unit of time the cap is defined at.
		/// Only the Day, Week and Month time units are supported.
		/// <span class="constraint Selectable">This field can be selected using the value "TimeUnit".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public TimeUnit? TimeUnit { get; set; }
		/// <summary>
		/// The level on which the cap is to be applied (creative/adgroup).
		/// Cap is applied to all the entities of this level in the campaign.
		/// <span class="constraint Selectable">This field can be selected using the value "Level".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public Level? Level { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Impressions = null;
			TimeUnit = null;
			Level = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "impressions")
				{
					Impressions = long.Parse(xItem.Value);
				}
				else if (localName == "timeUnit")
				{
					TimeUnit = TimeUnitExtensions.Parse(xItem.Value);
				}
				else if (localName == "level")
				{
					Level = LevelExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Impressions != null)
			{
				xItem = new XElement(XName.Get("impressions", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Impressions.Value.ToString());
				xE.Add(xItem);
			}
			if (TimeUnit != null)
			{
				xItem = new XElement(XName.Get("timeUnit", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TimeUnit.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Level != null)
			{
				xItem = new XElement(XName.Get("level", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Level.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
