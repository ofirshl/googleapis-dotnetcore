using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Possible actions:
	/// <ul>
	/// <li> Create a new label - create a new {@link Label} and call mutate with ADD operator
	/// <li> Edit the label name - set the appropriate fields in your {@linkplain Label} and call
	/// mutate with the SET operator. Null fields will be interpreted to mean "no change"
	/// <li> Delete the label - call mutate with REMOVE operator
	/// </ul>
	///
	/// @param operations list of unique operations to be executed in a single transaction, in the
	/// order specified.
	/// @return the mutated labels, in the same order that they were in as the parameter
	/// @throws ApiException if problems occurs while modifying label information
	/// </summary>
	internal class AccountLabelServiceMutate : ISoapable
	{
		/// <summary>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint SupportedOperators">The following {@link Operator}s are supported: ADD, SET, REMOVE.</span>
		/// </summary>
		public List<AccountLabelOperation> Operations { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operations")
				{
					if (Operations == null) Operations = new List<AccountLabelOperation>();
					var operationsItem = new AccountLabelOperation();
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
					xItem = new XElement(XName.Get("operations", "https://adwords.google.com/api/adwords/mcm/v201609"));
					operationsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
