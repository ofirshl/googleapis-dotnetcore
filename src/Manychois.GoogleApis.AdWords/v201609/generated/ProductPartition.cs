using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Product partition (product group) in a shopping campaign. Depending on its type, a product
	/// partition subdivides products along some product dimension, specifies a bid for products, or
	/// excludes products from bidding.
	///
	/// <p>Inner nodes of a product partition hierarchy are always subdivisions. Each child is linked to
	/// the subdivision via the {@code parentCriterionId} and defines a {@code caseValue}. For all
	/// children of the same subdivision, the {@code caseValue}s must be mutually different but
	/// instances of the same class.
	///
	/// To create a subdivision and child node in the same API request, they should refer to each other
	/// using temporary criterion IDs in the {@code parentCriterionId} of the child, and ID field of the
	/// subdivision. Temporary IDs are specified by using any negative integer. Temporary IDs only exist
	/// within the scope of a single API request. The API will assign real criterion IDs, and replace
	/// the temporary values, and the API response will reflect this.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class ProductPartition : Criterion, ISoapable
	{
		/// <summary>
		/// Type of the product partition.
		/// <span class="constraint Selectable">This field can be selected using the value "PartitionType".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public ProductPartitionType? PartitionType { get; set; }
		/// <summary>
		/// ID of the parent product partition subdivision. Undefined for the root partition.
		/// <span class="constraint Selectable">This field can be selected using the value "ParentCriterionId".</span>
		/// </summary>
		public long? ParentCriterionId { get; set; }
		/// <summary>
		/// Dimension value with which this product partition is refining its parent. Undefined for the
		/// root partition.
		/// <span class="constraint Selectable">This field can be selected using the value "CaseValue".</span>
		/// </summary>
		public ProductDimension CaseValue { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			PartitionType = null;
			ParentCriterionId = null;
			CaseValue = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "partitionType")
				{
					PartitionType = ProductPartitionTypeExtensions.Parse(xItem.Value);
				}
				else if (localName == "parentCriterionId")
				{
					ParentCriterionId = long.Parse(xItem.Value);
				}
				else if (localName == "caseValue")
				{
					CaseValue = InstanceCreator.CreateProductDimension(xItem);
					CaseValue.ReadFrom(xItem);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "ProductPartition");
			XElement xItem = null;
			if (PartitionType != null)
			{
				xItem = new XElement(XName.Get("partitionType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PartitionType.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (ParentCriterionId != null)
			{
				xItem = new XElement(XName.Get("parentCriterionId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ParentCriterionId.Value.ToString());
				xE.Add(xItem);
			}
			if (CaseValue != null)
			{
				xItem = new XElement(XName.Get("caseValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				CaseValue.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
