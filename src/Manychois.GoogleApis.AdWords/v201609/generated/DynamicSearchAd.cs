using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a dynamic search ad. This ad will have its headline and
	/// tracking URL auto-generated at serving time according to domain name
	/// specific information provided by {@link DomainInfoExtension} linked at the
	/// campaign level.
	///
	/// <p>Auto-generated fields: headline and optional tracking URL.</p>
	///
	/// <p><b>Required fields:</b> {@code description1}, {@code description2},
	/// {@code displayUrl}.</p>
	///
	/// <p>The tracking URL field must contain at least one of the following placeholder tags
	/// (URL parameters):</p>
	/// <ul>
	/// <li>{unescapedlpurl}</li>
	/// <li>{escapedlpurl}</li>
	/// <li>{lpurl}</li>
	/// <li>{lpurl+2}</li>
	/// <li>{lpurl+3}</li>
	/// </ul>
	///
	/// <ul>
	/// <li>{unescapedlpurl} will be replaced with the full landing page URL of the displayed ad.
	/// Extra query parameters can be added to the end, e.g.: "{unescapedlpurl}?lang=en".</li>
	///
	/// <li>{escapedlpurl} will be replaced with the URL-encoded version of the full
	/// landing page URL. This makes it suitable for use as a query parameter
	/// value (e.g.: "http://www.3rdpartytracker.com/?lp={escapedlpurl}") but
	/// not at the beginning of the URL field.</li>
	///
	/// <li>{lpurl} encodes the "?" and "=" of the landing page URL making it suitable
	/// for use as a query parameter. If found at the beginning of the URL field, it is
	/// replaced by the {unescapedlpurl} value.
	/// E.g.: "http://tracking.com/redir.php?tracking=xyz&url={lpurl}".</li>
	///
	/// <li>{lpurl+2} and {lpurl+3}  will be replaced with the landing page URL escaped two or three
	/// times, respectively.  This makes it suitable if there is a chain of redirects in the tracking
	/// URL.</li>
	/// </ul>
	///
	/// <p class="note">Note that {@code finalUrls} and {@code finalMobileUrls}
	/// cannot be set for dynamic search ads.</p>
	///
	/// <p>For more information, see the article
	/// <a href="//support.google.com/adwords/answer/2549100">Using dynamic tracking URLs</a>.
	/// </p>
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class DynamicSearchAd : Ad, ISoapable
	{
		/// <summary>
		/// The first description line.
		/// <span class="constraint Selectable">This field can be selected using the value "Description1".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Description1 { get; set; }
		/// <summary>
		/// The second description line.
		/// <span class="constraint Selectable">This field can be selected using the value "Description2".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public string Description2 { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Description1 = null;
			Description2 = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "description1")
				{
					Description1 = xItem.Value;
				}
				else if (localName == "description2")
				{
					Description2 = xItem.Value;
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "DynamicSearchAd");
			XElement xItem = null;
			if (Description1 != null)
			{
				xItem = new XElement(XName.Get("description1", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description1);
				xE.Add(xItem);
			}
			if (Description2 != null)
			{
				xItem = new XElement(XName.Get("description2", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Description2);
				xE.Add(xItem);
			}
		}
	}
}
