using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a criterion containing a function that when evaluated specifies how to target
	/// based on the type of the location. These "location groups" are custom, dynamic bundles of
	/// locations (for instance "High income areas in California" or "Airports in France").
	///
	/// <p>Examples:</p>
	///
	/// For income demographic targeting, we need to specify the income tier and the geo
	/// which it targets. Areas in California that are in the top national income tier can be
	/// represented by:
	/// <pre><code>
	/// Function function = new Function();
	/// function.setLhsOperand(Arrays.asList(
	/// (Operand) new IncomeOperand(IncomeTier.TIER_1));
	/// function.setOperator(Operator.AND);
	/// function.setRhsOperand(Arrays.asList(
	/// (Operand) new GeoTargetOperand(Lists.newArrayList(new CriterionId(21137L))));
	/// </code></pre>
	///
	/// For place of interest targeting, we need to specify the place of interest category and the geo
	/// which it targets. Airports in France can be represented by:
	/// <pre><code>
	/// Function function = new Function();
	/// function.setLhsOperand(Arrays.asList(
	/// (Operand) new PlacesOfInterestOperand(PlacesOfInterestOperand.Category.AIRPORT));
	/// function.setOperator(Operator.AND);
	/// function.setRhsOperand(Arrays.asList(
	/// (Operand) new GeoTargetOperand(Lists.newArrayList(new CriterionId(2250L))));
	/// </code></pre>
	///
	/// <p>NOTE: Starting v201607 places of interest targeting is read only.</p>
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class LocationGroups : Criterion, ISoapable
	{
		/// <summary>
		/// Feed to be used for targeting around locations. This is required for distance targets.
		/// <span class="constraint Selectable">This field can be selected using the value "FeedId".</span>
		/// </summary>
		public long? FeedId { get; set; }
		/// <summary>
		/// Matching function to filter out locations targeted by the criteria.
		///
		/// This allows advertisers to target based on the semantics of the location.
		/// <span class="constraint Selectable">This field can be selected using the value "MatchingFunction".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : ADD.</span>
		/// </summary>
		public Function MatchingFunction { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			FeedId = null;
			MatchingFunction = null;
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
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "LocationGroups");
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
		}
	}
}
