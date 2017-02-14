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
			return CreateService<IAccountLabelService>((x, y, z) => new AccountLabelService(x, y, z), true);
		}

		[Fact]
		public async Task TestGetAsync_NotNull_Passed()
		{
			IAccountLabelService service = CreateService();
			var selector = new Selector();
			selector.Fields = new List<string>();
			selector.Fields.Add("LabelId");
			selector.Fields.Add("AccountLabels");
			var accountLabelPage = await service.GetAsync(selector);
			Assert.NotNull(accountLabelPage);
		}

		[Fact]
		public async Task TestMutateAsync_Add_Passed()
		{
			IAccountLabelService service = CreateService();
			var operation = new AccountLabelOperation();
			operation.Operand = new AccountLabel();
			operation.Operand.Name = string.Format(System.Globalization.CultureInfo.InvariantCulture, "AccLbl{0:yyMMddHHmmss}", DateTime.UtcNow);
			operation.Operator = Operator.Add;

			var returnValue = await service.MutateAsync(new AccountLabelOperation[] { operation });
			var returnedLabel = returnValue.Labels[0];
			Assert.True(returnedLabel.Id.HasValue);
			Assert.Equal(operation.Operand.Name, returnedLabel.Name);
		}
	}
}
