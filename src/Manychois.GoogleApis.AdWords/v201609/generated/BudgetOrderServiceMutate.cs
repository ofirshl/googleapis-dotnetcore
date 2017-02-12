using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Mutates BudgetOrders, supported operations are:
	/// <p><code>ADD</code>: Adds a {@link BudgetOrder} to the billing account
	/// specified by the billing account ID.</p>
	/// <p><code>SET</code>: Sets the start/end date and amount of the
	/// {@link BudgetOrder}.</p>
	/// <p><code>REMOVE</code>: Cancels the {@link BudgetOrder} (status change).</p>
	/// <p class="warning"><b>Warning:</b> The <code>BudgetOrderService</code>
	/// is limited to one operation per mutate request. Any attempt to make more
	/// than one operation will result in an <code>ApiException</code>.</p>
	/// @param operations A list of operations, <b>however currently we only
	/// support one operation per mutate call</b>.
	/// @return BudgetOrders affected by the mutate operation.
	/// @throws ApiException
	/// </summary>
	internal class BudgetOrderServiceMutate : ISoapable
	{
		/// <summary>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// <span class="constraint SupportedOperators">The following {@link Operator}s are supported: ADD, SET, REMOVE.</span>
		/// </summary>
		public List<BudgetOrderOperation> Operations { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operations")
				{
					if (Operations == null) Operations = new List<BudgetOrderOperation>();
					var operationsItem = new BudgetOrderOperation();
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
					xItem = new XElement(XName.Get("operations", "https://adwords.google.com/api/adwords/billing/v201609"));
					operationsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
