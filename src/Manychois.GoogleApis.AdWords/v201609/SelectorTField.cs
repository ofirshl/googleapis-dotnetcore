using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public class Selector<TField> : Selector
		where TField : struct
	{
		public Selector<TField> AddFields(params TField[] fields)
		{
			var fieldNames = fields.Select(x => x.ToString()).ToArray();
			if (Fields == null) Fields = new List<string>();
			Fields.AddRange(fieldNames);
			return this;
		}

		public Selector<TField> AddPredicate(TField field, PredicateOperator @operator, params object[] values)
		{
			var predicate = new Predicate();
			predicate.Field = field.ToString();
			predicate.Operator = @operator;
			predicate.Values = new List<string>();
			foreach (var value in values)
			{
				predicate.Values.Add(value.ToString());
			}
			if (Predicates == null) Predicates = new List<Predicate>();
			Predicates.Add(predicate);
			return this;
		}

		public Selector<TField> AddOrderBy(TField field, bool isAsc)
		{
			var orderBy = new OrderBy();
			orderBy.Field = field.ToString();
			orderBy.SortOrder = isAsc ? SortOrder.Ascending : SortOrder.Descending;
			if (Ordering == null) Ordering = new List<OrderBy>();
			Ordering.Add(orderBy);
			return this;
		}
	}
}
