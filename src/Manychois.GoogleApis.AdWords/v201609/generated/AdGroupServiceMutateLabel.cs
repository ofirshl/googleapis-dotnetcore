using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Adds labels to the {@linkplain AdGroup ad group} or removes {@linkplain Label label}s from the
	/// {@linkplain AdGroup ad group}.
	/// <p>{@code ADD} -- Apply an existing label to an existing {@linkplain AdGroup ad group}.
	/// The {@code adGroupId} must reference an existing {@linkplain AdGroup ad group}. The
	/// {@code labelId} must reference an existing {@linkplain Label label}.
	/// <p>{@code REMOVE} -- Removes the link between the specified {@linkplain AdGroup ad group}
	/// and a {@linkplain Label label}.</p>
	///
	/// @param operations the operations to apply.
	/// @return a list of {@linkplain AdGroupLabel}s where each entry in the list is the result of
	/// applying the operation in the input list with the same index. For an
	/// add operation, the returned AdGroupLabel contains the AdGroupId and the LabelId.
	/// In the case of a remove operation, the returned AdGroupLabel will only have AdGroupId.
	/// @throws ApiException when there are one or more errors with the request.
	/// </summary>
	internal class AdGroupServiceMutateLabel : ISoapable
	{
		/// <summary>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint DistinctIds">Elements in this field must have distinct IDs for following {@link Operator}s : ADD, REMOVE.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint SupportedOperators">The following {@link Operator}s are supported: ADD, REMOVE.</span>
		/// </summary>
		public List<AdGroupLabelOperation> Operations { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operations")
				{
					if (Operations == null) Operations = new List<AdGroupLabelOperation>();
					var operationsItem = new AdGroupLabelOperation();
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
