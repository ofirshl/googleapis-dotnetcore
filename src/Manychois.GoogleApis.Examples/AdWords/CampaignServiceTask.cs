using Manychois.GoogleApis.AdWords.v201609;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.Examples.AdWords
{
	public class CampaignServiceTask
	{
		private readonly ILogger _logger;

		public CampaignServiceTask(ILogger logger)
		{
			_logger = logger;
		}

		public async Task<string> ChangeCampaignNameAsync(AdWordsApiConfig config, long campaignId)
		{
			string randomName = $"New Campaign Name {DateTime.Now.Ticks}";
			ICampaignService service = new CampaignService(config);
			var operation = new CampaignOperation();
			operation.Operand = new Campaign
			{
				Id = campaignId,
				Name = randomName
			};
			operation.Operator = Operator.Set;

			var returnValue = await service.MutateAsync(new CampaignOperation[] { operation }).ConfigureAwait(false);
			if (returnValue.PartialFailureErrors != null)
			{
				foreach (var err in returnValue.PartialFailureErrors)
				{
					_logger.LogError(err.Message);
				}
			}

			return randomName;
		}
	}
}
