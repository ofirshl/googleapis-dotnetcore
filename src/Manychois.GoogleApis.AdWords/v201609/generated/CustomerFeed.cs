using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// CustomerFeeds are used to link a feed to the customer using a matching function,
	/// making the feed's feed items available in the customer's ads for substitution.
	/// </summary>
	public class CustomerFeed : ISoapable
	{
		/// <summary>
		/// Id of the Feed associated with the CustomerFeed.
		/// <span class="constraint Selectable">This field can be selected using the value "FeedId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? FeedId { get; set; }
		/// <summary>
		/// Matching function associated with the CustomerFeed.
		/// The matching function is used to filter the set of feed items selected.
		/// <span class="constraint Selectable">This field can be selected using the value "MatchingFunction".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public Function MatchingFunction { get; set; }
		/// <summary>
		/// Indicates which <a href="/adwords/api/docs/appendix/placeholders">placeholder types</a>
		/// the feed may populate under the connected customer.
		/// <span class="constraint Selectable">This field can be selected using the value "PlaceholderTypes".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public List<int> PlaceholderTypes { get; set; }
		/// <summary>
		/// Status of the CustomerFeed.
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public CustomerFeedStatus? Status { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FeedId = null;
			MatchingFunction = null;
			PlaceholderTypes = null;
			Status = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "feedId")
				{
					FeedId = long.Parse(xItem.Value);
				}
				else if (localName == "matchingFunction")
				{
					MatchingFunction = new Function();
					MatchingFunction.ReadFrom(xItem);
				}
				else if (localName == "placeholderTypes")
				{
					if (PlaceholderTypes == null) PlaceholderTypes = new List<int>();
					PlaceholderTypes.Add(int.Parse(xItem.Value));
				}
				else if (localName == "status")
				{
					Status = CustomerFeedStatusExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FeedId != null)
			{
				xItem = new XElement(XName.Get("feedId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedId.Value.ToString());
				xE.Add(xItem);
			}
			if (MatchingFunction != null)
			{
				xItem = new XElement(XName.Get("matchingFunction", "https://adwords.google.com/api/adwords/cm/v201609"));
				MatchingFunction.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (PlaceholderTypes != null)
			{
				foreach (var placeholderTypesItem in PlaceholderTypes)
				{
					xItem = new XElement(XName.Get("placeholderTypes", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(placeholderTypesItem.ToString());
					xE.Add(xItem);
				}
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
