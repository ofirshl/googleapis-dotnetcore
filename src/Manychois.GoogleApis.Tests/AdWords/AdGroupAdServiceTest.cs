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
		public async Task TestAdGroupAd_CRUD_Passed()
		{
			var service = CreateService();
			var testConfig = TestConfig.GetFromConfigFile();
			long adGroupId = testConfig.AdWords.AdGroupId;

			// Create
			var createOp = new AdGroupAdOperation();
			var textAd = new ExpandedTextAd
			{
				HeadlinePart1 = "Test Headline Part One",
				HeadlinePart2 = "Test Headline Part Two",
				Description = "Test Expanded Text Ad Description",
				FinalUrls = StringUtility.List("https://github.com/manychois/googleapis-dotnetcore")
			};
			createOp.Operand = new AdGroupAd
			{
				AdGroupId = adGroupId,
				Ad = textAd,
				Status = AdGroupAdStatus.Enabled
			};
			createOp.Operator = Operator.Add;

			var returnValue = await service.MutateAsync(new AdGroupAdOperation[] { createOp });
			Assert.Equal(1, returnValue.Value.Count);
			var returnAdGroupAd = returnValue.Value[0];
			Assert.Equal(adGroupId, returnAdGroupAd.AdGroupId.Value);
			Assert.Equal(AdGroupAdStatus.Enabled, returnAdGroupAd.Status.Value);
			Assert.IsType<ExpandedTextAd>(returnAdGroupAd.Ad);
			var returnTextAd = returnAdGroupAd.Ad as ExpandedTextAd;
			Assert.Equal(textAd.HeadlinePart1, returnTextAd.HeadlinePart1);
			Assert.Equal(textAd.HeadlinePart2, returnTextAd.HeadlinePart2);
			Assert.Equal(textAd.Description, returnTextAd.Description);
			Assert.Equal(textAd.FinalUrls, returnTextAd.FinalUrls);

			long adId = returnTextAd.Id.Value;

			// Read
			var selector = new Selector<AdGroupAdServiceField>()
				.AddFields(
					AdGroupAdServiceField.AdGroupId,
					AdGroupAdServiceField.BaseCampaignId,
					AdGroupAdServiceField.Status,
					AdGroupAdServiceField.AdGroupCreativeApprovalStatus,
					AdGroupAdServiceField.HeadlinePart1,
					AdGroupAdServiceField.HeadlinePart2,
					AdGroupAdServiceField.Description,
					AdGroupAdServiceField.CreativeFinalUrls)
				.AddPredicate(AdGroupAdServiceField.Id, PredicateOperator.Equals, adId);

			var page = await service.GetAsync(selector);
			Assert.Equal(1, page.TotalNumEntries.Value);
			returnAdGroupAd = page.Entries[0];
			Assert.Equal(adGroupId, returnAdGroupAd.AdGroupId.Value);
			Assert.Equal(AdGroupAdStatus.Enabled, returnAdGroupAd.Status.Value);
			Assert.Equal(testConfig.AdWords.CampaignId, returnAdGroupAd.BaseCampaignId.Value);
			Assert.Equal(AdGroupAdApprovalStatus.Unchecked, returnAdGroupAd.ApprovalStatus.Value);
			Assert.IsType<ExpandedTextAd>(returnAdGroupAd.Ad);
			returnTextAd = returnAdGroupAd.Ad as ExpandedTextAd;
			Assert.Equal(textAd.HeadlinePart1, returnTextAd.HeadlinePart1);
			Assert.Equal(textAd.HeadlinePart2, returnTextAd.HeadlinePart2);
			Assert.Equal(textAd.Description, returnTextAd.Description);
			Assert.Equal(textAd.FinalUrls, returnTextAd.FinalUrls);

			// Update (Status only)
			var setOp = new AdGroupAdOperation();
			setOp.Operand = new AdGroupAd
			{
				AdGroupId = adGroupId,
				Ad = new Ad
				{
					Id = adId
				},
				Status = AdGroupAdStatus.Paused
			};
			setOp.Operator = Operator.Set;

			returnValue = await service.MutateAsync(new AdGroupAdOperation[] { setOp });
			Assert.Equal(1, returnValue.Value.Count);
			returnAdGroupAd = returnValue.Value[0];
			Assert.Equal(adGroupId, returnAdGroupAd.AdGroupId.Value);
			Assert.Equal(AdGroupAdStatus.Paused, returnAdGroupAd.Status.Value);
			Assert.IsType<ExpandedTextAd>(returnAdGroupAd.Ad);
			returnTextAd = returnAdGroupAd.Ad as ExpandedTextAd;
			Assert.Equal(textAd.HeadlinePart1, returnTextAd.HeadlinePart1);
			Assert.Equal(textAd.HeadlinePart2, returnTextAd.HeadlinePart2);
			Assert.Equal(textAd.Description, returnTextAd.Description);
			Assert.Equal(textAd.FinalUrls, returnTextAd.FinalUrls);

			// Delete
			var removeOp = new AdGroupAdOperation();
			removeOp.Operand = new AdGroupAd
			{
				AdGroupId = adGroupId,
				Ad = new Ad
				{
					Id = adId
				}
			};
			removeOp.Operator = Operator.Remove;

			returnValue = await service.MutateAsync(new AdGroupAdOperation[] { removeOp });
			Assert.Equal(1, returnValue.Value.Count);
			returnAdGroupAd = returnValue.Value[0];
			Assert.Equal(adId, returnAdGroupAd.Ad.Id);
		}

		[Fact]
		public async Task TestLabel_CD_Passed()
		{
			var testConfig = TestConfig.GetFromConfigFile();

			long labelId = 0;
			ILabelService labelService = CreateService<ILabelService>((x, y, z) => new LabelService(x, y, z));
			var labelSelector = new Selector<LabelServiceField>()
				.AddFields(LabelServiceField.LabelId)
				.AddPredicate(LabelServiceField.LabelName, PredicateOperator.Equals, testConfig.AdWords.LabelText);
			var lsReturnValue = await labelService.GetAsync(labelSelector);
			labelId = lsReturnValue.Entries[0].Id.Value;

			IAdGroupAdService adService = CreateService();
			// Create
			var createOp = new AdGroupAdLabelOperation();
			createOp.Operand = new AdGroupAdLabel
			{
				AdGroupId = testConfig.AdWords.AdGroupId,
				AdId = testConfig.AdWords.AdId,
				LabelId = labelId
			};
			createOp.Operator = Operator.Add;

			var adLabelReturnValue = await adService.MutateLabelAsync(new AdGroupAdLabelOperation[] { createOp });
			Assert.Equal(1, adLabelReturnValue.Value.Count);
			var adLabel = adLabelReturnValue.Value[0];
			Assert.Equal(testConfig.AdWords.AdGroupId, adLabel.AdGroupId.Value);
			Assert.Equal(testConfig.AdWords.AdId, adLabel.AdId.Value);
			Assert.Equal(labelId, adLabel.LabelId.Value);

			var adSelector = new Selector<AdGroupAdServiceField>()
				.AddFields(AdGroupAdServiceField.Labels)
				.AddPredicate(AdGroupAdServiceField.Id, PredicateOperator.Equals, testConfig.AdWords.AdId);
			var adReturnValue = await adService.GetAsync(adSelector);
			Assert.Equal(1, adReturnValue.TotalNumEntries.Value);
			var returnAdGroupAd = adReturnValue.Entries[0];
			Assert.True(returnAdGroupAd.Labels.Count >= 1);
			var returnLabel = returnAdGroupAd.Labels.First(x => x.Name == testConfig.AdWords.LabelText) as TextLabel;
			Assert.Equal(labelId, returnLabel.Id);

			// Delete
			var removeOp = new AdGroupAdLabelOperation();
			removeOp.Operand = new AdGroupAdLabel
			{
				AdGroupId = testConfig.AdWords.AdGroupId,
				AdId = testConfig.AdWords.AdId,
				LabelId = labelId
			};
			removeOp.Operator = Operator.Remove;

			adLabelReturnValue = await adService.MutateLabelAsync(new AdGroupAdLabelOperation[] { removeOp });
			Assert.Equal(1, adLabelReturnValue.Value.Count);
			adLabel = adLabelReturnValue.Value[0];
			Assert.Equal(testConfig.AdWords.AdGroupId, adLabel.AdGroupId.Value);
			Assert.Equal(testConfig.AdWords.AdId, adLabel.AdId.Value);
			Assert.False(adLabel.LabelId.HasValue);
		}

		[Fact]
		public async Task TestQueryAsync()
		{
			var testConfig = TestConfig.GetFromConfigFile();
			var service = CreateService();
			string query = $"SELECT {AdGroupAdServiceField.Id} WHERE {AdGroupAdServiceField.AdGroupId} = {testConfig.AdWords.AdGroupId}";

			long adId = testConfig.AdWords.AdId;
			var page = await service.QueryAsync(query);
			Assert.True(page.Entries.Any(x => x.Ad.Id.Value == adId));
		}
	}
}
