using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Selected set of conversion types for optimizing campaigns. For e.g. For universal app campaigns,
	/// these are the set of in-app actions to optimize the campaign towards.
	/// </summary>
	public class SelectiveOptimization : ISoapable
	{
		/// <summary>
		/// The selected conversion ids for selective optimization.
		/// </summary>
		public List<long> ConversionTypeIds { get; set; }
		/// <summary>
		/// The selected conversion ids ops for selective optimization.
		/// </summary>
		public ListOperations ConversionTypeIdsOps { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			ConversionTypeIds = null;
			ConversionTypeIdsOps = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "conversionTypeIds")
				{
					if (ConversionTypeIds == null) ConversionTypeIds = new List<long>();
					ConversionTypeIds.Add(long.Parse(xItem.Value));
				}
				else if (localName == "conversionTypeIdsOps")
				{
					ConversionTypeIdsOps = new ListOperations();
					ConversionTypeIdsOps.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (ConversionTypeIds != null)
			{
				foreach (var conversionTypeIdsItem in ConversionTypeIds)
				{
					xItem = new XElement(XName.Get("conversionTypeIds", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(conversionTypeIdsItem.ToString());
					xE.Add(xItem);
				}
			}
			if (ConversionTypeIdsOps != null)
			{
				xItem = new XElement(XName.Get("conversionTypeIdsOps", "https://adwords.google.com/api/adwords/cm/v201609"));
				ConversionTypeIdsOps.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
