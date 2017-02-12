using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Sets and removes ad parameters.
	/// <p class="note"><b>Note:</b> {@code ADD} is not supported. Use {@code SET}
	/// for new ad parameters.</p>
	///
	/// <ul class="nolist">
	/// <li>{@code SET}: Creates or updates an ad parameter, setting the new
	/// parameterized value for the given ad group / keyword pair.
	/// <li>{@code REMOVE}: Removes an ad parameter. The <code><var>default-value</var>
	/// </code> specified in the ad text will be used.</li>
	/// </ul>
	///
	/// @param operations The operations to perform.
	/// @return A list of ad parameters, where each entry in the list is the
	/// result of applying the operation in the input list with the same index.
	/// For a {@code SET} operation, the returned ad parameter will contain the
	/// updated values. For a {@code REMOVE} operation, the returned ad parameter
	/// will simply be the ad parameter that was removed.
	/// </summary>
	internal class AdParamServiceMutate : ISoapable
	{
		/// <summary>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint SupportedOperators">The following {@link Operator}s are supported: SET, REMOVE.</span>
		/// </summary>
		public List<AdParamOperation> Operations { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operations")
				{
					if (Operations == null) Operations = new List<AdParamOperation>();
					var operationsItem = new AdParamOperation();
					operationsItem.ReadFrom(xItem);
					Operations.Add(operationsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Operations != null)
			{
				foreach (var operationsItem in Operations)
				{
					xItem = new XElement(XName.Get("operations", "https://adwords.google.com/api/adwords/cm/v201609"));
					operationsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
