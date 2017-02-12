using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Specifies the adgroup the request context must match in order for
	/// the feed item to be considered eligible for serving (aka the targeted adgroup).
	/// E.g., if the below adgroup targeting is set to adgroup = X, then the feed
	/// item can only serve under adgroup X.
	/// </summary>
	public class FeedItemAdGroupTargeting : ISoapable
	{
		/// <summary>
		/// The ID of the adgroup to target.
		/// <span class="constraint Selectable">This field can be selected using the value "TargetingAdGroupId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API for the following {@link Operator}s: REMOVE.</span>
		/// </summary>
		public long? TargetingAdGroupId { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			TargetingAdGroupId = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "TargetingAdGroupId")
				{
					TargetingAdGroupId = long.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (TargetingAdGroupId != null)
			{
				xItem = new XElement(XName.Get("TargetingAdGroupId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(TargetingAdGroupId.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
