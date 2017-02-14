using Manychois.GoogleApis.AdWords.v201609;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Manychois.GoogleApis.Tests.AdWords
{
	public class AccountLabelServiceTest : BaseServiceTest
	{
		public AccountLabelServiceTest(ITestOutputHelper output) : base(output)
		{
		}

		protected IAccountLabelService CreateService()
		{
			return CreateService<IAccountLabelService>((x, y, z) => new AccountLabelService(x, y, z), useManagerId: true);
		}

		[Fact]
		public async Task TestCRUD()
		{
			IAccountLabelService service = CreateService();
			long labelId = 0;
			string labelName = StringUtility.Format("AccLbl{0}", DateTime.Now.Ticks);

			// Create
			var createOp = new AccountLabelOperation();
			createOp.Operand = new AccountLabel
			{
				Name = labelName
			};
			createOp.Operator = Operator.Add;

			var returnValue = await service.MutateAsync(new AccountLabelOperation[] { createOp });
			var returnLabel = returnValue.Labels[0];

			Assert.Equal(1, returnValue.Labels.Count);
			Assert.True(returnLabel.Id.HasValue);
			Assert.Equal(labelName, returnLabel.Name);

			labelId = returnLabel.Id.Value;

			// Read
			var selector = new Selector();
			selector.Fields = StringUtility.List("LabelId", "LabelName");

			var idPredicate = new Predicate
			{
				Field = "LabelId",
				Operator = PredicateOperator.Equals,
				Values = StringUtility.List(labelId)
			};
			selector.Predicates = new List<Predicate>();
			selector.Predicates.Add(idPredicate);

			var page = await service.GetAsync(selector);
			returnLabel = page.Labels[0];

			Assert.Equal(1, page.Labels.Count);
			Assert.Equal(labelId, returnLabel.Id.Value);
			Assert.Equal(labelName, returnLabel.Name);

			// Update
			labelName = labelName + "-new";

			var setOp = new AccountLabelOperation();
			setOp.Operand = new AccountLabel
			{
				Id = labelId,
				Name = labelName
			};
			setOp.Operator = Operator.Set;

			returnValue = await service.MutateAsync(new AccountLabelOperation[] { setOp });
			returnLabel = returnValue.Labels[0];

			Assert.Equal(1, returnValue.Labels.Count);
			Assert.Equal(labelId, returnLabel.Id.Value);
			Assert.Equal(labelName, returnLabel.Name);

			// delete
			var removeOp = new AccountLabelOperation();
			removeOp.Operand = new AccountLabel
			{
				Id = labelId
			};
			removeOp.Operator = Operator.Remove;

			returnValue = await service.MutateAsync(new AccountLabelOperation[] { removeOp });

			Assert.Equal(1, returnValue.Labels.Count);
			Assert.Equal(labelId, returnLabel.Id.Value);
			Assert.Equal(labelName, returnLabel.Name);

			page = await service.GetAsync(selector);
			Assert.Null(page.Labels);
		}
	}
}
