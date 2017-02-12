using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a keyword to be estimated.
	/// </summary>
	public class KeywordEstimateRequest : EstimateRequest, ISoapable
	{
		/// <summary>
		/// The {@link Keyword} to estimate. The keyword text is required regardless
		/// of whether the keyword ID is included. The keyword ID is optional and has
		/// the following characteristics:
		/// <ul>
		/// <li>When omitted, the ID indicates a new keyword to be estimated.</li>
		/// <li>When present with a campaign and ad group also specified, the ID should
		/// be for an existing keyword in the ad group. This can improve the estimates
		/// since historical performance is known.</li>
		/// <li>When present without a campaign and ad group specified, the ID is
		/// ignored.</li>
		/// </ul>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public Keyword Keyword { get; set; }
		/// <summary>
		/// The max CPC bid for this keyword.
		///
		/// In general, the {@code maxCpc} of a {@link KeywordEstimateRequest} is
		/// optional, since there is usually another {@code maxCpc} that can be used,
		/// such as the {@code maxCpc} on an existing keyword, an existing or
		/// overriding {@code maxCpc} of containing {@link AdGroupEstimateRequest}.
		/// However, if there is no backup value of {@code maxCpc} anywhere along the
		/// line, you must provide a value for {@code maxCpc} in
		/// {@link KeywordEstimateRequest}. This would happen, for example, if the
		/// {@link KeywordEstimateRequest} is for a new keyword.
		/// </summary>
		public Money MaxCpc { get; set; }
		/// <summary>
		/// Whether the keyword is negative or not. The default value is false.
		/// If negative, no current ad group ads will appear for searches containing
		/// this keyword.<p>
		///
		/// The estimate for negative keywords should reflect no traffic and zero CPC,
		/// but including a negative keyword will affect the other estimates in the
		/// request.
		/// </summary>
		public bool? IsNegative { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			Keyword = null;
			MaxCpc = null;
			IsNegative = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "keyword")
				{
					Keyword = new Keyword();
					Keyword.ReadFrom(xItem);
				}
				else if (localName == "maxCpc")
				{
					MaxCpc = new Money();
					MaxCpc.ReadFrom(xItem);
				}
				else if (localName == "isNegative")
				{
					IsNegative = bool.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/o/v201609", "KeywordEstimateRequest");
			XElement xItem = null;
			if (Keyword != null)
			{
				xItem = new XElement(XName.Get("keyword", "https://adwords.google.com/api/adwords/o/v201609"));
				Keyword.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (MaxCpc != null)
			{
				xItem = new XElement(XName.Get("maxCpc", "https://adwords.google.com/api/adwords/o/v201609"));
				MaxCpc.WriteTo(xItem);
				xE.Add(xItem);
			}
			if (IsNegative != null)
			{
				xItem = new XElement(XName.Get("isNegative", "https://adwords.google.com/api/adwords/o/v201609"));
				xItem.Add(IsNegative.Value.ToString());
				xE.Add(xItem);
			}
		}
	}
}
