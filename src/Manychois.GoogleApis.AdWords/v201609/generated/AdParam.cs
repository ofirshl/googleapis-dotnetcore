using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents an ad parameter.  Use ad parameters to update numeric values
	/// (such as prices or inventory levels) in any line of a text ad, including
	/// the destination URL. You can set two <code>AdParam</code> objects
	/// (one for each value of {@link #paramIndex}) per ad group
	/// <a href="AdGroupCriterionService.Keyword.html">Keyword</a>
	/// criterion.
	/// <p>When setting or removing an <code>AdParam</code>, it is uniquely
	/// identified by the combination of these three fields:</p>
	/// <ul>
	/// <li><code>adGroupId</code></li>
	/// <li><code>criterionId</code></li>
	/// <li><code>paramIndex</code></li>
	/// </ul>
	/// </summary>
	public class AdParam : ISoapable
	{
		/// <summary>
		/// ID of the associated ad group. Text ads in this ad group will be
		/// candidates for parameterized text replacement.
		/// <span class="constraint Selectable">This field can be selected using the value "AdGroupId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? AdGroupId { get; set; }
		/// <summary>
		/// ID of the associated <code>Keyword</code> criterion. The keyword must be
		/// in the same ad group as this <code>AdParam</code>. Text ads triggered by
		/// this keyword will have their
		/// <code>{param<var>N</var>:<var>default-value</var>}</code> snippet
		/// replaced by the contents of {@link #insertionText}.
		/// <span class="constraint Selectable">This field can be selected using the value "CriterionId".</span><span class="constraint Filterable">This field can be filtered on.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public long? CriterionId { get; set; }
		/// <summary>
		/// Numeric value to insert into the ad text. The following restrictions
		/// apply:
		/// <ul>
		/// <li>Can use <code><b>,</b></code> or <code><b>.</b></code> as a
		/// separator, with an optional <code><b>.</b></code> or
		/// <code><b>,</b></code> (respectively) for fractional values. For
		/// example, <code>1,000,000.00</code> and <code>2.000.000,10</code> are
		/// valid.</li>
		/// <li>Can be prepended or appended with a currency symbol.
		/// For example, <code>$99.99</code> and <code>200&pound;</code> are
		/// valid.</li>
		/// <li>Can be prepended or appended with a currency code.
		/// For example, <code>99.99USD</code> and <code>EUR200</code> are
		/// valid.</li>
		/// <li>Can use <code>%</code>. For example, <code>1.0%</code> and
		/// <code>1,0%</code> are valid.</li>
		/// <li>Can use <code>+</code> or <code>-</code>. For example,
		/// <code>-10.99</code> and <code>25+</code> are valid.</li>
		/// <li>Can use <code>/</code> between two numbers. For example
		/// <code>4/1</code> and <code>0.95/0.45</code> are valid.</li>
		/// </ul>
		/// <span class="constraint Selectable">This field can be selected using the value "InsertionText".</span>
		/// <span class="constraint Required">This field is required and should not be {@code null} when it is contained within {@link Operator}s : SET.</span>
		/// <span class="constraint StringLength">The length of this string should be between 1 and 25, inclusive.</span>
		/// </summary>
		public string InsertionText { get; set; }
		/// <summary>
		/// Defines which parameterized snippet of ad text to replace. For example, a
		/// value of <code>1</code> indicates a replacement for the
		/// <code>{<b>param1</b>:<var>default-value</var>}</code> token.
		/// <span class="constraint Selectable">This field can be selected using the value "ParamIndex".</span>
		/// <span class="constraint InRange">This field must be between 1 and 2, inclusive.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public int? ParamIndex { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			AdGroupId = null;
			CriterionId = null;
			InsertionText = null;
			ParamIndex = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "adGroupId")
				{
					AdGroupId = long.Parse(xItem.Value);
				}
				else if (localName == "criterionId")
				{
					CriterionId = long.Parse(xItem.Value);
				}
				else if (localName == "insertionText")
				{
					InsertionText = xItem.Value;
				}
				else if (localName == "paramIndex")
				{
					ParamIndex = int.Parse(xItem.Value);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (AdGroupId != null)
			{
				xItem = new XElement(XName.Get("adGroupId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AdGroupId.Value.ToString());
				xE.Add(xItem);
			}
			if (CriterionId != null)
			{
				xItem = new XElement(XName.Get("criterionId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(CriterionId.Value.ToString());
				xE.Add(xItem);
			}
			if (InsertionText != null)
			{
				xItem = new XElement(XName.Get("insertionText", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(InsertionText);
				xE.Add(xItem);
			}
			if (ParamIndex != null)
			{
				xItem = new XElement(XName.Get("paramIndex", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(ParamIndex.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
