using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Describes the behavior of elements in a list. Instances of ListOperations will always be defined
	/// alongside some list in an API POJO. The number of operators in the ListOperations must be
	/// equal to the number of elements in the POJO list. Each operator, together with its corresponding
	/// list element, describe an intended change.
	///
	/// <p>For example, if in a request Campaign.selectiveOptimization contains 2 conversionTypeIds,
	/// and the conversionTypeIdsOps is non-null, it must contain 2 operators. If those operators are
	/// {PUT, REMOVE} then the API will add the first conversionTypeId (if it doesn't
	/// already exist) and remove the second conversionTypeId (if it exists).
	/// </summary>
	public class ListOperations : ISoapable
	{
		/// <summary>
		/// Indicates that all contents of the list should be deleted. If this is true, then operators
		/// should be empty, or contain only PUTs.
		///
		/// <p>REMOVE/UPDATE is invalid with clear, as once the clear is applied no elements would exist to
		/// remove or update.
		/// </summary>
		public bool? Clear { get; set; }
		/// <summary>
		/// The desired behavior of each element in the POJO list that this ListOperation corresponds to.
		/// This will contain the same number of elements as the corresponding List<>.
		/// </summary>
		public List<ListOperationsListOperator> Operators { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Clear = null;
			Operators = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "clear")
				{
					Clear = bool.Parse(xItem.Value);
				}
				else if (localName == "operators")
				{
					if (Operators == null) Operators = new List<ListOperationsListOperator>();
					Operators.Add(ListOperationsListOperatorExtensions.Parse(xItem.Value));
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Clear != null)
			{
				xItem = new XElement(XName.Get("clear", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Clear.Value.ToString());
				xE.Add(xItem);
			}
			if (Operators != null)
			{
				foreach (var operatorsItem in Operators)
				{
					xItem = new XElement(XName.Get("operators", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(operatorsItem.ToXmlValue());
					xE.Add(xItem);
				}
			}
		}
	}
}
