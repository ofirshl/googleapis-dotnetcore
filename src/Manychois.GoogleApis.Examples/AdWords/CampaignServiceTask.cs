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
		private readonly ILoggerFactory _loggerFactory;
		private readonly ILogger _logger;

		public CampaignServiceTask(ILoggerFactory loggerFactory)
		{
			_loggerFactory = loggerFactory;
			_logger = loggerFactory.CreateLogger<CampaignServiceTask>();
		}

		public async Task<string> ChangeCampaignNameAsync(AdWordsApiConfig config, long campaignId)
		{
			string randomName = $"New Campaign Name {DateTime.Now.Ticks}";
			ICampaignService service = new CampaignService(config, new NetUtility(), _loggerFactory);
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
