using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a function where its operator is applied to its argument operands
	/// resulting in a return value. It has the form
	/// (Operand... Operator Operand...). The type of the return value depends on
	/// the operator being applied and the type of the operands.
	///
	/// <p class="special">Operands per function is limited to <b>20</b>.</p>
	///
	/// <p>Here is a code example:</p>
	///
	/// <pre><code>
	///
	/// // For example "feed_attribute == 30" can be represented as:
	/// FeedId feedId = (FeedId of Feed associated with feed_attribute)
	/// FeedAttributeId feedAttributeId = (FeedAttributeId of feed_attribute)
	/// Function function = new Function();
	/// function.setLhsOperand(
	/// Arrays.asList((Operand) new FeedAttributeOperand(feedId, feedAttributeId)));
	/// function.setOperator(Operator.IN);
	/// function.setRhsOperand(
	/// Arrays.asList((Operand) new ConstantOperand(30L)));
	///
	/// // Another example matching on multiple values:
	/// "feed_item_id IN (10, 20, 30)" can be represented as:
	///
	/// Function function = new Function();
	/// function.setLhsOperand(
	/// Arrays.asList((Operand) new RequestContextOperand(ContextType.FEED_ITEM_ID)));
	/// function.setOperator(Operator.IN);
	/// function.setRhsOperand(Arrays.asList(
	/// (Operand) new ConstantOperand(10L), new ConstantOperand(20L), new ConstantOperand(30L)));
	/// </code></pre>
	/// </summary>
	public class Function : ISoapable
	{
		/// <summary>
		/// Operator for a function.
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public FunctionOperator? Operator { get; set; }
		/// <summary>
		/// Operand on the LHS in the equation. This is also the operand to be used for
		/// single operand expressions such as NOT.
		/// <span class="constraint CollectionSize">The minimum size of this collection is 1.</span>
		/// </summary>
		public List<FunctionArgumentOperand> LhsOperand { get; set; }
		/// <summary>
		/// Operand on the RHS of the equation.
		/// </summary>
		public List<FunctionArgumentOperand> RhsOperand { get; set; }
		/// <summary>
		/// String representation of the {@code Function}.
		///
		/// <p>For mutate actions, this field can be set instead of the {@code operator},
		/// {@code lhsOperand}, and {@code rhsOperand} fields. This field will be parsed and used to
		/// populate the other fields.
		///
		/// <p>When {@code Function} objects are returned from get or mutate calls, this field contains the
		/// string representation of the {@code Function}. Note that because multiple strings may map to
		/// the same {@code Function} (whitespace and single versus double quotation marks, for example),
		/// the value returned may not be identical to the string sent in the request.
		/// </summary>
		public string FunctionString { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operator = null;
			LhsOperand = null;
			RhsOperand = null;
			FunctionString = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operator")
				{
					Operator = FunctionOperatorExtensions.Parse(xItem.Value);
				}
				else if (localName == "lhsOperand")
				{
					if (LhsOperand == null) LhsOperand = new List<FunctionArgumentOperand>();
					var lhsOperandItem = InstanceCreator.CreateFunctionArgumentOperand(xItem);
					lhsOperandItem.ReadFrom(xItem);
					LhsOperand.Add(lhsOperandItem);
				}
				else if (localName == "rhsOperand")
				{
					if (RhsOperand == null) RhsOperand = new List<FunctionArgumentOperand>();
					var rhsOperandItem = InstanceCreator.CreateFunctionArgumentOperand(xItem);
					rhsOperandItem.ReadFrom(xItem);
					RhsOperand.Add(rhsOperandItem);
				}
				else if (localName == "functionString")
				{
					FunctionString = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Operator != null)
			{
				xItem = new XElement(XName.Get("operator", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(Operator.Value.ToXmlValue());
				xE.Add(xItem);
			}
			if (LhsOperand != null)
			{
				foreach (var lhsOperandItem in LhsOperand)
				{
					xItem = new XElement(XName.Get("lhsOperand", "https://adwords.google.com/api/adwords/cm/v201609"));
					lhsOperandItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (RhsOperand != null)
			{
				foreach (var rhsOperandItem in RhsOperand)
				{
					xItem = new XElement(XName.Get("rhsOperand", "https://adwords.google.com/api/adwords/cm/v201609"));
					rhsOperandItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (FunctionString != null)
			{
				xItem = new XElement(XName.Get("functionString", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FunctionString);
				xE.Add(xItem);
			}
		}
	}
}
