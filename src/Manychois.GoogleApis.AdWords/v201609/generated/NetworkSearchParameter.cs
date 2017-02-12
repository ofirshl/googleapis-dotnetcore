using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// <p>A {@link SearchParameter} for setting the search network. Currently we
	/// support two network setting options:
	/// <ul>
	/// <li>Google search network</li>
	/// <li>Google search network and AFS</li>
	/// </ul>
	/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
	/// <p>This element is supported by following {@link RequestType}s: IDEAS, STATS.
	/// </summary>
	public class NetworkSearchParameter : SearchParameter, ISoapable
	{
		/// <summary>
		/// The network targeted for this search.
		///
		/// <p>Currently we can support two options:
		/// <ul>
		/// <li>number of google search impressions</li>
		/// <li>number of search impressions on the google search network(AFS)</li>
		/// </ul>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public NetworkSetting NetworkSetting { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			NetworkSetting = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "networkSetting")
				{
					NetworkSetting = new NetworkSetting();
					NetworkSetting.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "NetworkSearchParameter");
			XElement xItem = null;
			if (NetworkSetting != null)
			{
				xItem = new XElement(XName.Get("networkSetting", "https://adwords.google.com/api/adwords/o/v201609"));
				NetworkSetting.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
