using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Bidding strategies store shared bidding configuration data and are account-level objects.
	/// </summary>
	public class SharedBiddingStrategy : ISoapable
	{
		/// <summary>
		/// Specifies the type of bidding scheme and the metadata associated with it.
		/// <span class="constraint Selectable">This field can be selected using the value "BiddingScheme".</span>
		/// </summary>
		public BiddingScheme BiddingScheme { get; set; }
		/// <summary>
		/// Id of the flexible bidding strategy. The bidding strategy id is used to associate
		/// the bidding strategy with the campaign, ad group or ad group criterion.
		/// <span class="constraint Selectable">This field can be selected using the value "Id".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET, REMOVE.</span>
		/// </summary>
		public long? Id { get; set; }
		/// <summary>
		/// Name of the bidding strategy. Every bidding strategy must have a non-null non-empty name.
		/// In addition, all bidding strategies within an account must be named distinctly.
		/// <span class="constraint Selectable">This field can be selected using the value "Name".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 255, inclusive, in UTF-8 bytes, (trimmed).</span>
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "Status".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public SharedBiddingStrategyBiddingStrategyStatus? Status { get; set; }
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "Type".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// </summary>
		public BiddingStrategyType? Type { get; set; }
		/// <summary>
		/// The status of the bid strategy, with respect to circumstances that could affect
		/// the automation system.
		/// <span class="constraint Selectable">This field can be selected using the value "SystemStatus".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public BiddingStrategySystemStatus? SystemStatus { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			BiddingScheme = null;
			Id = null;
			Name = null;
			Status = null;
			Type = null;
			SystemStatus = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "biddingScheme")
				{
					BiddingScheme = InstanceCreator.CreateBiddingScheme(xItem);
					BiddingScheme.ReadFrom(xItem);
				}
				else if (localName == "id")
				{
					Id = long.Parse(xItem.Value);
				}
				else if (localName == "name")
				{
					Name = xItem.Value;
				}
				else if (localName == "status")
				{
					Status = SharedBiddingStrategyBiddingStrategyStatusExtensions.Parse(xItem.Value);
				}
				else if (localName == "type")
				{
					Type = BiddingStrategyTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "systemStatus")
				{
					SystemStatus = BiddingStrategySystemStatusExtensions.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (BiddingScheme != null)
			{
				xItem = new XElement(XName.Get("biddingScheme", "https://adwords.google.com/api/adwords/cm/v201609"));
				BiddingScheme.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (Id != null)
			{
				xItem = new XElement(XName.Get("id", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Id.Value.ToString());
				xE.Add(xItem);
			}
			if (Name != null)
			{
				xItem = new XElement(XName.Get("name", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Name);
				xE.Add(xItem);
			}
			if (Status != null)
			{
				xItem = new XElement(XName.Get("status", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Status.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (Type != null)
			{
				xItem = new XElement(XName.Get("type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Type.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (SystemStatus != null)
			{
				xItem = new XElement(XName.Get("systemStatus", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(SystemStatus.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
