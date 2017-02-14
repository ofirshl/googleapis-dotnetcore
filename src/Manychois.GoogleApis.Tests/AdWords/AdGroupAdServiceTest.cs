using Manychois.GoogleApis.AdWords.v201609;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Manychois.GoogleApis.Tests.AdWords
{
    public class AdGroupAdServiceTest : BaseServiceTest
    {
		public AdGroupAdServiceTest(ITestOutputHelper output) : base(output)
		{
		}

		protected IAdGroupAdService CreateService()
		{
			return CreateService<IAdGroupAdService>((x, y, z) => new AdGroupAdService(x, y, z));
		}

		[Fact]
		public async Task TestGetAsync_NotNull_Passed()
		{
			var service = CreateService();
			var selector = new Selector();
			selector.Fields = new List<string>();
			selector.Fields.Add("Id");
			selector.Fields.Add("AdGroupId");
			selector.Fields.Add("Status");
			selector.Fields.Add("CreativeFinalUrls");
			selector.Fields.Add("HeadlinePart1");
			selector.Fields.Add("HeadlinePart2");
			selector.Fields.Add("Description");
			selector.Fields.Add("Path1");
			selector.Fields.Add("Path2");
			var page = await service.GetAsync(selector);
			Assert.NotNull(page);
		}

		public async Task TestMutateAsync()
		{
			var service = CreateService();

			var textAd = new ExpandedTextAd();
			/*
			textAd.Description1 = StringUtility.Format("Unofficial AdWords API {0:yyyyMMdd}", DateTime.Today);
			textAd.Description2 = StringUtility.Format("Begin at {0:HHmmss}", DateTime.Now);
			textAd.DisplayUrl = "";
			*/
			var operation = new AdGroupAdOperation();
			operation.Operand = new AdGroupAd();
			operation.Operand.Ad = new TextAd();
			operation.Operator = Operator.Add;
			var returnValue =  await service.MutateAsync(new AdGroupAdOperation[] { operation });
			var returnedAdGroupAd = returnValue.Value[0];

			Assert.Equal(operation.Operand.AdGroupId, returnedAdGroupAd.AdGroupId);
		}
	}
}
